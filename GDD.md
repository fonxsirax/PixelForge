# PixelForge
## Game Design Document (GDD)

**Versão:** 0.2
**Status:** Em Desenvolvimento
**Gênero:** Survival • Open World • Creature Collector • Base Building • Multiplayer

---

# 1. Elevator Pitch

**PixelForge** é um jogo 2D pixel-art de sobrevivência em mundo aberto onde o jogador explora um vasto mundo, captura criaturas chamadas **Forgelings**, constrói sua própria base, evolui sua profissão e enfrenta chefes, facções inimigas e outros jogadores utilizando a combinação entre suas habilidades e as de seus companheiros.

Os Forgelings não são apenas aliados de combate: suas habilidades especiais permitem explorar novas regiões, coletar recursos raros, resolver desafios ambientais e auxiliar na construção e evolução do mundo.

O foco do jogo é proporcionar liberdade para explorar, construir, evoluir e jogar cooperativamente em servidores persistentes.

---

# 2. Gênero

- Survival
- Open World
- Adventure RPG
- Creature Collector
- Base Building
- Multiplayer Online

---

# 3. Público Alvo

- PC (Steam)
- Steam Deck
- Consoles (futuro)

---

# 4. Direção Artística

- Pixel Art 16 bits
- Visão lateral (Side View)
- Animações fluidas
- Mundo vivo e colorido
- Biomas únicos com identidade própria

---

# 5. Gameplay Principal

Durante a aventura o jogador irá:

- Explorar o mundo
- Coletar recursos
- Construir sua base
- Capturar Forgelings
- Evoluir sua profissão
- Fabricar equipamentos
- Derrotar chefes
- Descobrir novos biomas
- Jogar cooperativamente com amigos

---

# 6. Gameplay Loop

```text
Explorar

↓

Coletar Recursos

↓

Capturar Forgelings

↓

Construir Base

↓

Fabricar Equipamentos

↓

Evoluir Profissão

↓

Derrotar Chefes

↓

Explorar Novos Biomas

↓

Capturar Novos Forgelings

↓

Repetir
```

---

# 7. Diferencial Principal

O diferencial de PixelForge está na integração entre o jogador e seus Forgelings.

Cada criatura possui habilidades próprias que expandem as possibilidades de exploração, combate e coleta de recursos.

Enquanto o personagem evolui através de suas profissões, os Forgelings oferecem novas formas de interagir com o mundo, desbloqueando caminhos, recursos e estratégias impossíveis de serem alcançados sozinho.

---

# 8. Sistema de Captura

Os Forgelings podem ser encontrados em diferentes biomas do mundo.

Após enfraquecer uma criatura, o jogador poderá utilizar uma cápsula de captura.

A chance de captura depende de diversos fatores:

- Vida restante
- Nível
- Raridade
- Tipo da cápsula
- Condições especiais aplicadas

Cada espécie possui características únicas e diferentes graus de dificuldade para captura.

---

# 9. Forgelings

Os Forgelings acompanham o jogador durante toda sua aventura.

Cada espécie possui:

- Elemento
- Atributos
- Personalidade
- Nível
- Skills exclusivas
- Ataques
- Afinidades

Cada jogador possui apenas um Forgeling ativo por vez durante o combate e exploração.

---

# 10. Skills dos Forgelings

Cada Forgeling possui um conjunto exclusivo de Skills.

Essas habilidades permitem acessar novas áreas do mapa, obter recursos específicos e resolver diversos desafios do mundo.

Exemplos:

- Dig
- Surf
- Rock Smash
- Lumberjack
- Climb
- Fly
- Swim
- Mine
- Ignite
- Freeze
- Illuminate
- Push
- Pull
- Carry

As Skills podem ser utilizadas para:

- Coleta de recursos
- Construção
- Exploração
- Missões
- Resolução de puzzles
- Acesso a áreas bloqueadas

Diversos recursos do jogo somente poderão ser obtidos utilizando um Forgeling com a Skill adequada.

---

# 11. Construção

O jogador poderá construir sua própria base utilizando recursos encontrados durante a exploração.

Construções previstas:

- Casas
- Muralhas
- Portões
- Fazendas
- Minas
- Armazéns
- Laboratórios
- Forjas
- Cozinhas
- Fábricas
- Torres
- Decorações

