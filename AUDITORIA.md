# PixelForge — Auditoria Técnica

**Data:** 2026-08-01
**Escopo:** asset PixelWorld (motor gráfico), código próprio do projeto, configuração Unity, aderência ao GDD v0.1
**Unity:** 6000.4.8f1 · URP 17.4.0 · 2D Feature 2.0.2 · Input System 1.19.0 · Cinemachine 3.1.6

> **Nota de estrutura (2026-08-01, após a auditoria).** A pasta `Assets/PixelWorld` foi dissolvida e não existe mais. Os caminhos citados neste documento referem-se à estrutura antiga; a correspondência é:
>
> | Caminho no documento | Caminho atual |
> |---|---|
> | `PixelWorld/Animations` | `Assets/Animations` |
> | `PixelWorld/Sprites` | `Assets/Art/Sprites` |
> | `PixelWorld/Atlas` | `Assets/Art/Atlas` |
> | `PixelWorld/TIlePrefab` | `Assets/Art/TileAssets` |
> | `PixelWorld/Prefabs/*` | `Assets/Prefabs/*` |
> | `PixelWorld/Scripts/NavMeshComponents` | `Assets/Scripts/ThirdParty/NavMeshPlus` |
> | `PixelWorld/URPSettings/*` | `Assets/Settings/` |
> | `PixelWorld/Documentation`, `ProSettings` | `Docs/` (fora de `Assets`) |
> | `Assets/Sprites` | `Assets/Art/Sprites/Forgelings` |
> | `Assets/Scenes/{Player,Forgeling}.prefab` | `Assets/Prefabs/` |
>
> Os 19 scripts de gameplay do PixelWorld (seção 5) foram removidos. O bloqueante de tags e sorting layers (seção 2.1) foi resolvido.

---

## Sumário executivo

O PixelWorld entrega um acervo de arte de nível comercial — **6.702 sprites recortados, 1.079 tiles, 1.277 prefabs, 383 animações, 128 Animator Controllers e dois mundos de demonstração já montados**. Isso representa meses de trabalho de arte e level design que o projeto não precisará fazer.

Os **scripts** do PixelWorld, ao contrário, são código de demonstração e devem ser descartados por inteiro (~700 linhas, 14 arquivos). O código próprio do projeto (705 linhas) é um protótipo de locomoção e animação bem escrito, mas nenhum verbo do gameplay loop do GDD existe ainda.

Há **três problemas que precisam de decisão antes de qualquer linha nova de código**:

1. **Conflito de perspectiva em três frentes.** GDD, código e arte descrevem jogos diferentes.
2. **Sorting layers e layers ausentes.** Todo o conteúdo do PixelWorld está renderizando errado neste momento.
3. **Grade de sprites incompatível.** O pipeline de arte por IA está gerando assets fora da grade do motor gráfico.

---

## 1. O conflito de perspectiva — decisão bloqueante

Três especificações diferentes convivem no projeto hoje:

| Fonte | Perspectiva | Direções de personagem |
|---|---|---|
| **GDD §4** | "Visão lateral (Side View)" | — |
| **Código próprio** | ~~Top-down em grid, passo tile-a-tile~~ → **movimento livre por NavMeshAgent** (decidido em 2026-08-01) | 4 direções suportadas, com fallback automático para `Side` quando não há arte de costas/frente |
| **Arte que vem no PixelWorld** | Top-down 3/4, movimento livre por NavMesh | 1 orientação por sheet + espelhamento em X |

**O que vem no pacote:** os 88 sheets de unidade e monstro trazem uma orientação cada — verificado em `Archer_64`, `VikingPlayer_64` e `Wolf_64_32`. Os controllers acompanham: o `Player.controller` tem 4 estados (Idle/Move/Attack/Death) e dois parâmetros (`IsRunning`, `PlayerAttack`), sem blend tree e sem parâmetro de direção. O virar é feito invertendo `localScale.x`.

