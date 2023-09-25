using GuruDev2._0.Programas;
using System;
class Progm
{
    static void Main(string[] args)
    {

        List<Funcionario> listFun = new List<Funcionario>();

        List<Medico> listMed = new List<Medico>();
        
        List<Adiministrativo> listAds = new List<Adiministrativo>();

        while (true)
        {
            Console.WriteLine("Seja bem vindo ao controle de funcionario!");
            Console.WriteLine("Qual dos tres abaixo você é?" +
                "\n 1 - Funcionario Comum" +
                "\n 2 - Medico" +
                "\n 3 - Funcionario Adiministrativo" +
                "\n 4 - Sair ");
            int opcao = Convert.ToInt32(Console.ReadLine());

            if( opcao == 1 )
            {
                Console.WriteLine("Nos informe seu nome:");
                nome = Console.ReadLine();
            }


            if(opcao == 4)
            {
                Console.WriteLine("Até a proxima!");
                
            }
        }

    }
}