A base servirá como centro de operações do jogador durante toda a campanha.

---

# 12. Exploração

O mundo de PixelForge será composto por diversos biomas.

Exemplos:

- Floresta
- Deserto
- Neve
- Pântano
- Vulcão
- Montanhas
- Ruínas
- Ilhas
- Cavernas

Cada bioma possui:

- Recursos exclusivos
- Forgelings exclusivos
- Chefes
- Eventos
- Materiais próprios

---

# 13. Sistema de Clima

O mundo possui clima dinâmico.

Eventos climáticos previstos:

- Chuva
- Tempestades
- Neve
- Tempestade de areia
- Neblina
- Lua Vermelha

Determinados eventos, criaturas e recursos poderão aparecer apenas sob condições climáticas específicas.

---

# 14. Crafting

O jogador poderá fabricar diversos itens.

Exemplos:

- Ferramentas
- Armas
- Armaduras
- Poções
- Comidas
- Máquinas
- Decorações
- Veículos

Novos itens serão desbloqueados conforme a exploração e evolução do jogador.

---

# 15. Sistema de Profissões

O personagem possui uma profissão principal que define seu estilo de combate e desbloqueia equipamentos e habilidades exclusivas.

Cada profissão possui sua própria árvore de evolução.

## Engenheiro

Especialista em combate estratégico.

Habilidades:

- Armadilhas
- Bombas
- Minas explosivas
- Torres temporárias
- Equipamentos especiais

---

## Caçador

Especialista em combate à distância.

Habilidades:

- Arcos
- Bestas
- Flechas especiais
- Disparos carregados
- Alta mobilidade
- **Taunt** — provoca Forgelings selvagens a desafiá-lo, abrindo uma rota de aquisição de criaturas exclusiva da profissão (§26.4)

---

## Mercenário

Especialista em combate corpo a corpo.

Habilidades:

- Adagas
- Golpes críticos
- Combos
- Esquivas
- Ataques rápidos

---

# 16. Sistema de Combate

O combate ocorre em tempo real.

O personagem principal luta utilizando equipamentos relacionados à sua profissão.

Enquanto isso, seu Forgeling fornece suporte através de suas próprias habilidades.

## Combate do Personagem

Dependendo da profissão escolhida, o jogador poderá utilizar:

- Adagas
- Arcos
- Armadilhas
- Bombas
- Equipamentos especiais

Novas técnicas serão desbloqueadas conforme a evolução da profissão.

## Combate dos Forgelings

Cada Forgeling pode equipar até **4 Skills de combate simultaneamente**.

As Skills são ativadas diretamente pelo jogador através das teclas:

- 1
- 2
- 3
- 4

Cada criatura possui habilidades exclusivas, incentivando diferentes estratégias e combinações.

---

# 17. IA dos Forgelings

O Forgeling ativo acompanha automaticamente o jogador durante toda a exploração.

Durante o combate:

- Segue automaticamente o personagem.
- Ao clicar com o botão direito sobre um inimigo, passa a atacar aquele alvo.
- Continua atacando o alvo até sua derrota ou até receber uma nova ordem.
- As Skills continuam sendo ativadas manualmente pelo jogador através das teclas de atalho.

Essa abordagem busca oferecer uma IA previsível, simples e eficiente, permitindo que o jogador mantenha controle total durante os combates.

---

# 18. Chefes

PixelForge contará com diversos chefes distribuídos pelo mundo.

Esses encontros representarão alguns dos maiores desafios do jogo e exigirão preparação, equipamentos adequados e uma boa combinação entre as habilidades do personagem e de seus Forgelings.

Os detalhes sobre progressão, mecânicas e recompensas dos chefes serão definidos em versões futuras do GDD.

---

# 19. Multiplayer

PixelForge possui suporte nativo ao modo multiplayer baseado em salas.

Os jogadores poderão criar salas públicas ou privadas para compartilhar um mesmo mundo.

Cada sala possui sua própria progressão, construções, criaturas capturadas e estado persistente do mundo.

Recursos previstos:

- Cooperação entre jogadores
- Bases compartilhadas
- Exploração em grupo
- Construção colaborativa
- Comércio entre jogadores
- Duelos amistosos
- Eventos cooperativos
- Chefes enfrentados em equipe

