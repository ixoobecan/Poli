using System;
using app.src;

namespace app
{
    class Program
    {
        public Program()
        {
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Bem Vindo ao Campo");
            Console.WriteLine("Para Listar os animais que pode encontar digite 0 ");
            Console.WriteLine("Para sair digite outra tecla");
            int opcao = int.Parse(Console.ReadLine());

            if (opcao == 0);
        }
        Animal karin = new Gato("Karin", 2, "Branco", "Mamifero", "Felis catus");
        Animal rocambole = new Morcego("Rocambole", 1, "Preto", "Mamifero", "Mormopterus");
        Animal mimosa = new Vaca("Mimosa", 5, "Marron", "Mamifero", "Bos taurus");






    }
}