**Isso não é um teto.** Os sprites do jogador e dos Forgelings vão ser produzidos por IA, então a cobertura direcional é uma decisão de escopo de produção, não uma limitação do asset. O que o acervo comprado define é apenas o custo de *reautorar os 83 NPCs e monstros dele* caso você queira que todos tenham a mesma direcionalidade dos seus personagens.

**O sintoma que havia:** o `NewMonsterData.asset` só define `IdleDown` e `WalkSide`. Ao andar para o norte, `SpriteAnimator.Play()` retornava `false`, a animação anterior continuava rodando e, como `facing.x == 0`, o `flipX` nem era atualizado — o monstro andava para cima virado para o lado errado. **Corrigido em 2026-08-01:** o motor agora cai para a pose `Side` quando não existe arte da direção pedida, e o espelhamento passou a ser guiado pela última direção horizontal, então o personagem não "vira sozinho" ao andar na vertical. Isso torna o código tolerante às duas convenções abaixo.

### As três opções

**A — Top-down 4 direções** (o que o código já implementa). Gerar Down/Up/Side para jogador e cada Forgeling. Direcionalidade completa nos personagens que importam. Custo: **cada criatura passa a exigir ~3× mais sprites**, para sempre — num creature collector com dezenas de espécies, esse multiplicador é o custo dominante do projeto. Os NPCs do PixelWorld continuariam com uma orientação, criando uma inconsistência que na prática quase ninguém nota em NPC de fundo.

**B — Uma orientação + flip horizontal** (convenção do PixelWorld). Casa com todo o acervo sem retrabalho, aproveita as 383 animações e 128 controllers como estão, e reduz o custo de cada espécie nova a um terço. É a convenção de vários comerciais do gênero. Custo: andar para norte e sul mostra a mesma pose lateral. Exige simplificar o enum `AnimationState`, removendo os pares Up/Down.

**C — Side view real** (GDD como está escrito). Descartaria praticamente todo o acervo de cenário e personagem. Não recomendado.

**Recomendação: B**, pelo custo marginal por espécie, que é o número que mais importa num creature collector. A recomendação inverte para **A** se a direcionalidade for considerada essencial à identidade visual do jogo — nesse caso, decidir agora, porque cada Forgeling gerado sob a convenção errada é retrabalho.

Em qualquer cenário, o GDD §4 precisa ser atualizado: "visão lateral" não descreve nem o código nem a arte.

---

## 2. Configuração quebrada — correção imediata

### 2.1 Sorting layers, layers e tag ausentes

`ProjectSettings/TagManager.asset` do projeto está vazio: `tags: []`, nenhuma layer customizada, e apenas a sorting layer `Default`.

O PixelWorld espera (`Assets/PixelWorld/ProSettings/TagManager.asset`):

- **Tag:** `Attack`
- **Layers:** `Earth` (6), `Roads` (7), `Objects` (8), `Weather` (9), `Player` (10)
- **Sorting layers:** `Tiles` (3865308043), `Grass` (3277085909), `Objects` (561869287), `Imitation` (3517967339)

Os prefabs referenciam esses IDs diretamente. Exemplo verificado em `Assets/PixelWorld/Prefabs/Objects/TreesStones/Bush.prefab`: `m_SortingLayerID: 561869287`, que não existe no projeto. Todo o conteúdo cai em `Default` e a ordenação de profundidade do mundo colapsa. Os NPCs estão na layer 10, que está sem nome — a matriz de colisão 2D também não foi reconstituída.

### 2.2 Y-sorting desligado

O renderer do PixelWorld (`URPSettings/Renderer2D_Renderer.asset`) usa `m_TransparencySortMode: 3` (CustomAxis) com `m_TransparencySortAxis: {x:0, y:1, z:0}` — o Y-sorting clássico de top-down, que faz personagens mais abaixo na tela aparecerem à frente.

O renderer do projeto (`Assets/Settings/Renderer2D.asset`) usa `m_TransparencySortMode: 0` (Default). Sem isso, personagens e objetos se sobrepõem de forma indefinida. Agravante: os prefabs `Player` e `Forgeling` têm `m_SortingOrder: 99` fixo, ficando permanentemente à frente de tudo.

### 2.3 Build Settings apontando para o vazio

