/* 

Com os conceitos de hoje (métodos, arrays, strings) estamos prontos para pensar no nosso projeto final: o Jogo da Forca no console. Vamos aproveitar os últimos minutos desta aula para planejar como será a implementação, dividindo em etapas lógicas. Na próxima aula, vamos programá-lo passo a passo.

Regras do jogo da forca (resumo): O computador deve escolher uma palavra secreta, e o jogador vai tentando adivinhar letras. A cada letra errada, o jogador “perde” uma vida (tentativa). Se o jogador revelar todas as letras da palavra antes de esgotar as tentativas, ele vence; se as tentativas acabarem primeiro, ele perde. Em modo texto, podemos simplesmente informar o número de tentativas restantes e mostrar a palavra com os espaços preenchidos conforme as letras forem descobertas.

Etapas para implementar:
	1.	Escolha da palavra secreta: Podemos ter uma lista (array ou List<string>) de palavras possíveis no programa e selecionar uma aleatoriamente com Random. Para simplificar, podemos começar com uma palavra fixa para testar a lógica e depois adicionar aleatoriedade.
	2.	Configuração inicial: Criar um array de caracteres para representar o estado atual das letras descobertas. Por exemplo, se a palavra é “MACA”, podemos ter um array {'_', '_', '_', '_'} no início, indicando que nenhuma letra foi revelada ainda.
	3.	Loop de jogo: Enquanto houver tentativas disponíveis e a palavra não estiver totalmente descoberta:
	•	Mostrar o estado atual (ex: “_ _ _ _”) e o número de tentativas restantes.
	•	Pedir ao jogador que chute uma letra.
	•	Verificar se a letra já foi tentada (podemos manter uma lista de letras já chutadas para não repetir).
	•	Verificar se a letra existe na palavra:
	•	Se sim, revelar todas ocorrências dessa letra no array de estado (substituir ‘_’ pela letra nas posições corretas).
	•	Se não, decrementar o contador de tentativas (e talvez informar letras erradas já chutadas).
	4.	Fim do jogo: Verificar se o jogador venceu (todas letras reveladas) ou perdeu (tentativas chegaram a 0). Mostrar a palavra completa e uma mensagem adequada.

Podemos escrever alguns métodos para ajudar:
	•	Um método para verificar se a palavra está completa (se não há mais ‘_’ no array de estado).
	•	Um método para revelar letras dada a palavra e o chute (atualizando o array de estado e retornando verdadeiro/falso se acertou).
	•	Talvez um método para escolher palavra aleatória de uma lista.


------------- Regras
1. O jogo escolhe aleatoriamente uma palavra 
   em maiúsculas de um dicionário interno com ≥ 10 itens.
   Não vale uma palavra fixa.
2. Exibe o “painel” da palavra como _ _ _ _ 
   (com espaços) e o contador de erros restantes (6).
3. Lê uma letra por tentativa (Console.ReadKey(true)).
   Mostre a letra lida depois.
4. Se a letra já foi tentada, avise e não desconta tentativa.
   Lista de tentadas visível.
5. Se a letra existe, revela todas ocorrências.
   Ex.: “BANANA” e chute A → _ A _ A _ A.
6. Se erra, decrementa contador; ao chegar a 0, 
    exibe “Você perdeu” e mostra a palavra.
7. Quando todas as letras forem reveladas, 
     exibe “Parabéns” e número de erros usados.
8. Após vitória/derrota, pergunta “Jogar de novo? (S/N)”; 
     se “S” reinicia com nova palavra.
   Deve resetar estado.

Aula anterior: https://github.com/xxmgkxx/aula3_cshapr_puc
dotnet new console -n Forca
cd Forca
*/