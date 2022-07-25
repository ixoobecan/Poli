using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.src
{
    internal class Gato : Animal
    {
        public Gato(string nome, int idade, string cor, string classe, string especie) : base(nome, idade, cor, classe, especie)
        {
        }

        public virtual void Dormir()
        {

        }
        public virtual void Comer() { }


            
        
    }
}