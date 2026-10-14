# PixelForge — Compêndio de Conteúdo

**Documento companheiro do [GDD](GDD.md).**
O GDD define *como os sistemas funcionam*. Este documento define *o que existe dentro deles*.

**Versão:** 0.1 · **Status:** proposta de expansão · **Autor:** Lead Game Design

---

## Como ler este documento

Cada entrada segue o formato compacto:

> **### · Nome** — Categoria · Raridade · Estágio
> Descrição. **Obtém:** como se consegue. **Serve:** para que serve. **Liga com:** sistemas do GDD que toca. **Por quê:** o que a ideia acrescenta ao jogo.

**Raridade:** Comum · Incomum · Raro · Épico · Lendário
**Estágio:** Início (nv. 1–3) · Meio (nv. 4–6) · Fim (nv. 7–10) · Endgame (pós-teto)

## Princípios respeitados em todas as sugestões

1. **O Forgeling é o coração.** Nada aqui torna a criatura opcional. Quando um item é poderoso, ele costuma agir *através* do Forgeling, não no lugar dele.
2. **Seis tipos, não sete.** Água, Fogo, Terra, Ar, Sombrio e Sagrado (§20). Nenhum conteúdo novo introduz um sétimo elemento.
3. **Teto de nível 10 é sagrado** (§27.2). A progressão de longo prazo vem de *coleção, base, profissão e equipamento* — nunca de esticar a barra de XP de um bicho só.
4. **Sem classe de mago.** As três profissões (§15) são marciais e técnicas. A "magia" de PixelForge é **material**: vem de gemas, relíquias, runas e da própria criatura — nunca de uma barra de mana no personagem.
5. **Side view manda.** Tudo foi pensado para um mundo 2D de perfil: profundidade é *descer*, distância é *andar de lado*.
6. **Multiplayer sem duplicar sistemas.** Cada item novo funciona igual solo e em sala (§19); nada aqui exige um modo separado.

---
---

# RODADA 1 — Terra, Pedra e Matéria-Prima

*O chão do jogo. Se o jogador vai passar 200 horas batendo em coisas, as coisas precisam ser interessantes de bater.*

---

## 1.1 Minérios

**001 · Ferro Bruto** — Minério · Comum · Início
Veio cinza-avermelhado nas paredes de caverna rasa. **Obtém:** picareta de pedra ou Skill *Mine* (§10). **Serve:** barra de ferro → primeiras ferramentas, armas e armadura decentes. **Liga com:** Forja (§11), Mine, todas as profissões. **Por quê:** é o degrau que ensina o loop minério→barra→equipamento sem exigir bioma perigoso.

**002 · Cobre** — Minério · Comum · Início
Veio esverdeado, macio, aparece quase na superfície. **Obtém:** qualquer picareta, inclusive a de madeira. **Serve:** bronze (com estanho), fiação de máquinas do Engenheiro, panelas. **Liga com:** Engenharia, Cozinha (§11). **Por quê:** dá ao jogador um recurso que ele consegue *na primeira hora*, garantindo que ninguém fique travado sem nada para craftar.

**003 · Estanho** — Minério · Comum · Início
Veio pálido e quebradiço, quase sempre perto de cobre. **Obtém:** picareta de pedra. **Serve:** liga de bronze; solda em componentes eletrônicos. **Liga com:** Bancada de Fundição. **Por quê:** ligas ensinam ao jogador que combinar recursos vale mais que acumular um só.

**004 · Carvão Mineral** — Minério · Comum · Início
Veios negros densos em cavernas de todas as profundidades. **Obtém:** picareta; também de árvore queimada com *Ignite*. **Serve:** combustível de forja, fornalha, tocha, pólvora. **Liga com:** Fogo (§20), Ignite, Engenheiro. **Por quê:** cria um consumo constante que mantém a mineração relevante mesmo no endgame.

**005 · Chumbo** — Minério · Comum · Início
Pesado, opaco, comum em cavernas úmidas. **Obtém:** picareta de ferro. **Serve:** munição de besta do Caçador, contrapesos, blindagem contra dano Sombrio. **Liga com:** Caçador (§15), Sombrio (§20). **Por quê:** dá ao chumbo uma identidade defensiva específica em vez de ser "ferro pior".

**006 · Prata Lunar** — Minério · Incomum · Meio
Brilha fracamente à noite, mesmo dentro da mochila. **Obtém:** picareta de ferro, apenas em veios que afloram durante a noite ou sob a Lua Vermelha (§13). **Serve:** armas anti-Sombrio, espelhos, instrumentos de precisão. **Liga com:** Clima, ciclo dia/noite, Sagrado. **Por quê:** um recurso que só existe em certas horas transforma o relógio do jogo em mecânica, não em cenário.

**007 · Ouro** — Minério · Incomum · Meio
Veio inconfundível em cavernas profundas e ruínas. **Obtém:** picareta de ferro ou *Mine* nível alto. **Serve:** moeda, joalheria, condutor perfeito para máquinas de precisão. **Liga com:** Economia, Comércio (§19), Engenharia. **Por quê:** é o dinheiro do jogo *e* um material funcional — o jogador sempre sente que está gastando algo real.

**008 · Quartzo** — Minério · Comum · Meio
Cristais brancos em geodos fechados. **Obtém:** quebrar geodo com *Rock Smash*. **Serve:** lentes, vidro de alta pureza, base de encantamento. **Liga com:** Rock Smash (§10), Encantamentos (Rodada 2). **Por quê:** o geodo é uma mini-caixa de surpresa — o jogador nunca sabe o que sai, e isso é viciante.

**009 · Obsidiana** — Minério · Incomum · Meio
Vidro vulcânico formado onde lava toca água. **Obtém:** *Freeze* sobre lava, depois *Rock Smash* ou *Mine*. **Serve:** lâminas de altíssimo corte, blocos à prova de fogo. **Liga com:** Freeze, Ignite, bioma Vulcão (§12). **Por quê:** é o primeiro recurso que **exige duas Skills de Forgelings diferentes** — força o jogador a valorizar a coleção.

**010 · Forgita** — Minério · Raro · Meio
O minério que dá nome ao mundo. Veio azul-metálico que **assume o tipo elemental do ambiente** onde foi extraído. **Obtém:** picareta de aço em veios profundos; o tipo depende do bioma. **Serve:** matéria-prima de todo equipamento elemental; a mesma barra vira seis coisas diferentes. **Liga com:** §20 inteiro, Forja, Biomas. **Por quê:** dá ao jogo um **material assinatura**. "Você tem Forgita de Ar?" vira frase natural entre jogadores.

**011 · Escória Vulcânica** — Recurso · Comum · Meio
Rocha porosa e ainda morna do bioma Vulcão. **Obtém:** picareta, ou recolher após erupção. **Serve:** isolante térmico, base de tijolo refratário, fertilizante potente. **Liga com:** Agricultura, Construção. **Por quê:** faz o bioma mais hostil produzir algo que melhora a fazenda mais segura — recompensa o risco com conforto.

**012 · Sal-Gema** — Recurso · Comum · Início
Blocos brancos em cavernas secas e no deserto. **Obtém:** picareta de pedra. **Serve:** conservar comida, curtir couro, culinária, repelir certos Forgelings Sombrios. **Liga com:** Culinária, Conservação (Rodada 4). **Por quê:** sal é o item mundano perfeito — barato, onipresente e usado em dez sistemas diferentes.

**013 · Enxofre** — Recurso · Comum · Meio
Depósitos amarelos junto a fontes termais e ao Vulcão. **Obtém:** pá ou picareta. **Serve:** pólvora, bombas do Engenheiro, poções corrosivas. **Liga com:** Engenheiro (§15), Alquimia. **Por quê:** dá ao Engenheiro uma cadeia de suprimento própria, reforçando identidade de profissão.

**014 · Salitre** — Recurso · Incomum · Meio
Crosta esbranquiçada nas paredes de cavernas onde há muito guano. **Obtém:** raspar com pá. **Serve:** pólvora (com carvão + enxofre), fertilizante. **Liga com:** Engenheiro, Fazenda. **Por quê:** transforma um canto nojento e ignorado da caverna em destino de expedição.

**015 · Ferro Meteórico** — Minério · Raro · Fim
Cai do céu durante o evento Chuva de Estrelas. **Obtém:** localizar a cratera nas horas seguintes ao evento. **Serve:** equipamento de alto tier que ignora parte da resistência elemental. **Liga com:** Eventos (Rodada 6), §20. **Por quê:** conteúdo cronometrado que cria urgência — "caiu perto do pântano, vamos AGORA".

**016 · Núcleo de Magma** — Material · Raro · Fim
Esfera de rocha derretida que permanece líquida dentro de um invólucro. **Obtém:** drop de Forgelings de Fogo de alto nível e de veios no fundo do Vulcão. **Serve:** combustível infinito para uma máquina; forja de armas de Fogo. **Liga com:** Máquinas (Rodada 3), Fogo. **Por quê:** um "combustível que nunca acaba" é uma recompensa de progressão fantástica — remove uma chatice permanentemente.

**017 · Gelo Perene** — Material · Incomum · Meio
Gelo que não derrete nem dentro do Vulcão. **Obtém:** picareta em geleiras profundas do bioma Neve. **Serve:** refrigeração (conservar comida), armas de Água/gelo, apagar lava. **Liga com:** Freeze, Conservação, Vulcão. **Por quê:** um item de bioma frio que resolve um problema de bioma quente amarra o mapa inteiro.

**018 · Âmbar Fóssil** — Material · Incomum · Meio
Resina endurecida com algo preso dentro. **Obtém:** minerar árvores petrificadas e camadas de sedimento. **Serve:** quebrar revela: inseto (isca de pesca), semente antiga, ou **fragmento de Forgeling extinto** (colecionável). **Liga com:** Pesca, Colecionáveis, Agricultura. **Por quê:** cada âmbar é uma micro-loteria com três resultados úteis — nunca é lixo.

**019 · Argila** — Recurso · Comum · Início
Barrancos de rio e margens de lago. **Obtém:** pá ou Skill *Dig*. **Serve:** tijolo, cerâmica, vasos, cadinho, moldes. **Liga com:** Dig (§10), Construção, Olaria. **Por quê:** dá utilidade imediata ao *Dig*, garantindo que a primeira Skill utilitária do jogador tenha valor no dia um.

**020 · Cascalho** — Recurso · Comum · Início
Sobra de qualquer escavação. **Obtém:** subproduto automático da mineração. **Serve:** peneirar para achar pepitas, gemas rachadas e ossos; base de estrada. **Liga com:** Peneira (Rodada 3). **Por quê:** transforma o "lixo" do inventário em um mini-jogo de loteria — o clássico truque do RuneScape.

**021 · Calcário** — Recurso · Comum · Início
Rocha clara e mole, comum em cavernas de água. **Obtém:** qualquer picareta. **Serve:** cal → argamassa, tratar solo ácido, curtume. **Liga com:** Construção, Agricultura. **Por quê:** dá ao jogador uma razão para escolher *onde* cavar em vez de cavar em linha reta.

**022 · Granito & Mármore** — Recurso · Comum · Meio
Veios decorativos em camadas médias. **Obtém:** picareta de ferro. **Serve:** construção de prestígio, estátuas, pisos, bancadas nobres. **Liga com:** Decoração, Construção. **Por quê:** jogadores que constroem por estética precisam de paleta; blocos bonitos são conteúdo.

**023 · Areia Negra** — Recurso · Incomum · Meio
Praias de ilhas vulcânicas. **Obtém:** pá. **Serve:** vidro fumê, molde de fundição de alta precisão, pólvora refinada. **Liga com:** Ilhas, Engenharia. **Por quê:** uma variante de um recurso banal que exige viagem — recompensa a exploração marítima.

**024 · Cinábrio** — Minério · Raro · Fim
Cristais vermelho-sangue que exsudam mercúrio. **Obtém:** picareta de aço; **causa envenenamento lento** ao minerar sem luvas. **Serve:** alquimia avançada, espelhos, termômetros de precisão. **Liga com:** Debuffs, Alquimia, Equipamento de proteção. **Por quê:** um recurso que *machuca* quem o coleta cria uma decisão real de equipamento.

**025 · Cobalto Abissal** — Minério · Raro · Fim
Azul intenso, encontrado apenas abaixo da camada de água subterrânea. **Obtém:** picareta de aço + Forgeling com *Swim*. **Serve:** aço azul (leve e resistente), equipamento de mergulho. **Liga com:** Swim, Surf, camada oceânica profunda. **Por quê:** dá ao Swim um destino de fim de jogo, evitando que Skills utilitárias virem irrelevantes.

**026 · Adamas Sombrio** — Minério · Épico · Endgame
Pedra que absorve a luz ao redor; o pixel fica visivelmente mais escuro perto dela. **Obtém:** apenas no Abismo, e apenas com uma fonte de luz Sagrada ativa. **Serve:** equipamento Sombrio de topo; blocos que bloqueiam detecção. **Liga com:** §20.3, Illuminate, Dungeon endgame. **Por quê:** o eixo moral do GDD ganha representação física no mundo, não só na tabela de dano.

**027 · Aurita Sagrada** — Minério · Épico · Endgame
Veio dourado-branco que emite luz própria e **cura lentamente** quem está perto. **Obtém:** santuários selados no alto das Montanhas. **Serve:** equipamento Sagrado, a resposta contra chefes Sombrios (§20.6). **Liga com:** dependência de progressão de §20.6, Climb, Fly. **Por quê:** dá forma concreta à dependência Sagrado↔Sombrio que o GDD já identificou como risco.

**028 · Pó de Estrela** — Material · Épico · Endgame
Resíduo brilhante que fica na cratera do meteoro. **Obtém:** peneirar o solo da cratera. **Serve:** reagente de encantamento de topo; reroll de IV. **Liga com:** IVs (§27.4), Encantamentos. **Por quê:** dá ao endgame uma moeda de otimização sem quebrar a regra de "IVs nunca mudam" — é raro o bastante para ser cerimonial.

**029 · Veio de Eco** — Recurso · Raro · Fim
Cristal que repete o último som ouvido. **Obtém:** minerar em cavernas de silêncio absoluto. **Serve:** componente de itens de comunicação, gravação de melodias, puzzles sonoros. **Liga com:** Puzzles, Multiplayer (chat por eco), Segredos. **Por quê:** abre uma dimensão de puzzle inteiramente nova sem precisar de sistema novo pesado.

**030 · Pedra-Ímã** — Recurso · Incomum · Meio
Rocha magnética natural. **Obtém:** picareta em cavernas de ferro. **Serve:** bússola, coletor magnético automático, armadilhas do Engenheiro. **Liga com:** QoL de coleta, Engenheiro. **Por quê:** é a raiz de uma das melhores QoLs do gênero (auto-coleta de drops) e faz o jogador *ganhar* essa comodidade.

---

## 1.2 Gemas

**031 · Safira Marinha** — Gema · Incomum · Meio
Azul profunda, fria ao toque. **Obtém:** geodos submersos, drop de chefe de Água. **Serve:** encaixe que dá +Água a arma ou armadura. **Liga com:** §20, Encantamento por encaixe. **Por quê:** as seis gemas elementais dão ao jogador controle direto sobre a tabela de tipos — a decisão mais interessante do combate.

**032 · Rubi de Forja** — Gema · Incomum · Meio
Vermelha, morna, brilha mais perto de fogo. **Obtém:** veios do Vulcão. **Serve:** encaixe de Fogo. **Liga com:** §20, Forja. **Por quê:** ver a gema reagir ao ambiente é feedback visual barato e delicioso em pixel art.

**033 · Esmeralda Telúrica** — Gema · Incomum · Meio
Verde opaca com veios de terra. **Obtém:** camadas fundas, drop de Forgelings de Terra. **Serve:** encaixe de Terra. **Liga com:** §20. **Por quê:** completa o ciclo elemental de encaixes, mantendo o equilíbrio perfeito de §20.6.

**034 · Topázio Ventoso** — Gema · Incomum · Meio
Amarelo pálido, quase sem peso. **Obtém:** picos de montanha, ninhos de Forgelings voadores. **Serve:** encaixe de Ar; reduz o peso do item em que está encaixada. **Liga com:** Peso/Mochila, Fly, Climb. **Por quê:** uma gema com efeito duplo (elemento + logística) é mais memorável que um número puro.

**035 · Ônix Nulo** — Gema · Raro · Fim
Negra fosca que não reflete nada. **Obtém:** Abismo, chefes Sombrios. **Serve:** encaixe Sombrio; concede resistência elemental de 25% ao portador. **Liga com:** §20.3. **Por quê:** entrega ao jogador o poder de *virar* um Sombrio defensivo temporariamente — fantasia de poder clara.

**036 · Diamante Aurora** — Gema · Raro · Fim
Branca com brilho iridescente. **Obtém:** santuários selados. **Serve:** encaixe Sagrado; dano dobrado contra Sombrio. **Liga com:** §20.6, progressão de chefes. **Por quê:** é a chave de acesso que o próprio GDD pede para destravar o conteúdo Sombrio.

**037 · Opala Cambiante** — Gema · Épico · Fim
Muda de cor conforme o bioma em que o jogador está. **Obtém:** um único drop garantido do chefe das Ruínas. **Serve:** encaixe que assume o elemento do bioma atual. **Liga com:** §20, Biomas. **Por quê:** um item que se adapta sozinho recompensa exploração ampla em vez de farm de um lugar só.

**038 · Ametista** — Gema · Comum · Início
Roxa, comum em geodos rasos. **Obtém:** quebrar geodo. **Serve:** joalheria, gema de baixo tier, moeda de troca com NPCs. **Liga com:** Economia. **Por quê:** o jogador precisa de gemas "descartáveis" para não sentir que está queimando tesouro em receitas comuns.

**039 · Granada de Sangue** — Gema · Incomum · Meio
Vermelho-escura, quente quando o portador está com pouca vida. **Obtém:** minerar em cavernas de carne (dungeon). **Serve:** encaixe de roubo de vida. **Liga com:** Sustain, Mercenário. **Por quê:** dá ao Mercenário corpo-a-corpo uma resposta ao desgaste que combina com sua fantasia.

**040 · Pérola de Rio** — Gema · Comum · Início
Dentro de ostras de água doce. **Obtém:** pesca ou *Swim*. **Serve:** joalheria, comércio, receita de poção de clareza. **Liga com:** Pesca, Swim. **Por quê:** recompensa o jogador que pesca por diversão com algo vendável.

**041 · Olho-de-Tigre** — Gema · Incomum · Meio
Listrada, parece piscar sob a luz. **Obtém:** peneirar cascalho de deserto. **Serve:** encaixe de +precisão / +chance de crítico. **Liga com:** Caçador, fórmula de crítico (§20.7). **Por quê:** valoriza a peneira e dá um encaixe atraente que não é elemental.

**042 · Lágrima de Obsidiana** — Gema · Raro · Fim
Gota de vidro vulcânico perfeita. **Obtém:** resfriar lava com *Freeze* no momento exato. **Serve:** encaixe que converte parte do dano recebido em dano refletido. **Liga com:** Freeze, timing skill. **Por quê:** um recurso obtido por *execução* e não por sorte premia habilidade do jogador.

**043 · Gema Rachada** — Material · Comum · Início
Qualquer gema quebrada na extração. **Obtém:** falhar a extração sem picareta adequada. **Serve:** pó de gema → reagente barato de encantamento. **Liga com:** Encantamento. **Por quê:** garante que o fracasso ainda produza algo, reduzindo frustração.

**044 · Núcleo Prismático** — Gema · Lendário · Endgame
Contém os seis elementos ao mesmo tempo, girando. **Obtém:** fundir as seis gemas elementais no Altar Prismático. **Serve:** encaixe único que permite ao Forgeling usar um ataque de qualquer tipo em afinidade total. **Liga com:** §20.7, endgame de coleção. **Por quê:** é o objetivo final da caçada de gemas — um item que só existe se você viu o mundo inteiro.

---

## 1.3 Árvores e Madeiras

**045 · Carvalho** — Árvore · Comum · Início
Tronco grosso, copa larga, floresta inicial. **Obtém:** machado ou *Lumberjack*. **Serve:** madeira base, tábuas, carvão vegetal, bolota (semente/comida animal). **Liga com:** Lumberjack (§10), Construção. **Por quê:** é o recurso do minuto zero; precisa ser abundante e generoso.

**046 · Pinho** — Árvore · Comum · Início
Alto e reto, montanhas e neve. **Obtém:** machado. **Serve:** tábuas longas (vigas, mastros, escadas), resina. **Liga com:** Construção vertical, Navegação. **Por quê:** madeira "longa" cria diferenciação real em vez de reskin de cor.

**047 · Bétula Prateada** — Árvore · Comum · Início
Casca clara e destacável. **Obtém:** machado; a casca sai sem derrubar. **Serve:** papel, mapas, tochas, canoa leve. **Liga com:** Mapa (QoL), Navegação. **Por quê:** uma árvore que dá recurso **sem ser derrubada** ensina sustentabilidade e é ótima QoL.

**048 · Bambu** — Planta lenhosa · Comum · Início
Cresce rapidíssimo em brejo e selva. **Obtém:** qualquer lâmina. **Serve:** andaimes, varas de pescar, gaiolas, encanamento. **Liga com:** Pesca, Fazenda, Água. **Por quê:** crescimento rápido dá ao jogador um recurso renovável sem esforço, ótimo para construir muito.

**049 · Salgueiro-do-Brejo** — Árvore · Incomum · Meio
Raízes na água, galhos pendentes. **Obtém:** machado de ferro no Pântano. **Serve:** madeira que não apodrece na água → docas, barcos, pontes. **Liga com:** Surf, Ilhas, Pântano. **Por quê:** resolve um problema específico de bioma, tornando o Pântano necessário em vez de opcional.

**050 · Mogno da Selva** — Árvore · Incomum · Meio
Densa, vermelha, tronco enorme. **Obtém:** machado de ferro. **Serve:** móveis nobres, armários de grande capacidade, arcos pesados. **Liga com:** Decoração, Caçador. **Por quê:** madeira de prestígio dá status visual à base — construir bonito vira progressão.

**051 · Árvore-de-Cinzas** — Árvore · Raro · Fim
Cresce apenas em solo vulcânico, folhas de brasa. **Obtém:** machado com proteção térmica. **Serve:** madeira à prova de fogo; cabo de ferramenta que não queima. **Liga com:** Vulcão, Ignite, Forja. **Por quê:** madeira ignífuga é uma daquelas soluções que fazem o jogador dizer "ah, é ISSO que eu precisava".

**052 · Pinheiro-Geada** — Árvore · Incomum · Meio
Coberto de gelo permanente, bioma Neve. **Obtém:** machado de ferro. **Serve:** madeira fria → conservação, cabo de arma de gelo. **Liga com:** Gelo Perene, Conservação. **Por quê:** o contraponto da Árvore-de-Cinzas; simetria elegante entre biomas opostos.

**053 · Árvore-Oca das Ruínas** — Estrutura vegetal · Raro · Meio
Uma árvore antiga com o interior vazio, alta o bastante para ser um andar. **Obtém:** encontrada, não colhida. **Serve:** mini-dungeon vertical; abrigo pronto; ninho de Forgeling raro. **Liga com:** Climb, Estruturas geradas. **Por quê:** vegetação que é *arquitetura* aproveita o side view de um jeito que poucos jogos fazem.

**054 · Raiz-Abissal** — Recurso · Raro · Fim
Raízes gigantes que descem até camadas profundas. **Obtém:** machado de aço no subsolo. **Serve:** madeira viva que se **regenera** se plantada; corda extremamente resistente. **Liga com:** Climb, Pull, Fazenda subterrânea. **Por quê:** encontrar árvores debaixo da terra é uma daquelas surpresas verticais que definem exploração.

**055 · Árvore-Vela** — Árvore · Incomum · Meio
Folhas largas como panos, nas Ilhas. **Obtém:** machado. **Serve:** velas de barco, tecido vegetal, guarda-chuva. **Liga com:** Navegação, Clima (chuva). **Por quê:** dá ao arquipélago um recurso próprio e conecta bioma a veículo.

**056 · Ipê-Solar** — Árvore · Épico · Fim
Floresce dourado apenas ao amanhecer. **Obtém:** derrubar durante o nascer do sol; fora disso é madeira comum. **Serve:** componente de equipamento Sagrado; flor usada em cura de topo. **Liga com:** Sagrado, ciclo dia/noite. **Por quê:** conteúdo com janela de tempo cria rituais — jogadores acordam cedo *no jogo* por isso.

**057 · Teixo-Sombrio** — Árvore · Épico · Fim
Negra, sem folhas, absorve som. **Obtém:** apenas em terreno corrompido. **Serve:** componente Sombrio; arco silencioso do Caçador. **Liga com:** Sombrio, furtividade. **Por quê:** o par simétrico do Ipê-Solar; o eixo moral aparece até na madeira.

**058 · Cipó Rígido** — Recurso · Comum · Início
Trepadeiras de selva e caverna. **Obtém:** lâmina. **Serve:** corda, escada de mão, laço, arapuca. **Liga com:** Climb, Caçador, Engenheiro. **Por quê:** corda é o material mais subestimado de qualquer jogo de sobrevivência — habilita dezenas de receitas.

**059 · Cortiça** — Recurso · Incomum · Meio
Casca esponjosa de sobreiro. **Obtém:** descascar sem derrubar. **Serve:** boias de pesca, flutuação, isolamento acústico, rolhas de poção. **Liga com:** Pesca, Alquimia. **Por quê:** materiais renováveis-sem-destruição são ótimos incentivos ecológicos dentro do jogo.

**060 · Resina & Seiva** — Recurso · Comum · Início
Escorre de coníferas feridas. **Obtém:** ferir a árvore e voltar depois. **Serve:** cola, impermeabilizante, tocha de longa duração, base de âmbar. **Liga com:** Tempo/paciência, Crafting. **Por quê:** um recurso que exige *voltar depois* ensina o jogador a planejar rotas.

