using System;
namespace app.src
{
   public class Animal
    {
       public string Classe { get; set;} 
       public int Idade {get; set;}
       public string Cor {get; set;} 
       public string Especie {get; set;}
       public string Nome{ get; set;}

        public Animal(string nome, int idade, string cor, string classe, string especie)
        {
            Nome = nome;
            Idade = idade;
            Cor = cor;
            Classe = classe;
            Especie = especie;

        }



       public virtual void Dormir (string Nome)
       {
        Console.WriteLine($"{Nome} esta dormindo");
       }
       public virtual void Comer (string Nome)
       {
         Console.WriteLine($"{Nome} esta comendo");
       }
       public virtual void Cagar (string Nome)
       {
         Console.WriteLine($"{Nome} esta fazendo coco");
       }
       public virtual void Mamar (string Nome)
       {
         Console.WriteLine($"{Nome} esta mamando");
       }



    
 
    }
}