Todo o conteúdo principal do jogo poderá ser aproveitado tanto em partidas solo quanto em multiplayer.

---

# 20. Sistema de Tipos

PixelForge possui **6 tipos elementais**. Todo Forgeling tem exatamente um tipo, e todo ataque também tem um tipo — o multiplicador é sempre `tipo do ataque × tipo do Forgeling defensor`.

## 20.1 Os seis tipos

| Tipo | Papel no sistema |
|---|---|
| **Água** | Ciclo elemental |
| **Fogo** | Ciclo elemental |
| **Terra** | Ciclo elemental |
| **Ar** | Ciclo elemental |
| **Sombrio** | Eixo moral — muralha contra os elementos |
| **Sagrado** | Eixo moral — algoz do Sombrio |

## 20.2 O ciclo elemental (Água, Fogo, Terra, Ar)

Os quatro elementos formam um **ciclo fechado**, o que os deixa perfeitamente equilibrados entre si:

```text
Água → Fogo → Terra → Ar → Água
```

Cada elemento:

- causa **150%** de dano no elemento seguinte do ciclo;
- causa **50%** de dano no elemento anterior do ciclo;
- causa **100%** de dano no elemento oposto (Água↔Terra, Fogo↔Ar) e em si mesmo.

Ou seja: cada um dos quatro tem exatamente **uma vantagem, uma desvantagem e duas neutralidades**. Nenhum deles é melhor que outro no vácuo — a escolha depende de contra o que você vai lutar.

## 20.3 O eixo moral (Sombrio e Sagrado)

- **Sombrio** recebe apenas **25%** de dano dos quatro elementos, mas recebe **200%** de dano Sagrado.
- **Sagrado** é o inverso exato: recebe **200%** de dano dos quatro elementos, mas recebe apenas **25%** de dano Sombrio.
- Sombrio e Sagrado causam dano **neutro (100%)** contra os quatro elementos e contra si mesmos.

O resultado é uma relação de pedra-papel-tesoura em escala macro: **Sombrio domina o mundo elemental, Sagrado domina o Sombrio, e o mundo elemental domina o Sagrado.**

## 20.4 Tabela de dano (atacante × defensor)

Leia como: *"um ataque do tipo da linha, contra um Forgeling do tipo da coluna, causa X% do dano"*.

| Atacante ↓ / Defensor → | Água | Fogo | Terra | Ar | Sombrio | Sagrado |
|---|---|---|---|---|---|---|
| **Água**    | 100% | **150%** | 100% | *50%* | *25%* | **200%** |
| **Fogo**    | *50%* | 100% | **150%** | 100% | *25%* | **200%** |
| **Terra**   | 100% | *50%* | 100% | **150%** | *25%* | **200%** |
| **Ar**      | **150%** | 100% | *50%* | 100% | *25%* | **200%** |
| **Sombrio** | 100% | 100% | 100% | 100% | 100% | *25%* |
| **Sagrado** | 100% | 100% | 100% | 100% | **200%** | 100% |

Multiplicadores em código: `2.0` · `1.5` · `1.0` · `0.5` · `0.25`.

## 20.5 Leitura rápida por tipo (defesa)

| Tipo | Fraco contra (recebe mais) | Resiste a (recebe menos) |
|---|---|---|
| **Água** | Ar (150%) | Fogo (50%) |
| **Fogo** | Água (150%) | Terra (50%) |
| **Terra** | Fogo (150%) | Ar (50%) |
| **Ar** | Terra (150%) | Água (50%) |
| **Sombrio** | Sagrado (200%) | Água, Fogo, Terra, Ar (25%) |
| **Sagrado** | Água, Fogo, Terra, Ar (200%) | Sombrio (25%) |

## 20.6 Verificação de balanceamento

Somando a linha (poder ofensivo total) e a coluna (dano total recebido — quanto **menor**, mais tanque) de cada tipo:

| Tipo | Soma ofensiva | Soma defensiva (menor = melhor) | Perfil |
|---|---|---|---|
| Água / Fogo / Terra / Ar | 625 cada | 600 cada | Idênticos entre si — equilíbrio perfeito |
| **Sombrio** | 525 | **400** | Tanque: a melhor defesa do jogo, o pior ataque |
| **Sagrado** | 700 | **925** | Glass cannon: o melhor ataque, a pior defesa |

