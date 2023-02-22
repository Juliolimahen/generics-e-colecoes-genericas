
#region HashSet<T> - Criação 
//HashSet<T> - Criação 
//Possui sete construtores que podem ser usados para crar uma instância de HashSet<T>
//HashSet<T>() - inicializa uma nova instancia da classe HashSet<T> que está vazia e usa o comparador de igualdade padão para tipi conjunto.

//HashSet<T> - proprieadade
//Count - Retorna o número de elementos no HashSet
//Comparer - Retorna o objeto IEqualityComparer<T> que é usado para determinar a igualdade dos elementos no HashSet

HashSet<int> result = new HashSet<int>();
var numeros = new HashSet<int> { 1, 2, 3, 4, 5 };
var frutas = new HashSet<string> { "uva", "banana", "pera" };
var timesBA = new HashSet<string> { "Bahia", "Vitória", "Juazeiro" };
var timesRJ = new HashSet<string> { "Vasco", "Flamengo", "Fluminense" };
var timesSP = new HashSet<string> { "Conrinthians", "São Paulo", "Santos" };
var timesMundiais = new HashSet<string> { "Conrinthians", "São Paulo", "Santos", "Flamengo" };

////Criando um HashSet e adicionando elementos com método Add
//AtribuirValor(result);

//ExibirColecao(result);


#endregion

//Construtor usando IEnumerable
#region Construtor usando IEnumerable

InicializarHashSets();

Console.ReadKey();

static void InicializarHashSets()
{
    //int
    var lista1 = new List<int> { 1, 2, 3, 4, 5, 6, 7 };

    var conjunto = new HashSet<int>(lista1);

    //string 
    var lista2 = new List<string> { "uva", "abacte", "pera" };

    HashSet<string> minhasFrutas = new HashSet<string>(lista2);

    //array
    var impares = new int[] { 1, 3, 5, 7, 9, 11, 13 };
    HashSet<int> meuhashset = new HashSet<int>(impares);
}

#endregion

#region Métodos Auxiliares


static void AtribuirValor(HashSet<int> result)
{
    for (int i = 0; i < 6; i++)
    {
        result.Add(i * 2);
    }
}
#endregion

#region Metodos para fazer verificações 

void verificacoes()
{
    //verificar se já existe na coleção
    if (!timesSP.Contains("Palmeiras"))
    {
        timesSP.Add("Palmeiras");
    }

    //verificar subconjunto 
    if (timesSP.IsSubsetOf(timesMundiais))
    {
        Console.WriteLine("timesSP é um subconjunto de timesMundiais \n");
    }

    //verificar se é um superconjunto
    if (timesMundiais.IsSupersetOf(timesSP))
    {
        Console.WriteLine("times mundiais é um superconjunto de timesSP\n");
    }

    //verficar se comtem itens de outros conjuntos
    if (timesRJ.Overlaps(timesMundiais))
    {
        Console.WriteLine("Pelo menos um time do RJ tem um mundial");
    }

    if (!timesRJ.SetEquals(timesBA))
    {
        Console.WriteLine("TimesBA e TimesRJ são diferentes, não comteém clubes iguais");
    }
}
#endregion

#region Unir Conjuntos

void UnirEOdenarConjuntos()
{
    var timesBR = timesSP.Union(timesRJ);
    timesBR = timesBR.Union(timesBA);

    //ordenando conjunto
    var timesOrdenados = new SortedSet<string>(timesBR);

    ExibirColecao(timesBR);
    ExibirColecao(timesOrdenados);
}
#endregion

#region Intersecção de dois Hash set<T>

void InterseccaoDeDoisHashSet()
{
    Console.WriteLine("\n Intersecção de dois Hash set<T>: TimesSP e Tmes timesMundiais");

    timesSP.IntersectWith(timesMundiais);

    ExibirColecao(timesSP);
}
#endregion

#region Diferença dois Hash set
void DiferencaDoisHashSet()
{
    Console.WriteLine("Diferença: TimesSP e Tmes timesMundiais");

    timesMundiais.ExceptWith(timesSP);

    ExibirColecao(timesMundiais);
}
#endregion

# region Diferença de dois HashSet com SymmetricExcepition
void DiferencaDeDoisHashSetComSymmetricExcepition()
{
    Console.WriteLine("Diferença de dois HashSet: TimesSP e timesMundiais com SymmetricExcepition");

    timesMundiais.SymmetricExceptWith(timesSP);

    ExibirColecao(timesMundiais);
}
#endregion

#region Limpar HashSet
void LimparHashSet()
{
    timesMundiais.Clear();
    ExibirColecao(timesMundiais);
}
#endregion

#region Métodos para exibir coleções genericas
//criar metodos "<T> IEnumerable<T>" genericos para utilizar em qualquer tipo de coleção
static void ExibirColecao<T>(IEnumerable<T> timesBR)
{
    Console.WriteLine();

    foreach (var item in timesBR)
    {
        Console.WriteLine(item);
    }
}
#endregion
