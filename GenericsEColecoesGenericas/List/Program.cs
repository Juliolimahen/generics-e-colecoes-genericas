var limiteCredito = new List<Limite>();

for (int i = 1; i < 16; i++)
{
    limiteCredito.Add(new Limite(){ Numero=i});
}

var limitesComRestricao = limiteCredito.Where(x=> x.AnaliseLimite()).ToList();

var primeiroLimiteComRestricao = limitesComRestricao.FirstOrDefault();
Console.WriteLine($"{primeiroLimiteComRestricao}.numero");

Console.WriteLine("\nFim do processamento...");

Console.ReadKey();

//para acessar o resultado apenas uma vez é recmendado usar IEnumerable(mais eficiente em relação ao memória)
//para acessar varias vezes é recomendado usar IList

if (limitesComRestricao.Count() > 3)
{
    Console.WriteLine("Temos mais de 3 limites ");
}

public class Limite
{
    public int Numero { get; set; }
    private bool isRestricao;

    public Limite()
    {
        var semente = Guid.NewGuid().GetHashCode();
        var numeroAleatorio = new Random(semente).Next(1, 4);
        isRestricao = numeroAleatorio == 1;
    }

    public bool AnaliseLimite()
    {
        Console.WriteLine($"Executa análise de limite de crédito para limte {Numero}");
        return isRestricao;
    }
}