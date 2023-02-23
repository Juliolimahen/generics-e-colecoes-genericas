
Dictionary<int, int> dic1 = new Dictionary<int, int>();
var dic2 = new Dictionary<int, int>();

dic2.Add(1, 100);
dic2.Add(4, 400);
dic2.Add(6, 600);


var dic3 = new Dictionary<int, int>()
{
    {2,200},
    {3,300},
    {5,500}
};

try
{
    dic3.Add(2, 200);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
    Console.WriteLine("\n" + e.ToString());
}

Console.WriteLine("\nUsando o método TryAdd para a chave 3");
var resultado = dic3.TryAdd(2, 200);
Console.WriteLine("Elemneto foi incluido ? " + resultado);

if (!dic1.ContainsKey(7))
{
    Console.WriteLine("\nIncluido o elemento com chave 7 e valor 7000");
    dic3.Add(7, 7000);
}

Console.WriteLine(dic3[7]);

if (dic3.ContainsKey(7))
{
    Console.WriteLine("\nAlterando o valor do elmento com chave chave 7");
    dic3[7] = 7777;
}

Console.WriteLine("\nUsando tryGetValue() para a chave 5");

if (dic3.TryGetValue(5, out int valor))
{
    Console.WriteLine("Valor para a chave 5 = " + valor);
}
else
{
    Console.WriteLine("Chave não encontrada");
}

Console.WriteLine("\nPercorrendo o dicionario e exibindo os intens (foreach) ");

foreach (var item in dic3)
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}

Console.WriteLine("\nOrdenando os elementos do dicionario (SortedDictionary/LINQ) ");

//ordenado pela classe sortedDictionary
var dic3Ordenado = new SortedDictionary<int, int>(dic3);



foreach (var item in dic3Ordenado)
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}

var dic3OrdenadoLinq = dic3.OrderBy(x => x.Key);

Console.WriteLine("\nOrdenando os elementos do dicionario LINQ pelo OrderBy" );

foreach (var item in dic3OrdenadoLinq)
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}

Console.WriteLine("\nValor alterado do item " + dic3[7]);
Console.ReadKey();