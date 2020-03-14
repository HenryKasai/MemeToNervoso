using System;

namespace MemeToNervoso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EU TE ACHO MUITO SEM GRAÇA BIXO");
            Console.WriteLine("E o que você pensa de mim?");
            string pensamento = Console.ReadLine();
            Console.Clear();
            Console.WriteLine(pensamento .Remove(14) + "......" + " NÃO, PERA. Tô nervoso.");

        }
    }
}