`EditorBuildSettings.asset` referencia `Assets/PixelWorld/Demo/Dungeons.unity` (as cenas foram movidas para `Assets/Scenes/`) e `Assets/Scenes/SampleScene.unity` (não existe). A única cena com Player e Forgeling — `Example_Scene_01.unity` — não está na lista.

### 2.4 Como corrigir

**Resolvido em 2026-08-01 para 2.1 e 2.3.** `TagManager.asset` e `NavMeshAreas.asset` foram copiados de `ProSettings` para `ProjectSettings/`, registrando a tag `Attack`, as layers `Earth`/`Roads`/`Objects`/`Weather`/`Player` e as sorting layers `Tiles`/`Grass`/`Objects`/`Imitation` com os IDs originais. Como o `TagManager` do projeto estava vazio, nada foi perdido — mas de agora em diante essa cópia passa a ser destrutiva, então qualquer tag nova deve ser criada pelo editor, não sobrescrevendo o arquivo. As cópias originais ficaram em `Docs/PixelWorld-ProSettings/`.

**Resolvido em 2026-08-01 para 2.2.** O Y-sorting foi ligado em `Assets/Settings/Renderer2D.asset` (`m_TransparencySortMode: 3`, CustomAxis, eixo `(0,1,0)`) — confirmado que esse é o renderer ativo pela cadeia `GraphicsSettings` → `UniversalRP.asset` → `Renderer2D.asset`. Os prefabs `Player` e `Forgeling` saíram da sorting layer `Default` com `m_SortingOrder: 99` para a layer `Objects` (ID 561869287) com ordem 0, que é a mesma convenção dos prefabs de unidade e cenário do acervo. Ficar em `Default` os teria deixado atrás do próprio terreno, já que `Default` é a primeira da lista.

> **Ressalva.** O Y-sorting ordena pela posição do pivô do sprite. Os sprites do acervo usam pivô central e são consistentes entre si, mas os sprites próprios (`a_idle`/`a_walk`) têm pivô central sobre frames de tamanhos diferentes — enquanto o pivô não for corrigido para a base (seção 3), o Forgeling vai oscilar na ordenação além de tremer na animação.

---

## 3. Pipeline de sprites por IA — a grade do motor

O PixelWorld é rigorosamente uniforme, e essa grade é inegociável para o conteúdo novo:

| Parâmetro | Valor |
|---|---|
| **PPU** (`spritePixelsToUnits`) | **32** |
| **1 tile** | 32 × 32 px = 1 unidade Unity |
| **Filter Mode** | Point (no filter) |
| **Compressão** | None |
| **Sprite Mode** | Multiple (sheet fatiado em grade fixa) |
| **Resolução de referência da câmera** | 640 × 480, Pixel Perfect Camera, PPU 32 |

**Tamanhos de frame canônicos** (o sufixo no nome do arquivo é o tamanho do frame):

- **64 × 64** — padrão para humanoides e criaturas médias. 59 dos 88 sheets.
- **32 × 32** — criaturas pequenas (Rat, Sheep, Bird, SlimeLittle)
- **84 / 92 / 102** — criaturas grandes (Bear, Deer, Golem, Ogre, Yeti)
- **128 – 320** — chefes (`DragonBossSheet_320_256`, `GolemGian_194`)

### O que está errado nos sprites atuais

`Assets/Sprites/a_idle.png` e `a_walk.png`:

| Problema | Valor atual | Deveria ser |
|---|---|---|
| PPU | **1000** | 32 |
| Resolução do sheet | 768×768 e **2128×2384** | múltiplo da célula |
| `maxTextureSize` | **2048** (o walk tem 2384 px — Unity reescala por 0,9624 e destrói o alinhamento) | 4096 ou sheet menor |
| Compressão | **Ativada** | None |
| Slice | auto-slice com trim — **cada frame tem dimensão diferente** (529×588, 509×586, 500×594…) | grade de célula fixa |
| Pivot | Center em bounding box variável → **personagem treme ao andar** | Bottom (alignment 7) |

