namespace RocketseatDesafioPratico1;

public static class Exercicio4
{
    public static void mostrarCaracteres()
    {
        Console.WriteLine("Olá, escreva uma palavra.");
        var palavra = Console.ReadLine();
        Console.Clear();
        Console.WriteLine($"A palavra '{palavra}' possui {palavra.Length} caractere(s).");
    }
}
