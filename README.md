# Manipulacao de arquivos
### 👨🏽‍💻💻Um pouco sobre manipulação de arquivos em C#👨🏽‍💻💻

### 📂Introdução 📖
Olá novamente, hoje vou falar um pouco sobre manipulação de arquivos em C#. Primeiramente é necessário entender que o conceito de manipulação de arquivos é muito importante na programação, e que existem dois tipos de arquivos que são:

<ul>
  <li>Arquivo Texto: São os arquivos que conseguimos ler, arquivos que é possível entender o que está escrito, como por exemplo, arquivos .txt, .html, .docx, entre outros.</li>
  <li>Arquivo Binário: São os arquivos em que não conseguimos ler o seu conteúdo, apenas a máquina(computador) consegue entender, como por exemplo, arquivos .mp4, .pdf, .mp3, e assim por diante</li>
</ul>

Outra forma de identificar se um arquivo é de texto ou binário é o abrindo em um bloco de notas, no qual se aparecer símbolos que não fazem sentido nenhum e não for totalmente legíveis sabemos que é um arquivo binário, já se o arquivo estiver legível por inteiro sabemos que este é um arquivo texto.

### Qual é a diferença entre arquivos de texto e binário?

Na pratica a grande diferença entre arquivos de texto e arquivos binário é a seguinte, quando alguém escreve em um arquivo de texto, todos os valores são convertidos em strings e armazenados no arquivo de texto. Já os arquivos binários funcionam da seguinte maneira, ao invés de converter os valores e tipos em strings e depois disso salvar as strings no arquivo, o que ocorre é que todos os tipos e valores, são salvos da forma que são, ou seja, um array vai ser salvo como um array, um valor booleano será salvo como booleano e assim por diante.


### Requisitos para a manipulação de arquivos

Para que você consiga fazer a manipulação de arrquivos, é necessário o uso do `System.IO`, com ele é possível acessar métodos estáticos para a criação, cópia, exclusão, deslocamento e abertura de um arquivo, além de ajudar na criação de objetos FileStream.

# 📝 Escrita de arquivos de texto 📝
Para escrever arquivos de texto é necessário criar uma variável do tipo `StreamWriter`, definir um nome que será utilizado pelo StreamWriter e após isso você precisa criar um novo StreamWriter e passar um parametro que será o nome do arquivo junto com sua extensão. Um ponto a ser destacado sobre um arquivo, é que ele não é definido pela exttensão e sim pela forma do conteúdo que ele possui.

### Procurando o arquivo: 
>• Aba direita>nome do projeto>Abrir Pasta no Explorador de Arquivos>bin>debug>abrir o arquivo criado.

>• Aba direita>bin>debug>arquivo o arquivo criado.

### Adicionando outros valores sem apagar os valores que já estão inseridos no arquivo
Para que os valores que já foram inseridos não sejam apagados quando o código for executado, é usado o fluxo `.AppendText()`. Que é inserido no lugar do new StreamWriter. Ficando da seguinte forma.

• Criando um arquivo novo:<br>
<code>string StreamWriter escritor = new StreamWriter("teste.txt");</code>

• Modificando um arquivo existente:<br>
<code>StreamWriter escritor = File.AppendText("teste.txt");</code>

### Leitura de arquivos de texto

Para que a leitura de arquivos seja possível, é necessário o uso do `StreamReader`, e criar um novo StreamReader e inserir o nome do arquivo que você queira ler.

Uma forma utilizada para a leitura de linha por linha pe usando estrututa de repetição. Além de ser possível colocar essas linhas em uma lista que será acessada.

E a outra forma de exibir o valor da lista é usando a função `ReadToEnd` que surge depois da criação de uma variável junto com seu tipo. Ou seja.

<code>StreamReader leitor = new StreamReader("teste.txt");</code>

<code>string conteudo = leitor.ReadToEnd();</code>

# 📝 Manipulação de arquivo binários 📝
Para escrever em arquivos binários é necessário usar o `FileStream`, que serve para duas funções que são, escrita e leitura de arquivos, após isso ele segue o mesmo modelo `StreamWriter`.

<code>FileStream stream = new FileStream("teste.txt", FileMode.OpenOrCreate);</code>

Veja que agora adicionamos um parametro a mais ele serve para que, o arquivo seja criado caso não exista, e aberto se já existir. Após realizada a criação do arquivo é necessário usar o serealizador para que possamos escrever de forma binária no arquivo, o serealizador ira converter qualquer formato de dado, qualquer tipo para uma cadeia de byte, byte são vários bits(especificamente 8 bits) juntos que se tornam 1 byte, ou seja, para trabalhar com arquivos binários é necessário converter os dados em bytes. E oara fazer isso é necessário importar a biblioteca `System.Runtime.Serialization.Formatters.Binary`. Após isso pe preciso criar um BinaryFormatter com um nome que ele recebe-rá e logo após isso criar um novo BinaryFormatter. Com ele é possível escrever em arquivos binários como mostra o arquivo "AprendendoFiles.cs" que está neste mesmo repositório. Como é possível perceber, os valores precisam passar primeiro pelo formatador, e só após isso ele será armazenado no arquivo junto com seu valor. Além de ser possível trabalhar usando variáveis e listas no qual será necessário passar o nome da variável.

OBS: Para armazenar outros tipos de dados como structs ou funções, é encessário que acima do tipo tenha [System.Serializable], com isso os dados vão poder e serão armazenados em binários.
