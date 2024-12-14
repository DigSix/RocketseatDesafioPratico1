namespace RocketseatDesafioPratico1;

public class Exercicio4
{
    public static void mostrarCaracteres()
    {
        Console.WriteLine("Olá, escreva uma palavra.");
        var palavra = Console.ReadLine();
        var caracteres = palavra.Length;
        Console.Clear();
        Console.WriteLine($"A palavra '{palavra}' possui {caracteres} caractere(s).");
    }
}
