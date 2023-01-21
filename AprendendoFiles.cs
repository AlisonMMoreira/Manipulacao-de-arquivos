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
