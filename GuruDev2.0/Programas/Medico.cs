
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuruDev2._0.Programas
{
    internal class Medico : Funcionario
    {
        public string CRM { get; set; }
        public double horaExtra { get; set; }
        public string Especialidade { get; set; }

        //public Medico();

        /*public override Funcionario(string nome, string cpf, string matricula,
            DateOnly dataNas, string sexo, double salario)
        {
            this.Nome = nome;
            this.CPF = cpf;
            this.Matricula = matricula;
            this.DataNas = dataNas;
            this.Sexo = sexo;
            this.Salario = salario;
        }*/
        public Medico(string cRM, double horaExtra, string especialidade)
        {
            this.CRM = cRM;
            this.horaExtra = horaExtra;
            this.Especialidade = especialidade;
        }
    }
}