**061 · Casca-de-Ferro** — Recurso · Raro · Fim
Árvore cuja casca tem dureza de metal. **Obtém:** machado de aço; consome durabilidade rápido. **Serve:** escudos, blindagem leve, cabo de ferramenta de topo. **Liga com:** Armaduras. **Por quê:** madeira de tier alto mantém a lenha relevante contra a inflação de metais.

**062 · Cogumelo-Árvore Gigante** — Flora · Raro · Meio
Fungo do tamanho de uma árvore, em cavernas úmidas. **Obtém:** machado; o chapéu dá blocos macios. **Serve:** blocos que amortecem queda, madeira fúngica bioluminescente. **Liga com:** Construção subterrânea, Illuminate. **Por quê:** cavernas precisam de biomas próprios — a floresta de cogumelos é um clássico que sempre encanta.

---

## 1.4 Plantas, Flores e Fungos

**063 · Erva-Curativa** — Planta · Comum · Início
Folhas verdes com nervura branca, quase toda parte. **Obtém:** colher à mão. **Serve:** poção de cura menor; comida de emergência. **Liga com:** Alquimia, Cama (§11.1). **Por quê:** o item de cura básico precisa ser abundante para que o jogador experimente sem medo.

**064 · Erva-Sangue** — Planta · Incomum · Meio
Vermelha, cresce onde algo morreu. **Obtém:** colher; aparece em campos de batalha e covis. **Serve:** poção de cura maior; regeneração ao Forgeling. **Liga com:** Recuperação do time. **Por quê:** o local de nascimento conta uma história sem uma linha de texto.

**065 · Folha-de-Vento** — Planta · Comum · Início
Leve, sempre em movimento, penhascos. **Obtém:** colher; pode voar para longe se demorar. **Serve:** poção de velocidade; encaixe de Ar. **Liga com:** Speed (§25), Ar. **Por quê:** uma planta que *foge* é uma micro-interação divertida e memorável.

**066 · Flor-Brasa** — Flor · Incomum · Meio
Pétalas em brasa; queima quem colhe sem luva. **Obtém:** colher com luva de couro grosso. **Serve:** poção de resistência ao frio; ignição sem pederneira. **Liga com:** Vulcão, Neve, equipamento. **Por quê:** um item que pune o jogador despreparado ensina o valor de equipamento sem matar ninguém.

**067 · Flor-de-Gelo** — Flor · Incomum · Meio
Cristalina, murcha se levada a bioma quente. **Obtém:** colher na Neve; precisa de recipiente frio para transportar. **Serve:** poção de resistência ao calor; conservante. **Liga com:** Logística, Gelo Perene. **Por quê:** itens que exigem *transporte especial* criam planejamento de expedição.

**068 · Lírio-do-Brejo** — Flor · Comum · Início
Flutua no Pântano. **Obtém:** *Surf* ou barco. **Serve:** antídoto contra veneno. **Liga com:** Debuffs, Surf. **Por quê:** o antídoto nascendo no bioma venenoso é design honesto — a solução está onde está o problema.

**069 · Junco** — Planta · Comum · Início
Margens de água. **Obtém:** lâmina. **Serve:** cestaria, esteira, telhado de palha, flechas leves. **Liga com:** Construção rústica, Caçador. **Por quê:** dá ao jogador uma estética de "cabana de pescador" logo cedo.

**070 · Algodão Selvagem** — Planta · Comum · Início
Arbusto de plumas brancas na pradaria. **Obtém:** colher. **Serve:** tecido, bandagem, estofado de móveis. **Liga com:** Armadura leve, Móveis. **Por quê:** tecido é pré-requisito de mochila, cama e roupa — três coisas que o jogador quer cedo.

**071 · Linho** — Planta cultivável · Comum · Início
Semente comprada de NPC agricultor. **Obtém:** plantar e colher. **Serve:** linha, corda fina, tecido fino, vela. **Liga com:** Agricultura, Comércio. **Por quê:** é a primeira cultura *não-alimentar*, ensinando que a fazenda serve para mais que comer.

**072 · Cana-de-Açúcar** — Planta cultivável · Comum · Início
Cresce em água rasa. **Obtém:** plantar na margem. **Serve:** açúcar → doces, geleia, fermentação, rum. **Liga com:** Culinária, Bebidas. **Por quê:** açúcar destrava a metade "prazerosa" da culinária, que é onde estão os melhores buffs.

**073 · Trigo** — Cultura · Comum · Início
A base do pão. **Obtém:** plantar. **Serve:** farinha → pão, massa, bolo; ração animal. **Liga com:** Culinária, Pecuária. **Por quê:** o pão é o alimento-âncora que todo survival precisa: barato, saciante, sem glamour.

**074 · Milho** — Cultura · Comum · Início
Alto, colheita múltipla. **Obtém:** plantar. **Serve:** fubá, pipoca (buff curto e divertido), ração. **Liga com:** Culinária, Pecuária. **Por quê:** culturas com colheitas múltiplas recompensam quem espera em vez de replantar sempre.

**075 · Batata** — Cultura · Comum · Início
Cresce enterrada; *Dig* colhe mais rápido. **Obtém:** plantar. **Serve:** comida saciante, base de ensopado, fermentação. **Liga com:** Dig. **Por quê:** dá ao Forgeling uma função na fazenda, não só na mina — o Forgeling deve estar em toda parte.

**076 · Cenoura** — Cultura · Comum · Início
**Obtém:** plantar. **Serve:** comida; poção/prato de visão noturna. **Liga com:** Illuminate, exploração noturna. **Por quê:** o buff de visão é uma alternativa barata à tocha, dando escolha ao jogador pobre.

**077 · Abóbora** — Cultura · Comum · Meio
Cresce em cruz, ocupa espaço. **Obtém:** plantar. **Serve:** torta (buff de vida máxima), lanterna decorativa. **Liga com:** Decoração, Eventos sazonais. **Por quê:** culturas que ocupam espaço criam decisões de layout de fazenda.

**078 · Tomate** — Cultura · Comum · Meio
**Obtém:** plantar. **Serve:** molho, base de dezenas de receitas. **Liga com:** Culinária. **Por quê:** ingredientes "combinadores" multiplicam o livro de receitas sem custo de arte.

**079 · Pimenta-Vulcânica** — Cultura · Incomum · Meio
Só cresce em solo de escória. **Obtém:** plantar em solo vulcânico. **Serve:** pratos que dão resistência a frio e +ATK; ingrediente de bomba incendiária. **Liga com:** Escória, Engenheiro. **Por quê:** liga agricultura a um bioma perigoso — a fazenda também vira expedição.

**080 · Uva das Ruínas** — Cultura · Incomum · Meio
Trepadeira que só vinga em pedra antiga. **Obtém:** plantar em blocos de ruína. **Serve:** vinho (buff longo de sorte). **Liga com:** Bebidas, Ruínas. **Por quê:** uma cultura que exige um *tipo de bloco* raro dá valor a demolir ruínas.

**081 · Morango-da-Neve** — Cultura · Incomum · Meio
Doce, cresce sob a neve. **Obtém:** *Dig* na neve. **Serve:** sobremesas, buff de regeneração. **Liga com:** Neve, Dig. **Por quê:** achar comida doce em um bioma hostil é uma das melhores sensações de sobrevivência.

**082 · Girassol** — Flor cultivável · Comum · Meio
Vira em direção ao sol. **Obtém:** plantar. **Serve:** óleo, sementes, decoração que **afasta criaturas Sombrias** num raio. **Liga com:** Defesa de base, Sombrio. **Por quê:** decoração com função defensiva faz o jogador querer uma base bonita *e* útil.

**083 · Lavanda** — Flor · Comum · Meio
**Obtém:** colher em campos abertos. **Serve:** chá calmante (reduz duração de debuffs), perfume que atrai Forgelings passivos. **Liga com:** Captura (§8), Debuffs. **Por quê:** uma ferramenta *não violenta* de captura amplia o público do jogo.

**084 · Papoula Sonífera** — Flor · Incomum · Meio
Pólen pesado. **Obtém:** colher com máscara. **Serve:** bomba de sono do Engenheiro; sedativo que **aumenta muito a chance de captura**. **Liga com:** §8, Engenheiro. **Por quê:** dá ao sistema de captura uma alavanca estratégica além de "bater até quase morrer".

**085 · Trevo de Quatro Folhas** — Flor · Raro · Meio
1 em cada mil trevos. **Obtém:** procurar em campos. **Serve:** buff temporário de sorte (drop e IV de ovos). **Liga com:** IVs (§27.4), Ovos. **Por quê:** recompensa o jogador observador com algo que ele *sente* na próxima captura.

**086 · Flor-Sino** — Flor · Incomum · Meio
Emite luz suave e toca quando alguém passa. **Obtém:** cavernas. **Serve:** iluminação natural; alarme de intrusos na base. **Liga com:** Illuminate, Defesa de base, Multiplayer. **Por quê:** um alarme orgânico é mais charmoso que uma máquina e cabe na estética.

**087 · Musgo Luminoso** — Flora · Comum · Início
Cobre paredes de caverna. **Obtém:** raspar. **Serve:** tinta luminosa para marcar caminho; iluminação barata. **Liga com:** QoL de navegação em caverna. **Por quê:** marcar o próprio caminho resolve o problema nº 1 de cavernas: se perder.

**088 · Cogumelo Comum** — Fungo · Comum · Início
**Obtém:** colher em sombra. **Serve:** ensopado, base de poção. **Liga com:** Culinária. **Por quê:** o ingrediente coringa que todo iniciante encontra por acidente.

**089 · Cogumelo Azul-Caverna** — Fungo · Comum · Início
Bioluminescente. **Obtém:** cavernas. **Serve:** poção de mana? não — **poção de fôlego** para mergulho. **Liga com:** Swim, Cobalto Abissal. **Por quê:** fôlego é o limitador natural do mergulho; ter uma resposta cria progressão vertical na água.

**090 · Cogumelo Venenoso** — Fungo · Comum · Início
Vermelho de pintas. **Obtém:** colher. **Serve:** veneno para flechas e lâminas; comida que **envenena** se comida crua. **Liga com:** Debuffs, Caçador, Mercenário. **Por quê:** um item que pode ser erro *ou* arma ensina o jogador a ler o mundo.

**091 · Trufa Subterrânea** — Fungo · Raro · Meio
Enterrada, invisível na superfície. **Obtém:** apenas com Forgeling de *Dig* e faro — um Forgeling específico a detecta. **Serve:** prato de altíssimo valor; item de comércio caro. **Liga com:** Dig, Economia, especialização de Forgeling. **Por quê:** dá a *um* Forgeling um monopólio econômico — o jogador vai caçar aquele bicho especificamente.

**092 · Fungo-Explosivo** — Fungo · Incomum · Meio
Estoura ao ser tocado. **Obtém:** colher com pinça ou de longe com flecha. **Serve:** explosivo natural do Engenheiro; abre passagens sem pólvora. **Liga com:** Engenheiro, mineração. **Por quê:** uma bomba grátis que exige coleta cuidadosa é uma troca de recurso por risco elegante.

**093 · Líquen de Rocha** — Flora · Comum · Início
Cresce em pedra nua. **Obtém:** raspar. **Serve:** corante, chá, ração de emergência. **Liga com:** Tinturaria, Decoração. **Por quê:** corantes destravam customização visual — conteúdo infinito por quase zero custo.

**094 · Alga Marinha** — Flora aquática · Comum · Início
**Obtém:** *Swim* ou pesca. **Serve:** comida, fertilizante, papel de sushi. **Liga com:** Pesca, Agricultura. **Por quê:** o oceano precisa de coleta além de peixe para valer a viagem.

**095 · Coral Vivo** — Flora aquática · Incomum · Meio
Recifes coloridos. **Obtém:** *Swim* com ferramenta adequada. **Serve:** decoração, tinta rara, componente de equipamento de Água. **Liga com:** Decoração, Ilhas. **Por quê:** dá cor ao fundo do mar, que em pixel art rende belíssimo.

**096 · Nenúfar** — Flora aquática · Comum · Início
**Obtém:** colher da superfície. **Serve:** bloco flutuante para atravessar água sem *Surf*. **Liga com:** Surf, mobilidade. **Por quê:** dá ao jogador sem o Forgeling certo uma solução *pior mas existente* — nunca travar totalmente é bom design.

**097 · Cacto Suculento** — Flora · Comum · Início
Deserto. **Obtém:** lâmina; espinhos ferem sem luva. **Serve:** água potável de emergência, geleia, espinho para dardo. **Liga com:** Deserto, sobrevivência. **Por quê:** achar água num cacto é o momento "eu sobrevivi" que define o gênero.

**098 · Espinho-Ferrão** — Flora · Incomum · Meio
Arbusto agressivo do Pântano. **Obtém:** lâmina. **Serve:** armadilha natural do Engenheiro; munição farpada. **Liga com:** Engenheiro, defesa de base. **Por quê:** transformar plantas em defesa passiva é uma torre grátis, muito satisfatória.

**099 · Raiz-Amarga** — Flora · Comum · Início
Sabor horrível, efeito ótimo. **Obtém:** *Dig*. **Serve:** remove todos os debuffs, mas causa −ATK por um tempo. **Liga com:** Debuffs. **Por quê:** curas com custo são decisões; curas gratuitas são botões.

**100 · Flor-Sudário** — Flor · Raro · Fim
Cresce só em terreno corrompido; pétalas negras. **Obtém:** colher com proteção Sagrada. **Serve:** reagente Sombrio; permite ver Forgelings invisíveis. **Liga com:** Sombrio, exploração do Abismo. **Por quê:** dá uma razão para o jogador *entrar* no lugar mais assustador do jogo.

---

## 1.5 Materiais de Criatura

**101 · Couro Cru** — Material · Comum · Início
De animais e Forgelings de pele. **Obtém:** derrotar fauna. **Serve:** curtir → couro → armadura leve, mochila, luvas. **Liga com:** Mochilas, Armaduras. **Por quê:** o caminho couro→mochila é a primeira progressão de QoL que o jogador sente no corpo.

**102 · Pelo Espesso** — Material · Comum · Meio
Fauna do bioma Neve. **Obtém:** derrotar ou tosquiar. **Serve:** roupa de frio, estofado, cama quente. **Liga com:** Neve, Cama (§11.1). **Por quê:** resistência climática por vestuário é progressão sem números inflados.

**103 · Pena Leve** — Material · Comum · Início
De aves e Forgelings de Ar. **Obtém:** derrotar ou coletar em ninhos. **Serve:** flechas, travesseiro, poção de queda lenta. **Liga com:** Caçador, Fly. **Por quê:** flecha é consumível — o Caçador precisa de uma cadeia de suprimento constante.

**104 · Escama Elemental (×6)** — Material · Incomum · Meio
Uma variante por elemento, do Forgeling correspondente. **Obtém:** derrotar Forgelings de cada tipo. **Serve:** armadura com resistência elemental específica. **Liga com:** §20, Armaduras. **Por quê:** faz o jogador *escolher* qual bicho caçar com base na tabela de tipos — o sistema de tipos vira também economia.

**105 · Presa Afiada** — Material · Comum · Meio
**Obtém:** predadores. **Serve:** adagas do Mercenário, ponta de lança, colar de intimidação. **Liga com:** Mercenário. **Por quê:** armas feitas de bicho têm identidade que armas de metal não têm.

**106 · Chifre Ressonante** — Material · Incomum · Meio
Vibra em frequência baixa. **Obtém:** Forgelings herbívoros grandes. **Serve:** corneta que **chama o Forgeling de volta** instantaneamente; instrumento. **Liga com:** IA do Forgeling (§17), QoL. **Por quê:** resolve a frustração clássica de "meu pet ficou preso lá atrás".

**107 · Garra Rasgadora** — Material · Incomum · Meio
**Obtém:** Forgelings felinos e reptilianos. **Serve:** manopla de escalada, componente de *Climb* artificial. **Liga com:** Climb, mobilidade sem Forgeling. **Por quê:** dá ao jogador uma versão inferior de uma Skill — útil, mas nunca melhor que ter a criatura.

**108 · Osso** — Material · Comum · Início
**Obtém:** derrotar fauna; peneirar cascalho. **Serve:** farinha de osso (fertilizante), ferramentas primitivas, decoração macabra. **Liga com:** Agricultura, Peneira. **Por quê:** fertilizante fecha o ciclo caça→fazenda, integrando dois sistemas distantes.

**109 · Casco Endurecido** — Material · Incomum · Meio
De Forgelings de Terra. **Obtém:** derrotar. **Serve:** escudo, blindagem de veículo. **Liga com:** Terra, Veículos. **Por quê:** escudos precisam de um material próprio para não competirem com armas por metal.

**110 · Teia Resistente** — Material · Incomum · Meio
**Obtém:** aracnídeos de caverna. **Serve:** corda de arco, rede de pesca, armadilha adesiva. **Liga com:** Caçador, Pesca, Engenheiro. **Por quê:** um material que serve às três profissões evita que biomas virem exclusivos de uma classe.

**111 · Glândula de Veneno** — Material · Incomum · Meio
**Obtém:** criaturas peçonhentas. **Serve:** veneno aplicável, antídoto (destilado), armadilha tóxica. **Liga com:** Debuffs, Alquimia. **Por quê:** o mesmo item virar veneno *ou* cura é alquimia no seu melhor.

**112 · Saco de Tinta** — Material · Incomum · Meio
De criaturas marinhas. **Obtém:** pesca ou combate aquático. **Serve:** tinta de escrita, bomba de fumaça, corante preto. **Liga com:** Furtividade, Mapas. **Por quê:** fumaça dá ao jogador uma saída de emergência — essencial quando o time cai (§22).

**113 · Fragmento de Núcleo Elemental (×6)** — Material · Raro · Fim
Estilhaço do núcleo interno de um Forgeling poderoso. **Obtém:** drop raro de Forgelings de nível alto e chefes. **Serve:** infundir equipamento; alimentar máquinas elementais. **Liga com:** §20, Máquinas. **Por quê:** o primeiro material verdadeiramente "mágico" do jogo, e ele vem *da criatura* — coerente com a identidade.

**114 · Essência Destilada (×6)** — Material · Raro · Fim
Fragmento refinado no Alambique Elemental. **Obtém:** processar fragmentos. **Serve:** moeda de encantamento; reagente de evolução. **Liga com:** Evolução (§23), Encantamentos. **Por quê:** um material de segundo nível cria cadeias de produção, o coração do endgame de crafting.

**115 · Ectoplasma** — Material · Raro · Fim
Resíduo de criaturas incorpóreas. **Obtém:** derrotar espectros nas Ruínas à noite. **Serve:** poção de atravessar (passar por grades), itens de furtividade. **Liga com:** Exploração, Ruínas. **Por quê:** habilita atalhos e segredos que nenhuma Skill de Forgeling cobre.

**116 · Cinza de Sombra** — Material · Épico · Endgame
O que sobra quando um Sombrio é derrotado por dano Sagrado. **Obtém:** condição de morte específica. **Serve:** forjar equipamento que ignora resistência de 25%. **Liga com:** §20.3, endgame. **Por quê:** um drop condicionado ao *como* você matou é profundidade grátis para jogadores avançados.

**117 · Pluma Sagrada** — Material · Épico · Endgame
Cai de Forgelings Sagrados ao evoluir. **Obtém:** evoluir um Sagrado; drop de chefe. **Serve:** revive um Forgeling caído em combate — o único item que faz isso. **Liga com:** §22, morte de time. **Por quê:** um "auto-revive" ultra-raro dá ao jogador uma carta na manga sem quebrar a regra de troca travada.

**118 · Cera de Abelha** — Material · Comum · Meio
Colmeias. **Obtém:** com fumaça, senão leva ferroada. **Serve:** velas, impermeabilizar, polir armas. **Liga com:** Apicultura, Iluminação. **Por quê:** apicultura é um mini-sistema encantador e de baixo custo de implementação.

**119 · Mel** — Alimento base · Comum · Meio
**Obtém:** colmeia. **Serve:** adoçante, cura leve contínua, hidromel. **Liga com:** Culinária, Bebidas. **Por quê:** cura por regeneração (em vez de instantânea) diversifica o kit do jogador.

**120 · Gordura Animal** — Material · Comum · Início
**Obtém:** grandes herbívoros. **Serve:** sabão, óleo de lamparina, fritura, graxa de máquina. **Liga com:** Engenharia, Culinária, Iluminação. **Por quê:** materiais humildes com cinco usos são o que fazem um mundo parecer real.

**121 · Tendão** — Material · Comum · Meio
**Obtém:** grandes animais. **Serve:** corda de arco superior, costura de armadura. **Liga com:** Caçador. **Por quê:** dá ao arco uma progressão de material própria, separada da flecha.

**122 · Cristal de Forgeling** — Material · Lendário · Endgame
Só se forma em um Forgeling que atingiu nível 10 com IVs perfeitos e nunca foi derrotado. **Obtém:** condição extrema, não-destrutiva (o cristal é *doado* pela criatura). **Serve:** item de status; forjar o equipamento pessoal definitivo. **Liga com:** IVs, teto de nível, vínculo com a criatura. **Por quê:** dá um objetivo de perfeccionista que celebra o vínculo com a criatura em vez de matá-la — perfeitamente alinhado com a alma do jogo.

---
---

# RODADA 2 — Ferramentas, Armas, Armaduras e Equipamento

*Se o Forgeling é o coração do combate, o equipamento do personagem é a sua profissão feita objeto. Nada aqui deve deixar o jogador achar que pode dispensar a criatura.*

---

## 2.1 Ferramentas

**123 · Picareta (5 tiers)** — Ferramenta · Comum→Raro · Todos
Pedra → Cobre → Ferro → Aço → Forgita. Cada tier destrava um grupo de minérios. **Obtém:** Bancada e Forja. **Serve:** mineração manual. **Liga com:** Mine (§10), todos os minérios. **Por quê:** a escada de picaretas é o metrônomo da progressão — o jogador sempre sabe qual é o próximo passo.

**124 · Machado (5 tiers)** — Ferramenta · Comum→Raro · Todos
**Obtém:** Bancada e Forja. **Serve:** derrubar árvores, arma de emergência. **Liga com:** Lumberjack. **Por quê:** ferramenta que também é arma dá ao iniciante uma resposta antes da primeira arma real.

**125 · Pá** — Ferramenta · Comum · Início
**Obtém:** Bancada. **Serve:** terra, areia, argila, neve; escavar tesouros marcados. **Liga com:** Dig, Mapas do tesouro. **Por quê:** cavar deve ser rápido e satisfatório; sem pá dedicada, o jogador usa a picareta e odeia.

**126 · Foice** — Ferramenta · Comum · Início
**Obtém:** Bancada. **Serve:** colher culturas em área, cortar grama e junco. **Liga com:** Agricultura. **Por quê:** colheita em área é a QoL nº 1 de qualquer farming game.

**127 · Regador** — Ferramenta · Comum · Início
**Obtém:** Bancada. **Serve:** irrigar plantações; melhora com tier (mais alcance). **Liga com:** Agricultura, Chuva (§13). **Por quê:** chuva substituir o regador transforma o clima de decoração em economia de tempo.

**128 · Martelo de Construção** — Ferramenta · Comum · Início
**Obtém:** Bancada. **Serve:** girar, mover e **demolir** blocos recuperando material. **Liga com:** Construção. **Por quê:** construir sem poder desfazer sem perda é hostil; o martelo é obrigatório.

**129 · Cinzel** — Ferramenta · Incomum · Meio
**Obtém:** Forja. **Serve:** esculpir variantes de bloco (arco, meia-altura, moldura) e estátuas. **Liga com:** Decoração. **Por quê:** um cinzel multiplica a paleta de construção por dez sem novos materiais.

**130 · Vara de Pescar (4 tiers)** — Ferramenta · Comum→Raro · Todos
Bambu → Madeira → Ferro → Osso Abissal. **Obtém:** Bancada / NPC pescador. **Serve:** pesca. **Liga com:** Pesca (Rodada 5). **Por quê:** a pesca é o sistema "calmo" que equilibra a tensão do combate.

**131 · Rede de Mão** — Ferramenta · Comum · Início
**Obtém:** teia ou linho. **Serve:** capturar insetos, peixes pequenos, girinos. **Liga com:** Colecionáveis, Isca. **Por quê:** insetos são colecionáveis baratíssimos de produzir e adoráveis de caçar.

**132 · Peneira** — Ferramenta · Comum · Início
**Obtém:** Bancada. **Serve:** processar cascalho e areia em pepitas, gemas rachadas, ossos, âmbar. **Liga com:** Cascalho, Gemas. **Por quê:** dá ao "entulho" um destino, e o jogador adora peneirar por horas.

**133 · Tesoura de Tosquia** — Ferramenta · Comum · Meio
**Obtém:** Forja. **Serve:** lã de animais sem matá-los; podar arbustos. **Liga com:** Pecuária, Decoração. **Por quê:** recursos renováveis sem violência são o alicerce da pecuária.

**134 · Balde** — Ferramenta · Comum · Início
Madeira → Ferro → Obsidiana. **Obtém:** Bancada. **Serve:** água, leite, lava (só o de obsidiana). **Liga com:** Agricultura, Vulcão, Forja. **Por quê:** o tier de balde que segura lava é um marco de progressão delicioso.

**135 · Lupa do Naturalista** — Ferramenta · Incomum · Meio
**Obtém:** quartzo + ouro. **Serve:** **revela natureza e IVs** de um Forgeling selvagem antes da captura. **Liga com:** §27.3, §27.4, §8. **Por quê:** transforma a captura de loteria cega em decisão informada — respeita o tempo do jogador.

