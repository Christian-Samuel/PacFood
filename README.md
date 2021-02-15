# PacFood
Jogo simples desenvolvido para testar um sistema de fisica entre Controles no Visual Studio C#
Essa simulação gera automaticamente pequenos cubos que servem de alimentos para as celulas, que
nesse caso fazem o papel dos animais do jogo. Esses aniamis ao colidirem entre si geram um novo
animal, desde que ambos estejam alimentados e sejam de sexo opostos.A procriação torna os dois
animais inferteis, e a fertilidade só retornara ao se alimentarem.

![telaprincipal](https://github.com/Christian-Samuel/PacFood/blob/master/IMG/20210215_194720.gif?raw=true)


### CENARIO
Um cenario é gerado aleatóriamente(Controle.cs) e 2 animais são criados(Form1.cs).
Esse cenario e fixo e permanece inalterado até que o jogo seja reiniciado. Os animais atraves de um
sistema de colisão(Fisica.cs) detectam estes blocos e de forma aleatoria escolhem uma nova direção para seguir.

### COMIDA
A cada 5 segundos um novo alimento aparece em uma posição aleatoria no cenario, antes
de ser instanciado no cenario, ele verifica se não está sobrendo algum objeto do jogo(Animal,Cenario ou Comida),
caso positivo, sorteia uma nova posição até que a condição se torne falsa.

### ANIAMIS
A simulação começa com 2 animais, um controlado pelo computador e outro por você, e você precisa encostar no ani-
mal controlado pelo computador para que seja gerado um novo animal. Esse processo precisa ser repetido até que
algum animal do sexo 'M' seja criado, a partir deste momento a simulação continua por si só.
A movimentação dos animais controlados pelo computador acontece de forma aleatória, mas respeitando as regras pré-
estabelecidas pelo script Cells.cs.

-Inicio da Simulação:<br>
![telaprincipal](https://github.com/Christian-Samuel/PacFood/blob/master/IMG/PrimeiraTela.PNG?raw=true)


-Alguns minutos depois:<br>
![telaprincipal](https://github.com/Christian-Samuel/PacFood/blob/master/IMG/FinalTela.PNG?raw=true)


## Como abrir?
### Projeto
Este aplicativo foi desenvolvido no Visual Studio 2019.
Segue o link com o passo a passo de como carregar o projeto.
https://docs.microsoft.com/pt-br/visualstudio/get-started/tutorial-open-project-from-repo?view=vs-2019

### Executavel
Faça download do arquivo executavel que se encontra na pasta "App"
