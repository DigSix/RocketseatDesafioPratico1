namespace RocketseatDesafioPratico1;

    static class Exercicio1
    {
        public static void MenssagemDeBoasVindas()
        {
            Console.WriteLine("Olá, por gentileza escreva seu nome.");
            var nomeUsuario = Console.ReadLine();
            Console.WriteLine($"Bem vindo {nomeUsuario}!");
        }
    }