**136 · Detector de Veios** — Ferramenta · Incomum · Meio
**Obtém:** pedra-ímã + ouro. **Serve:** pinga e destaca minérios num raio, através da parede. **Liga com:** Mineração, QoL. **Por quê:** elimina a mineração cega e mantém o jogador na parte divertida.

**137 · Corda com Gancho** — Ferramenta · Comum · Início
**Obtém:** cipó + ferro. **Serve:** descer com segurança e subir de volta; puxar itens. **Liga com:** Climb, Pull, side view. **Por quê:** em um jogo de perfil, **descida segura é a mecânica de exploração**.

**138 · Marreta de Demolição** — Ferramenta · Incomum · Meio
**Obtém:** Forja. **Serve:** quebrar 3×3 de rocha comum de uma vez. **Liga com:** Rock Smash, mineração em massa. **Por quê:** escavar salas grandes é chato sem uma ferramenta de área.

**139 · Enxada Fértil** — Ferramenta · Raro · Fim
Enxada com essência de Terra. **Obtém:** Forja + Essência de Terra. **Serve:** arar em área e **aumenta a qualidade** da colheita. **Liga com:** §20, Agricultura. **Por quê:** infundir elemento em ferramenta (não só em arma) prova que o sistema de tipos permeia tudo.

**140 · Cápsula de Captura (5 tiers)** — Ferramenta · Comum→Épico · Todos
Simples → Reforçada → Prismática → Abissal → Perfeita. Cada tier melhora a chance de §8. **Obtém:** crafting e comércio. **Serve:** capturar Forgelings. **Liga com:** §8. **Por quê:** o GDD lista "tipo da cápsula" como fator de captura mas nunca os define — esta é a escada faltante.

**141 · Cápsula-Isca** — Ferramenta especial · Incomum · Meio
Fica no chão com comida dentro; captura sozinha quem entrar. **Obtém:** crafting. **Serve:** captura passiva enquanto o jogador faz outra coisa. **Liga com:** §8, QoL. **Por quê:** captura passiva respeita quem quer construir mas ainda quer coleção.

**142 · Cápsula-Bioma** — Ferramenta especial · Raro · Fim
Só funciona no bioma para o qual foi feita, mas com chance altíssima. **Obtém:** crafting com material do bioma. **Serve:** capturar o bicho difícil daquele lugar. **Liga com:** §8, Biomas. **Por quê:** especialização barata é sempre mais interessante que poder genérico caro.

**143 · Cápsula-Noturna** — Ferramenta especial · Incomum · Meio
Chance dobrada entre o pôr e o nascer do sol. **Obtém:** prata lunar. **Serve:** captura noturna. **Liga com:** Ciclo dia/noite. **Por quê:** dá função ao período noturno, que na maioria dos jogos é só "hora de dormir".

**144 · Cápsula da Redenção** — Ferramenta especial · Épico · Fim
Só funciona em Forgelings **Sombrios**, e só se o jogador tiver um Sagrado no time. **Obtém:** Aurita + Ônix. **Serve:** capturar Sombrios de elite. **Liga com:** §20.6, dependência de progressão. **Por quê:** dá narrativa mecânica ao eixo moral — você redime, não captura.

**145 · Kit de Reparo** — Ferramenta · Comum · Início
**Obtém:** Bancada. **Serve:** restaura durabilidade em campo, com perda de durabilidade máxima. **Liga com:** Durabilidade. **Por quê:** conserto em campo evita expedições encurtadas, sem eliminar o custo do desgaste.

---

## 2.2 Armas — Mercenário

**146 · Adaga de Osso** — Arma · Comum · Início
Rápida, dano baixo. **Obtém:** Bancada. **Serve:** primeira arma corpo a corpo. **Liga com:** §15 Mercenário. **Por quê:** toda profissão precisa de uma arma no minuto um.

**147 · Par de Adagas** — Arma · Incomum · Meio
Duas lâminas, combo de 4 golpes. **Obtém:** Forja. **Serve:** DPS de combo (§15). **Liga com:** sistema de combos. **Por quê:** transforma a palavra "Combos" do GDD em um objeto concreto.

**148 · Estilete Perfurante** — Arma · Incomum · Meio
Dano baixo, **ignora armadura**. **Obtém:** Forja + presa. **Serve:** contra inimigos blindados. **Liga com:** Chefes de Terra. **Por quê:** armas que resolvem *um* problema são mais memoráveis que armas que resolvem todos.

**149 · Adagas Gêmeas de Forgita** — Arma · Raro · Fim
Cada lâmina pode ter um elemento diferente. **Obtém:** Forja + 2 Forgitas. **Serve:** cobrir duas colunas da tabela §20.4 ao mesmo tempo. **Liga com:** §20. **Por quê:** dá ao Mercenário uma resposta tática à tabela de tipos sem trocar de Forgeling.

**150 · Garra de Punho** — Arma · Incomum · Meio
Arma que não ocupa a mão — permite carregar item enquanto luta. **Obtém:** garra rasgadora. **Serve:** combate durante coleta. **Liga com:** Carry, QoL. **Por quê:** remover a troca de arma constante é uma QoL enorme para quem coleta.

**151 · Chicote de Cipó** — Arma · Incomum · Meio
Alcance médio, puxa inimigos. **Obtém:** cipó + tendão. **Serve:** reposicionar inimigos; funciona como gancho em cenário. **Liga com:** Pull, mobilidade. **Por quê:** armas com utilidade fora de combate são sempre as favoritas dos jogadores.

**152 · Espada Larga** — Arma · Incomum · Meio
Lenta, alto dano, acerta em arco. **Obtém:** Forja. **Serve:** grupos de inimigos. **Liga com:** Mercenário. **Por quê:** o Mercenário precisa de uma opção pesada, senão vira só "o rápido".

**153 · Lâmina Sombria** — Arma · Épico · Endgame
Rouba vida, mas o portador recebe **200% de dano Sagrado** enquanto empunha. **Obtém:** Adamas + Cinza de Sombra. **Serve:** poder bruto com custo real. **Liga com:** §20.3. **Por quê:** aplicar a fraqueza do Sombrio *ao jogador* é ousado e coerente com a tabela.

**154 · Lâmina Aurora** — Arma · Épico · Endgame
Brilha; dano dobrado em Sombrios; frágil contra tudo o mais. **Obtém:** Aurita. **Serve:** a arma anti-chefe-Sombrio do Mercenário. **Liga com:** §20.6. **Por quê:** cada profissão precisa da sua própria chave para o gargalo Sagrado/Sombrio.

---

## 2.3 Armas — Caçador

**155 · Arco Curto** — Arma · Comum · Início
**Obtém:** madeira + tendão. **Serve:** primeiro ataque à distância. **Liga com:** §15 Caçador. **Por quê:** o Caçador precisa existir na primeira hora, não só na décima.

**156 · Arco Longo** — Arma · Incomum · Meio
Disparo carregado, alcance grande. **Obtém:** mogno + tendão. **Serve:** dano de longa distância (§15). **Liga com:** disparos carregados. **Por quê:** materializa a mecânica de "carregar tiro" já prevista no GDD.

**157 · Besta de Repetição** — Arma · Raro · Fim
Cadência alta, munição de chumbo. **Obtém:** Engenharia + Forja. **Serve:** DPS sustentado. **Liga com:** Chumbo, Engenharia. **Por quê:** uma arma que exige duas cadeias de produção premia o jogador que investiu em oficina.

**158 · Arco Silencioso** — Arma · Raro · Fim
Feito de Teixo-Sombrio; não alerta inimigos próximos. **Obtém:** Teixo. **Serve:** furtividade, abater sentinelas. **Liga com:** Sight dos selvagens (§26.1). **Por quê:** dá uma resposta ao `sight` do spawner — uma mecânica do GDD ganhando contramedida.

**159 · Flecha Comum / Farpada / Incendiária / Gélida / Venenosa / Sagrada** — Munição · Comum→Raro · Todos
Seis linhas de munição. **Obtém:** Bancada de Fletching. **Serve:** aplicar elemento e status à distância. **Liga com:** §20, Debuffs. **Por quê:** munição é a forma mais barata de dar ao Caçador acesso à tabela de tipos inteira.

**160 · Flecha-Corda** — Munição especial · Incomum · Meio
Crava e deixa uma corda pendurada. **Obtém:** Fletching. **Serve:** criar rotas verticais em qualquer lugar. **Liga com:** Climb, side view. **Por quê:** mobilidade criada pelo jogador é o que torna um mundo 2D realmente aberto.

**161 · Flecha-Marcadora** — Munição especial · Incomum · Meio
Marca o alvo: fica visível através de paredes por 30s. **Obtém:** Fletching + musgo luminoso. **Serve:** rastrear Forgeling que fugiu. **Liga com:** §8, captura. **Por quê:** um bicho raro fugindo é frustração pura; isso conserta.

**162 · Flecha-Cápsula** — Munição especial · Raro · Fim
Dispara uma cápsula de captura à distância. **Obtém:** Engenharia. **Serve:** capturar sem se aproximar. **Liga com:** §8. **Por quê:** é a fantasia definitiva do Caçador e um upgrade de captura exclusivo da profissão.

**163 · Zarabatana** — Arma · Comum · Início
Silenciosa, dardos de espinho. **Obtém:** bambu. **Serve:** aplicar sono/veneno cedo. **Liga com:** Papoula, captura. **Por quê:** dá ao Caçador iniciante uma ferramenta de captura antes de qualquer tecnologia.

**164 · Bumerangue de Casca-de-Ferro** — Arma · Incomum · Meio
Volta trazendo itens no caminho. **Obtém:** Casca-de-Ferro. **Serve:** dano + coleta remota. **Liga com:** QoL de coleta. **Por quê:** um item de dupla função é sempre mais divertido que dois itens.

---

## 2.4 Armas e Aparatos — Engenheiro

**165 · Bomba de Pólvora** — Consumível · Comum · Início
**Obtém:** carvão + enxofre + salitre. **Serve:** dano em área; abrir passagem. **Liga com:** §15, mineração. **Por quê:** a bomba é a assinatura do Engenheiro e serve para lutar *e* para minerar.

**166 · Bomba Adesiva** — Consumível · Incomum · Meio
Gruda no alvo. **Obtém:** + resina. **Serve:** garantir dano em inimigo móvel. **Liga com:** Chefes rápidos. **Por quê:** resolve o problema de bombas contra alvos que se mexem.

**167 · Bomba de Fumaça** — Consumível · Comum · Início
**Obtém:** saco de tinta + pólvora. **Serve:** quebrar linha de visão e **fugir quando o time cai** (§22). **Liga com:** invulnerabilidade condicional. **Por quê:** dá ao estado de "sem Forgeling" uma saída tática em vez de morte certa.

**168 · Mina de Pressão** — Armadilha · Incomum · Meio
**Obtém:** Oficina. **Serve:** defesa de base e de acampamento. **Liga com:** Defesa de base, Multiplayer. **Por quê:** transforma o Engenheiro no responsável natural pela segurança da base compartilhada.

**169 · Armadilha de Rede** — Armadilha · Incomum · Meio
Prende o Forgeling selvagem no lugar. **Obtém:** teia + mecanismo. **Serve:** **captura sem combate**. **Liga com:** §8, §26.4 (rota paralela ao Taunt). **Por quê:** dá ao Engenheiro sua própria rota de aquisição, equilibrando o Taunt exclusivo do Caçador.

**170 · Armadilha de Urso** — Armadilha · Comum · Início
Dano + imobilização. **Obtém:** ferro. **Serve:** caça passiva. **Liga com:** Couro, materiais. **Por quê:** caça enquanto você faz outra coisa é excelente uso do tempo do jogador.

**171 · Torre Temporária (Balista / Chamas / Gelo)** — Estrutura · Incomum→Raro · Meio
Três variantes, duram 60s. **Obtém:** Oficina. **Serve:** apoio em luta de chefe (§15). **Liga com:** ForgelingView (§22). **Por quê:** dá ao Engenheiro presença em combate mesmo com o personagem parado durante o ForgelingView.

**172 · Dinamite de Mineração** — Consumível · Incomum · Meio
Explosão em linha horizontal, ideal para túneis. **Obtém:** Oficina. **Serve:** escavação em massa. **Liga com:** side view, mineração. **Por quê:** um explosivo que respeita o formato do mundo 2D é muito mais útil que um raio genérico.

**173 · Grappling Gun** — Equipamento · Raro · Fim
Gancho mecânico de longo alcance. **Obtém:** Oficina + mola de aço. **Serve:** mobilidade vertical instantânea. **Liga com:** Climb, Fly. **Por quê:** é a resposta tecnológica do Engenheiro às Skills de mobilidade — mesmo destino, caminho diferente.

**174 · Drone de Coleta** — Equipamento · Raro · Fim
Pequeno autômato que recolhe drops num raio. **Obtém:** Oficina + Núcleo Elemental de Ar. **Serve:** QoL de coleta automática. **Liga com:** Pedra-Ímã, loot. **Por quê:** recompensa o investimento em engenharia com conveniência permanente.

**175 · Lança-Chamas Portátil** — Arma · Raro · Fim
Combustível: gordura ou óleo. **Obtém:** Oficina. **Serve:** dano de Fogo contínuo; derreter gelo; *Ignite* sem Forgeling. **Liga com:** §20, Ignite. **Por quê:** dá ao Engenheiro uma versão mecânica de uma Skill — sempre inferior, sempre disponível.

**176 · Congelador Portátil** — Arma · Raro · Fim
O oposto do anterior. **Obtém:** Oficina + Gelo Perene. **Serve:** *Freeze* sem Forgeling; solidificar lava (obsidiana!). **Liga com:** Obsidiana, Freeze. **Por quê:** destrava a cadeia da obsidiana para quem não tem o Forgeling certo.

---

## 2.5 Armaduras

**177 · Roupa de Tecido** — Armadura · Comum · Início
**Obtém:** algodão. **Serve:** defesa mínima, sem penalidade. **Liga com:** Início de jogo. **Por quê:** o jogador precisa poder trocar de aparência desde cedo — vestir-se é identidade.

**178 · Armadura de Couro** — Armadura · Comum · Início
**Obtém:** curtume. **Serve:** defesa leve, +stealth. **Liga com:** Caçador. **Por quê:** o primeiro conjunto real, acessível a todos.

**179 · Cota de Malha** — Armadura · Incomum · Meio
**Obtém:** Forja. **Serve:** defesa média, −speed leve. **Liga com:** Mercenário. **Por quê:** introduz a troca defesa↔mobilidade, que é o coração de qualquer sistema de armadura.

**180 · Placas de Aço** — Armadura · Raro · Fim
**Obtém:** Forja. **Serve:** defesa alta, −speed forte. **Liga com:** Chefes. **Por quê:** dá ao jogador que apanha muito uma resposta clara.

**181 · Conjunto Elemental (×6)** — Armadura · Raro · Fim
Um conjunto por elemento, feito de Escamas + Forgita. **Obtém:** Forja. **Serve:** resistência forte a um tipo, fraqueza ao oposto. **Liga com:** §20.4. **Por quê:** faz o jogador **trocar de armadura por chefe**, criando preparação real antes de cada luta.

**182 · Manto do Vigia Sombrio** — Armadura · Épico · Endgame
Reduz dano elemental a 25%, dobra dano Sagrado recebido. **Obtém:** Adamas. **Serve:** virar um Sombrio ambulante. **Liga com:** §20.3. **Por quê:** deixar o jogador *habitar* um tipo é a melhor forma de ensinar a tabela.

**183 · Paramentos Aurora** — Armadura · Épico · Endgame
O inverso exato. **Obtém:** Aurita. **Serve:** glass cannon anti-Sombrio. **Liga com:** §20.3. **Por quê:** simetria; e dá ao jogador a escolha de qual lado do eixo moral encarnar.

**184 · Traje de Mergulho** — Equipamento · Raro · Fim
**Obtém:** couro + cobalto + cortiça. **Serve:** fôlego longo, descer fundo. **Liga com:** Cobalto Abissal, Swim. **Por quê:** o oceano profundo precisa de um portão de equipamento para virar destino.

**185 · Traje Térmico** — Equipamento · Incomum · Meio
**Obtém:** pelo espesso ou escória. **Serve:** sobreviver a Neve e Vulcão. **Liga com:** Biomas extremos. **Por quê:** portões climáticos ordenam a exploração sem paredes invisíveis.

**186 · Máscara de Filtro** — Equipamento · Incomum · Meio
**Obtém:** cortiça + tecido + carvão. **Serve:** imunidade a esporos, gás, cinábrio. **Liga com:** Cinábrio, Pântano. **Por quê:** um item pequeno que abre três lugares perigosos.

**187 · Botas de Amortecimento** — Equipamento · Incomum · Meio
**Obtém:** couro + cogumelo gigante. **Serve:** anula dano de queda. **Liga com:** side view, cavernas. **Por quê:** em um jogo vertical, dano de queda é o assassino nº 1 do novato.

**188 · Botas de Aderência** — Equipamento · Raro · Fim
**Obtém:** garra + resina. **Serve:** andar em paredes íngremes sem *Climb*. **Liga com:** Climb. **Por quê:** rota alternativa a uma Skill — nunca travar o jogador é princípio.

**189 · Luvas de Escavador** — Equipamento · Comum · Início
**Obtém:** couro. **Serve:** colher plantas perigosas; +velocidade de mineração. **Liga com:** Flor-Brasa, Cinábrio. **Por quê:** dá função a um slot que normalmente é só número.

**190 · Elmo com Lanterna** — Equipamento · Incomum · Meio
**Obtém:** ferro + vidro + óleo. **Serve:** luz permanente sem ocupar a mão. **Liga com:** Illuminate, cavernas. **Por quê:** libera o jogador de segurar tocha — QoL clássica e sempre celebrada.

**191 · Amuleto de Vínculo** — Acessório · Raro · Fim
**Obtém:** Cristal de Forgeling. **Serve:** o Forgeling ativo ganha +10% em todos os stats. **Liga com:** §27.5. **Por quê:** acessórios que fortalecem a *criatura*, não o jogador, reforçam a identidade do jogo.

**192 · Anel de Afinidade** — Acessório · Raro · Fim
**Obtém:** joalheria + Essência. **Serve:** transfere o bônus de afinidade (§20.7) para ataques de outro tipo. **Liga com:** §29.1. **Por quê:** dá função direta a uma das questões em aberto do GDD, seja qual for o valor escolhido.

**193 · Colar de Sorte** — Acessório · Incomum · Meio
**Obtém:** trevo + ouro. **Serve:** +chance de drop raro e +IV em ovos. **Liga com:** §27.4, Ovos. **Por quê:** dá ao jogador uma alavanca sobre a aleatoriedade, que é onde mora a frustração.

**194 · Cinto de Utilidades** — Acessório · Comum · Início
**Obtém:** couro. **Serve:** +4 slots de acesso rápido para consumíveis. **Liga com:** UI, QoL. **Por quê:** hotbar maior é progressão de conforto, e conforto é recompensa.

---

## 2.6 Mochilas e Armazenamento Pessoal

**195 · Bolsa de Pano** — Mochila · Comum · Início
+8 slots. **Obtém:** algodão. **Serve:** o primeiro alívio de inventário. **Liga com:** UI. **Por quê:** o primeiro upgrade de mochila é sempre o item mais amado do início de jogo.

**196 · Mochila de Couro** — Mochila · Comum · Início
+16 slots. **Obtém:** couro. **Serve:** expedições curtas. **Liga com:** Curtume. **Por quê:** escada clara de conforto.

**197 · Mochila de Explorador** — Mochila · Incomum · Meio
+24 slots, resistente à água. **Obtém:** salgueiro + couro. **Serve:** expedição aquática. **Liga com:** Surf, Swim. **Por quê:** mochila com propriedade (não só tamanho) é mais interessante.

**198 · Cesto de Minerador** — Mochila especial · Incomum · Meio
Slots normais + 12 slots **exclusivos para minério**. **Obtém:** junco + ferro. **Serve:** mineração longa. **Liga com:** Mineração. **Por quê:** bolsas especializadas dão ao jogador razão para trocar de kit por atividade.

**199 · Cesto de Herborista** — Mochila especial · Incomum · Meio
Slots exclusivos para plantas; **retarda o apodrecimento**. **Obtém:** junco + cera. **Serve:** coleta longa. **Liga com:** Conservação, Alquimia. **Por quê:** simetria com o cesto de minerador; cada profissão informal ganha a sua.

**200 · Bolsa Dimensional** — Mochila · Épico · Endgame
+48 slots; **acessa o baú da base à distância**. **Obtém:** Núcleo Elemental de Ar + Forgita. **Serve:** fim da logística. **Liga com:** Armazém (§11), QoL. **Por quê:** é a recompensa de endgame que os jogadores mais pedem em jogos de crafting.

**201 · Alforje de Forgeling** — Equipamento de criatura · Incomum · Meio
Equipado **no Forgeling**, não no jogador; +12 slots. **Obtém:** couro + tecido. **Serve:** o companheiro carrega parte da carga. **Liga com:** Carry (§10), §27.2. **Por quê:** dá aos Forgelings um slot de equipamento próprio — um sistema inteiro nascendo de um item.

**202 · Coleira Elemental** — Equipamento de criatura · Raro · Fim
Equipada no Forgeling; muda o tipo do auto-ataque. **Obtém:** Essência + couro. **Serve:** flexibilidade tática. **Liga com:** §20, §25. **Por quê:** dá conserto parcial à rigidez de "não pode trocar em combate" (§22) sem revogar a regra.

**203 · Sela** — Equipamento de criatura · Raro · Fim
Só para Forgelings grandes. **Obtém:** couro + tendão. **Serve:** **montar o Forgeling** para viajar mais rápido. **Liga com:** Fly, Swim, mobilidade. **Por quê:** montaria é a evolução natural do vínculo e transforma o mapa aberto em algo prazeroso de cruzar.

---

## 2.7 Encantamentos, Runas e Infusões

*Regra de identidade: **não existe magia no personagem**. Todo efeito "mágico" vem de material — gema, essência ou runa gravada.*

**204 · Encaixe de Gema** — Sistema · — · Meio
Armas e armaduras têm 1–3 encaixes. Gemas entram e saem livremente. **Obtém:** Bancada de Joalheria. **Serve:** customização reversível. **Liga com:** §20, todas as gemas. **Por quê:** reversível = o jogador experimenta sem medo, e experimentar é onde nasce o domínio do sistema.

**205 · Runa de Vigor** — Runa · Incomum · Meio
+LIFE. **Obtém:** gravar em pedra rúnica. **Serve:** buff permanente ao item. **Liga com:** §27.5. **Por quê:** as runas cobrem os três stats do GDD sem inventar um quarto.

**206 · Runa de Ímpeto** — Runa · Incomum · Meio
+ATK. **Liga com:** §27.5. **Por quê:** idem.

**207 · Runa de Alacridade** — Runa · Incomum · Meio
+SPEED, respeitando o teto de 2× da cadência (§25). **Liga com:** §25. **Por quê:** o teto do GDD deve valer para itens também, senão o item fura o design.

**208 · Runa da Sanguessuga** — Runa · Raro · Fim
Converte 5% do dano em vida do Forgeling. **Liga com:** sustentação em combate longo. **Por quê:** ajuda em lutas de chefe onde a troca é travada (§22).

**209 · Runa do Eco** — Runa · Raro · Fim
Chance de o ataque disparar duas vezes. **Liga com:** §24, cooldowns. **Por quê:** proc aleatório é o tipo de item que gera histórias.

**210 · Runa da Bigorna** — Runa · Incomum · Meio
Reduz o desgaste de durabilidade pela metade. **Liga com:** Durabilidade. **Por quê:** transformar manutenção em não-problema é um upgrade que o jogador *sente*.

**211 · Runa do Colecionador** — Runa · Raro · Fim
+chance de o inimigo dropar material raro. **Liga com:** Loot. **Por quê:** o jogador de endgame precisa de itens que otimizem o farm.

**212 · Infusão Elemental** — Sistema · — · Fim
Aplicar Essência Destilada (§114) a um equipamento **converte permanentemente** seu tipo. **Obtém:** Alambique + Forja. **Serve:** transformar equipamento antigo em relevante. **Liga com:** §20, sustentabilidade de itens. **Por quê:** combate a obsolescência — o item favorito do jogador pode acompanhá-lo.

**213 · Corrupção & Purificação** — Sistema · — · Endgame
Um item pode ser corrompido (poder alto, penalidade Sagrada) ou purificado (o inverso). Reversível, mas caro. **Obtém:** Altar Sombrio / Santuário. **Serve:** identidade de build. **Liga com:** §20.3. **Por quê:** dá ao eixo moral um sistema de personalização, não só uma tabela de dano.

**214 · Selo de Herança** — Encantamento · Épico · Endgame
Transfere os encantamentos de um item antigo para um novo. **Obtém:** Pó de Estrela. **Serve:** upgrade sem perder investimento. **Liga com:** Economia de endgame. **Por quê:** é o antídoto para o medo de melhorar de equipamento.

**215 · Marca do Domador** — Encantamento de criatura · Raro · Fim
Gravada na Coleira; o Forgeling ganha +1 slot de ataque equipado (5 em vez de 4). **Obtém:** quest de mestre-domador. **Serve:** quebrar o limite de §24 — uma vez, com muito esforço. **Liga com:** §24, §16. **Por quê:** quebrar uma regra própria de forma rara e cerimonial é a melhor recompensa que um GDD pode oferecer.

---
---

# RODADA 3 — A Base: Construções, Estações, Máquinas e Móveis

*O GDD já disse que a base é o centro de operações e que a cama cura o time (§11.1). Agora ela precisa de conteúdo suficiente para o jogador querer passar horas dentro dela.*

---

## 3.1 Estações de Crafting