A arte em si tem resolução lógica de **48 × 48 pixels** (blocos de cor de 16 px em uma imagem de 768 px), ampliada 16×. O `a_walk.png` é uma grade 4×4 de 16 frames.

### Especificação para gerar os Forgelings

Gerar e exportar **na resolução nativa**, sem upscale:

- **Forgeling padrão: 64 × 64 px por frame.** Pequenos podem usar 32, chefes 128+.
- Sheet em grade uniforme (ex.: 4 colunas × N linhas = 256 px de largura).
- Orientação conforme a decisão da seção 1. Se for uma orientação só, gerar virado para a direita (o PixelWorld assume `flipX` para a esquerda); se for 4 direções, gerar Down/Up/Side com o mesmo alinhamento de célula entre os três.
- Pivot na base, personagem alinhado consistentemente na célula.
- Estados mínimos para casar com os controllers existentes: `Idle`, `Move`, `Attack`, `Death`.
- Paleta: a arte do PixelWorld é dessaturada e terrosa; sprites de IA com alta saturação e contorno preto duro vão destoar visivelmente. Vale calibrar o prompt contra um sheet de referência.

O sprite atual, reduzido à resolução lógica de 48 px, fica proporcionalmente coerente ao lado de um Archer de 64 px — a proporção não é o problema, a configuração de import é.

---

## 4. Inventário do PixelWorld — o que está pronto

**63,7 MB, 6.503 arquivos.**

### Arte (excelente)

| Categoria | Arquivos | Sub-sprites |
|---|---|---|
| Tiles | 24 PNG | 1.453 |
| Objetos de cenário | 66 PNG | 2.190 |
| Construções modulares | 8 PNG | 1.297 |
| Unidades humanoides | 52 PNG | 832 |
| Monstros | 31 PNG | 449 |
| Efeitos | 54 PNG | 337 |
| Chefes | 5 PNG | 144 |
| **Total** | **241 PNG + 3 PSB** | **6.702** |

### Tilemap

1.079 Tile assets (1.046 estáticos + 33 animados de água/lava) e 17 Tile Palettes. **Não há RuleTile** — todo autotiling teria de ser configurado do zero. Um Sprite Atlas (`TileAtlas.spriteatlas`) com 1.425 packables.

### Cobertura de biomas vs. GDD §12

| Bioma do GDD | Tiles | Situação |
|---|---|---|
| Floresta | ~359 | Pronto |
| Cavernas / masmorra | 175 | Pronto |
| Neve | 188 | Pronto |
| Montanhas | 86 | Pronto |
| Ruínas | via prefabs | Pronto |
| Deserto | 30 | Raso — 1 sheet, sem cliffs |
| Vulcão | 15 | Quase inexistente |
| **Pântano** | **0** | Só props e inimigos, **nenhum terreno** |
| **Ilhas** | **0** | Ausente |

Bônus não previstos no GDD: bioma "Evil Lands" (112 tiles) e "Fantasy/Outono" (157 tiles).

### Prefabs

- **Objetos de mundo: 1.147** — árvores e pedras (265), interiores (210), decoração (176), construções (175), estradas (95), masmorra (86), grupos prontos (72), baús e caixas quebráveis (35)
- **VFX: 49** — nevasca, chuva, névoa, nuvens, vento, folhas caindo, lava, fogo, luz volumétrica, pegadas. **Cobre boa parte do GDD §13 (clima) sem arte nova.**
- **Unidades: 63** — 59 humanoides, 3 players, **1 único chefe**

### Animações

383 `.anim` + 128 `.controller`, padrão `Idle` / `Move` / `Attack` / `Death` por personagem. Sprite swap via `m_PPtrCurves` no Animator do Unity (não é 2D Animation com bones). Consistente e limpo — junto com a arte, é o maior ativo do pacote.

Parâmetros de Animator padronizados: `Move`, `ChasingSpeedMultiplier`, `EnemyAttack`, `TakeDamage`, `Died` (inimigos); `IsRunning`, `PlayerAttack` (player). **Preservar esses nomes** ao reescrever a IA — 60+ controllers já estão autorados contra eles.

### Cenas de demonstração

