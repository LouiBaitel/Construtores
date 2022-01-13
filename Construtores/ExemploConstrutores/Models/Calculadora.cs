namespace ExemploConstrutores.Models
{
    public class Calculadora
    {
        //Delegate
        public delegate void DelegateCalculadora();

        //Evento
        public static event DelegateCalculadora EventoCalculadora;
        public static void Somar (int x, int y) //Se possuir inscritos no evento
        {
            if (EventoCalculadora != null)
            {
                System.Console.WriteLine($"Adição: {x + y}");
                EventoCalculadora();
            }
            else{
                System.Console.WriteLine("Nenhum Inscrito");
            }
            
        }

        public static void Subtrair (int x, int y)
        {
            System.Console.WriteLine($"Adição: {x - y}");
        }
    }
}