**216 · Bancada de Trabalho** — Estação · Comum · Início
A primeira estação. **Obtém:** 10 tábuas. **Serve:** ferramentas básicas, estações seguintes. **Liga com:** todo o crafting. **Por quê:** o momento em que o jogador coloca a primeira bancada é o momento em que ele decide onde é "casa".

**217 · Fornalha** — Estação · Comum · Início
**Obtém:** pedra + argila. **Serve:** fundir minério em barra; cozinhar carne cru. **Liga com:** Minérios. **Por quê:** o passo minério→barra é onde o loop de mineração fecha.

**218 · Forja** — Estação · Comum · Meio
**Obtém:** pedra + ferro + carvão. **Serve:** armas, armaduras e ferramentas de metal. **Liga com:** §11 (já listada no GDD). **Por quê:** dá função ao substantivo "Forja" que o GDD já lista.

**219 · Bigorna** — Estação · Comum · Meio
**Obtém:** ferro. **Serve:** reparar e reforjar itens; aplicar runas. **Liga com:** Durabilidade, Runas. **Por quê:** separar "fazer" de "consertar" cria duas rotinas distintas na base.

**220 · Bancada de Marcenaria** — Estação · Comum · Início
**Obtém:** tábuas + serra. **Serve:** móveis, tábuas refinadas, variantes de bloco. **Liga com:** Decoração. **Por quê:** construir bonito precisa de uma estação dedicada, senão a decoração vira nota de rodapé.

**221 · Tear** — Estação · Comum · Início
**Obtém:** madeira + linho. **Serve:** tecido, roupa, tapete, vela de barco, mochilas. **Liga com:** Mochilas, Navegação. **Por quê:** a cadeia têxtil sustenta três sistemas diferentes.

**222 · Curtume** — Estação · Comum · Início
**Obtém:** madeira + sal + calcário. **Serve:** couro cru → couro. **Liga com:** Materiais de criatura. **Por quê:** dá destino ao drop mais comum do jogo.

**223 · Cozinha / Fogão** — Estação · Comum · Início
**Obtém:** pedra + ferro. **Serve:** todas as receitas culinárias. **Liga com:** §11 (Cozinhas), Buffs. **Por quê:** a comida é o sistema de buff mais acessível; precisa de casa própria cedo.

**224 · Alambique** — Estação · Incomum · Meio
**Obtém:** cobre + vidro. **Serve:** alquimia: poções, venenos, essências. **Liga com:** §11 (Laboratórios). **Por quê:** dá função ao "Laboratório" que o GDD lista sem definir.

**225 · Alambique Elemental** — Estação · Raro · Fim
**Obtém:** Alambique + Forgita. **Serve:** destilar Fragmentos em Essências (§114). **Liga com:** §20, Infusão. **Por quê:** cadeia de produção de segundo nível é o que dá longevidade ao endgame.

**226 · Bancada de Joalheria** — Estação · Incomum · Meio
**Obtém:** ouro + quartzo. **Serve:** lapidar gemas, criar encaixes, anéis e colares. **Liga com:** Gemas, Acessórios. **Por quê:** a lapidação transforma gema bruta em decisão de build.

**227 · Bancada de Fletching** — Estação · Comum · Início
**Obtém:** madeira + pena. **Serve:** arcos, flechas, munição especial. **Liga com:** Caçador. **Por quê:** cada profissão merece uma estação que seja "dela".

**228 · Oficina de Engenharia** — Estação · Incomum · Meio
**Obtém:** ferro + cobre + engrenagens. **Serve:** bombas, armadilhas, torres, drones, máquinas. **Liga com:** Engenheiro. **Por quê:** idem — e é o pré-requisito de toda a automação da base.

**229 · Mesa de Táticas do Mercenário** — Estação · Incomum · Meio
**Obtém:** mogno + couro. **Serve:** aprender e reordenar combos; simular lutas. **Liga com:** Mercenário, combos. **Por quê:** fecha o trio de estações de profissão, e dá um lugar físico à árvore de evolução (§15).

**230 · Pedra Rúnica** — Estação · Raro · Fim
**Obtém:** granito + Essência. **Serve:** gravar runas em equipamento. **Liga com:** Runas. **Por quê:** encantamento precisa de uma estação com peso ritual, não de um menu.

**231 · Altar Prismático** — Estação · Lendário · Endgame
**Obtém:** as seis gemas elementais + Forgita pura. **Serve:** fundir o Núcleo Prismático (§44); rituais de topo. **Liga com:** endgame de coleção. **Por quê:** a base precisa de um objeto final que seja um troféu visível.

**232 · Altar Sombrio / Santuário Aurora** — Estação · Épico · Endgame
Par oposto. **Obtém:** Adamas / Aurita. **Serve:** corromper e purificar itens (§213). **Liga com:** §20.3. **Por quê:** obriga o jogador a escolher que tipo de base ele é dono — ou a ter as duas e conviver com a tensão.

**233 · Incubadora de Ovos** — Estação · Incomum · Meio
**Obtém:** madeira + palha + fonte de calor. **Serve:** chocar ovos mais rápido; a fonte de calor **influencia o tipo** do filhote. **Liga com:** §29.5 (questão em aberto sobre ovos). **Por quê:** responde diretamente a uma pergunta que o GDD deixou aberta, com uma mecânica que dá controle ao jogador.

**234 · Moinho** — Estação · Comum · Meio
**Obtém:** madeira + pedra. **Serve:** trigo→farinha, milho→fubá, osso→farinha de osso. **Liga com:** Culinária, Agricultura. **Por quê:** processamento intermediário faz a colheita valer mais que a soma das partes.

**235 · Barril de Fermentação** — Estação · Comum · Meio
**Obtém:** tábuas + aro de ferro. **Serve:** vinho, cerveja, hidromel, picles, queijo. **Liga com:** Bebidas, Conservação. **Por quê:** esperar por um produto melhor ensina o jogador a investir em tempo real de jogo.

**236 · Defumador** — Estação · Comum · Meio
**Obtém:** pedra + madeira. **Serve:** conservar carne e peixe por muito tempo. **Liga com:** Pesca, Caça. **Por quê:** conservação transforma a caça de "hoje" em despensa de "sempre".

**237 · Compostora** — Estação · Comum · Início
**Obtém:** tábuas. **Serve:** transformar restos e plantas ruins em fertilizante. **Liga com:** Agricultura. **Por quê:** um destino para o lixo do inventário — nada é inútil.

**238 · Serraria** — Estação · Incomum · Meio
**Obtém:** ferro + madeira. **Serve:** converter tora em tábuas com 50% mais rendimento. **Liga com:** Lumberjack. **Por quê:** upgrades de rendimento dão sensação de progressão econômica.

**239 · Britador** — Estação · Incomum · Meio
**Obtém:** Oficina. **Serve:** pedra→cascalho→areia; minério→pó (rendimento dobrado ao fundir). **Liga com:** Peneira, Fornalha. **Por quê:** rendimento dobrado é o clássico upgrade que faz o jogador refazer todo o farm antigo com prazer.

**240 · Olaria** — Estação · Comum · Início
**Obtém:** argila + pedra. **Serve:** vasos, telhas, potes de armazenamento, cadinhos. **Liga com:** Argila, Decoração. **Por quê:** cerâmica é a estética mais barata e mais charmosa de um jogo pixel art.

---

## 3.2 Máquinas e Automação

*Automação em PixelForge é **assistida**, nunca total: máquinas processam e transportam, mas coletar e explorar continuam sendo do jogador e do Forgeling.*

**241 · Fornalha a Vapor** — Máquina · Incomum · Meio
Funde 4 minérios ao mesmo tempo. **Obtém:** Oficina + caldeira. **Serve:** escala de fundição. **Liga com:** Fornalha. **Por quê:** o primeiro salto de escala é sempre eufórico.

**242 · Esteira Transportadora** — Máquina · Incomum · Meio
Move itens entre máquinas e baús. **Obtém:** Oficina + couro + engrenagem. **Serve:** ligar estações. **Liga com:** Automação. **Por quê:** logística visível em side view é lindíssima e vira hobby do jogador.

**243 · Funil / Tremonha** — Máquina · Comum · Meio
Puxa itens para dentro de um contêiner. **Obtém:** ferro. **Serve:** a peça de encaixe de toda automação. **Liga com:** Esteira. **Por quê:** sem funil, esteira é enfeite.

**244 · Prensa Hidráulica** — Máquina · Raro · Fim
**Obtém:** Oficina + Núcleo de Água. **Serve:** placas de blindagem, óleo de semente, sucos. **Liga com:** Armaduras, Culinária. **Por quê:** uma máquina servindo a dois sistemas mantém a oficina relevante para não-engenheiros.

**245 · Gerador Elemental (×6)** — Máquina · Raro · Fim
Alimentado por Fragmento; cada elemento produz um tipo de energia. **Obtém:** Oficina + Fragmento. **Serve:** energizar máquinas avançadas. **Liga com:** §20. **Por quê:** faz o sistema de tipos, que nasceu no combate, **atravessar para a base** — coerência de mundo.

**246 · Bomba d'Água** — Máquina · Incomum · Meio
**Obtém:** cobre + couro. **Serve:** irrigar fazenda automaticamente; drenar cavernas alagadas. **Liga com:** Agricultura, exploração. **Por quê:** drenar uma caverna para revelar o que havia embaixo é um momento de descoberta memorável.

**247 · Elevador de Mina** — Máquina · Incomum · Meio
Plataforma vertical entre andares. **Obtém:** madeira + corda + engrenagem. **Serve:** transporte vertical rápido. **Liga com:** side view, mineração. **Por quê:** em um mundo de perfil, o elevador é **a** QoL de mobilidade.

**248 · Trilho e Vagonete** — Máquina · Incomum · Meio
**Obtém:** ferro + tábuas. **Serve:** transporte horizontal longo, carga pesada. **Liga com:** Mineração, Multiplayer. **Por quê:** construir uma linha férrea pela caverna é um projeto de fim de semana que jogadores adoram.

**249 · Farol de Retorno** — Máquina · Raro · Fim
**Obtém:** Oficina + quartzo + ouro. **Serve:** ponto de teleporte para a base; um por sala. **Liga com:** QoL, Multiplayer. **Por quê:** viagem rápida ganha peso de construção em vez de ser botão de menu.

**250 · Portal de Ancoragem** — Máquina · Épico · Endgame
Par de portais que o jogador posiciona. **Obtém:** Núcleo de Ar + Forgita. **Serve:** ligar base a um bioma distante. **Liga com:** Exploração de endgame. **Por quê:** encurta o mundo só depois de o jogador já ter merecido conhecê-lo por inteiro.

**251 · Extrator Automático** — Máquina · Raro · Fim
Minera lentamente o bloco à frente, para sempre. **Obtém:** Oficina + Núcleo de Terra. **Serve:** renda passiva de minério comum. **Liga com:** Economia. **Por quê:** renda passiva pequena é ótima; renda passiva grande mata o jogo. Aqui ela é deliberadamente lenta.

**252 · Colmeia Artificial** — Estrutura · Comum · Meio
**Obtém:** tábuas + cera. **Serve:** mel e cera renováveis; **poliniza a fazenda** (+rendimento). **Liga com:** Agricultura. **Por quê:** sinergia entre dois sistemas é sempre mais gostosa que um bônus solto.

**253 · Estufa** — Construção · Incomum · Meio
**Obtém:** vidro + madeira. **Serve:** cultivar qualquer planta fora do bioma e da estação. **Liga com:** Agricultura, Clima. **Por quê:** liberdade tardia; o jogador ganha o direito de ignorar restrições que respeitou por 20 horas.

**254 · Aquário de Criação** — Construção · Incomum · Meio
**Obtém:** vidro + pedra. **Serve:** criar peixes; produz ovas e peixe renovável. **Liga com:** Pesca. **Por quê:** a pesca ganha um lado de produção, não só de coleta.

**255 · Pasto e Estábulo** — Construção · Comum · Meio
**Obtém:** madeira + cerca. **Serve:** abrigar animais domesticados. **Liga com:** Pecuária. **Por quê:** dá aos animais comuns (não-Forgelings) um lugar no mundo.

**256 · Recinto de Forgelings** — Construção · Incomum · Meio
**Obtém:** madeira + pedra + Forgita. **Serve:** abrigar os Forgelings **fora do time de 5** (§27.1); eles vagam, interagem e **geram ovos**. **Liga com:** §27.1, Ovos, §29.5. **Por quê:** resolve o destino dos Forgelings excedentes — hoje o GDD limita o time a 5 e não diz o que acontece com o sexto. Um pasto de criaturas é também o conteúdo mais fofo possível.

**257 · Poço** — Construção · Comum · Início
**Obtém:** pedra + balde. **Serve:** água infinita perto de casa. **Liga com:** Agricultura, Culinária. **Por quê:** eliminar caminhadas repetitivas é a essência de melhorar a base.

**258 · Silo** — Construção · Comum · Meio
**Obtém:** madeira + pedra. **Serve:** armazenar ração/feno em massa; alimenta o pasto automaticamente. **Liga com:** Pecuária. **Por quê:** um sistema de criação sem automação de comida vira tarefa doméstica chata.

**259 · Pombal** — Construção · Incomum · Meio
**Obtém:** madeira + pena. **Serve:** enviar itens e mensagens entre bases (inclusive de outros jogadores). **Liga com:** §19 Multiplayer, Comércio. **Por quê:** correio assíncrono deixa a sala viva mesmo quando os amigos não estão online.

---

## 3.3 Defesa e Infraestrutura da Base

**260 · Cerca / Muro / Muralha** — Construção · Comum→Raro · Todos
Três tiers de altura e resistência. **Obtém:** madeira / pedra / aço. **Serve:** delimitar e proteger. **Liga com:** §11 (já listado). **Por quê:** dá aos "Muros e Portões" do GDD uma escada de progressão.

**261 · Portão Automático** — Construção · Incomum · Meio
Abre para o dono e para aliados da sala. **Obtém:** Oficina. **Serve:** conveniência + segurança. **Liga com:** §19, permissões. **Por quê:** bases compartilhadas precisam de controle de acesso, senão o multiplayer vira atrito.

**262 · Torre de Vigia** — Construção · Incomum · Meio
**Obtém:** pedra + madeira. **Serve:** ampliar visão; posto para o Caçador. **Liga com:** §11 (Torres), Caçador. **Por quê:** verticalidade na base aproveita o side view.

**263 · Torre de Balista Fixa** — Construção · Raro · Fim
Versão permanente da torre temporária do Engenheiro. **Obtém:** Oficina. **Serve:** defesa automatizada. **Liga com:** Eventos de invasão. **Por quê:** dá sentido ao evento de invasão e recompensa quem investiu em engenharia.

**264 · Totem Repelente** — Construção · Incomum · Meio
Impede spawn hostil num raio. **Obtém:** osso + Essência. **Serve:** tornar a base segura de verdade. **Liga com:** §26.3 Spawners. **Por quê:** o jogador precisa poder declarar um lugar como seguro; sem isso, base vira estresse.

**265 · Totem de Atração** — Construção · Raro · Fim
O inverso: aumenta spawn de uma espécie escolhida num raio. **Obtém:** Essência + Cristal. **Serve:** criar uma "fazenda de Forgelings" para farm de drops e ovos. **Liga com:** §26.3, Economia. **Por quê:** conteúdo de endgame que usa um sistema já existente do GDD sem inventar nada novo.

**266 · Para-raios Elemental** — Construção · Incomum · Meio
**Obtém:** cobre + quartzo. **Serve:** protege a base de tempestades (§13) e **captura a energia** como recurso. **Liga com:** Clima. **Por quê:** transformar um perigo climático em recurso é a melhor forma de fazer o clima importar.

**267 · Barômetro** — Móvel funcional · Comum · Meio
**Obtém:** vidro + mercúrio. **Serve:** prever o clima das próximas horas. **Liga com:** §13, planejamento. **Por quê:** previsão transforma o clima aleatório em planejamento — o jogador deixa de ser vítima.

**268 · Sino de Alarme** — Construção · Comum · Meio
**Obtém:** bronze. **Serve:** avisa todos na sala sobre invasão ou evento. **Liga com:** §19. **Por quê:** coordenação em multiplayer precisa de ferramentas dentro do jogo, não só de voz externa.

**269 · Ponte Levadiça** — Construção · Incomum · Meio
**Obtém:** madeira + corrente. **Serve:** travessia controlada sobre fosso. **Liga com:** Defesa. **Por quê:** castelinho é uma fantasia universal de base building.

**270 · Fosso e Espinhos** — Construção · Comum · Meio
**Obtém:** *Dig* + espinho-ferrão. **Serve:** defesa passiva barata. **Liga com:** Dig. **Por quê:** defesa que o Forgeling ajuda a construir reforça o vínculo.

---

## 3.4 Móveis e Decoração

**271 · Cama (4 tiers)** — Móvel · Comum→Raro · Todos
Palha → Pano → Pelo → Real. **Obtém:** Marcenaria + Tear. **Serve:** curar o time (§11.1); tiers melhores **curam mais rápido ou dão buff de descanso**. **Liga com:** §11.1. **Por quê:** o GDD já fez da cama uma peça de sistema; ela merece uma escada de progressão.

**272 · Baú (4 tiers)** — Móvel · Comum→Raro · Todos
Madeira → Ferro → Reforçado → Dimensional. **Serve:** armazenamento. **Liga com:** §11 Armazéns. **Por quê:** espaço é a moeda silenciosa de todo jogo de crafting.

**273 · Baú de Ordenação Automática** — Móvel · Raro · Fim
Puxa dos baús vizinhos e organiza por categoria. **Obtém:** Oficina. **Serve:** fim do caos de inventário. **Liga com:** QoL. **Por quê:** organização automática é o item mais pedido de todo survival, sem exceção.

**274 · Mesa e Cadeiras** — Móvel · Comum · Início
**Obtém:** Marcenaria. **Serve:** decoração; sentar **acelera a regeneração** fora de combate. **Liga com:** Descanso. **Por quê:** dar função mínima à decoração faz o jogador decorar de verdade.

**275 · Tapete** — Móvel · Comum · Início
20 cores via corantes. **Serve:** estética. **Liga com:** Tinturaria. **Por quê:** cor é conteúdo infinito por custo quase zero.

**276 · Quadro / Pintura** — Decoração · Comum · Meio
**Obtém:** tela + tinta; ou **encomendar a um NPC pintor um retrato do seu Forgeling**. **Serve:** estética e memória afetiva. **Liga com:** NPCs, vínculo. **Por quê:** um retrato do seu bicho favorito na parede é o tipo de detalhe que vira post em rede social.

**277 · Estante de Livros** — Móvel · Comum · Meio
**Serve:** armazenar receitas e lore; **aumenta a chance de sucesso do encantamento** perto da Pedra Rúnica. **Liga com:** Runas. **Por quê:** móveis que buffam estações criam o hobby de projetar salas ótimas.

**278 · Vitrine de Troféus** — Móvel · Incomum · Meio
Expõe um item raro; visível para visitantes da sala. **Liga com:** §19, Colecionáveis. **Por quê:** exibir conquista para outros jogadores é motivação social poderosíssima.

**279 · Pedestal de Fóssil** — Móvel · Incomum · Meio
Expõe fósseis e âmbares. **Liga com:** Colecionáveis, Museu. **Por quê:** dá destino aos colecionáveis que não têm uso funcional.

**280 · Aquário Decorativo** — Móvel · Comum · Meio
Mostra os peixes que você pescou. **Liga com:** Pesca. **Por quê:** transformar a coleção em decoração dá razão para pescar aquele peixe feio.

**281 · Lareira** — Móvel · Comum · Início
**Serve:** luz, calor (contra debuff de frio), cozinhar simples. **Liga com:** Clima, Neve. **Por quê:** a lareira é o coração visual de qualquer casa pixel art.

**282 · Lampião / Vela / Candelabro / Lustre de Quartzo** — Iluminação · Comum→Raro · Todos
**Serve:** iluminação com estéticas distintas. **Liga com:** Illuminate, Cera. **Por quê:** iluminação é a ferramenta de composição visual mais usada por construtores.

**283 · Placa e Letreiro** — Decoração · Comum · Início
Texto livre. **Liga com:** §19, organização. **Por quê:** placas são a linguagem natural de bases compartilhadas.

**284 · Espantalho Elemental** — Decoração funcional · Incomum · Meio
Um por elemento; afasta pragas do tipo oposto da fazenda. **Liga com:** §20, Agricultura. **Por quê:** faz o jogador aplicar a tabela de tipos **na fazenda**, o que é encantadoramente inesperado.

**285 · Estátua de Forgeling** — Decoração · Incomum · Meio
Esculpida com cinzel; qualquer espécie já capturada. **Liga com:** Cinzel, coleção. **Por quê:** monumentalizar a criatura favorita é expressão pessoal pura.

**286 · Bandeira de Sala** — Decoração · Comum · Meio
Emblema customizável da sala multiplayer. **Liga com:** §19, identidade de grupo. **Por quê:** grupos precisam de símbolo; símbolo cria pertencimento.

**287 · Jardim Zen / Canteiro / Vaso / Treliça** — Decoração · Comum · Meio
Peças de jardinagem ornamental. **Liga com:** Flores. **Por quê:** dá uso decorativo às flores que não viram poção.

**288 · Relógio de Sol / Ampulheta / Relógio de Parede** — Móvel funcional · Comum · Meio
Mostra a hora do jogo. **Liga com:** Ciclo dia/noite, Prata Lunar, Ipê-Solar. **Por quê:** vários conteúdos dependem de hora; o jogador precisa saber que horas são sem abrir menu.

**289 · Mapa-Múndi de Parede** — Móvel funcional · Incomum · Meio
Mostra o mundo explorado da sala inteira. **Liga com:** §19, Mapas. **Por quê:** mapa compartilhado é coordenação e também troféu coletivo.

**290 · Cofre de Sala** — Móvel · Incomum · Meio
Baú com permissões por jogador. **Liga com:** §19. **Por quê:** confiança precisa de ferramentas; sem permissões, cooperação vira risco.

**291 · Poltrona do Forgeling / Caminha / Comedouro / Brinquedo** — Móvel de criatura · Comum · Meio
Móveis que o Forgeling **usa de verdade** quando está ocioso na base. **Liga com:** Recinto, IA (§17). **Por quê:** ver a criatura interagir com a casa que você construiu é o que transforma pet em companheiro.

**292 · Jukebox e Discos** — Móvel · Incomum · Meio
Toca trilhas encontradas pelo mundo. **Obtém:** discos como drops raros e recompensa de quest. **Liga com:** Colecionáveis. **Por quê:** música colecionável é um dos colecionáveis mais queridos do gênero.

**293 · Instrumentos (Flauta, Tambor, Alaúde, Corneta)** — Móvel / Item · Incomum · Meio
Tocáveis de verdade, com notas. **Liga com:** Veio de Eco, Multiplayer, puzzles sonoros. **Por quê:** jogadores fazem coisas incríveis com instrumentos; é conteúdo gerado por eles, de graça.

---
---

# RODADA 4 — Culinária, Alquimia, Buffs e Consumíveis

*O GDD (§11.1) já estabeleceu que a cura vem da cama ou de itens. Esta rodada constrói o "itens".*

**Regra de balanceamento proposta:** comida dá buffs **longos e moderados**; poções dão efeitos **curtos e fortes**. Comida se planeja, poção se reage. Nunca sobrepõem-se dois buffs do mesmo eixo.

---

## 4.1 Alimentos e Receitas

**294 · Carne Assada** — Alimento · Comum · Início
**Obtém:** carne crua + fogo. **Serve:** saciedade e cura leve. **Liga com:** Caça. **Por quê:** o primeiro prato precisa ser trivial; é o tutorial silencioso da cozinha.

**295 · Pão** — Alimento · Comum · Início
**Obtém:** farinha + água + forno. **Serve:** saciedade duradoura, barato. **Liga com:** Trigo, Moinho. **Por quê:** a comida-âncora que sustenta o jogador pobre sem competir com pratos bons.

**296 · Ensopado de Raízes** — Receita · Comum · Início
Batata + cenoura + cogumelo. **Serve:** cura moderada + regeneração curta. **Liga com:** Agricultura. **Por quê:** o primeiro prato "combinado" ensina que misturar vale mais que empilhar.

**297 · Sopa de Peixe** — Receita · Comum · Início
Peixe + sal + erva. **Serve:** cura + resistência ao frio. **Liga com:** Pesca, Neve. **Por quê:** amarra pesca a bioma hostil.

**298 · Espetinho do Caçador** — Receita · Comum · Meio
Carne + pimenta + sal. **Serve:** +ATK do jogador por 8 min. **Liga com:** §15. **Por quê:** buff longo dá ritmo de "preparar antes de sair".

**299 · Torta de Abóbora** — Receita · Incomum · Meio
**Serve:** +LIFE máximo temporário. **Liga com:** Chefes. **Por quê:** buff de vida máxima é o preparo clássico pré-chefe.

**300 · Pão de Mel** — Receita · Incomum · Meio
**Serve:** regeneração lenta e longa. **Liga com:** Mel, Apicultura. **Por quê:** regeneração passiva é o que permite explorar sem parar a cada dano.

**301 · Bolo de Morango-da-Neve** — Receita · Incomum · Meio
**Serve:** +SPEED, +sorte. **Liga com:** Neve, Trevo. **Por quê:** pratos festivos merecem efeitos alegres.

**302 · Sushi de Alga** — Receita · Incomum · Meio
Peixe cru + arroz? → **alga + peixe + sal**. **Serve:** cura eficiente sem peso. **Liga com:** Pesca, expedição. **Por quê:** comida "leve" importa quando o inventário é apertado.

**303 · Ração de Forgeling** — Receita · Comum · Início
Farinha + carne + erva. **Serve:** **cura o Forgeling** (não o jogador) em campo. **Liga com:** §11.1, §22. **Por quê:** o Forgeling precisa da sua própria linha de consumíveis — ele é quem apanha.

