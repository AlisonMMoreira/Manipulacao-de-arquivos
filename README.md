# Manipulacao-de-arquivos
### 👨🏽‍💻💻Um pouco sobre manipulação de arquivos em C#👨🏽‍💻💻

### 📂Introdução 📖
Olá novamente, hoje vou falar um pouco sobre manipulação de arquivos em C#. Primeiramente é necessário entender que o conceito de manipulação de arquivos é muito importante na programação, e que existem dois tipos de arquivos que são:

<ul>
  <li>Arquivo Texto: São os arquivos que conseguimos ler, arquivos que é possível entender o que está escrito, como por exemplo, arquivos .txt, .html, .docx, entre outros.</li>
  <li>Arquivo Binário: São os arquivos em que não conseguimos ler o seu conteúdo, apenas a máquina(computador) consegue entender, como por exemplo, arquivos .mp4, .pdf, .mp3, e assim por diante</li>
</ul>

Outra forma de identificar se um arquivo é de texto ou binário é o abrindo em um bloco de notas, no qual se aparecer símbolos que não fazem sentido nenhum e não for totalmente legíveis sabemos que é um arquivo binário, já se o arquivo estiver legível por inteiro sabemos que este é um arquivo texto.

### Requisitos para a manipulação de arquivos

Para que você consiga fazer a manipulação de arrquivos, é necessário o uso do `System.IO`, com ele é possível acessar métodos estáticos para a criação, cópia, exclusão, deslocamento e abertura de um arquivo, além de ajudar na criação de objetos FileStream.

### Gravando no arquivo
Para adicionar a capacidade de gravar em um arquivo por meio do aplicativo, use a classe `StreamWriter`. StreamWriter foi criado para a saída de caracteres em uma determinada codificação, enquanto a classe `Stream` foi criada para entrada e saída em bytes. Use StreamWriter para gravar linhas de informações em um arquivo de texto padrão. 
