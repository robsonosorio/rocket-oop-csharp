using System;
using System.Collections.Generic;
using System.Text;

namespace Secao09.Exercicios.Exercicio_01.Entities
{
    public class Department
    {
        public string Name { get; set; }

        public Department()
        {
        }

        public Department(string name)
        {
            Name = name;
        }
    }
}