**304 · Guloseima de Afinidade (×6)** — Receita · Incomum · Meio
Um doce por elemento. **Serve:** aumenta temporariamente o dano do Forgeling naquele tipo. **Liga com:** §20.7, §29.1. **Por quê:** dá ao jogador um botão manual sobre a tabela de tipos, útil independente da decisão de §29.1.

**305 · Bolo de Vínculo** — Receita · Raro · Fim
Ingredientes raros dos seis biomas. **Serve:** +XP permanente acelerado ao Forgeling por 30 min. **Liga com:** §29.8 (curva de XP). **Por quê:** com teto de nível 10, acelerar XP é uma recompensa forte mas contida por natureza.

**306 · Ensopado do Minerador** — Receita · Comum · Meio
**Serve:** +velocidade de mineração e visão em caverna. **Liga com:** Mineração. **Por quê:** buffs por atividade fazem o jogador cozinhar antes de cada tipo de expedição.

**307 · Chá de Lavanda** — Bebida · Comum · Meio
**Serve:** reduz duração de debuffs em 50%. **Liga com:** Debuffs. **Por quê:** resistência a status é uma categoria de buff que quase todo survival esquece.

**308 · Café de Raiz** — Bebida · Comum · Meio
**Serve:** +SPEED, mas −precisão. **Liga com:** Caçador (penalidade real). **Por quê:** buff com contra-indicação é decisão, não obviedade.

**309 · Vinho das Ruínas** — Bebida · Incomum · Meio
**Serve:** +sorte de drop, −defesa. **Liga com:** Uva das Ruínas. **Por quê:** o "arriscar para ganhar mais" é um eixo divertido de consumível.

**310 · Hidromel** — Bebida · Comum · Meio
**Serve:** +resistência a knockback e a medo. **Liga com:** Chefes. **Por quê:** dá função a um status (medo) que os chefes podem aplicar.

**311 · Cerveja de Trigo** — Bebida · Comum · Meio
**Serve:** buff social — em sala multiplayer, buffa **todos os jogadores próximos**. **Liga com:** §19. **Por quê:** consumíveis coletivos criam rituais de grupo antes de raide.

**312 · Suco de Cacto** — Bebida · Comum · Início
**Serve:** hidratação no deserto; remove superaquecimento. **Liga com:** Deserto. **Por quê:** solução local para problema local.

**313 · Leite Fresco** — Alimento base · Comum · Meio
**Obtém:** pecuária. **Serve:** **remove todos os buffs e debuffs** — o botão de reset. **Liga com:** Buffs. **Por quê:** o jogador precisa de uma forma de sair de um estado ruim rápido.

**314 · Queijo Curado** — Receita · Incomum · Meio
**Obtém:** leite + tempo no Barril. **Serve:** cura forte, não perecível. **Liga com:** Fermentação. **Por quê:** recompensa o jogador que planeja com semanas de antecedência no jogo.

**315 · Geleia (várias frutas)** — Receita · Comum · Meio
**Serve:** cura barata, conserva fruta indefinidamente. **Liga com:** Conservação. **Por quê:** resolver o apodrecimento é meio caminho para uma despensa organizada.

**316 · Conserva em Salmoura** — Receita · Comum · Meio
**Serve:** conservar vegetais; leve buff de resistência. **Liga com:** Sal-gema. **Por quê:** dá ao sal a importância histórica que ele merece.

**317 · Pipoca** — Receita · Comum · Início
**Serve:** buff curtíssimo de +SPEED; barata e divertida. **Liga com:** Milho. **Por quê:** nem tudo precisa ser sério; itens leves dão personalidade.

**318 · Banquete** — Receita · Raro · Fim
Prato de mesa que serve **até 5 jogadores**. **Obtém:** Cozinha nível alto. **Serve:** buff forte e longo para o grupo inteiro. **Liga com:** §19, raides. **Por quê:** o banquete pré-raide é um dos melhores momentos sociais que um jogo cooperativo pode ter.

**319 · Prato Corrompido** — Receita · Raro · Fim
Cozinhado no Altar Sombrio. **Serve:** buff enorme com penalidade Sagrada. **Liga com:** §20.3, §213. **Por quê:** o eixo moral chega até a cozinha — coerência total.

**320 · Ambrosia** — Receita · Lendário · Endgame
Ipê-Solar + Pluma Sagrada + mel + Aurita. **Serve:** cura completa do time **e revive todos os Forgelings caídos**. **Liga com:** §22, §117. **Por quê:** o consumível definitivo precisa existir, ser caríssimo e mudar o resultado de uma luta impossível.

---

## 4.2 Poções e Alquimia

**321 · Poção de Cura (3 tiers)** — Poção · Comum→Raro · Todos
Menor / Média / Maior. **Obtém:** Alambique + ervas. **Serve:** cura instantânea do jogador. **Liga com:** §11.1. **Por quê:** o GDD já cita "itens de cura"; esta é a linha canônica.

**322 · Elixir de Forgeling (3 tiers)** — Poção · Comum→Raro · Todos
A mesma linha, mas para a criatura. **Liga com:** §22. **Por quê:** manter as duas linhas separadas impede que uma poção resolva tudo.

**323 · Antídoto** — Poção · Comum · Início
**Obtém:** Lírio-do-Brejo. **Serve:** remove veneno. **Liga com:** Debuffs. **Por quê:** cada debuff merece uma cura específica e barata.

**324 · Unguento de Queimadura / Descongelante / Tônico de Clareza** — Poções · Comum · Meio
Curas específicas para queimadura, congelamento e confusão. **Liga com:** Debuffs. **Por quê:** especificidade força o jogador a montar um kit, e montar kit é gameplay.

**325 · Poção de Fôlego** — Poção · Comum · Meio
**Obtém:** Cogumelo Azul. **Serve:** mergulho longo. **Liga com:** Cobalto Abissal. **Por quê:** portão consumível é mais barato que portão de equipamento para conteúdo intermediário.

**326 · Poção de Queda Lenta** — Poção · Comum · Meio
**Obtém:** pena + folha-de-vento. **Serve:** descer buracos sem morrer. **Liga com:** side view. **Por quê:** em um jogo vertical, cair é rotina; sobreviver à queda é conforto.

**327 · Poção de Visão Noturna** — Poção · Comum · Meio
**Obtém:** cenoura + musgo. **Serve:** enxergar sem luz. **Liga com:** Illuminate. **Por quê:** dá alternativa a quem não tem o Forgeling de luz.

**328 · Poção de Atravessar** — Poção · Raro · Fim
**Obtém:** Ectoplasma. **Serve:** passar por grades e paredes finas por 5s. **Liga com:** Segredos, Ruínas. **Por quê:** habilita uma camada inteira de segredos sem precisar de chaves.

**329 · Poção do Coletor** — Poção · Incomum · Meio
**Serve:** +rendimento de coleta por 10 min. **Liga com:** Economia. **Por quê:** consumível de eficiência é o que o jogador usa em sessão de farm.

**330 · Poção do Domador** — Poção · Raro · Fim
**Obtém:** Papoula + Essência. **Serve:** **+40% na chance de captura** por 2 min. **Liga com:** §8. **Por quê:** dá ao jogador um recurso gastável para o momento em que o bicho dos sonhos aparece.

**331 · Poção de Repelência** — Poção · Comum · Meio
**Serve:** selvagens de nível baixo não atacam. **Liga com:** §26.1 `aggressive`. **Por quê:** atravessar uma área já dominada não deveria custar tempo.

**332 · Poção de Atração** — Poção · Comum · Meio
O inverso; aumenta encontros. **Liga com:** §26.3. **Por quê:** quem está caçando quer *mais* encontros, não menos.

**333 · Poção de Rastreamento** — Poção · Incomum · Meio
Mostra Forgelings raros no minimapa por 5 min. **Liga com:** QoL, §8. **Por quê:** procurar um bicho raro às cegas é a pior parte de creature collectors.

**334 · Óleo de Lâmina (×6 elementos)** — Consumível · Incomum · Meio
Aplica um tipo à arma por 3 min. **Liga com:** §20. **Por quê:** dá a *qualquer* profissão acesso temporário à tabela de tipos sem forjar arma nova.

**335 · Veneno de Contato** — Consumível · Incomum · Meio
Aplicado à arma; DoT no alvo. **Liga com:** Mercenário, Glândula. **Por quê:** DoT é a forma mais barata de dar profundidade tática ao corpo a corpo.

**336 · Frasco Incendiário / Congelante / Corrosivo** — Consumível arremessável · Incomum · Meio
**Liga com:** Engenheiro, §20. **Por quê:** dá arremesso a quem não é Engenheiro, com eficiência menor.

**337 · Pó de Cegueira** — Consumível · Comum · Meio
Reduz o `sight` do inimigo (§26.1). **Liga com:** furtividade. **Por quê:** mexer diretamente num parâmetro do GDD é design elegante e barato.

**338 · Bomba de Teia** — Consumível · Incomum · Meio
Imobiliza em área. **Liga com:** Captura, Engenheiro. **Por quê:** controle de multidão é o que salva o jogador quando o time cai (§22).

**339 · Elixir de Reroll de Natureza** — Poção · Épico · Endgame
Sorteia uma nova natureza para o Forgeling. **Obtém:** Pó de Estrela + Essência. **Serve:** otimização de topo. **Liga com:** §27.3 (que prevê "item raro" exatamente para isso). **Por quê:** o GDD já abriu a porta; esta é a chave, cara o bastante para não banalizar.

**340 · Elixir de Espelho de IV** — Poção · Lendário · Endgame
Copia os IVs de um Forgeling para outro da **mesma espécie**, sacrificando o doador. **Liga com:** §27.4. **Por quê:** respeita "IVs nunca mudam" ao nível da instância, mas dá ao criador dedicado um caminho — com custo emocional real.

**341 · Incenso Elemental (×6)** — Consumível de base · Incomum · Meio
Queimado no Recinto; influencia o tipo dos ovos gerados. **Liga com:** §29.5, Incubadora. **Por quê:** criação com direcionamento parcial é o ponto doce entre controle e surpresa.

---

## 4.3 Buffs e Debuffs — Catálogo de Status

**342 · Queimadura** — Debuff · — · Todos
Dano ao longo do tempo; **anulada por água ou chuva** (§13). **Liga com:** Fogo, Clima. **Por quê:** status que interagem com o ambiente fazem o mundo parecer coerente.

**343 · Congelamento** — Debuff · — · Todos
−SPEED severo; quebra ao receber dano de Fogo. **Liga com:** §20. **Por quê:** contra-jogo claro entre elementos opostos.

**344 · Encharcado** — Debuff · — · Todos
+dano recebido de gelo, −resistência a frio; aplicado por chuva e água. **Liga com:** §13. **Por quê:** dá à chuva uma consequência tática de verdade.

**345 · Enraizado** — Debuff · — · Todos
Não pode se mover, pode atacar. **Liga com:** Terra. **Por quê:** no ForgelingView (§22) o movimento é tudo; travá-lo é a ameaça mais real possível.

**346 · Vendaval** — Debuff · — · Todos
Empurra o alvo constantemente; atrapalha mira. **Liga com:** Ar, Caçador. **Por quê:** cada elemento merece um status assinatura.

**347 · Maldição** — Debuff · — · Fim
Cura recebida reduzida em 50%. **Liga com:** Sombrio. **Por quê:** anti-sustain é o que torna chefes Sombrios genuinamente ameaçadores.

**348 · Ofuscado** — Debuff · — · Fim
−precisão e visão reduzida. **Liga com:** Sagrado. **Por quê:** o Sagrado precisa ser desconfortável de enfrentar, não só forte.

**349 · Envenenado / Corroído / Sangrando** — Debuffs · — · Todos
DoTs de intensidades e fontes diferentes; corroído também **destrói durabilidade**. **Liga com:** Durabilidade, Cinábrio. **Por quê:** um debuff que ataca o equipamento e não a vida assusta de um jeito novo.

**350 · Medo** — Debuff · — · Fim
O Forgeling se recusa a atacar por alguns segundos. **Liga com:** §17 IA, Chefes. **Por quê:** perder o controle da criatura é a punição mais temática possível neste jogo.

**351 · Exaustão** — Debuff · — · Todos
Cooldowns 50% mais longos; causado por não dormir e por excesso de esforço. **Liga com:** §11.1 Cama. **Por quê:** dá à cama uma segunda razão de existir além da cura.

**352 · Sortudo / Focado / Enfurecido / Protegido / Acelerado** — Buffs · — · Todos
A família positiva padrão: +drop, +crítico, +ATK, +defesa, +speed. **Liga com:** §27.5, §20.7. **Por quê:** buffs precisam mapear exatamente os três stats do GDD, sem inventar um quarto eixo.

**353 · Ressonância Elemental** — Buff · — · Fim
Quando jogador e Forgeling usam equipamento do mesmo tipo, ambos ganham +10%. **Liga com:** §20.7, Conjuntos Elementais. **Por quê:** recompensa o jogador por *coordenar* sua build com a da criatura — exatamente a fantasia central do jogo.

**354 · Vínculo Profundo** — Buff · — · Endgame
Acumula enquanto um Forgeling específico permanece ativo sem ser derrotado; até +15%. Zera ao cair. **Liga com:** §22, teto de nível. **Por quê:** dá uma progressão *dentro da sessão* que o teto de nível 10 não permite, sem quebrar a regra.

---

## 4.4 Agricultura, Pecuária e Pesca

**355 · Qualidade de Cultivo** — Sistema · — · Meio
Toda colheita sai como Comum / Boa / Excelente, conforme solo, irrigação e fertilizante. **Liga com:** Culinária, Comércio. **Por quê:** dá teto alto para o fazendeiro dedicado sem adicionar culturas novas.

**356 · Estações do Ano** — Sistema · — · Todos
Quatro estações que alteram o que cresce, o clima e o spawn. **Liga com:** §13, Biomas. **Por quê:** transforma o calendário em conteúdo cíclico e dá ritmo ao ano de jogo.

**357 · Rotação e Exaustão de Solo** — Sistema · — · Meio
Plantar o mesmo item repetidamente reduz o rendimento. **Liga com:** Compostora, Fertilizante. **Por quê:** impede a monocultura ótima e obriga variedade — variedade é conteúdo visto.

**358 · Enxertia** — Sistema · — · Fim
Cruzar duas culturas gera variantes híbridas com efeitos novos. **Liga com:** Culinária, Alquimia. **Por quê:** conteúdo combinatório que os jogadores descobrem e documentam entre si.

**359 · Animais domesticáveis** — Criaturas · Comum · Meio
Galinha (ovos), Vaca (leite), Ovelha (lã), Porco (trufa!), Cabra (leite, sobe rochas), Pato (pena, nada). **Obtém:** capturar filhotes ou comprar. **Liga com:** Pecuária, Trufa. **Por quê:** animais não-Forgelings dão ao mundo camada de normalidade e à base uma economia doméstica.

**360 · Peixes por bioma** — Colecionáveis · Comum→Lendário · Todos
~40 espécies: Truta, Carpa, Bagre, Perca, Enguia, Piranha, Peixe-Lâmina, Peixe-Lanterna (caverna), Arraia-de-Areia (deserto!), Peixe-Fantasma (ruínas à noite), Salmão-Aurora, Enguia-Abissal, Peixe-Magma (lava, com vara de obsidiana). **Liga com:** Aquário, Culinária, Museu. **Por quê:** a pesca é a atividade "calma" que segura o jogador entre expedições, e cada peixe raro é uma micro-conquista.

**361 · Iscas** — Consumível · Comum · Todos
Minhoca, inseto, âmbar, isca elemental. Cada uma altera a tabela de peixes. **Liga com:** Rede de Mão, Âmbar. **Por quê:** dá controle sobre a aleatoriedade da pesca.

**362 · Tesouros de Pesca** — Loot · Incomum · Todos
Garrafas com mapa, baús submersos, relíquias, lixo (reciclável). **Liga com:** Mapas do tesouro. **Por quê:** a chance de fisgar algo que não é peixe é o que mantém a pesca emocionante.

**363 · Pesca no Gelo / na Lava / na Chuva** — Variações · Incomum→Raro · Meio
Cada condição abre uma tabela própria. **Liga com:** §13, Biomas. **Por quê:** multiplica o conteúdo de pesca sem multiplicar o sistema.

**364 · Forgelings pescáveis** — Mecânica · Raro · Fim
Algumas espécies aquáticas só aparecem **fisgadas**, nunca no mundo. **Liga com:** §8, coleção. **Por quê:** conecta duas atividades que normalmente vivem separadas, e dá à pesca um propósito para o colecionador.

---
---

# RODADA 5 — O Mundo: Biomas, Estruturas, Dungeons e Criaturas

*O GDD lista nove biomas em uma linha cada (§12). Aqui cada um vira um lugar.*

---

## 5.1 Sub-biomas e Regiões

**365 · Clareira dos Iniciantes** — Sub-bioma · — · Início
Floresta rala, sem hostis agressivos, com Forgelings de nível 1–2 e recursos básicos. **Serve:** o berço. **Liga com:** §26.3 (spawner `aggressive: false`). **Por quê:** todo mundo precisa de um lugar onde não morre — é lá que ele aprende a gostar do jogo.

**366 · Floresta Profunda** — Sub-bioma · — · Meio
Copa fechada, escuridão diurna, Forgelings de Terra e Sombrio. **Liga com:** Illuminate. **Por quê:** dá à Skill de luz um uso fora da caverna.

**367 · Bosque Encantado** — Sub-bioma · — · Meio
Cogumelos gigantes bioluminescentes, Forgelings de Ar raros. **Liga com:** Flora, Colecionáveis. **Por quê:** todo mundo precisa de um lugar que só existe para ser bonito.

**368 · Dunas Cantantes** — Sub-bioma (Deserto) · — · Meio
A areia emite som; segui-lo leva a ruínas soterradas. **Liga com:** Veio de Eco, Segredos. **Por quê:** navegação por som é uma pista de exploração que quase nenhum jogo 2D usa.

**369 · Oásis** — Sub-bioma (Deserto) · — · Meio
Água, palmeiras, um NPC comerciante nômade. **Liga com:** Comércio. **Por quê:** alívio no meio do bioma mais punitivo é ritmo de design.

**370 · Mar de Sal** — Sub-bioma (Deserto) · — · Meio
Planície branca ofuscante; sal-gema em abundância; miragens que escondem entradas. **Liga com:** Sal, Segredos. **Por quê:** miragem é um puzzle visual perfeito para pixel art.

**371 · Tundra Congelada** — Sub-bioma (Neve) · — · Meio
Vento constante que empurra o jogador. **Liga com:** Vendaval, Traje Térmico. **Por quê:** um bioma cuja física atrapalha dá identidade sem inimigos novos.

**372 · Cavernas de Gelo** — Sub-bioma · — · Meio
Piso escorregadio, Gelo Perene, ecos. **Liga com:** Gelo Perene. **Por quê:** física alterada é conteúdo de movimentação, que é o que o side view faz melhor.

**373 · Aurora Boreal** — Fenômeno (Neve) · — · Fim
Ocorre em noites limpas; enquanto dura, Forgelings **Sagrados** aparecem na Neve. **Liga com:** §20.6, Clima. **Por quê:** dá uma rota previsível e memorável para a criatura Sagrada que a progressão exige.

**374 · Manguezal** — Sub-bioma (Pântano) · — · Meio
Raízes labirínticas, maré que sobe e desce. **Liga com:** Surf, ciclo de maré. **Por quê:** maré cria conteúdo que muda de forma ao longo do dia sem custo de conteúdo novo.

**375 · Pântano Ácido** — Sub-bioma · — · Fim
Poças que corroem equipamento. **Liga com:** Corroído, Máscara de Filtro. **Por quê:** ameaça ao equipamento, não à vida — uma pressão diferente.

**376 · Campos de Lava** — Sub-bioma (Vulcão) · — · Fim
Rios de lava, obsidiana, Núcleos de Magma. **Liga com:** Freeze, Obsidiana. **Por quê:** o bioma onde duas Skills combinadas viram um recurso.

**377 · Caldeira** — Sub-bioma (Vulcão) · — · Fim
Arena natural no topo do vulcão; palco de chefe. **Liga com:** Chefes. **Por quê:** chefes merecem cenários que já parecem arena antes de a luta começar.

**378 · Fontes Termais** — Sub-bioma · — · Meio
Regeneram vida do jogador e do time lentamente. Enxofre por perto. **Liga com:** §11.1 (alternativa em campo à cama). **Por quê:** um "acampamento natural" recompensa quem explora longe da base.

**379 · Picos Ventosos** — Sub-bioma (Montanha) · — · Fim
Só acessível com *Climb* ou *Fly*. Topázio, Aurita, ninhos. **Liga com:** Climb, Fly. **Por quê:** dá às Skills de mobilidade uma recompensa de topo, não só um atalho.

**380 · Ruínas Submersas** — Sub-bioma · — · Fim
Cidade antiga no fundo do mar. **Liga com:** Swim, Traje de Mergulho. **Por quê:** o oceano precisa de arquitetura para não virar tela azul.

**381 · Arquipélago Errante** — Sub-bioma (Ilhas) · — · Fim
Ilhas que mudam de posição a cada ciclo lunar. **Liga com:** Navegação, Mapas. **Por quê:** um pedaço do mundo que se recusa a ser memorizado mantém a exploração viva no endgame.

**382 · Terra Corrompida** — Sub-bioma · — · Endgame
Mancha Sombria que **cresce** se não for contida. Flora e fauna corrompidas. **Liga com:** §20.3, Purificação. **Por quê:** um bioma que avança dá ao mundo um antagonista sem precisar de vilão.

**383 · Santuário Selado** — Sub-bioma · — · Endgame
Enclaves Sagrados no alto das montanhas, atrás de puzzles. **Liga com:** Aurita, §20.6. **Por quê:** o contrapeso da Terra Corrompida e a fonte da chave anti-Sombrio.

**384 · O Abismo** — Camada · — · Endgame
A camada mais profunda do mundo, abaixo de tudo. Escuridão que apaga tochas. Adamas. **Liga com:** Illuminate, endgame. **Por quê:** em um jogo de perfil, "quão fundo você consegue ir" é a pergunta que move o jogador.

---

## 5.2 Estruturas Geradas

**385 · Acampamento Abandonado** — Estrutura · Comum · Início
Fogueira apagada, um baú, uma nota. **Serve:** loot inicial e lore. **Por quê:** contar história pelo cenário é mais barato e mais eficaz que diálogo.

**386 · Mina Abandonada** — Estrutura · Comum · Início
Túneis com trilhos, vigas podres e minério exposto. **Liga com:** Vagonete. **Por quê:** dá ao jogador um "dungeon zero" sem chefe nem chave.

**387 · Torre do Eremita** — Estrutura · Incomum · Meio
Um NPC solitário com receitas exclusivas. **Liga com:** NPCs. **Por quê:** premiar exploração com um professor é mais valioso que premiar com um baú.

**388 · Vila** — Estrutura · Comum · Início
Comerciantes, quests, ferreiro, fazendeiro. **Liga com:** §21, Economia. **Por quê:** o hub social precisa existir mesmo em solo.

**389 · Posto Avançado de Facção** — Estrutura · Incomum · Meio
Base de uma facção inimiga (§ Elevator Pitch cita facções). **Liga com:** Facções. **Por quê:** o pitch promete facções; elas precisam de endereço.

**390 · Círculo de Pedras** — Estrutura · Incomum · Meio
Monólitos; ativados na ordem certa, abrem um cofre. **Liga com:** Puzzles. **Por quê:** puzzle ambiental sem chave nem texto.

**391 · Biblioteca Soterrada** — Estrutura · Raro · Fim
Estantes com receitas perdidas e lore do mundo. **Liga com:** Receitas, Lore. **Por quê:** dá ao jogador a sensação de estar recuperando conhecimento, não só itens.

**392 · Ninho de Forgeling Alfa** — Estrutura · Raro · Fim
Um selvagem muito acima do nível da área, com ovos ao redor. **Liga com:** §26.3, Ovos. **Por quê:** perigo opcional e visível é a melhor forma de tentar o jogador.

**393 · Cristal de Ressonância** — Estrutura · Incomum · Meio
Ao ser tocado com o Forgeling certo, revela um caminho. **Liga com:** §20, Skills. **Por quê:** puzzles que só a criatura certa resolve reforçam o valor da coleção.

**394 · Naufrágio** — Estrutura · Incomum · Meio
Casco encalhado ou submerso, com carga. **Liga com:** Swim, Navegação. **Por quê:** loot com contexto é sempre mais gostoso.

**395 · Cemitério Antigo** — Estrutura · Incomum · Meio
Espectros à noite, Ectoplasma, Erva-Sangue. **Liga com:** Ectoplasma. **Por quê:** um lugar que muda completamente de perigo entre dia e noite dobra seu conteúdo.

**396 · Coliseu em Ruínas** — Estrutura · Raro · Fim
Arena que pode ser reativada para desafios em ondas. **Liga com:** Desafios, §19. **Por quê:** conteúdo repetível de combate sem precisar de novo mapa.

**397 · Farol Quebrado** — Estrutura · Incomum · Meio
Restaurá-lo revela o mapa da costa e reduz naufrágios. **Liga com:** Navegação, QoL. **Por quê:** restaurar estruturas do mundo é progressão que muda o mapa de todos na sala.

**398 · Portal Selado** — Estrutura · Épico · Endgame
Precisa das seis Essências para abrir. Leva ao Abismo. **Liga com:** §20, endgame. **Por quê:** o portão final deve exigir que o jogador tenha visitado o mundo inteiro.

**399 · Casa da Árvore Vazia** — Estrutura · Incomum · Meio
Uma Árvore-Oca (§53) já mobiliada e abandonada; o jogador pode reivindicá-la. **Liga com:** Base. **Por quê:** dar ao jogador uma segunda casa pronta longe da primeira incentiva bases satélite.

