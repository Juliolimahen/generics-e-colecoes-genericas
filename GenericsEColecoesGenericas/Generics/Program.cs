
//Segurança de tipo
//Definido o tipo na intanciação da classe 
Teste<int, int> testeInt = new Teste<int, int>();

//Segurança de tipo
Teste<float, float> testeFloat = new Teste<float, float>();

int i1 = 20;
int i2 = 20;

testeInt.Comparar(i1, i2);

float f1 = 10.4f;
float f2 = 10.4f;

testeFloat.Comparar(f1, f2);

Console.ReadKey();

public class Teste<T1, T2> where T1 : struct where T2 : struct //Deginido que só aceita tipo por valor
{
    #region Definindo tipo generico
    //public void Comparar<T>(T p1, T p2)
    //{
    //    Console.WriteLine($" Os tipos : {p1.GetType()} e {p1.GetType()}");
    //    //Equals compara o conteúdo e o tipo de dados
    //    //enquanto o operador == compara as referências 
    //    var result = p1.Equals(p2);
    //    Console.WriteLine($"{p1} e {p2} são iguais? {result}");
    //}
    #endregion

    public void Comparar(T1 p1, T2 p2)
    {
        Console.WriteLine($" Os tipos : {p1.GetType()} e {p1.GetType()}");
        var result = p1.Equals(p2);
        Console.WriteLine($"{p1} e {p2} são iguais? {result}");
    }

    #region Definido tipos genericos multiplos
    //public void Comparar<T1, T2>(T1 p1, T2 p2)
    //{
    //    Console.WriteLine($" Os tipos : {p1.GetType()} e {p1.GetType()}");
    //    var result = p1.Equals(p2);
    //    Console.WriteLine($"{p1} e {p2} são iguais? {result}");
    //}
    #endregion

    #region sobrecarga para tocar tipo de parametro (Forma errada)
    ////problema
    //public void Comparar(float p1, float p2)
    //{ 
    //    var result = p1.Equals(p2);
    //    Console.WriteLine($"{p1} e {p2} são iguais? {result}");
    //}
    #endregion  
}