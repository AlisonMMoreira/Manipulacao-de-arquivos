// Criando e escrevendo em um arquivo de texto

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace AprendendoFiles
{
	
	class Program
	{
	static void Main(string[] args)
		{
			StreamWriter escritor = new StreamWriter("teste.txt");
			escritor.WriteLine("Alison");
			escritor.WriteLine("Moreira");
			escritor.WriteLine("Curso de C#");
			escritor.Close();
			Console.WriteLine("Arquivo gerado");
			Console.ReadLine();
		}
	}
}

// Adicionando novas informações um arquivo de texto

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace AprendendoFiles
{
	
	class Program
	{
	static void Main(string[] args)
		{
			/*É necessário mudar apenas uma linha do programa, no qual ao invés de receber `StreamWriter` a recebera o parametro de `File.AppendText`*/
			StreamWriter escritor = File.AppendText("teste.txt");
			escritor.WriteLine("Alison");
			escritor.WriteLine("Moreira");
			escritor.Close();
			Console.WriteLine("Arquivo gerado");
			Console.ReadLine();
		}
	}
}

// Lendo um arquivo de texto com estruturas de repetição

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace AprendendoFiles
{
	
	class Program
	{
	static void Main(string[] args)
		{
			StreamReader leitor = new StreamReader("teste.txt");
		
			string = "";
			while(linha != null)
			{
				linha = leitor.ReadLine();
				if(linha != null)
			}
			Console.WriteLine(linha);
		}
	}
	leitor.Close();
}

// Lendo um arquivo com ReadToEnd

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace AprendendoFiles
{
	
	class Program
	{
	static void Main(string[] args)
		{
			StreamReader leitor = new StreamReader("teste.txt");
			string conteudo = leitor.ReadToEnd();
		}
	}
}


// Criando e escrevendo em um arquivo binário

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace AprendendoFiles
{
	
	class Program
	{
	static void Main(string[] args)
		{
			FileStream stream = new FileStream("teste.txt", FileMode.OpenOrCreate);
			BinaryFormatter encoder = new BinaryFormatter();
		
			encoder.Serialize(stream, 120);
			encoder.Serialize(stream, "Alison Moreira");
			encoder.Serialize(stream, true);
		
			stream.Close();
		}
	}
}

// Escrevendo uma lista em um arquivo binário

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace AprendendoFiles
{
	
	class Program
	{
	static void Main(string[] args)
		{
			List<string> clientes = new List<string>();
            		clientes.Add("Yuri");
            		clientes.Add("André");
            		clientes.Add("Marcelo");
            		clientes.Add("Mateus");
            		string fornecedor = "Guilherme Prata";
            		clientes.Add(fornecedor);
		
			FileStream stream = new FileStream("teste.txt", FileMode.OpenOrCreate);
			BinaryFormatter encoder = new BinaryFormatter();
		
			encoder.Serialize(stream, clientes);
		
			stream.Close();
		}
	}
}

// Leitura de um arquivo binário

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace AprendendoFiles
{
	
	class Program
	{
	static void Main(string[] args)
		{	
			List<string> listaDoArquivo = (List<string>)enconder.Deserialize (stream);
			Produto prod = (Produto)enconder.Deserialize (stream);
		
			Console.WriteLine(listaDoArquivo);
			Console.WriteLine(prod.nome);
		
			stream.Close();
		}
	}
}