Os quatro elementos são numericamente **indistinguíveis** — a diferença entre eles é só *contra quem* funcionam, exatamente como pedido. Sombrio e Sagrado pagam pelo poder com a fraqueza oposta: Sombrio atravessa o mundo inteiro até encontrar um Sagrado; Sagrado destrói Sombrios mas derrete contra qualquer elemento comum.

> **Consequência de design a observar:** contra Sombrio, o time do jogador *precisa* ter uma resposta Sagrada (25% de dano é praticamente uma parede). Chefes Sombrios devem, portanto, aparecer só **depois** que o jogador tiver acesso garantido a um Forgeling Sagrado — via quest, ovo ou respawn fixo. Isso é uma dependência de progressão, não só de balanceamento.

## 20.7 Aplicação no cálculo de dano

```text
dano = potenciaDoAtaque
     × (atkAtacante / defDefensor)
     × multiplicadorElemental      // tabela 20.4
     × bonusDeAfinidade            // 1.2 se tipoAtaque == tipoForgeling, senão 1.0
     × critico                     // 1.5 ou 1.0
     × variacao                    // aleatório entre 0.9 e 1.1
```

- O **multiplicador elemental** é sempre aplicado antes da variação aleatória, para que a vantagem de tipo nunca seja apagada pela sorte.
- O **bônus de afinidade** (+20% quando o Forgeling usa um ataque do próprio tipo) é uma proposta desta versão — ver §28.

## 20.8 Impacto no código existente

O enum atual em [MonsterData.cs:5](Assets/Scripts/Data/MonsterData.cs:5) é `MonsterElement { Normal, Fire, Water, Grass, Electric, Rock, Ice, Bug }` — herdado do protótipo e **incompatível com este GDD**. Precisa virar:

```csharp
public enum ForgelingElement { Water, Fire, Earth, Air, Dark, Holy }
```

A tabela de §20.4 deve viver como uma matriz `float[6,6]` estática (ou um ScriptableObject `TypeChartData` editável no Inspector, se quiser tunar sem recompilar), consultada por `GetMultiplier(attackType, defenderType)`.

---

# 21. NPCs, Tasks e Quests

NPCs espalhados pelo mundo podem oferecer três coisas ao jogador:

| Oferta | O que é | Exemplo |
|---|---|---|
| **Task** | Objetivo curto e repetível, sem narrativa. | "Traga 10 minérios de ferro", "colete 5 ervas" |
| **Quest** | Cadeia com narrativa, etapas encadeadas e recompensa única. | "Descubra o que aconteceu com a mina do norte" |
| **Batalha** | Desafio direto contra o time do NPC. | Duelo com o treinador da vila |

Regras gerais:

- Um NPC pode oferecer mais de um tipo ao mesmo tempo, e o que ele oferece pode mudar conforme o progresso do jogador.
- Tasks são repetíveis (com cooldown); quests são únicas por jogador.
- Etapas de quest podem exigir **combate**, e nesse caso o jogo entra em **ForgelingView** (§22).
- Recompensas possíveis: XP do jogador, XP do Forgeling, itens, recursos, itens de evolução, ovos, Forgelings e desbloqueio de áreas.

---

# 22. ForgelingView — Modo de Batalha

Todo combate de PixelForge acontece no **ForgelingView**.

**Como funciona:** o personagem do jogador **fica parado** e o controle passa integralmente para o **Forgeling ativo**. O jogador move o Forgeling, posiciona, esquiva e dispara suas Skills (teclas 1–4, §16).

**Quando o ForgelingView é ativado:**

- Etapas de combate dentro de quests
- Batalhas contra NPCs
- Combate contra Forgelings selvagens
- Chefes
- Outras situações convenientes (features futuras — ex.: puzzles que exigem controlar o Forgeling à distância)

**O personagem durante a batalha:**

- Fica **visível na cena**, parado na posição em que estava.
- É **invulnerável** — não pode ser atingido nem alvejado por inimigos. Toda a tensão do combate está no Forgeling.
- A câmera passa a seguir o **Forgeling**, não o personagem.

**Troca de Forgeling em combate:**

O jogador **não pode trocar livremente** o Forgeling ativo durante a batalha. A troca só acontece quando o Forgeling atual é **derrotado** — o próximo do time entra automaticamente (ou por escolha do jogador, se houver mais de um disponível), funcionando como uma "vida extra".

