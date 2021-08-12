using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2
{
    class Aluno:Pessoa
    {
        private string Matricula;

        public void Estudar()
        {
            Console.WriteLine("\n" + Nome1 + " está estudando...");
        }
        public string Matricula1 { get => Matricula; set => Matricula = value; }
    }
}
