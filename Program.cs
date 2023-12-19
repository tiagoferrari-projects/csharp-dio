using csharp_dio_array.models;
using System.Globalization;
using System.Security.Cryptography;


Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "São Paulo");
estados.Add("BA", "Bahia");
estados.Add("RS", "Rio Grande do Sul");

Console.WriteLine(estados["RS"]);


foreach (KeyValuePair<string, string> item in estados)
{
  Console.WriteLine($"Chave: {item.Key} - Valor: {item.Value}");
}

Console.WriteLine("****************");

estados.Remove("BA");
estados["SP"] = "São Paulo - valor alterado";

foreach (KeyValuePair<string, string> item in estados)
{
  Console.WriteLine($"Chave: {item.Key} - Valor: {item.Value}");
}

string chave = "SC";
Console.WriteLine($"Verificando o elemento: {chave}");

if (estados.ContainsKey(chave))
{
  Console.WriteLine($"Valor existente: {chave}");
}
else
{
  Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {chave}");
}


// --------------------------------------------------------------------------

// Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach (int item in pilha)
// {
//   Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");

// pilha.Push(20);
// foreach (int item in pilha)
// {
//   Console.WriteLine(item);
// }


// --------------------------------------------------------------------------

// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach (int item in fila)
// {
//   Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");

// fila.Enqueue(10);
// foreach (int item in fila)
// {
//   Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");


// --------------------------------------------------------------------------

// new ExemploExcecao().Metodo1();

// try
// {
//   string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");
//   foreach (string linha in linhas)
//   {
//     Console.WriteLine(linha);
//   }
// }
// catch (FileNotFoundException ex)
// {
//   Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado! {ex.Message}");
// }
// catch (DirectoryNotFoundException ex)
// {
//   Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Verifique o caminho especificado! {ex.Message}");
// }
// catch (Exception ex)
// {
//   Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// }
// finally
// {
//   Console.WriteLine("Chegou até aqui");
// }


// --------------------------------------------------------------------------

//DateTime data = DateTime.Now;
//DateTime data = DateTime.Parse("07/01/1994 10:31");

// string dataString = "2023-13-17 18:00";

// bool sucesso = DateTime.TryParseExact(dataString,
//                       "yyyy-MM-dd HH:mm",
//                       CultureInfo.InvariantCulture,
//                       DateTimeStyles.None, out DateTime data);

// if (sucesso)
// {
//   Console.WriteLine($"Conversão com sucesso! Data: {data}");
// }
// else
// {
//   Console.WriteLine($"{dataString} não é uma data válida!");
// }

// --------------------------------------------------------------------------

//Console.WriteLine(data);
// Console.WriteLine(data.ToShortDateString());
// Console.WriteLine(data.ToShortTimeString());
// Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));

// --------------------------------------------------------------------------

// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// decimal valorMonetario = 2382.40M;
// Console.WriteLine($"{valorMonetario:C}");
// Console.WriteLine(valorMonetario.ToString("C1"));
// Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));

// double porcentagem = .3421;
// Console.WriteLine(porcentagem.ToString("P"));

// int numero = 123456;
// Console.WriteLine(numero.ToString("##-##-##"));

// --------------------------------------------------------------------------

// int numero1 = 10;
// string numero2 = "20";
// string resultado = numero1 + numero2;
// Console.WriteLine(resultado);

// --------------------------------------------------------------------------

// Pessoa p1 = new Pessoa(nome: "Tiago", sobrenome: "Ferrari");
// Pessoa p2 = new Pessoa(nome: "Angela", sobrenome: "Almeida Ferrari");

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Inglês";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();