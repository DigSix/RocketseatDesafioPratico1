namespace RocketseatDesafioPratico1;

static class Exercicio2
{
    public static void ConcatenarNomeESobrenome()
    {
        Console.WriteLine("Olá, por gentileza escreva seu nome.");
        var nomeUsuario = Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Quantos sobrenome(s) você tem?.");
        var numeroDeSobreNomes = int.Parse(Console.ReadLine());
        Console.Clear();

        List<string> listaSobreNomes = new List<string>();

        for (int i = 0; i < numeroDeSobreNomes; i++)
        {
            Console.WriteLine($"Escreva seu {i+1}º sobrenome.");
            listaSobreNomes.Add( Console.ReadLine() );
            Console.Clear();
        }

        var sobreNomes = "";

        for (int i = 0;i < numeroDeSobreNomes; i++)
        {
            sobreNomes = string.Concat(sobreNomes, " ", listaSobreNomes[i]);
        }

        var nomeCompleto = string.Concat(nomeUsuario, "", sobreNomes);
        
        Console.WriteLine($"Bem vindo {nomeCompleto}!");
    }
}