Consequência de design: a escolha do Forgeling **antes** da batalha é uma decisão real e punível. Entrar contra um Sombrio sem um Sagrado no time (§20.6) significa lutar em desvantagem até o fim — não dá para consertar no meio da luta.

---

# 23. Evolução dos Forgelings

- A maioria das espécies possui **2 evoluções** (ou seja, 3 estágios: base → evo 1 → evo 2).
- Algumas possuem **3 evoluções**.
- Em casos **raros**, uma espécie pode ter até **4 evoluções**.
- Algumas espécies não evoluem (forma única).

**Requisitos de evolução:**

- A maioria dos Forgelings exige um **item especial de evolução** além do nível mínimo.
- Itens de evolução são obtidos por quests, chefes, biomas específicos e crafting.
- É possível **encontrar Forgelings já evoluídos** no mundo — normalmente em áreas de nível alto, com respawn mais raro. Essa é a rota alternativa para quem não tem o item.

**Níveis de evolução sugeridos** (dentro do teto de nível 10, §27.2):

| Estágios | Evolui em |
|---|---|
| 2 estágios (1 evolução) | Nv. 5 |
| 3 estágios (2 evoluções) | Nv. 4 e Nv. 8 |
| 4 estágios (3 evoluções) | Nv. 3, Nv. 6 e Nv. 9 |
| 5 estágios (4 evoluções — raro) | Nv. 2, 4, 6 e 8 |

Evoluir **não reseta** nível, natureza nem individual values — muda a espécie, os stats base, o sprite e libera novas entradas na lista de ataques.

---

# 24. Ataques e AtkPool

Cada espécie de Forgeling possui uma **AtkPool**: a lista completa de ataques que aquela espécie pode aprender, cada um associado ao nível em que se torna disponível.

Regras:

- Ao subir de nível, o Forgeling **aprende** todo ataque cujo nível de desbloqueio foi atingido.
- O Forgeling mantém no **máximo 4 ataques equipados** ao mesmo tempo.
- Se já tem 4 e aprende um novo, o jogador escolhe qual substituir (ou recusa o novo).
- Ataques trocados fora não são perdidos permanentemente — ficam disponíveis para reequipar a qualquer momento fora de combate.
- Cada ataque tem: **tipo** (§20), **potência**, **cooldown**, **alcance** (melee/range), **custo** (se houver) e **efeito** opcional.

Estrutura de dados:

```text
AtkPoolEntry { attackId, unlockLevel }
ForgelingSpecies { ..., atkPool: AtkPoolEntry[] }
ForgelingInstance { ..., equippedAttacks: attackId[4] }
```

---

# 25. Auto-Ataque, Melee e Range

Todo Forgeling — do jogador ou selvagem — possui **auto-ataque**. Ele dispara sozinho contra o alvo atual, sem input do jogador; as Skills das teclas 1–4 são o que o jogador controla ativamente.

**Melee × Range:** cada espécie é **melee** ou **range**. Isso define o alcance do auto-ataque e o posicionamento natural da criatura em combate — mas ambos têm auto-ataque.

**Cadência pela Speed:** a velocidade do auto-ataque deriva do atributo `speed`, mas **varia pouco de propósito** — no máximo o dobro da cadência base:

```text
intervalo = INTERVALO_BASE / (1 + min(1, speed / SPEED_REF))
```

| Speed | Multiplicador de cadência | Intervalo (com base 1.2s) |
|---|---|---|
| 0 | 1.0× | 1.20 s |
| SPEED_REF / 2 | 1.5× | 0.80 s |
| ≥ SPEED_REF | 2.0× (teto) | 0.60 s |

Valores iniciais para tuning: `INTERVALO_BASE = 1.2s`, `SPEED_REF = 200`.

O teto rígido de 2× garante que speed **nunca** vire o atributo dominante — ela decide iniciativa e reposicionamento, não DPS bruto.

---

# 26. Forgelings Selvagens

## 26.1 Comportamento

- Forgelings selvagens usam os ataques da própria **AtkPool** (§24), respeitando **cooldown** e as mesmas regras de balanceamento dos ataques do jogador. Não existe IA que "trapaceia" com cooldown reduzido ou dano diferente.
- Um selvagem pode ser **agressivo** (ataca ao detectar) ou **passivo** (só reage se atacado).
- **Sight** define o raio em que o selvagem detecta o jogador.
- Ao ser derrotado, o selvagem concede **XP para o jogador** e **XP para o Forgeling que estava ativo**.