---

## 5.3 Dungeons

*Formato proposto: cada dungeon tem uma **Skill-chave**, um **puzzle recorrente**, um **inimigo assinatura**, um **chefe** e um **drop exclusivo**. Cinco peças, muito conteúdo.*

**400 · Toca das Raízes** — Dungeon · Início
**Chave:** *Dig*. **Puzzle:** desobstruir passagens. **Chefe:** Verme-Mãe. **Drop:** primeira gema elemental de Terra. **Por quê:** ensina que Skills abrem caminho, sem risco de morte alta.

**401 · Mina Inundada** — Dungeon · Meio
**Chave:** *Swim* + bomba d'água. **Puzzle:** drenar níveis para revelar andares. **Chefe:** Sanguessuga Colossal. **Drop:** Safira Marinha. **Por quê:** o nível de água muda o mapa — mesma dungeon, três layouts.

**402 · Cripta de Ecos** — Dungeon · Meio
**Chave:** *Illuminate*. **Puzzle:** repetir melodias com Veios de Eco. **Chefe:** Coro Silente. **Drop:** disco de música raro. **Por quê:** puzzle sonoro é uma textura totalmente diferente das outras dungeons.

**403 · Forja Esquecida** — Dungeon · Fim
**Chave:** *Ignite*. **Puzzle:** reacender fornalhas na ordem certa. **Chefe:** Autômato Ferrugem. **Drop:** receita de Forgita. **Por quê:** premia o jogador com a chave do material assinatura do jogo.

**404 · Ninho nas Nuvens** — Dungeon · Fim
**Chave:** *Fly* ou *Climb*. **Puzzle:** correntes de vento que carregam plataformas. **Chefe:** Rainha das Plumas. **Drop:** Topázio Ventoso, Sela. **Por quê:** verticalidade extrema é a coisa mais divertida que um jogo 2D pode fazer.

**405 · Coração do Vulcão** — Dungeon · Fim
**Chave:** *Freeze*. **Puzzle:** congelar lava para criar plataformas — que derretem. **Chefe:** Salamandra Primordial. **Drop:** Núcleo de Magma. **Por quê:** plataformas temporárias criam tensão de tempo real sem cronômetro na tela.

**406 · Catedral Afogada** — Dungeon · Fim
**Chave:** *Surf* + fôlego. **Puzzle:** bolsões de ar e correntes. **Chefe:** Guardião de Coral. **Drop:** Traje de Mergulho aprimorado. **Por quê:** dungeon com recurso de sobrevivência (ar) tem tensão embutida.

**407 · Labirinto de Espelhos** — Dungeon · Fim
**Chave:** Prata Lunar. **Puzzle:** desviar feixes de luz. **Chefe:** Reflexo (copia o Forgeling do jogador). **Drop:** Diamante Aurora. **Por quê:** um chefe que copia a *sua* build é o teste definitivo de conhecimento do próprio kit.

**408 · O Descenso** — Dungeon · Endgame
**Chave:** luz Sagrada permanente. **Puzzle:** a escuridão apaga fontes de luz progressivamente. **Chefe:** Devorador de Aurora. **Drop:** Adamas Sombrio. **Por quê:** recurso escasso (luz) é o melhor gerador de tensão que existe.

**409 · Dungeons Rotativas** — Sistema · Endgame
Uma dungeon procedural semanal com modificadores (ex.: "todos os inimigos são de Ar", "sem itens de cura"). **Liga com:** Endgame, §19. **Por quê:** conteúdo infinito a partir de peças já construídas; é o que segura a comunidade entre atualizações.

---

## 5.4 Fauna Comum (não-Forgelings)

**410 · Coelho, Veado, Javali, Lobo, Urso, Raposa** — Fauna terrestre · Comum · Início–Meio
Carne, couro, pelo, gordura, tendão. Alguns hostis. **Por quê:** o mundo precisa de vida que não seja capturável, senão tudo vira cápsula.

**411 · Corvo, Falcão, Coruja, Gaivota** — Fauna aérea · Comum · Todos
Pena; o corvo **rouba itens do chão**. **Por quê:** um bicho irritante e inofensivo dá personalidade ao mundo.

**412 · Morcego, Aranha, Escorpião, Centopeia** — Fauna de caverna · Comum · Início–Meio
Teia, glândula de veneno. **Por quê:** povoar a caverna com bichinhos hostis mantém a mineração tensa.

**413 · Caranguejo, Tartaruga, Golfinho, Tubarão** — Fauna aquática · Comum → Incomum · Meio
Casco, óleo; o golfinho **guia o jogador até naufrágios**. **Por quê:** fauna que ajuda cria momentos que os jogadores contam para os amigos.

**414 · Vagalume, Borboleta, Besouro, Libélula, Louva-a-deus** — Insetos · Comum→Raro · Todos
Colecionáveis, isca, corante. **Por quê:** colecionar insetos é um vício comprovado do gênero.

**415 · Lesma de Sal, Tatu de Pedra, Camaleão de Areia** — Fauna de bioma · Incomum · Meio
Materiais específicos; o camaleão é quase invisível. **Por quê:** fauna com truque visual recompensa o jogador atento.

---

## 5.5 Monstros e Facções

**416 · Saqueadores** — Facção · Início–Meio
Humanos hostis: batedor, arqueiro, bruto, capataz. Acampamentos com baús. **Liga com:** §389, facções do pitch. **Por quê:** inimigos humanoides dropam equipamento usável — a economia de loot mais satisfatória.

**417 · Culto do Véu** — Facção · Fim
Cultistas Sombrios que **espalham a Terra Corrompida**. Acólito, arauto, sacerdote. **Liga com:** §382, §20.3. **Por quê:** dá autoria à corrupção; um mundo que piora sozinho é menos interessante que um mundo que alguém está piorando.

**418 · Ordem da Aurora** — Facção · Fim
Sagrados fanáticos: aliados úteis, mas hostis a quem carrega equipamento corrompido. **Liga com:** §213. **Por quê:** uma facção que reage às *escolhas* do jogador cria consequência sem sistema de moral.

**419 · Autômatos Antigos** — Monstros · Fim
Guardiões mecânicos das Ruínas. Imunes a veneno, fracos a corrosão. **Liga com:** Debuffs. **Por quê:** inimigos com imunidades ensinam o jogador a diversificar o kit.

**420 · Espectros** — Monstros · Meio–Fim
Só aparecem à noite e em cemitérios; atravessam paredes. **Liga com:** Ectoplasma. **Por quê:** um inimigo que ignora suas defesas físicas força adaptação.

**421 · Golens (Pedra, Magma, Gelo, Cristal)** — Monstros · Meio–Fim
Lentos, muita vida, área. Dropam blocos e gemas. **Por quê:** inimigos-recurso dão razão para lutar mesmo com o inventário cheio.

**422 · Enxames** — Monstros · Meio
Nuvens de insetos, morcegos ou peixes que agem como uma unidade. **Liga com:** Dano em área. **Por quê:** força o jogador a equipar Skills de área, diversificando o loadout de §24.

**423 · Corrompidos** — Monstros · Endgame
Versões Sombrias de fauna e Forgelings comuns, encontradas na Terra Corrompida. **Liga com:** §382, Cápsula da Redenção. **Por quê:** reaproveitar arte com paleta nova é o truque mais eficiente do gênero, e narrativamente arrepiante.

---

## 5.6 Forgelings — Linhas de Espécies Sugeridas

*Amostra de 24 linhas, quatro por elemento, respeitando §23 (2–4 evoluções) e o teto de nível 10.*

**424 · Gotalha → Marulho → Maremoto** — Água · Comum · Início
Melee. Skill: *Surf*. **Por quê:** o starter de Água precisa destravar travessia cedo.

**425 · Cardume → Vórtice** — Água · Incomum · Meio
Range, enxame. Skill: *Swim*. **Por quê:** uma criatura que é várias é visualmente distinta em pixel art.

**426 · Orvalim → Nevoeira → Dilúvia** — Água · Raro · Fim
Range, suporte, cura. Skill: *Illuminate* (fosforescência). **Por quê:** o time precisa de um curandeiro, já que a troca é travada (§22).

**427 · Concha-Vigia → Fortaleza-Nácar** — Água · Incomum · Meio
Melee, tanque. Skill: *Push*. **Por quê:** tanques dão ao jogador conservador uma resposta.

**428 · Fagulho → Braseiro → Incêndio** — Fogo · Comum · Início
Melee, alto ATK, baixo LIFE. Skill: *Ignite*. **Por quê:** o starter agressivo, para quem quer bater.

**429 · Pavescente → Fênix-Cinza** — Fogo · Raro · Fim
Range, voa. Skill: *Fly*. **Habilidade:** revive uma vez por dia de jogo. **Liga com:** §22, §117. **Por quê:** dá acesso mais barato ao auto-revive, tornando-o mecânica em vez de item lendário.

**430 · Carvãozinho → Antracito → Vulcanídeo** — Fogo · Incomum · Meio
Melee, tanque de Fogo. Skill: *Mine*. **Por quê:** amarra a criatura de fogo à mineração — sinergia temática linda.

**431 · Lamparim → Fogaréu-Andarilho** — Fogo · Incomum · Meio
Suporte, luz permanente. Skill: *Illuminate*. **Por quê:** a lanterna viva é um dos companheiros mais úteis que um jogo de caverna pode ter.

**432 · Torrãozinho → Rochedo → Monolito** — Terra · Comum · Início
Melee, muito LIFE, pouca SPEED. Skill: *Rock Smash*. **Por quê:** o starter defensivo fecha o trio de arquétipos iniciais.

**433 · Toupim → Escavarrão** — Terra · Comum · Início
Skill: *Dig*. **Habilidade:** fareja Trufas e tesouros enterrados. **Liga com:** §91. **Por quê:** dá ao jogador um "cão farejador" — uma das companhias mais queridas do gênero.

**434 · Semente-Viva → Arbusto-Andante → Guardião-Sequoia** — Terra · Raro · Fim
Melee, cura passiva do time. Skill: *Lumberjack*. **Por quê:** uma árvore que corta árvores é a ironia certa e um tanque-suporte útil.

**435 · Cristalino → Prismarca** — Terra · Raro · Fim
Range, reflete projéteis. Skill: *Carry*. **Por quê:** carregar carga pesada é logística; o jogador vai amar.

**436 · Brisél → Ventania → Ciclone** — Ar · Comum · Início
Range, alta SPEED. Skill: *Fly*. **Por quê:** o starter de mobilidade abre o mapa mais rápido.

**437 · Plumilo → Falcônido → Tempestário** — Ar · Incomum · Meio
Range, crítico alto. Skill: *Climb*. **Por quê:** a criatura de precisão é a favorita natural do Caçador.

**438 · Ecoante → Reverbério** — Ar · Raro · Fim
Suporte, debuffs sonoros. Skill: — (interage com Veios de Eco). **Por quê:** uma criatura que resolve puzzles em vez de lutar amplia o conceito de "útil".

**439 · Poeirinho → Simum → Djinn-de-Areia** — Ar · Incomum · Meio
Range, cega inimigos. Skill: *Dig*. **Por quê:** vento e areia no deserto, com uma Skill inesperada.

**440 · Sombrinho → Espreitante → Devorador** — Sombrio · Incomum · Meio
Melee, roubo de vida. Skill: *Push*. **Por quê:** o primeiro Sombrio precisa aparecer cedo o bastante para o jogador entender a parede de 25%.

**441 · Fiapo-de-Noite → Manto-Sem-Rosto** — Sombrio · Raro · Fim
Furtivo, invisível parado. Skill: — (passa por grades). **Por quê:** dá ao jogador uma criatura de infiltração, um estilo de jogo inteiro.

**442 · Presságio → Corvo-Fim** — Sombrio · Épico · Fim
Range, maldição. Skill: *Fly*. **Por quê:** o Sombrio voador é um dos encontros mais assustadores possíveis.

**443 · Ancoradiço → Naufragante** — Sombrio · Raro · Fim
Aquático, arrasta para o fundo. Skill: *Swim*. **Por quê:** o terror do oceano profundo, que o Traje de Mergulho torna acessível.

**444 · Lumezinho → Serafim-Menor → Arauto** — Sagrado · Raro · Fim
Suporte/cura, o **contrapeso obrigatório** ao Sombrio. **Obtém:** Aurora Boreal, quest, ovo. **Liga com:** §20.6, §29.7. **Por quê:** o GDD identificou que o jogador *precisa* de acesso garantido a um Sagrado; esta é a espécie que cumpre isso.

**445 · Campânula → Carrilhão-Sacro** — Sagrado · Épico · Fim
Range, dano em área contra Sombrios. Skill: *Illuminate*. **Por quê:** a resposta anti-Terra-Corrompida.

**446 · Ovelhinha-de-Luz → Pastor-Áureo** — Sagrado · Incomum · Meio
Tanque-suporte; protege o resto do time. **Por quê:** um Sagrado *defensivo* contraria a leitura de "glass cannon" e ensina que o tipo não define o papel.

**447 · Aurorélia** — Sagrado · Lendário · Endgame
Forma única, não evolui. Aparece uma vez por ciclo lunar em um santuário aleatório. **Por quê:** o jogo precisa de uma criatura lendária que vire lenda entre os jogadores.

**448 · Variantes Cromáticas (shiny)** — Sistema · Lendário · Todos
1 em ~2000; paleta alternativa, sem vantagem de stats. **Liga com:** coleção, status. **Por quê:** raridade puramente cosmética é o motor de coleção mais poderoso já inventado.

**449 · Variantes de Bioma** — Sistema · Incomum · Todos
A mesma espécie pode ter **tipo diferente** conforme o bioma de origem (ex.: Torrãozinho do Vulcão é Fogo). **Liga com:** §20, §26.3. **Por quê:** multiplica o roster sem multiplicar o trabalho de design de espécie.

**450 · Forgelings Alfa** — Sistema · Raro · Fim
Versões maiores, com nível acima da área, aura visível e IVs garantidos altos. **Liga com:** §26.3, §27.4. **Por quê:** dá ao mundo aberto encontros com peso de mini-chefe.

---

## 5.7 Chefes

*O GDD adia os chefes para "versões futuras" (§18). Proposta: **um chefe por bioma**, mais três de endgame, com estrutura fixa — arena própria, três fases, um drop exclusivo, uma receita.*

**451 · Verme-Mãe** — Chefe (Toca das Raízes) · Início · Terra
Escava e emerge; a arena desaba em fases. **Drop:** Esmeralda Telúrica, casco. **Por quê:** o primeiro chefe deve ensinar leitura de telegrafia, não punir build.

**452 · Sanguessuga Colossal** — Chefe (Mina Inundada) · Meio · Água
Rouba vida do Forgeling; o nível da água sobe por fase. **Drop:** Safira. **Por quê:** ensina que o cenário é parte da luta.

**453 · Coro Silente** — Chefe (Cripta de Ecos) · Meio · Sombrio
Três corpos que precisam morrer quase juntos. **Drop:** Ônix Nulo. **Por quê:** o primeiro chefe Sombrio é a hora exata de o jogador sentir a parede dos 25% (§20.6) — e ele já deve ter um Sagrado.

**454 · Autômato Ferrugem** — Chefe (Forja Esquecida) · Fim · Terra/Fogo
Blindado; só é ferido por corrosão ou por partes expostas. **Drop:** receita de Forgita. **Por quê:** um chefe que exige o item certo valida todo o sistema de status.

**455 · Rainha das Plumas** — Chefe (Ninho nas Nuvens) · Fim · Ar
Luta aérea sobre plataformas móveis; empurra o Forgeling para fora. **Drop:** Sela, Topázio. **Por quê:** a única luta do jogo onde cair é o maior perigo.

**456 · Salamandra Primordial** — Chefe (Caldeira) · Fim · Fogo
O chão vira lava progressivamente; exige *Freeze*. **Drop:** Núcleo de Magma. **Por quê:** obriga o jogador a levar a criatura certa — a decisão pré-luta que §22 tornou irreversível.

**457 · Guardião de Coral** — Chefe (Catedral Afogada) · Fim · Água
Luta subaquática com fôlego limitado. **Drop:** Coral Vivo puro. **Por quê:** um recurso de sobrevivência como cronômetro é melhor que um cronômetro na tela.

**458 · Reflexo** — Chefe (Labirinto de Espelhos) · Fim · Neutro
Copia o Forgeling ativo do jogador, com os mesmos ataques. **Drop:** Diamante Aurora. **Por quê:** o chefe que testa se você entende sua própria build; conteúdo diferente para cada jogador, de graça.

**459 · Colosso de Sal** — Chefe (Mar de Sal) · Meio · Terra
Regenera enquanto houver sal no chão; o jogador precisa "limpar" a arena. **Drop:** Sal Puro. **Por quê:** um chefe cuja mecânica é gerenciar o ambiente, não desviar.

**460 · Barão do Pântano** — Chefe (Pântano) · Meio · Sombrio/Terra
Invoca lacaios e envenena a arena. **Drop:** Glândula Suprema. **Por quê:** luta de gerenciamento de adds, um arquétipo que faltava.

**461 · Sentinela de Gelo** — Chefe (Cavernas de Gelo) · Meio · Água
Congela o Forgeling periodicamente; o jogador precisa quebrá-lo com Fogo. **Drop:** Gelo Perene puro. **Por quê:** obriga o time misto, ensinando composição.

**462 · Devorador de Aurora** — Chefe (O Descenso) · Endgame · Sombrio
Apaga toda luz da arena em fases; sem luz, o jogador não vê os telegrafados. **Drop:** Adamas puro. **Por quê:** o clímax do eixo moral, e a razão final de existir uma criatura Sagrada.

**463 · Arquiteto Prismático** — Chefe secreto · Endgame · Muda de tipo
Troca de elemento a cada fase, percorrendo os seis. **Obtém:** Altar Prismático + Núcleo. **Drop:** Núcleo Prismático refinado. **Por quê:** o exame final da tabela §20.4: o jogador precisa do time inteiro pensado.

**464 · A Mancha** — Chefe de mundo · Endgame · Sombrio
Não fica numa arena: é a Terra Corrompida ganhando um corpo quando cresce demais. Toda a sala precisa lutar. **Liga com:** §19, §382. **Por quê:** um chefe que aparece por *negligência* dos jogadores é a coisa mais memorável que um mundo persistente pode fazer.

**465 · Chefes Sazonais** — Sistema · Endgame
Versões modificadas dos chefes existentes durante eventos e estações. **Por quê:** reaproveita conteúdo com custo mínimo e dá razão para voltar.

---
---

# RODADA 6 — Gente, Missões, Eventos, Economia e Sistemas Sociais

*O GDD define o formato de Task/Quest/Batalha (§21) mas não popula. Esta rodada dá nomes, rostos e razões.*

---

## 6.1 NPCs

**466 · Ferreiro Bráulio** — NPC · Vila · Início
Vende ferramentas, repara e **ensina receitas de forja** conforme o progresso. **Liga com:** Forja, §21. **Por quê:** um NPC que evolui com o jogador é conteúdo que se renova sozinho.

**467 · Herborista Nara** — NPC · Vila · Início
Compra plantas, vende sementes, ensina alquimia. **Liga com:** Alquimia. **Por quê:** dá vazão econômica ao excesso de coleta.

**468 · Domadora Íris** — NPC · Vila · Início
Ensina captura, vende cápsulas, **avalia IVs e natureza** de graça. **Liga com:** §8, §27.3, §27.4, Lupa. **Por quê:** o jogador precisa de um lugar que explique o sistema mais complexo do jogo.

**469 · Mestre-Domador Aurélio** — NPC · Itinerante · Fim
Desafia o jogador em batalha; ao ser vencido, concede a Marca do Domador (§215). **Liga com:** §24. **Por quê:** o NPC-desafio dá ao combate contra treinadores (§21) um clímax.

**470 · Pescador Teobaldo** — NPC · Costa · Início
Vende varas e iscas, compra peixes por preço variável, dá tasks de pesca. **Liga com:** Pesca. **Por quê:** preço variável por dia cria um mini-jogo econômico.

**471 · Arquiteta Vilma** — NPC · Vila · Meio
Vende plantas de construção e móveis avançados. **Liga com:** Construção. **Por quê:** desbloquear blueprints é progressão de base que não depende só de material.

**472 · Mercador Nômade Zafi** — NPC · Itinerante · Meio
Aparece em locais aleatórios com estoque rotativo e caro. **Liga com:** Economia. **Por quê:** o mercador raro é sempre um evento por si só.

**473 · Curandeira Ofélia** — NPC · Vila · Início
Cura o time por moedas — a alternativa à cama (§11.1) quando você está longe de casa. **Liga com:** §11.1. **Por quê:** dá à vila uma função de "posto avançado" que o jogador usa toda hora.

**474 · Escavador Hugo** — NPC · Ruínas · Meio
Troca fósseis e âmbar por relíquias; conta o lore. **Liga com:** Colecionáveis, Museu. **Por quê:** o arqueólogo é a boca natural para a história do mundo.

**475 · Eremita do Pico** — NPC · Montanha · Fim
Ensina a Skill *Climb* artificial e vende Aurita. **Liga com:** §20.6. **Por quê:** garantir acesso ao Sagrado por um NPC fixo resolve §29.7 de forma confiável.

**476 · Ferreiro Sombrio Marek** — NPC · Terra Corrompida · Endgame
Corrompe itens (§213); trata o jogador com desconfiança. **Liga com:** §418 Ordem da Aurora. **Por quê:** NPCs que se opõem entre si dão ao jogador escolhas com consequência social.

**477 · Bibliotecário Cego Sávio** — NPC · Biblioteca Soterrada · Fim
Troca livros perdidos por receitas e revelações do mapa. **Liga com:** Lore, Mapas. **Por quê:** um colecionável (livros) com um destinatário é sempre melhor que um colecionável solto.

**478 · Pintora Lila** — NPC · Vila · Meio
Pinta retratos dos seus Forgelings (§276). **Liga com:** Decoração. **Por quê:** serviços cosméticos pagos são um dreno econômico saudável e adorado.

**479 · Chef Ambulante Duan** — NPC · Itinerante · Meio
Ensina uma receita nova por semana e desafia o jogador a cozinhar. **Liga com:** Culinária. **Por quê:** conteúdo culinário entregue aos poucos evita despejar 40 receitas de uma vez.

**480 · Criança da Vila** — NPC · Vila · Início
Pede tasks bobas (achar um brinquedo, mostrar um Forgeling). Recompensas pequenas e afetuosas. **Liga com:** §21 Tasks. **Por quê:** tom leve entre tarefas sérias é o que faz uma vila parecer habitada.

**481 · Guarda da Vila** — NPC · Vila · Todos
Dá tasks de eliminar ameaças; a vila pode ser invadida se ignoradas. **Liga com:** Eventos. **Por quê:** consequência por ignorar tasks transforma conteúdo opcional em conteúdo que importa.

**482 · Fantasma da Cripta** — NPC · Cemitério · Meio
Uma cadeia de quests para descobrir por que ele não descansa. **Liga com:** §21 Quests. **Por quê:** o GDD define quest como "cadeia com narrativa"; este é o exemplo canônico.

**483 · Rival** — NPC recorrente · Todos
Aparece nos marcos da campanha com um time que evolui em paralelo ao do jogador. **Liga com:** §21 Batalha. **Por quê:** um espelho que cresce junto é o melhor medidor de progresso que um creature collector tem.

**484 · Reputação por NPC** — Sistema · — · Meio
Cada NPC tem afinidade que sobe com tasks, presentes e diálogo; destrava lojas e receitas exclusivas. **Liga com:** §21, Economia. **Por quê:** dá longevidade a NPCs que, sem isso, esgotam em duas horas.

---

## 6.2 Tasks e Quests

**485 · Quadro de Tasks da Vila** — Sistema · — · Início
Painel com 3–5 tasks rotativas diárias. **Liga com:** §21 (tasks repetíveis com cooldown). **Por quê:** o GDD já prevê tasks repetíveis; o quadro é a interface que as torna visíveis.

**486 · Contratos de Caça** — Task · Todos
"Derrote 5 Forgelings de Ar no Pântano." **Liga com:** §21, §26. **Por quê:** direciona o jogador para biomas que ele estava evitando.

**487 · Encomendas de Crafting** — Task · Todos
"Entregue 3 Poções de Cura Média." **Liga com:** Crafting, Economia. **Por quê:** dá saída econômica ao excedente de produção.

**488 · Pedidos de Coleção** — Task · Todos
"Traga um espécime de cada Forgeling de Água." **Liga com:** Coleção. **Por quê:** transforma a coleção passiva em objetivo ativo.

**489 · Quest: A Mina do Norte** — Quest · Início
O exemplo do próprio GDD, expandido: investigar, descer, descobrir o Verme-Mãe, decidir se sela ou explora a mina. **Liga com:** §21, Dungeon 400. **Por quê:** dar corpo ao exemplo do GDD é a forma mais rápida de validar o sistema de quests.

**490 · Quest: O Último Sagrado** — Quest · Meio
Cadeia que garante ao jogador seu primeiro Forgeling Sagrado antes do primeiro chefe Sombrio. **Liga com:** §20.6, §29.7. **Por quê:** resolve mecanicamente a dependência de progressão que o GDD já sinalizou como risco.

**491 · Quest: A Semente da Mancha** — Quest · Fim
Rastrear a origem da Terra Corrompida até o Culto do Véu. **Liga com:** §382, §417. **Por quê:** dá ao mundo uma linha principal sem forçar linearidade.

**492 · Quest: Cartas Não Enviadas** — Quest · Meio
Entregar cartas de um morto a seis pessoas; cada uma reage diferente. **Liga com:** NPCs, reputação. **Por quê:** uma quest sem combate prova que o mundo tem mais de um registro emocional.