- `World.unity` — 69 MB, 356 GameObjects, **3.753 instâncias de prefab**, 8 tilemaps, Cinemachine configurado
- `Dungeons.unity` — 13 MB, 371 instâncias, 6 tilemaps, NavMesh baked

Referência de level design pronta e navegável. **Nenhuma das duas contém Player ou Forgeling do projeto.**

### Lacunas do acervo

1. **Zero prefabs de criatura.** Existem 31 sheets de monstro + 5 de chefe com animações e controllers prontos, mas apenas 1 prefab de chefe montado. Faltam ~35 prefabs de Wolf, Bear, Bat, Slime, Golem, Dragon, Skeleton, Yeti e elementais — arte pronta, montagem pendente.
2. Sem RuleTile.
3. Todos os NPCs, inclusive não-combatentes (mercador, fazendeiro, rainha), carregam `EnemyBehaviour` + `EnemyEntity` + `NavMeshAgent`. Precisa ser reautorado.
4. Duplicatas de import a limpar: `Player 1`, `Box 1`, `Shadows 1/2/3`, `Portal 1`, e 3 sheets marcados `OLD`.
5. **Referências de nested prefab quebradas no próprio pacote** (detectado em 2026-08-01 num import completo). Cinco prefabs apontam para prefabs aninhados cujos GUIDs não existem em lugar nenhum do acervo:

   | Prefab | Filho ausente |
   |---|---|
   | `Prefabs/Objects/Buildings/SCastleBuilding1.prefab` | `Bed_1` |
   | `Prefabs/Objects/Buildings/SCastleBarracks.prefab` | `Bed_1` (3 instâncias) |
   | `Prefabs/Objects/Buildings/BuildingStable.prefab` | `Horse_A`, `Horse_B` |
   | `Prefabs/Objects/XReadyMadeGroups/ElvenTown.prefab` | `HorseC` |
   | `Prefabs/Objects/XReadyMadeGroups/StoneCastleRed.prefab` | `Horse_A`, `Horse_B` |

   É defeito de empacotamento do vendor, não da migração: existe um `Bed_1.prefab` no acervo, mas com GUID `0ce008e8f50376442b41051caa296321`, enquanto os castelos referenciam `33ac53b93c1870f4bacde7eef8b3d022`. Os prefabs de cavalo simplesmente não vieram no pacote — há sprites (`Horse_A/Horse_B_84`) e animações (`Horses`, `HorseC`), mas nenhum prefab. O impacto é cosmético (uma cama e alguns cavalos faltando na decoração) e a correção é reconstruir esses filhos a partir dos sprites que existem.

### Licenciamento

`NavMeshPlus` é MIT (`ThreePartyLicense/LICENSE_NavMeshPlus`) — sem restrição para publicação comercial na Steam.

---

## 5. Scripts do PixelWorld — descartados

**Removidos em 2026-08-01** (19 arquivos `.cs` nas pastas `AI/`, `Player/`, `Nature/` e `ScriptableObjects/`). Isso deixou componentes com script ausente em **312 arquivos** — 311 prefabs e a cena `World.unity`. Use o menu `PixelForge > Limpar scripts ausentes` ([MissingScriptCleaner.cs](Assets/Scripts/Editor/MissingScriptCleaner.cs)) para removê-los; a opção "Contar" simula sem modificar nada.

O registro do que havia e por que foi descartado segue abaixo.

14 scripts de gameplay, ~700 linhas. Origem de tutorial (o namespace `EnemyPatrol.Utilites` traz até o erro de digitação). Defeitos representativos:

