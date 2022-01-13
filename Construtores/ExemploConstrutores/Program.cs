using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class Program
    {

        public delegate void Operacao(int x, int y); //criação do delegate

        static void Main (string[] args)
        {

            // ------------------------------------------ Aula 1 -----------------------------------------


            // Pessoa p1 = new Pessoa("Loui", "Baitel"); //Devido a criação do construtor com parametros vazios, pode-se ou não colocar parametros
            // p1.Apresentar();


            //---------------------------------------- Aula 2 - Construtores privados --------------------


            // Log log = Log.GetInstance();

            // log.PropriedadeLog = "Teste Instância";

            // Log log2 = Log.GetInstance();
            // System.Console.WriteLine(log2.PropriedadeLog);


            // ----------------------------------- Aula 2 - Construtor + Herança --------------------------


            // Aluno p1 = new Aluno("Loui", "Baitel", "c#");
            // p1.Apresentar();


            // ------------------------------------ Aula 3 - Get e Set -------------------------------------
            

            // Data data = new Data();
            // data.SetMes(20);

            // // Utilizando a propriedade
            // data.Mes = 12;
            // System.Console.WriteLine(data.Mes);

            // data.ApresentarMes();


            //----------------------------------------- Constantes ----------------------------------------


            // const double pi = 3.14;
            // System.Console.WriteLine(pi);


            // ------------------------------------------- Delegate ---------------------------------------


            //Operacao op = Calculadora.Somar;
            // Operacao op = new Operacao(Calculadora.Somar);
            
            // op += Calculadora.Subtrair; // delegate multi cast
            
            // op.Invoke(10, 10);
            // op(10,10); //segunda forma de usar o delegate.


            //-------------------------------------------- Eventos -----------------------------------------


            Matematica m = new Matematica(10,20);
            m.Somar();
        }
    }
}