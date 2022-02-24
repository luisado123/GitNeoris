using System;

namespace LuisDeivid
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.MetodoLuis();
            program.MetodoDeivid();
        }

        public void MetodoLuis()
        {
            Console.WriteLine("Este es el metodo de luis");
        }
        public void MetodoDeivid()
        {
            Console.WriteLine("Este es el metodo de Deivid");
            Console.WriteLine("Hola mundo!!");
            Console.WriteLine("Hola mundo x2!!");
            Console.WriteLine("Hola mundo x3 :v!!");
            Console.WriteLine("Hola mundo x4 :v!!");
        }

    }
}