- `EnemyEntity.cs:23` — `currentHealth = maxHealth * 2;`. Todo inimigo tem o dobro da vida configurada.
- `EnemyEntity.cs:25-28` — `OnTriggerEnter2D` só faz `Debug.Log("Attack")`. **Não existe dano ao jogador.** O ataque dos inimigos é puramente cosmético.
- `EnemyBehaviour.cs:103,113,180` — a IA inteira depende de `PlayerBehaviour.Instance`. Premissa de jogador único, incompatível com o GDD §19.
- `EnemyBehaviour.cs:113` — `Vector3.Distance` por inimigo por frame. **82 instâncias em `World.unity`**, sem culling nem time-slicing.
- `EnemyEntity.cs:52-65` — na morte, desliga colisores mas nunca destrói nem devolve a pool. Cadáveres com `NavMeshAgent` ativo permanecem para sempre.
- `PlayerBehaviour.cs:46-49` — Input legado (`Input.GetKey(KeyCode.W)`), com o Input System instalado e ignorado.
- `PlayerBehaviour.cs:8` — o evento `OnPlayerAttack` nunca é disparado; todo o handler em `PlayerAnimations` é código morto.
- `Character3.cs:11` — busca o `SpriteRenderer` no root, mas no `PlayerHero.prefab` o renderer do root está desabilitado e o sprite real está no filho `Graphics`. **O fade de árvore/prédio não funciona.**
- `BushShake.cs:15` — `GetComponent<GameObject>()` é inválido e retorna sempre null.
- `BoxDestruction.cs:23-24` — o script se inscreve no próprio evento; `SetTrigger("Broke")` dispara duas vezes.
- `TreeFader.cs` e `BuildingFader.cs` são o mesmo arquivo duplicado, diferindo em duas constantes. 83 + 90 prefabs, cada um com `Update()` incondicional.
- `VectorValue3` grava posição em runtime dentro do `.asset` e persiste entre sessões de play no editor.
- Scripts órfãos, não referenciados por nenhum prefab ou cena: `SpawnFootprints.cs`, `OpenDoor.cs`, `SceneTransition.cs`.

**O que preservar:** a convenção de prefab `Root / Shadow / Graphics` (é boa), os nomes de parâmetro do Animator, os Animation Events já autorados nos clips de ataque (`TriggerAttAnimTurnOn/Off`), e o NavMeshPlus.

---

## 6. Código próprio — 705 linhas, 10 arquivos

### Arquitetura

```
ScriptableObject                    MonoBehaviour
 └─ CharacterAnimationSet (abstract) └─ CharacterMotor2D (abstract)
     ├─ MonsterData                      ├─ MonsterController  (IA)
     └─ PlayerCharacterData              └─ PlayerController   (input)
```

A separação "a base decide **como** se move, a subclasse decide **quando**" está correta e bem comentada. Adicionar uma espécie é duplicar um `.asset`, sem código.

O `SpriteAnimator` custom, que troca o sprite por timer manual em vez de usar o Animator do Unity, é **a decisão certa** para um creature collector: elimina um `.controller` + N `.anim` por espécie, reduz o custo por instância, e produz estado determinístico e serializável para multiplayer. O custo (sem blend trees, sem root motion) é irrelevante aqui.

Porém: isso **conflita com os 128 controllers do PixelWorld**, que são Animator clássico. Ou os sheets do PixelWorld são reimportados como `SpriteAnimationClip`, ou o projeto mantém dois sistemas de animação em paralelo. Vale decidir explicitamente.

### Estado dos sistemas

| Sistema | Estado |
|---|---|
| Movimento livre via `NavMeshAgent` | Funcional (reescrito em 2026-08-01; antes era grid tile-a-tile) |
| Animador de sprites | Funcional |
| Data assets (ScriptableObject) | Funcional |
| Input do jogador | Funcional, mas polling cru de teclado |
| IA de seguir (Forgeling) | Esqueleto — 11 linhas, sem pathfinding |
| Ataque / Coleta | Stub visual — toca animação, sem dano, sem hitbox, sem coleta |
| Vida / dano / morte | Stub — `CurrentHealth` é escrito uma vez e nunca lido |
| Colisão com obstáculos | Resolvido pelo navmesh — paredes vêm do bake, não mais de um `OverlapBox` com `obstacleMask` |
| Câmera / follow | Inexistente. Sem Cinemachine, sem Pixel Perfect Camera |

### Bugs verificados

**[Crítico] O Player está invisível.** `Assets/Resources/Player.asset` referencia o GUID `610666ad4a691274e974795222aa16b3` nos 13 frames. Busca recursiva em todo `Assets/` confirma: **esse GUID não existe**. A textura foi deletada ou renomeada.

