using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketseatDesafioPratico1;
public static class Exercicio5
{
    public static void validarPlaca()
    {
        Console.WriteLine("Escreva a placa segundo o padrão brasileiro valido ate 2018");
        var placa = Console.ReadLine();
        Console.Clear();

        if(placa.Length != 7)
        {
            Console.WriteLine("A placa nao e valida");
            return;
        }

        placa = placa.ToUpper();

        for(int i = 0; i < placa.Length; i++)
        {
            if(char.IsDigit(placa[i]) && i < 3)
            {
                Console.WriteLine("A placa nao e valida");
                return;
            }
            if (char.IsLetter(placa[i]) && i > 2)
            {
                Console.WriteLine("A placa nao e valida");
                return;
            }
        }

        Console.WriteLine($"A placa {placa} e valida");
    }
}
