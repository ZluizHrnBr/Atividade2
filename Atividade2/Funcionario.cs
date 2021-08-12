using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2
{
    class Funcionario:Pessoa
    {
        private string Departamento;

        public void Trabalhar()
        {
            Console.WriteLine("\n" + Nome1 + " está trabalhando no departamento.... " + Departamento);
        }

        public string Departamento1 { get => Departamento; set => Departamento = value; }
    }
}