O erro é silencioso: `SpriteAnimator.Play()` faz `_renderer.sprite = clip.frames[0]` sem checar null, e `BuildLookup()` só descarta arrays vazios, não arrays de nulls. O clip é considerado válido, `Play()` retorna `true`, e nada é renderizado — sem uma linha de erro no console. Agravante: o asset não tem o campo `sheet` serializado, então o "Auto-fill frames from sheets" não consegue repará-lo. Terá de ser refeito à mão.

**[Alto] Enum serializado por índice.** `AnimationState` é gravado nos assets como número (`state: 0`, `state: 5`). Inserir um valor no meio do enum **remapeia silenciosamente todas as animações de todos os assets já criados**. Com 100 espécies isso é irrecuperável. Corrigir agora com valores explícitos (`IdleDown = 0, IdleUp = 10, …`) — a janela para fazer isso de graça fecha a cada asset novo.

**[Alto] `InputSystem_Actions.inputactions` está pronto e ignorado.** O asset já tem `Move`, `Attack`, `Interact`, `Sprint`, `Jump` com bindings de teclado, gamepad e touch, e está registrado no `EditorBuildSettings`. O `PlayerController` lê `Keyboard.current` direto, com teclas hardcoded. Consequências: rebind impossível, **gamepad não funciona** (o GDD §3 tem Steam Deck e consoles como alvo), e `Keyboard.current` é um device global — dois `PlayerController` locais leriam o mesmo teclado. A migração é ~30 linhas.

**[Médio] Prefabs desconfigurados.** `Rigidbody2D` salvo como Dynamic com `gravityScale: 1`, `BoxCollider2D` com `size: 0.0001` — corrigidos só em runtime no `Awake()`. Funciona, mas o prefab mente sobre o que é: desabilitar o script faz o personagem despencar. Além disso, os prefabs estão em `Assets/Scenes/`, não em `Assets/Prefabs/`.

**Código morto:** `BehaviorState.Hurt` e `Faint` nunca são atingidos; `MonsterController.Move()` não tem chamador; `SnapToTileCenter()` é no-op (não há `Grid` na cena); `ResourceNodeData` inteiro é dado sem consumidor; os campos `element`, `gatherPower`, `canBattle`, `canCollectResources` e `inventorySlots` são órfãos.

**Sem testes e sem `.asmdef`** — tudo cai em `Assembly-CSharp`, com recompilação total a cada edição e sem como separar assemblies de cliente e servidor depois.

### Pontos bons a preservar

- O fallback quando não existe clip para Attack/Collect evita travar o personagem para sempre (`CharacterMotor2D.cs:167-175`).
- `EnsureRenderer()` lazy resolve a ordem indefinida de `Awake()` entre componentes do mesmo GameObject.
- Derivar `Loops` do estado em vez de serializar um bool contorna a armadilha do Unity de ignorar field initializers em elementos de lista — e o `frameRate: 0` em todos os clips prova que a armadilha era real.

---

## 7. Riscos de escala

**Multiplayer (GDD §19) — o mais grave.** Não há nenhum pacote de rede no `manifest.json`. Mais importante: `MonsterController.cs:35` faz `FindFirstObjectByType<PlayerController>()`, assumindo um único jogador no mundo — o mesmo defeito estrutural do PixelWorld. Não há separação entre simulação e apresentação: `CharacterMotor2D` mistura input, física e escolha de animação na mesma classe, e todo o estado autoritativo vive em `Transform`/`Rigidbody2D`. Não há como interpolar remotos, reconciliar predição, nem rodar headless. **Fazer esse refactor com 705 linhas custa dias; com 20.000, meses.**

**Muitas criaturas.** `Update()` por instância em três níveis (`SpriteAnimator`, `CharacterMotor2D`, `MonsterController`) mais `FixedUpdate`. Com centenas de Forgelings o custo é dominado por overhead de interop C++→C#, não por lógica. Precisa virar um manager iterando uma lista. Não há object pooling — e `MonsterController.Initialize()` foi escrito pensando em pool, mas não reseta `facingDirection`, `currentBehavior` nem `_isStepping`, o que garante bug no dia em que o pool existir.

