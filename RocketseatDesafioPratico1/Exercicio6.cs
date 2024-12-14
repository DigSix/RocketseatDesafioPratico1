using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketseatDesafioPratico1;
public static class Exercico6
{
    public static void mostrarData()
    {
        var data = DateTime.UtcNow;
        var dataLocal = data.ToLocalTime();

        var formato1 = dataLocal.ToString("dddd, dd 'de' MMMM 'de' yyyy, HH:mm:ss");
        var formato2 = dataLocal.ToString("dd/MM/yyyy");
        var formato3 = dataLocal.ToString("HH:mm");
        var formato4 = dataLocal.ToString("dd 'de' MMMM");

        Console.WriteLine(formato1);
        Console.WriteLine(formato2);
        Console.WriteLine(formato3);
        Console.WriteLine(formato4);

    }
}