**493 · Quest: O Ovo Roubado** — Quest · Início
Recuperar um ovo levado por saqueadores; a recompensa é chocá-lo. **Liga com:** Ovos, §29.5. **Por quê:** ensina o sistema de ovos por dentro de uma história em vez de um tutorial.

**494 · Quest: A Ponte de Todos** — Quest cooperativa · Meio
Só concluível com dois ou mais jogadores em pontos distantes. **Liga com:** §19. **Por quê:** o multiplayer precisa de conteúdo que *exija* companhia, não só permita.

**495 · Quest: O Torneio de Forgelings** — Quest · Fim
Torneio de eliminatórias contra treinadores NPC, com regras por rodada (só um tipo, sem itens, nível travado). **Liga com:** §21 Batalha. **Por quê:** regras restritivas obrigam o jogador a usar Forgelings que estavam encostados.

**496 · Quest: A Forja Extinta** — Quest · Fim
Reacender a Forja Esquecida e reaprender a trabalhar Forgita. **Liga com:** §10 Forgita, Dungeon 403. **Por quê:** amarra o material assinatura a um marco narrativo.

**497 · Quest de Profissão (×3)** — Quest · Meio
Uma linha por profissão, destravando a técnica-assinatura (Taunt aprimorado, torre permanente, combo final). **Liga com:** §15, §26.4. **Por quê:** o GDD promete árvores de evolução de profissão; quests são a forma de encená-las.

**498 · Quests de Reconstrução** — Quest · Fim
Restaurar o Farol, a Ponte, o Coliseu — mudanças permanentes e visíveis no mapa da sala. **Liga com:** §19, Estruturas. **Por quê:** ver o mundo melhorar por causa do seu trabalho é a recompensa mais duradoura que existe.

**499 · Quests Encadeadas de Facção** — Sistema · Fim
Escolher entre Ordem da Aurora e Culto do Véu; cada caminho fecha o outro. **Liga com:** §417, §418, §213. **Por quê:** exclusividade cria rejogabilidade e conversa entre jogadores.

---

## 6.3 Eventos de Mundo

**500 · Lua Vermelha** — Evento · Todos
Já previsto no GDD (§13). Proposta: spawn massivo de Corrompidos, invasão de base, drops exclusivos. **Liga com:** §13, Defesa de base. **Por quê:** dá ao evento já listado uma mecânica que justifica a existência de muralhas e torres.

**501 · Chuva de Estrelas** — Evento · Meio
Meteoros caem; crateras com Ferro Meteórico. **Liga com:** §15 Ferro Meteórico. **Por quê:** evento com recompensa localizada gera corrida no multiplayer.

**502 · Migração** — Evento · Todos
Um bando de uma espécie atravessa um bioma por algumas horas. **Liga com:** §26.3, coleção. **Por quê:** oportunidade de captura em massa cria urgência sem perigo.

**503 · Maré Baixa** — Evento · Meio
O nível do mar cai, revelando cavernas costeiras. **Liga com:** Manguezal, exploração. **Por quê:** conteúdo que só existe algumas horas por semana é conteúdo que as pessoas marcam no calendário.

**504 · Erupção** — Evento · Fim
O Vulcão entra em atividade; lava avança, mas escória e Núcleos ficam abundantes. **Liga com:** Vulcão. **Por quê:** risco e recompensa no mesmo pacote, escolhidos pelo jogador.

**505 · Nevasca** — Evento · Meio
Visão reduzida, frio severo, mas Flores-de-Gelo florescem. **Liga com:** §13. **Por quê:** dá ao clima do GDD uma consequência positiva além da negativa.

**506 · Invasão de Saqueadores** — Evento · Meio
Ondas atacam a base ou a vila. **Liga com:** Defesa, Engenheiro. **Por quê:** valida todo o investimento em muralhas, torres e armadilhas.

**507 · Onda de Corrupção** — Evento · Endgame
A Terra Corrompida se expande rapidamente por um dia. **Liga com:** §382, §464. **Por quê:** cria pressão coletiva sobre a sala inteira.

**508 · Feira da Colheita** — Evento sazonal · Todos
Vila decorada, minijogos, prêmios cosméticos, NPCs em roupas de festa. **Liga com:** Estações. **Por quê:** eventos festivos são o que fazem um mundo persistente parecer um lugar, não um servidor.

**509 · Festival das Luzes** — Evento sazonal · Todos
Lanternas, chefes Sagrados temporários, receitas de festa. **Liga com:** Sagrado. **Por quê:** dá ao eixo Sagrado um registro alegre e não só solene.

**510 · Noite Sem Lua** — Evento · Fim
Escuridão total; Sombrios saem em massa; Adamas aflora na superfície. **Liga com:** §20.3, Adamas. **Por quê:** traz o conteúdo do Abismo temporariamente para a superfície — acessibilidade sem trivializar.

**511 · Concurso de Pesca / de Culinária / de Construção** — Eventos · Todos
Competições com placar entre jogadores da sala. **Liga com:** §19. **Por quê:** competição amistosa em atividades pacíficas atende ao jogador que não quer PvP.

**512 · Eco do Passado** — Evento raro · Fim
Um pedaço do mundo antigo reaparece por 30 minutos, com inimigos e loot extintos. **Liga com:** Lore, Colecionáveis. **Por quê:** conteúdo efêmero e raríssimo gera mito na comunidade.

---

## 6.4 Economia e Comércio

**513 · Moeda: Fragmento de Forja** — Sistema · — · Início
Moeda única, obtida de NPCs, tasks e venda. **Liga com:** §19 comércio. **Por quê:** uma moeda só mantém a economia legível.

**514 · Preço Dinâmico** — Sistema · — · Meio
Vender muito de um item derruba seu preço temporariamente. **Liga com:** Comércio. **Por quê:** impede a exploração de um único item e incentiva diversificação.

**515 · Mercado da Sala** — Sistema · — · Meio
Baú público com preços definidos pelo dono; compra assíncrona. **Liga com:** §19. **Por quê:** comércio entre jogadores sem exigir que estejam online juntos.

**516 · Casa de Leilões Itinerante** — Sistema · — · Fim
Chega à vila uma vez por semana com itens raros e leilão entre jogadores. **Liga com:** Economia. **Por quê:** dreno de moeda de endgame e evento social ao mesmo tempo.

**517 · Contratos de Encomenda entre Jogadores** — Sistema · — · Meio
Um jogador publica "preciso de 20 barras de aço, pago X". **Liga com:** §19. **Por quê:** cria especialização econômica: alguém vira "o minerador da sala".

**518 · Impostos e Manutenção Zero** — Decisão de design · — · —
**Proposta explícita: não haver custo de manutenção de base.** **Por quê:** taxas recorrentes punem quem joga pouco e transformam um jogo relaxante em obrigação. Vale registrar como decisão consciente.

**519 · Barganha** — Mecânica · — · Meio
Minijogo curto de negociação com NPCs; reputação melhora as margens. **Liga com:** §484. **Por quê:** dá agência a uma interação que normalmente é só um clique.

**520 · Trocas Diretas entre Jogadores** — Sistema · — · Início
Janela de troca segura, com confirmação dupla. **Liga com:** §19. **Por quê:** o GDD promete "comércio entre jogadores"; esta é a base mínima e segura.

**521 · Coleiras de Empréstimo** — Sistema · — · Meio
Emprestar um Forgeling a um amigo por tempo determinado; ele volta sozinho. **Liga com:** §19, §27.1. **Por quê:** compartilhar criatura é o gesto cooperativo mais forte que este jogo pode oferecer.

---

## 6.5 Sistemas Sociais e Multiplayer

**522 · Guildas / Clãs de Sala** — Sistema · — · Meio
Grupos com banco compartilhado, emblema e ranking. **Liga com:** §19, §286. **Por quê:** estrutura social dá razão para voltar quando o conteúdo acaba.

**523 · Permissões de Base** — Sistema · — · Início
Por jogador e por área: construir, retirar, entrar. **Liga com:** §19. **Por quê:** sem isso, base compartilhada é fonte de conflito.

**524 · Log da Sala** — Sistema · — · Meio
Registro de quem construiu, retirou ou matou o quê. **Liga com:** Permissões. **Por quê:** transparência resolve 90% dos atritos de servidor cooperativo.

**525 · Duelos Amistosos** — Sistema · — · Meio
Já previsto no GDD (§19). Proposta: arena com regras (nível travado, sem itens, só um tipo). **Liga com:** §19, §22. **Por quê:** regras opcionais tornam o PvP interessante para quem não quer PvP puro.

**526 · Ranking de Sala** — Sistema · — · Fim
Placares de coleção, construção, pesca, chefes. **Por quê:** múltiplos placares deixam cada estilo de jogador ser "o melhor" em algo.

**527 · Cooperação em ForgelingView** — Regra · — · Meio
Quando dois jogadores lutam juntos, **cada um controla o próprio Forgeling** e os dois personagens ficam invulneráveis enquanto houver ao menos um Forgeling em campo (§22). Se todos os times caem, todos ficam vulneráveis juntos. **Liga com:** §22. **Por quê:** estende a regra de invulnerabilidade ao multiplayer de forma coerente, e cria o momento de "segura mais um pouco!".

**528 · Reviver Aliado** — Mecânica · — · Meio
Um jogador com Forgeling em campo pode reerguer um companheiro sem time. **Liga com:** §22, §527. **Por quê:** dá ao estado de vulnerabilidade uma saída cooperativa — o melhor tipo de tensão.

**529 · Chat por Emote de Forgeling** — QoL social · — · Início
Comunicação rápida usando expressões da criatura. **Liga com:** §19. **Por quê:** comunicação sem texto é acessível e adorável.

**530 · Casa de Visitas** — Sistema · — · Meio
Base pode ser marcada como visitável; visitantes deixam recado no livro de hóspedes. **Liga com:** Decoração. **Por quê:** construir para ser visto é metade do prazer de construir.

**531 · Projetos Coletivos** — Sistema · — · Fim
Estruturas gigantes (ponte entre ilhas, elevador do Abismo) que exigem contribuição de vários jogadores. **Liga com:** §498. **Por quê:** objetivos que ninguém alcança sozinho são o que mantém uma comunidade unida.

---

## 6.6 Progressão e Novas Mecânicas

**532 · Árvore de Profissão** — Sistema · — · Todos
Três ramos por profissão, pontos ganhos por nível do jogador. **Liga com:** §15 (que promete árvores). **Por quê:** o GDD promete; isto é a estrutura mínima para cumprir.

**533 · Especializações Secundárias** — Sistema · — · Meio
Minerador, Herborista, Pescador, Cozinheiro, Construtor: níveis próprios que sobem com uso. **Liga com:** todos os sistemas de coleta. **Por quê:** dá progressão a quem não quer lutar, sem tocar na profissão de combate.

**534 · Maestria de Espécie** — Sistema · — · Fim
Usar muito uma espécie destrava pequenos bônus **para todos os indivíduos daquela espécie**. **Liga com:** teto de nível 10. **Por quê:** dá progressão de longo prazo sem furar o teto — exatamente o que §27.2 pede.

**535 · Pokédex — o Codex de Forgelings** — Sistema · — · Início
Registro de espécies vistas, capturadas, evoluídas e variantes. Recompensas por marcos. **Liga com:** Coleção. **Por quê:** o creature collector precisa de um placar de coleção; sem ele, colecionar não tem eco.

**536 · Diário de Bordo** — Sistema · — · Início
Registro automático de biomas visitados, chefes, receitas e NPCs. **Liga com:** Codex. **Por quê:** ajuda o jogador que voltou depois de um mês a lembrar onde estava.

**537 · Vínculo com o Forgeling** — Sistema · — · Meio
Um medidor por indivíduo que sobe com uso, alimentação, descanso e móveis (§291). Alto vínculo dá pequenos bônus e reações visuais. **Liga com:** §354, Recinto. **Por quê:** transforma cinco criaturas em cinco personagens.

**538 · Fadiga do Forgeling** — Sistema · — · Meio
Uso prolongado reduz o desempenho até o descanso na base. **Liga com:** §11.1 Cama, §27.1 time de 5. **Por quê:** força a rotação do time — o antídoto perfeito contra o jogador que usa o mesmo bicho 200 horas.

**539 · Modo Desafio da Sala** — Sistema · — · Fim
A sala pode ativar regras globais: sem cama, morte permanente do Forgeling, tempo acelerado. **Liga com:** §19. **Por quê:** dificuldade opcional serve o hardcore sem afastar o casual.

**540 · Herança de Ovos** — Mecânica · — · Fim
Um ovo gerado no Recinto herda parcialmente IVs e um ataque dos pais. **Liga com:** §29.5, §27.4. **Por quê:** breeding é o endgame natural de todo creature collector, e responde direto a uma questão aberta do GDD.

**541 · Fusão de Skills** — Mecânica · — · Endgame
Dois ataques do mesmo tipo podem ser fundidos em um mais forte, ocupando um slot só. **Liga com:** §24 (limite de 4). **Por quê:** dá ao limite de 4 slots uma válvula de escape que ainda exige escolha.

**542 · Memória de Ataques** — QoL · — · Meio
O Forgeling guarda conjuntos de 4 ataques nomeados, trocáveis fora de combate com um clique. **Liga com:** §24, §22. **Por quê:** o GDD já permite reequipar fora de combate; presets tornam isso agradável em vez de tedioso.

**543 · Modo Foto** — Sistema · — · Todos
Congelar a cena, ajustar câmera, poses do Forgeling, moldura. **Liga com:** Retratos, redes sociais. **Por quê:** conteúdo gerado por jogador é a melhor divulgação que um jogo pixel art pode ter.

**544 · Ciclo Lunar** — Sistema · — · Meio
Quatro fases que afetam maré, spawn de Sombrios, Arquipélago Errante e a Aurorélia. **Liga com:** §381, §447. **Por quê:** um segundo relógio, mais lento que o diário, dá ao mundo respiração longa.

**545 · Aclimatação de Bioma** — Sistema · — · Meio
Ficar muito tempo em um bioma extremo aplica um debuff crescente, mitigado por equipamento e comida. **Liga com:** Trajes, Culinária. **Por quê:** dá aos biomas hostis uma pressão contínua em vez de um portão binário.

---
---

# RODADA 7 — Relíquias, Colecionáveis, Endgame e Segredos

---

## 7.1 Relíquias e Artefatos

*Regra: relíquias **não são equipamento**. São objetos passivos que ficam num Pedestal na base e concedem efeitos ao dono — para não competirem com armas nem inflacionarem stats.*

**546 · Bússola dos Antigos** — Relíquia · Raro · Meio
**Obtém:** Ruínas. **Serve:** aponta para a estrutura não explorada mais próxima. **Liga com:** Exploração. **Por quê:** conserta a maior falha de mundos abertos: não saber para onde ir.

**547 · Ampulheta Rachada** — Relíquia · Épico · Fim
**Obtém:** chefe secreto. **Serve:** desacelera o tempo do mundo por 10s, uma vez por dia. **Liga com:** Chefes. **Por quê:** um poder pequeno e raro é mais memorável que um poder grande e disponível.

**548 · Cálice da Terra Fértil** — Relíquia · Raro · Meio
**Serve:** todas as plantações da base crescem 20% mais rápido. **Liga com:** Agricultura. **Por quê:** relíquias que buffam a base recompensam quem investe em casa.

**549 · Elmo do Primeiro Domador** — Relíquia · Épico · Fim
**Serve:** +5% na chance de captura, permanentemente. **Liga com:** §8. **Por quê:** um bônus permanente pequeno é sentido em 500 capturas.

**550 · Escama da Serpente-Mundo** — Relíquia · Lendário · Endgame
**Serve:** o primeiro golpe fatal recebido pelo Forgeling em cada luta é anulado. **Liga com:** §22. **Por quê:** um seguro por batalha muda a matemática de risco sem tirar a tensão.

**551 · Núcleo Adormecido** — Relíquia · Lendário · Endgame
**Obtém:** montar seis fragmentos espalhados pelos seis biomas. **Serve:** abre O Descenso; concede uma sétima "cor" ao Codex. **Liga com:** §398. **Por quê:** uma caça de fragmentos que atravessa o mundo inteiro é o objetivo de endgame mais confiável do gênero.

**552 · Sino do Chamado** — Artefato · Raro · Fim
**Serve:** invoca um chefe já derrotado para reencontro. **Liga com:** Chefes, farm. **Por quê:** o jogador precisa poder repetir a melhor parte do jogo.

**553 · Máscara do Rosto Falso** — Artefato · Épico · Fim
**Serve:** facções inimigas não atacam à vista. **Liga com:** §416–418. **Por quê:** habilita infiltração como estilo de jogo, sem sistema de furtividade completo.

**554 · Lanterna Eterna** — Artefato · Épico · Endgame
**Serve:** luz que a escuridão do Abismo não apaga. **Liga com:** §408. **Por quê:** é a chave que transforma a dungeon final de impossível em difícil.

**555 · Diapasão Prismático** — Artefato · Lendário · Endgame
**Serve:** revela a fraqueza elemental de qualquer inimigo, inclusive chefes. **Liga com:** §20.4. **Por quê:** dá ao jogador de endgame o direito de parar de decorar a tabela.

**556 · Coleira do Primeiro Vínculo** — Artefato · Lendário · Endgame
**Obtém:** vínculo máximo com um Forgeling que nunca foi derrotado. **Serve:** aquele indivíduo específico ganha um segundo slot de Coleira. **Liga com:** §537, §202. **Por quê:** recompensa a lealdade a *um* bicho — o oposto do farm, e emocionalmente muito mais forte.

---

## 7.2 Colecionáveis

**557 · Fósseis (24 peças)** — Colecionável · Incomum→Raro · Meio
Montáveis em esqueletos completos no Museu. **Obtém:** escavação, âmbar, peneira. **Por quê:** montar um esqueleto peça por peça é um dos loops de coleção mais satisfatórios já feitos.

**558 · Museu da Vila** — Estrutura · — · Meio
Recebe fósseis, peixes, insetos, minérios e relíquias; abre alas conforme doações. **Liga com:** todos os colecionáveis. **Por quê:** dá ao colecionador um lugar público para exibir — e um NPC que agradece.

**559 · Discos de Música (20)** — Colecionável · Raro · Todos
**Obtém:** drops raros, quests, baús de dungeon. **Liga com:** Jukebox. **Por quê:** cada disco é uma pequena celebração e um pedaço de identidade sonora.

**560 · Páginas de Diário (60)** — Colecionável · Comum→Raro · Todos
Espalhadas pelo mundo; contam a história do colapso antigo. **Liga com:** Biblioteca, Lore. **Por quê:** lore opcional em pedaços respeita quem quer história e quem não quer.

**561 · Selos de Bioma (9)** — Colecionável · Incomum · Todos
Um por bioma, obtido ao completar seu marco. **Liga com:** Codex. **Por quê:** um checklist visível de "onde eu já estive de verdade".

**562 · Cartas de Forgeling** — Colecionável · Comum→Lendário · Todos
Itens cosméticos com arte de cada espécie; trocáveis entre jogadores. **Liga com:** §19, Codex. **Por quê:** um sistema de troca puramente social, sem impacto de poder — a economia mais saudável possível.

**563 · Receitas Perdidas (40)** — Colecionável funcional · Incomum→Raro · Todos
Papéis que destravam pratos e poções exclusivos. **Liga com:** Culinária, Alquimia. **Por quê:** colecionável que *faz* algo agrada quem não coleciona por coleção.

**564 · Sementes Antigas** — Colecionável · Raro · Fim
Plantas extintas dentro de âmbar. **Liga com:** §18 Âmbar, Estufa. **Por quê:** ressuscitar uma espécie vegetal é uma pequena epopeia de jogo.

**565 · Miniaturas de Chefe** — Colecionável · Raro · Fim
Estatuetas dropadas com baixa chance por cada chefe. **Liga com:** Vitrine. **Por quê:** troféu físico por chefe é a prova social mais direta que existe.

**566 · Skins de Cápsula / Ferramentas / Casa** — Cosméticos · Todos
Variações visuais obtidas por conquistas e eventos. **Por quê:** cosméticos por mérito são recompensa infinita e barata.

---

## 7.3 Conquistas

**567 · Primeira Fagulha** — Início — Capturar o primeiro Forgeling.
**568 · Lar Doce Lar** — Início — Dormir na própria cama (§11.1).
**569 · Fundo do Poço** — Meio — Alcançar a camada mais profunda acessível.
**570 · Seis de Seis** — Meio — Ter um Forgeling de cada tipo no Recinto.
**571 · Ninguém Fica para Trás** — Meio — Vencer um chefe sem perder nenhum Forgeling.
**572 · Sozinho no Escuro** — Fim — Vencer uma luta após o time inteiro cair (§22).
**573 · Cardápio Completo** — Fim — Cozinhar todas as receitas.
**574 · Arquiteto** — Fim — Construir todas as estações de crafting.
**575 · Zoólogo** — Endgame — Completar o Codex de espécies.
**576 · Curador** — Endgame — Completar o Museu.
**577 · Perfeito** — Endgame — Obter um Forgeling com IVs +10 nos três stats.
**578 · Cromático** — Endgame — Capturar uma variante cromática.
**579 · Pacifista** — Endgame — Capturar 50 Forgelings sem nunca derrotá-los (só sono/rede).
**580 · Redentor** — Endgame — Purificar um Forgeling Corrompido.
**581 · O Mundo Inteiro** — Endgame — Visitar todos os biomas e sub-biomas.
**582 · Vínculo Inquebrável** — Endgame — Chegar ao nível 10 com um Forgeling nunca derrotado.
*(**Por quê**, para todo o grupo: conquistas devem premiar **estilos de jogo distintos** — colecionar, construir, cozinhar, poupar, arriscar. Uma lista que só premia combate diz ao jogador que só o combate importa.)*

---

## 7.4 Endgame

**583 · Modo Ascensão** — Sistema · Endgame
Após o chefe final, o mundo ganha uma camada de dificuldade opcional com inimigos +3 níveis e drops exclusivos. **Liga com:** §539. **Por quê:** New Game+ sem apagar a base é o que respeita o tempo do jogador.

**584 · Torre Infinita** — Conteúdo · Endgame
Andares progressivos com restrições crescentes; placar de sala. **Liga com:** §526. **Por quê:** conteúdo vertical infinito com custo de produção quase nulo.

**585 · Caçada aos Alfas Lendários** — Conteúdo · Endgame
Doze Alfas únicos escondidos no mundo, cada um com uma pista. **Liga com:** §450. **Por quê:** caça ao tesouro de longo prazo que a comunidade resolve em conjunto.

**586 · Contratos Semanais de Guilda** — Conteúdo · Endgame
Objetivos grandes que exigem a sala inteira. **Liga com:** §522. **Por quê:** dá à guilda uma razão semanal de existir.

**587 · Restauração do Mundo** — Meta-objetivo · Endgame
Purificar toda a Terra Corrompida, restaurar todas as estruturas, reabrir todos os santuários. Muda a aparência do mundo permanentemente. **Liga com:** §382, §498. **Por quê:** o melhor final para um jogo de construção é um mundo visivelmente melhor do que você encontrou.

**588 · Bestiário Completo com Recompensa** — Endgame
Completar o Codex destrava a Aurorélia (§447) como companheira. **Por quê:** a recompensa final da coleção deve ser uma criatura — coerente com a alma do jogo.

---

## 7.5 Segredos e Easter Eggs

**589 · Sala do Desenvolvedor** — Segredo · Endgame
Atrás de uma parede falsa no Abismo; contém protótipos e um NPC que comenta o desenvolvimento. **Por quê:** todo jogo pixel art merece a sua.

**590 · O Forgeling que Não Existe** — Segredo · Endgame
Uma espécie que só aparece se o jogador jogar durante uma data específica, e desaparece do Codex depois. **Por quê:** mitos de jogador são a melhor publicidade orgânica que existe.

**591 · Paredes Falsas** — Segredo · Todos
Blocos que parecem sólidos mas cedem; detectáveis por som sutil. **Liga com:** Veio de Eco. **Por quê:** recompensa o jogador que presta atenção ao áudio.

**592 · Poço dos Desejos** — Segredo · Meio
Jogar itens dentro devolve algo relacionado, às vezes melhor. **Por quê:** interações não documentadas geram wikis e conversas.

**593 · Mensagens nas Paredes** — Segredo · Todos
Inscrições antigas em uma escrita que o jogador aprende a decifrar aos poucos. **Liga com:** Páginas de Diário. **Por quê:** decifrar um idioma é o segredo mais gratificante que um jogo pode ter.

**594 · O Pescador Fantasma** — Easter egg · Fim
Aparece em noites de neblina em um píer específico; vende iscas impossíveis. **Por quê:** encontros raros e sem explicação criam folclore.

**595 · A Porta que Nunca Abre** — Easter egg · Todos
Uma porta em ruína que resiste a tudo — até um evento raríssimo. **Por quê:** um mistério não resolvido é conteúdo que se sustenta por anos.

**596 · Sequência de Instrumentos** — Segredo · Fim
Tocar uma melodia específica (encontrada em uma página) num ponto do mapa abre uma câmara. **Liga com:** §293, §402. **Por quê:** puzzle que usa um sistema opcional recompensa quem explorou por curiosidade.

**597 · Forgeling Fujão** — Easter egg · Todos
Uma espécie que sempre foge no primeiro encontro, por quatro encontros, e no quinto se entrega. **Por quê:** transforma frustração em piada e depois em recompensa.

**598 · Blocos Impossíveis** — Easter egg · Endgame
Um punhado de blocos decorativos que não podem ser craftados, só encontrados um por mundo. **Por quê:** escassez absoluta cria valor absoluto em economias de jogador.

