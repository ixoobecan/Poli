using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.src
{
    internal class Vaca : Animal
    {
        public Vaca(string nome, int idade, string cor, string classe, string especie) : base(nome, idade, cor, classe, especie)
        {
        }
    }
}