**Mundo aberto.** `World.unity` tem 69 MB em cena monolítica. Sem Addressables, sem carregamento aditivo, sem chunking. Isso não carrega em Steam Deck.

~~**Movimento em grid sem reserva de célula.**~~ Obsoleto: com movimento livre por `NavMeshAgent`, a separação entre agentes passa a ser resolvida pelo *avoidance* do próprio NavMesh. Vale conferir a `Obstacle Avoidance Quality` dos agentes quando houver muitas criaturas juntas — é o parâmetro que troca custo de CPU por qualidade de separação.

---

## 8. GDD sem implementação

| § | Sistema | Status |
|---|---|---|
| 8 | Captura (cápsulas, chance por vida/nível/raridade) | Zero — não existe nem `level` nem `rarity` em `MonsterData` |
| 9 | Forgelings: personalidade, nível, afinidades, ataques | Zero — só `element` (órfão) + 3 stats |
| 10 | Skills (14 listadas: Dig, Surf, Mine, Fly…) | Zero — nenhuma classe `Skill` |
| 11 | Construção (12 tipos de edificação) | Zero |
| 12 | Biomas com recursos e chefes próprios | Zero em código — arte cobre 5 de 9 biomas |
| 13 | Clima dinâmico | Zero em código — **VFX prontos no PixelWorld** |
| 14 | Crafting | Zero — nem um `ItemData`; `ResourceNodeData.itemId` é string solta |
| 15 | Profissões (Engenheiro / Caçador / Mercenário) | Zero |
| 16 | Combate em tempo real, skills nas teclas 1-4 | Zero — `TriggerAttack` só toca animação |
| 17 | IA do Forgeling (clique direito para atacar) | ~5% — só o "segue automaticamente" |
| 18 | Chefes | Zero em código — 5 sheets + 1 prefab na arte |
| 19 | Multiplayer / salas / persistência | Zero, e a arquitetura atual é hostil a isso |
| — | Inventário, progressão, save/load, UI, áudio | Zero |

---

## 9. Ordem de trabalho recomendada

**Bloqueantes (antes de qualquer feature nova):**

1. Decidir a cobertura direcional dos personagens (seção 1) e atualizar o GDD §4. É a decisão que define o custo de cada Forgeling gerado daqui em diante.
2. Copiar `ProSettings/TagManager.asset` e `NavMeshAreas.asset` para `ProjectSettings/`, e ajustar o `Renderer2D.asset` para CustomAxis (0,1,0).
3. Corrigir `Player.asset` — os frames apontam para um GUID morto e o Player está invisível.
4. Definir o pipeline de sprites: 64×64 nativo, PPU 32, Point, sem compressão, slice em célula fixa, pivot Bottom, `maxTextureSize` 4096.
5. Dar valores explícitos ao enum `AnimationState`.

**Alta prioridade:**

6. Decidir entre `SpriteAnimator` custom e os Animator Controllers do PixelWorld — ou definir a fronteira entre os dois.
7. Migrar para `InputSystem_Actions` + `PlayerInput`. Destrava gamepad, Steam Deck e rebind por ~30 linhas.
8. Adicionar Pixel Perfect Camera (PPU 32, 640×480) e Cinemachine na cena de gameplay.
9. Criar `.asmdef` enquanto é barato.

**Estrutural, antes de crescer:**

10. Extrair a simulação de `MonoBehaviour` e remover a premissa de jogador único. Se o multiplayer do §19 é para valer, este é o momento.
11. Montar os ~35 prefabs de criatura a partir dos sheets do PixelWorld — a arte e as animações já existem.

---

## Nota de ambiente

O Unity Editor conectado via MCP nesta sessão está aberto em outro projeto (`C:/Projetos/autobattle` — "Auto Battle"), não em PixelForge. Toda a auditoria foi feita por leitura direta dos arquivos. Para inspeção ao vivo do PixelForge, o editor precisa ser aberto neste projeto.