## 26.2 Formas de adquirir Forgelings

| Método | Descrição |
|---|---|
| **Captura** | Cápsula em criatura enfraquecida (§8) |
| **Ovos** | Encontrados no mundo, comprados ou dados como recompensa; chocam após condição/tempo |
| **Quests** | Entregues como recompensa por NPCs (§21) |
| **Taunt** | Provocação que faz um selvagem desafiar o jogador (§26.4) |

## 26.4 Taunt

**Taunt é uma habilidade da profissão Caçador** (§15). O Caçador provoca um Forgeling selvagem, que passa a desafiá-lo diretamente — abrindo uma rota de aquisição que não depende de gastar cápsula.

**A fonte do Taunt precisa ser expansível.** O Taunt não deve ser codificado como "uma habilidade do Caçador", e sim como um **efeito que qualquer fonte pode conceder**:

| Fonte | Exemplo |
|---|---|
| **Profissão** | Habilidade nativa do Caçador |
| **Consumível** | Pergaminho de Provocação — uso único, disponível a qualquer profissão |
| **Equipamento / item** | Item que concede Taunt enquanto equipado |
| **Futuro** | Skill de Forgeling, item de base, evento |

Na prática: `TauntSource` é uma interface/lista de concessores, e o Caçador é apenas o primeiro deles. Isso mantém o Taunt como identidade do Caçador (ele tem de graça, sempre, sem custo de item) sem trancar a mecânica atrás da profissão — as outras profissões pagam com um consumível pelo que o Caçador faz nativamente.

Pontos a detalhar: cooldown, alcance, chance de sucesso por raridade/nível do alvo, e o que acontece exatamente ao vencer o desafio (§28).

## 26.3 Respawn de Forgelings

Pontos de respawn são **prefabs configuráveis** posicionados na cena pelo level designer. Cada ponto mantém uma população fixa de selvagens dentro de uma **área grande**.

**Configuração do prefab `ForgelingSpawner`:**

| Campo | Descrição |
|---|---|
| `species[]` | Espécies possíveis, com peso de sorteio |
| `spawnCount` | Quantidade que nasce por ciclo |
| `maxAlive` | População máxima viva simultânea na área |
| `areaShape` / `areaSize` | Círculo ou retângulo — a área é grande, não um ponto |
| `levelRange` | Nível mínimo e máximo dos selvagens gerados |
| `respawnDelay` | Tempo até repor um abatido |
| `aggressive` | Se os selvagens desta área atacam ao detectar |
| `sight` | Raio de detecção do jogador |
| `leashRange` | Distância máxima da área antes de o selvagem desistir e voltar |
| `preEvolved` | Se a área pode gerar formas já evoluídas (§23) e com que chance |

**Requisitos de usabilidade no Editor (obrigatórios):**

- O objeto de respawn deve **exibir o sprite do Forgeling** configurado, tanto no Inspector quanto como ícone na Scene View — para o level designer bater o olho no mapa e saber o que nasce ali sem clicar em nada.
- Quando houver múltiplas espécies, exibir todos os sprites lado a lado (ou o de maior peso, com contador).
- Gizmo desenhando a **área de spawn**, o **raio de sight** e o **leash** na Scene View.
- Um Editor script (`ForgelingSpawnerEditor.cs`) cuida do preview de sprite e dos gizmos; o componente de runtime não carrega nada disso.

---

# 27. Atributos e Estrutura de Dados

## 27.1 Jogador

| Campo | Descrição |
|---|---|
| `level` | Nível do jogador, ganho por combate, quests e tasks |
| `profession` | Profissão principal (§15) |
| `team[5]` | Até **5 Forgelings** no time |
| `activeForgeling` | Índice do Forgeling ativo (apenas 1 por vez, §9) |

## 27.2 Instância de Forgeling

Cada Forgeling é uma **instância única** — duas criaturas da mesma espécie têm stats diferentes.

