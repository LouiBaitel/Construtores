namespace ExemploConstrutores.Models
{
    public class Aluno : Pessoa 
    {
        //com base(parametros) conseguimos passar os parametros para classe mae
        public Aluno(string nome, string sobrenome, string disciplina) : base(nome, sobrenome) 
        {
            System.Console.WriteLine("Construtor classe aluno");
        }
    }
}