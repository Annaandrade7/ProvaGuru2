using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuruDev2._0.Programas
{
    internal class Adiministrativo : Funcionario
    {
        public int ValeTras { get; set; }
        public double ValeAli { get; set; }

        public Adiministrativo(int valeTras, double valeAli)
        {
            ValeTras = valeTras;
            ValeAli = valeAli;
        }
    }
}