**599 · Fim Alternativo do Codex** — Segredo · Endgame
Completar o Codex **sem nunca ter derrotado um Forgeling selvagem** dá uma cena e um título exclusivos. **Liga com:** §579. **Por quê:** premiar um estilo de jogo radicalmente diferente é o tipo de segredo que gera vídeos.

---
---

# RODADA 8 — QoL, Interface e Experiência

*Nada aqui adiciona conteúdo. Tudo aqui decide se o conteúdo acima será aproveitado ou abandonado.*

---

## 8.1 Inventário e Itens

**600 · Auto-empilhamento para Baús Próximos** — QoL
Um botão que deposita tudo o que já existe nos baús ao redor. **Por quê:** a QoL de maior impacto por linha de código em qualquer jogo de crafting.

**601 · Ordenar Inventário** — QoL — Um clique, por categoria e valor.
**602 · Favoritar Item** — QoL — Itens marcados nunca são depositados nem descartados automaticamente. **Por quê:** protege o jogador de si mesmo.
**603 · Crafting a Partir dos Baús** — QoL — Perto da base, receitas usam material dos baús vizinhos. **Por quê:** elimina a ida-e-volta que mata o prazer de construir.
**604 · Fila de Crafting** — QoL — Produzir 50 itens sem 50 cliques.
**605 · Busca no Inventário e no Livro de Receitas** — QoL — Campo de texto com filtro por material.
**606 · Livro de Receitas com "O que posso fazer agora"** — QoL — Filtro por material disponível. **Por quê:** o jogador descobre receitas que esqueceu que tinha.
**607 · Indicador de "Falta X"** — QoL — Receitas bloqueadas mostram exatamente o que falta e **onde encontrar**.
**608 · Comparação de Equipamento** — QoL — Tooltip lado a lado com o item equipado.
**609 · Lixeira com Desfazer** — QoL — 30 segundos para recuperar o que foi descartado. **Por quê:** um clique errado não deveria custar duas horas.
**610 · Auto-coleta de Drops** — QoL — Ativada por Pedra-Ímã e Drone (§30, §174). **Por quê:** conveniência que o jogador *conquista* vale mais que conveniência dada.

## 8.2 Combate e Forgelings

**611 · Barra de Vida do Forgeling Sempre Visível** — UI — Grande, clara, no canto oposto à do jogador.
**612 · Indicador de Vantagem de Tipo** — UI
Ao mirar um inimigo, uma seta ↑ ↓ = mostra o multiplicador de §20.4. **Por quê:** a tabela tem 36 células; ninguém decora, e ninguém deveria precisar.
**613 · Telegrafia de Ataque Inimigo** — UX — Todo ataque forte tem aviso visual e sonoro de ≥0.5s. **Por quê:** dificuldade justa exige informação antecipada.
**614 · Cooldowns nas Teclas 1–4** — UI — Radial claro sobre cada slot (§16).
**615 · Aviso de Forgeling em Perigo** — UX — Sinal visual e sonoro abaixo de 25% de vida. **Por quê:** com a troca travada (§22), perder a criatura por distração é punição desproporcional.
**616 · Alerta de "Time Prestes a Cair"** — UX — Aviso enfático quando resta o último Forgeling. **Por quê:** o jogador precisa saber que a invulnerabilidade está por acabar (§22).
**617 · Indicador de Invulnerabilidade** — UI — Ícone permanente no personagem enquanto protegido. **Por quê:** a regra mais importante do combate precisa ser visível o tempo todo.
**618 · Preview de Time antes da Batalha** — UX — Ao aceitar uma batalha de NPC, mostrar os tipos do time adversário. **Por quê:** §22 tornou a escolha pré-luta irreversível; escolher às cegas seria injusto.
**619 · Log de Combate** — UI — Rolagem opcional com dano, multiplicadores e status aplicados. **Por quê:** o jogador que quer otimizar precisa de números.
**620 · Marcador de Alvo Persistente** — UX — O alvo do botão direito (§17) fica destacado até morrer ou ser trocado.
**621 · Chamar o Forgeling de Volta** — QoL — Tecla dedicada, além da Corneta (§106). **Por quê:** responde diretamente ao ponto em aberto de §28.3.
**622 · Repetir Última Ordem de Cenário** — QoL — Segurar o botão do meio repete a interação em objetos iguais próximos. **Por quê:** responde ao ponto de "hold" levantado em §28.3.

## 8.3 Mundo e Navegação

**623 · Minimapa com Marcadores Customizáveis** — QoL — Ícones e cores definidos pelo jogador.
**624 · Mapa Compartilhado da Sala** — QoL — Descobertas de um aparecem para todos (§289). **Por quê:** coordenação sem sair do jogo.
**625 · Rastro de Migalhas** — QoL — Marca automática do caminho percorrido em cavernas, apagável. **Por quê:** se perder em caverna é a frustração nº 1 do gênero.
**626 · Marcador de Recurso** — QoL — "Marcar este veio" para voltar depois com a picareta certa.
**627 · Bússola de Superfície** — UI — Em cavernas, uma seta indicando a direção da saída mais próxima.
**628 · Indicador de Profundidade** — UI — Essencial em um jogo de perfil; define camadas e perigo.
**629 · Viagem Rápida por Farol** — QoL — Interface de mapa com os faróis construídos (§249).
**630 · Marcação de Bioma Não Visitado** — UX — Névoa de guerra que se dissipa, incentivando cobrir o mapa.

## 8.4 Base e Construção

**631 · Modo Construção com Grade e Espelhamento** — QoL — Simetria automática. **Por quê:** construir simétrico à mão é tedioso e desanimador.
**632 · Copiar e Colar Estrutura** — QoL — Blueprint de uma seção já construída, com custo de material.
**633 · Preview Fantasma** — UX — O bloco aparece translúcido antes de ser confirmado.
**634 · Desfazer na Construção** — QoL — Ctrl+Z para as últimas 20 ações.
**635 · Paleta de Blocos Favoritos** — QoL — Acesso rápido aos 10 blocos em uso no projeto atual.
**636 · Substituição em Massa** — QoL — Trocar todos os blocos de madeira por pedra numa área.
**637 · Alerta de Estoque de Máquina** — UX — Ícone flutuante quando uma máquina está sem combustível ou cheia.
**638 · Visualizar Rede de Automação** — UI — Sobreposição mostrando o fluxo de esteiras e funis.
**639 · Nomear e Etiquetar Baús** — QoL — Com ícone do conteúdo predominante.

## 8.5 Criaturas e Coleção

**640 · Comparador de Forgelings** — UI — Dois indivíduos lado a lado: stats, natureza, IVs, ataques.
**641 · Filtro do Recinto** — QoL — Por tipo, nível, natureza, IV, espécie, favorito.
**642 · Marcar como "Não Liberar"** — QoL — Trava de segurança em criaturas favoritas. **Por quê:** liberar o bicho errado é trauma permanente.
**643 · Preview de Evolução** — UI — Mostrar a próxima forma e o requisito (§23) antes de investir.
**644 · Notificação de Ovo Pronto** — UX — Aviso ao chocar, mesmo longe da base.
**645 · Histórico de Captura** — UI — Onde, quando e com qual cápsula cada criatura foi obtida. **Por quê:** memória afetiva é o que transforma um item num personagem.
**646 · Apelidar em Qualquer Momento** — QoL — Sem NPC intermediário. Simples e sempre pedido.

## 8.6 Acessibilidade e Conforto

**647 · Rebind Completo + Gamepad** — Acessibilidade — Responde diretamente a §28.3, incluindo o equivalente do botão do meio no Steam Deck (§3).
**648 · Modo Daltônico** — Acessibilidade — Crítico: o jogo inteiro depende de **seis cores elementais**. Padrões e símbolos além da cor.
**649 · Escala de UI e Fonte** — Acessibilidade — Steam Deck e monitores 4K exigem isso.
**650 · Modo Alto Contraste** — Acessibilidade — Silhuetas de inimigos destacadas em cenários carregados.
**651 · Toggle vs. Hold** — Acessibilidade — Para toda ação que exige segurar botão.
**652 · Redução de Tremor de Tela** — Acessibilidade — Opção separada de intensidade.
**653 · Legendas para Áudio Relevante** — Acessibilidade — Especialmente para puzzles sonoros (§402, §591).
**654 · Velocidade de Diálogo e Auto-avanço** — QoL.
**655 · Pausa em Solo** — QoL — Em sala privada de um jogador, pausar de verdade.
**656 · Salvamento Automático Frequente + Slots Manuais** — QoL — Com backup rotativo. **Por quê:** mundo persistente exige rede de segurança.

## 8.7 Onboarding

**657 · Tutorial Diegético** — UX — Aprender capturando, minerando e construindo, sem paredes de texto.
**658 · Dicas Contextuais Desativáveis** — UX — Aparecem uma vez, na hora certa, e podem ser desligadas de vez.
**659 · Guia de Tipos Interativo** — UX — Na casa da Domadora Íris (§468), uma tabela clicável de §20.4. **Por quê:** um sistema de 36 células precisa de um lugar onde o jogador possa estudá-lo com calma.
**660 · Objetivo Sugerido** — UX — Uma linha discreta com "o que fazer agora", desativável. **Por quê:** mundo aberto trava o jogador novo; uma sugestão gentil resolve sem tirar liberdade.

---
---

# RODADA 9 — Varredura: o que ainda não apareceu

*Passagem final procurando exclusivamente categorias e ideias ausentes nas oito rodadas anteriores.*

---

## 9.1 Veículos e Travessia

**661 · Jangada** — Veículo · Comum · Início
**Obtém:** troncos + cipó. **Serve:** travessia lenta de água sem *Surf*. **Liga com:** §10. **Por quê:** o jogador nunca deve ficar preso por não ter o Forgeling certo — só mais lento.

**662 · Barco a Vela** — Veículo · Incomum · Meio
**Obtém:** Salgueiro + vela de Árvore-Vela. **Serve:** navegação entre ilhas, com baú embutido. **Liga com:** Ilhas, Arquipélago. **Por quê:** um veículo com armazenamento vira base móvel — muda como o jogador explora.

**663 · Barco-Casa** — Veículo · Raro · Fim
**Obtém:** Marcenaria avançada. **Serve:** base flutuante com cama, baú e uma estação. **Liga com:** §11.1, nomadismo. **Por quê:** dá ao jogador que odeia voltar para casa uma casa que o segue.

**664 · Submersível** — Veículo · Épico · Endgame
**Obtém:** Oficina + Cobalto + vidro reforçado. **Serve:** Ruínas Submersas e o fundo do oceano sem fôlego. **Liga com:** §380. **Por quê:** um bioma inteiro só se abre de verdade com o veículo certo.

**665 · Planador** — Veículo · Incomum · Meio
**Obtém:** bambu + tecido. **Serve:** descer de picos com controle. **Liga com:** Climb, side view. **Por quê:** subir com esforço e descer voando é um dos melhores ciclos de movimento que um jogo 2D pode ter.

**666 · Balão de Ar Quente** — Veículo · Raro · Fim
**Obtém:** tecido + fornalha portátil. **Serve:** subida vertical lenta a qualquer altura. **Liga com:** Ilhas Flutuantes. **Por quê:** verticalidade sem *Fly*, com custo de tempo.

**667 · Trenó** — Veículo · Incomum · Meio
**Obtém:** madeira + couro; puxado por um Forgeling de Terra ou Água. **Serve:** travessia rápida da Neve com carga. **Liga com:** Sela, Pecuária. **Por quê:** faz o Forgeling participar da logística, não só do combate.

**668 · Montaria de Forgeling** — Sistema · Raro · Fim
Detalhado em §203; espécies grandes andam, nadam ou voam com o jogador. **Liga com:** §203, Fly, Swim. **Por quê:** é a fantasia máxima de um creature collector, e o GDD já tem os ingredientes.

**669 · Tirolesa** — Estrutura · Incomum · Meio
Corda entre dois pontos altos, construída pelo jogador. **Liga com:** Cipó, Climb. **Por quê:** mobilidade permanente construída pelo próprio jogador é infraestrutura que ele se orgulha de ter feito.

**670 · Ilhas Flutuantes** — Bioma novo · — · Fim
Camada acima das montanhas, acessível por *Fly*, balão ou planador. Ar e Sagrado; Aurita aflorada. **Liga com:** §20.6, Ar. **Por quê:** o GDD tem nove biomas todos no chão ou abaixo dele; um bioma **acima** completa o eixo vertical que o side view pede.

---

## 9.2 Acampamento e Vida em Expedição

**671 · Saco de Dormir** — Item · Comum · Início
**Obtém:** tecido + palha. **Serve:** ponto de retorno temporário; **não cura o time** (só a cama, §11.1). **Liga com:** §11.1. **Por quê:** preserva a cama como recompensa da base sem punir a expedição longa.

**672 · Tenda** — Estrutura portátil · Incomum · Meio
**Obtém:** tecido + varas. **Serve:** abrigo contra clima; cura parcial do time. **Liga com:** §13, §11.1. **Por quê:** o meio-termo entre saco de dormir e casa dá granularidade ao descanso.

**673 · Fogueira Portátil** — Item · Comum · Início
**Serve:** cozinhar simples, luz, calor, afastar hostis de baixo nível. **Por quê:** o acampamento improvisado é um dos rituais mais queridos do gênero.

**674 · Baú de Campo** — Item · Incomum · Meio
Pequeno, deixado no mundo, aparece no mapa. **Liga com:** Logística. **Por quê:** permite expedições muito mais longas sem voltar.

**675 · Kit de Primeiros Socorros** — Item · Comum · Início
**Serve:** cura o jogador ao longo do tempo, funciona andando. **Liga com:** §22 (estado vulnerável). **Por quê:** quando o time cai e o jogador vira alvo, ele precisa de algo que cure enquanto foge.

**676 · Corda de Escalada** — Item · Comum · Início
Fixa em um ponto e permite subir e descer. **Liga com:** §137, side view. **Por quê:** a ferramenta de exploração vertical mais básica e mais usada.

**677 · Sinalizador** — Item · Comum · Meio
Sobe alto e marca a posição para todos na sala por 2 min. **Liga com:** §19. **Por quê:** "estou aqui, venham" resolvido com um item, sem UI.

**678 · Mapa do Tesouro** — Item · Incomum · Todos
**Obtém:** pesca, saqueadores, garrafas. **Serve:** marca um ponto para cavar com a pá. **Liga com:** Dig, Pá. **Por quê:** um objetivo curto e concreto no meio de um mundo grande é um presente para o jogador sem rumo.

**679 · Chaves e Cadeados** — Sistema · Comum · Todos
Baús trancados em dungeons; chaves como drop. **Liga com:** Dungeons. **Por quê:** trancar loot atrás de uma chave transforma um baú em objetivo.

**680 · Gazua** — Item · Incomum · Meio
Abre cadeados sem a chave; quebra às vezes. **Liga com:** Mercenário. **Por quê:** dá ao Mercenário uma habilidade de exploração, já que ele é o único sem Skill utilitária óbvia.

**681 · Piquetes de Demarcação** — Item · Comum · Meio
Delimitam a área da sua base para permissões (§523). **Liga com:** §19. **Por quê:** a fronteira precisa ser visível, não abstrata.

---

## 9.3 Mascotes e Companhia

*Distintos dos Forgelings: **não lutam, não ocupam slot de time**, e existem para dar vida à base.*

**682 · Gato da Casa** — Mascote · Comum · Meio
Dorme nos móveis; **afasta pragas** da despensa. **Por quê:** um bicho que só vive na casa é o que transforma construção em lar.

**683 · Cão Farejador** — Mascote · Incomum · Meio
Anda com o jogador e **fareja itens enterrados** e Forgelings raros próximos. **Liga com:** §433, §678. **Por quê:** utilidade suave, sem competir com o Forgeling ativo.

**684 · Papagaio Falante** — Mascote · Incomum · Meio
Repete frases dos NPCs e dos jogadores da sala. **Liga com:** §19. **Por quê:** humor emergente de graça.

**685 · Vagalume de Estimação** — Mascote · Comum · Início
Luz fraca e constante ao redor do jogador. **Liga com:** Illuminate. **Por quê:** o primeiro mascote deve ser barato, bonito e minimamente útil.

**686 · Filhote de Forgeling** — Mascote · Raro · Fim
Um Forgeling recém-chocado que ainda não pode lutar; anda junto e cresce. **Liga com:** Ovos, §537. **Por quê:** ver o bicho crescer antes de virar combatente cria vínculo antes da utilidade.

**687 · Espantalho Vivo** — Mascote · Incomum · Meio
Autômato simples do Engenheiro que rega a fazenda. **Liga com:** Automação. **Por quê:** o Engenheiro merece um companheiro que ele mesmo construiu.

---

## 9.4 Sistemas de Sobrevivência (com posição de design)

**688 · Fome — proposta: SIM, mas suave** — Sistema · — · Todos
Uma barra lenta que, se esvaziar, causa **Exaustão** (§351), nunca morte. **Por quê:** dá razão para a culinária existir sem transformar o jogo em gestão de refeições. Sobrevivência punitiva contraria o tom de "liberdade para explorar e construir" do §1.

**689 · Sede — proposta: NÃO, exceto no Deserto** — Sistema · — · Meio
Só o Deserto e o Mar de Sal aplicam desidratação. **Liga com:** Cacto, Oásis. **Por quê:** um recurso de sobrevivência localizado dá identidade a um bioma; global, vira imposto sobre a diversão.

**690 · Temperatura** — Sistema · — · Meio
Frio e calor extremos aplicam debuffs crescentes, mitigados por roupa, fogueira e comida. **Liga com:** §545, Trajes. **Por quê:** é a forma mais orgânica de ordenar a exploração dos biomas.

**691 · Durabilidade — proposta: SIM, com conserto barato** — Sistema · — · Todos
Itens desgastam, mas o Kit de Reparo (§145) e a Bigorna resolvem sem custo doloroso. **Por quê:** desgaste mantém a economia de material viva; desgaste caro faz o jogador guardar o item bom e nunca usá-lo.

**692 · Peso — proposta: NÃO, usar slots** — Sistema · — · —
Limite por número de slots, não por peso. **Liga com:** Mochilas. **Por quê:** peso obriga aritmética constante; slots são legíveis à primeira vista, o que combina com pixel art e com Steam Deck.

**693 · Morte do Jogador — proposta** — Sistema · — · Todos
Ao morrer (possível apenas sem Forgeling, §22): respawn na última cama, **derruba metade dos recursos brutos** no local em uma lápide recuperável, mantém equipamento e Forgelings. **Liga com:** §29.2. **Por quê:** oferece uma resposta concreta a uma questão em aberto do GDD, com punição sentida mas nunca catastrófica — coerente com o tom do jogo.

**694 · Forgeling Derrotado — proposta** — Sistema · — · Todos
Não morre permanentemente. Fica "abatido" até a cama, item ou Fontes Termais. Perde parte do XP da sessão. **Liga com:** §11.1, §29.2. **Por quê:** morte permanente de criatura destruiria o vínculo que o jogo inteiro tenta construir.

---

## 9.5 Lore e Mundo

**695 · A Grande Forja** — Lore
O mundo teria sido *forjado* por uma civilização que aprendeu a moldar os seis elementos, e desabou ao tentar criar um sétimo. **Liga com:** §20 (seis tipos), Ruínas, Adamas. **Por quê:** explica por que existem exatamente seis elementos e por que há ruínas por toda parte — lore que justifica a mecânica é sempre a melhor lore.

**696 · Os Forgelings são fragmentos** — Lore
Cada Forgeling seria um pedaço vivo daquela forja. **Liga com:** §113 Núcleos, Evolução. **Por quê:** dá peso emocional à captura: você não coleciona bichos, você recolhe um mundo despedaçado.

**697 · A Mancha é o sétimo elemento** — Lore
A Terra Corrompida seria a tentativa fracassada de criar um sétimo tipo. **Liga com:** §382, §695. **Por quê:** transforma o antagonista ambiental em consequência da história, não em vilão avulso.

**698 · As Profissões são heranças** — Lore
Engenheiro, Caçador e Mercenário seriam remanescentes de três castas da Grande Forja. **Liga com:** §15. **Por quê:** dá às três profissões um lugar no mundo além da mecânica.

**699 · Nomes de Lugares com Sentido** — Diretriz
Todo bioma e estrutura carrega um nome que insinua o que aconteceu ali. **Por quê:** nomear bem é a forma mais barata de contar história.

**700 · Livro de Espécies Ilustrado** — Colecionável · Fim
Uma edição in-game do Codex com desenhos e notas de campo de um naturalista morto. **Liga com:** §535. **Por quê:** dá voz e personalidade ao menu mais consultado do jogo.

---

## 9.6 Áudio

**701 · Tema por Bioma** — Áudio — Nove trilhas com instrumentação distinta. **Por quê:** em pixel art, o som carrega metade da identidade do lugar.
**702 · Camadas Dinâmicas em Combate** — Áudio — A trilha ganha percussão ao entrar no ForgelingView (§22). **Por quê:** marcar a transição de modo pelo som é mais elegante que por UI.
**703 · Voz de Forgeling** — Áudio — Cada espécie com um som próprio, usado em emotes e no Codex. **Por quê:** é o que faz uma criatura ser lembrada.
**704 · Som de Material** — Áudio — Cada minério, madeira e bloco com seu próprio impacto. **Por quê:** feedback tátil por áudio é o que faz minerar viciar.
**705 · Silêncio Deliberado** — Áudio — O Abismo e a Terra Corrompida quase sem trilha. **Por quê:** a ausência de música é a ferramenta de tensão mais barata e mais eficaz que existe.
**706 · Tema do Rival** — Áudio — Sempre que ele aparece (§483). **Por quê:** um tema recorrente transforma um NPC em personagem.

---

## 9.7 Desafios e Modificadores

**707 · Desafio: Monotipo** — Só um elemento no time inteiro. **Liga com:** §20.
**708 · Desafio: Nuzlocke** — Um Forgeling por bioma; derrotado é liberado. **Liga com:** §539.
**709 · Desafio: Pacifista** — Zero Forgelings selvagens derrotados. **Liga com:** §579, §599.
**710 · Desafio: Sem Base** — Nenhuma construção permitida. **Liga com:** §671 Saco de Dormir.
**711 · Desafio: Speedrun de Chefe** — Placar por tempo, por chefe. **Liga com:** §526.
**712 · Desafio: Nível Travado** — Forgelings limitados ao nível 5. **Liga com:** §27.2.
**713 · Desafio: Um Só Vínculo** — Um único Forgeling, do começo ao fim. **Liga com:** §556.
*(**Por quê**, para o grupo: modificadores são a forma mais barata de multiplicar a vida útil de um jogo — o conteúdo já existe, só as regras mudam. E são a matéria-prima natural de streamers.)*

---
---

# Encerramento

## O que este documento acrescenta ao GDD

**713 propostas**, organizadas em nove rodadas. Um resumo do que elas cobrem:

| Território | Entradas |
|---|---|
| Recursos, minérios, gemas, flora, materiais | 001–122 |
| Ferramentas, armas, armaduras, equipamento, encantamentos | 123–215 |
| Base: estações, máquinas, defesa, móveis, decoração | 216–293 |
| Culinária, alquimia, buffs, agricultura, pesca | 294–364 |
| Biomas, estruturas, dungeons, criaturas, Forgelings, chefes | 365–465 |
| NPCs, quests, eventos, economia, social, progressão | 466–545 |
| Relíquias, colecionáveis, conquistas, endgame, segredos | 546–599 |
| QoL, UI, UX, acessibilidade, onboarding | 600–660 |
| Veículos, acampamento, mascotes, sobrevivência, lore, áudio, desafios | 661–713 |

## Respostas oferecidas às Questões em Aberto do GDD (§29)

Este documento não decide nada pelo GDD, mas oferece propostas concretas para cada ponto:

| Questão do GDD | Proposta neste documento |
|---|---|
| §29.1 Bônus de afinidade | Manter em +20%, com o Anel de Afinidade (§192) e as Guloseimas (§304) como alavancas do jogador |
| §29.2 Morte do personagem | §693 — lápide com metade dos recursos brutos, equipamento e time preservados |
| §29.3 Combate sozinho | Viável mas frágil: Kit de Primeiros Socorros (§675), Bomba de Fumaça (§167), armas de profissão |
| §29.4 Cama — detalhes | Quatro tiers (§271), Fontes Termais (§378) e Tenda (§672) como alternativas em campo |
| §29.5 Taunt | Armadilha de Rede (§169) como rota paralela do Engenheiro, mantendo o Taunt como identidade do Caçador |
| §29.6 Ovos | Incubadora (§233), Incenso Elemental (§341), Herança de Ovos (§540), Recinto (§256) |
| §29.7 Sagrado na progressão | Quest "O Último Sagrado" (§490), Aurora Boreal (§373), Eremita do Pico (§475), espécie Lumezinho (§444) |
| §29.8 Curva de XP | Maestria de Espécie (§534) e Vínculo Profundo (§354) como progressão de longo prazo *fora* do teto de 10 |

## Dívidas técnicas que este conteúdo torna mais urgentes

- O enum `MonsterElement` em [MonsterData.cs:5](Assets/Scripts/Data/MonsterData.cs:5) continua incompatível com os seis tipos (§20.8). Praticamente tudo neste documento depende dele.
- O stat `def` usado na fórmula de dano (§20.7) não existe na instância de Forgeling (§27.2). Armaduras, escamas e conjuntos elementais assumem que ele existirá.
- O personagem ainda não tem stats defensivos (§27.1) — e este documento propõe armaduras, temperatura e morte para ele.

## Próximas rodadas possíveis

Territórios que ainda comportariam uma varredura inteira: **roster completo de Forgelings** (uma linha evolutiva por página, com stats base), **catálogo de ataques por elemento** (a AtkPool de §24 espécie por espécie), **tabela de receitas com custos exatos**, **layout e mapa de cada dungeon**, **script de diálogo dos NPCs** e **curva numérica de XP e preços**.