```text
ForgelingInstance {
  speciesId          // espécie (define tipo, stats base, atkPool, evoluções)
  nickname
  level              // 1 a 10 (MAX_FORGELING_LEVEL = 10)
  xp
  nature             // §27.3
  individualValues { atk, life, speed }   // §27.4
  equippedAttacks[4] // §24
  currentHp
}
```

> **Teto de nível: 10, definitivo.** A progressão por criatura é curta de propósito — o foco do jogo é **colecionar e alternar** entre Forgelings, não grindar um único bicho até o teto. Isso impõe duas restrições de design a respeitar daqui em diante: AtkPools enxutas (5 a 8 entradas por espécie, já que só há 10 níveis para distribuí-las) e uma curva de XP curta o bastante para que capturar uma criatura nova nunca pareça um retrocesso.

## 27.3 Naturezas

Inspiradas no sistema de Pokémon, adaptadas aos **três stats** de PixelForge (`atk`, `life`, `speed`). Cada natureza dá **+10% em um stat e −10% em outro**, ou é neutra:

| Natureza | Sobe | Desce |
|---|---|---|
| **Neutra** | — | — |
| **Feroz** | ATK | LIFE |
| **Bruta** | ATK | SPEED |
| **Rígida** | LIFE | ATK |
| **Densa** | LIFE | SPEED |
| **Ágil** | SPEED | ATK |
| **Errática** | SPEED | LIFE |

São **7 naturezas** — todas as combinações possíveis de subir um e descer outro entre três stats, mais a neutra. A natureza é sorteada na captura/choco e **nunca muda** (a não ser por item raro, se essa mecânica for adicionada).

## 27.4 Individual Values (IVs)

Cada instância recebe **três rolagens independentes**, uma por stat, no intervalo de **−10% a +10%**:

```text
iv.atk   ∈ [-10, +10]
iv.life  ∈ [-10, +10]
iv.speed ∈ [-10, +10]
```

Armazenados como `int` de −10 a +10 (21 valores por stat, 9.261 combinações) e exibidos ao jogador como um selo de qualidade da criatura. IVs são fixos na geração e nunca mudam — nem ao evoluir.

## 27.5 Fórmula de stat final

```text
stat = floor( statBaseDaEspecie
            × (1 + 0.06 × (level - 1))     // crescimento por nível
            × (1 + iv / 100)                // -10% a +10%
            × naturezaMod )                 // 0.9, 1.0 ou 1.1
```

No nível 10, o crescimento por nível soma **+54%** sobre o base. A dispersão total entre a pior e a melhor instância da mesma espécie no mesmo nível fica em torno de **±20%** por stat (IV + natureza) — o suficiente para valer a pena procurar uma boa criatura, sem tornar uma criatura mediana inutilizável.

## 27.6 Configuração de selvagem

`aggressive`, `sight` e `leashRange` **não são atributos da instância** — são propriedades do **ponto de respawn** (§26.3). Isso é intencional: a mesma espécie pode ser passiva numa clareira inicial e agressiva numa caverna de fim de jogo, sem duplicar a espécie.

---

# 28. Questões em Aberto

Decisões que este documento levanta mas ainda não fecha:

1. **Bônus de afinidade (+20%)** — §20.7 propõe o bônus para ataque do mesmo tipo do Forgeling. Confirmar se existe e com qual valor.
2. **Time inteiro derrotado** — a troca só acontece quando o ativo cai (§22). O que acontece quando o **último** Forgeling do time é derrotado? Derrota, fuga forçada, perda de recursos, respawn na base?
3. **Recuperação entre batalhas** — Forgelings derrotados voltam curados? Precisam de item, tempo ou de uma estrutura na base (§11)?
4. **Taunt — detalhes** — cooldown, alcance, chance de sucesso por raridade/nível, e o que exatamente acontece ao vencer o desafio: o selvagem se junta direto, ou fica capturável sem cápsula? (§26.4)
5. **Ovos** — condição de choco (tempo, passos, incubadora na base?) e como espécie, natureza e IVs do filhote são determinados.
6. **Sombrio × Sagrado na progressão** — em que ponto da campanha o jogador tem acesso garantido a um Forgeling Sagrado (§20.6). Com a troca em combate travada (§22), essa dependência ficou mais rígida ainda.
7. **Curva de XP** — como os 10 níveis (§27.2) se distribuem, e quanto XP um selvagem concede ao jogador *versus* ao Forgeling ativo (§26.1).
