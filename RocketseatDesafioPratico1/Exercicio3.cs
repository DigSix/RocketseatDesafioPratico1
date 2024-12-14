using System.Runtime.InteropServices;

namespace RocketseatDesafioPratico1;

public static class Exercicio3
{
    public static (double soma, double subtracao, double multiplicacao, double divisao, double media) Caulculos(double valor1, double valor2)
    {
        double soma = valor1 + valor2;
        double subtracao = valor1 - valor2;
        double multiplicacao = valor1 * valor2;
        double divisao = valor2 != 0 ? valor1 / valor2 : double.NaN;
        double media = (valor1 + valor2) / 2;

        return (soma, subtracao, multiplicacao, divisao, media);
    }

    public static void mostrarValores((double soma, double subtracao, double multiplicacao, double divisao, double media) valores)
    {
        Console.WriteLine($"Os valores são, soma:{valores.soma}, subtracao: {valores.subtracao}, multiplicacao: {valores.multiplicacao}, divisão: {valores.divisao}, media: {valores.media}");
    }
}
