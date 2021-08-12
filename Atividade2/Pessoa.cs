using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2
{
    abstract class Pessoa
    {
        private string Nome;

        public void Dormir()
        {
            Console.WriteLine("\nTodas as Pessoas Dormem ");
        }
        public string Nome1 { get => Nome; set => Nome = value; }
    }
}
