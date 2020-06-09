# #️⃣👵 Jogo da velha feito em C#
> Jogo da velha é um jogo com regras extremamente simples, que não traz grandes dificuldades para seus jogadores e é facilmente aprendido. A origem é desconhecida, com indicações de que pode ter começado no antigo Egito, onde foram encontrados tabuleiros esculpidos na rocha, que teriam mais de 3.500 anos. 

## 🎮 Código
* A codificação desse jogo é super simples, mas não deixa de ser um ótimo exercício para a lógica de programação. Esse algoritmo está resolvendo o tabuleiro de forma automática a partir de números aleatórios.

## 📊 Curiosidades sobre o jogo

* Analisando o número de possibilidades de forma simplista, existem 362.880 (ou 9!) maneiras de se dispor o X e o círculo no tabuleiro, sem considerar jogadas vencedoras. Quando consideramos as combinações vencedoras, existem 255.168 jogos possíveis. Assumindo que 'X' inicia o jogo (se considerar que 'O' inicia, os resultados passam a ser inversos), temos:

**131.184** jogos finalizados são ganhos por **'X'**

**1.440** são ganhos por **'X'** após 5 movimentos

**47.952** são ganhos por **'X'** após 7 movimentos

**81.792** são ganhos por **'X'** após 9 movimentos

**77.904** jogos finalizados são ganhos por **'O'**

**5.328** são ganhos por **'O'** após 6 movimentos

**72.576** são ganhos por **'O'** após 8 movimentos

**46.080** jogos finalizados resultam em empate

Ignorando jogadas simétricas (outras jogadas rotacionadas ou refletidas), existem apenas **138** resultados únicos. Assumindo novamente que **'X'** sempre inicia o jogos, temos:

**91** resultados únicos são ganhos por **'X'**

**21** são ganhos por **'X'** após 5 movimentos

**58** são ganhos por **'X'** após 7 movimentos

**12** são ganhos por **'X'** após 9 movimentos

**44** resultados únicos são ganhos por **'O'**

**21** são ganhos por **'O'** após 6 movimentos

**23** são ganhos por **'O'** após 8 movimentos

**3** resultados únicos são empates
