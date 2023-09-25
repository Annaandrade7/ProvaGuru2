using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuruDev2._0.Programas
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; set; } 
        public string Matricula { get; set; }
        public DateOnly DataNas { get; set; }
        public string Sexo { get; set; }
        public double Salario { get; set; }

        public override Funcionario(string nome, string cpf, string matricula,
            DateOnly dataNas, string sexo, double salario)
        {
            this.Nome = nome;
            this.CPF = cpf;
            this.Matricula = matricula;
            this.DataNas = dataNas;
            this.Sexo = sexo;
            this.Salario = salario;
        }
    }
}
