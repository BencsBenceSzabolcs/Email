using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("0. Kilépés");
                Console.WriteLine("1. e-mailek listázása");
                Console.WriteLine("2. új-email");
                Console.WriteLine("3. e-mail törlése");
                Console.WriteLine("4. érvényes e-mailok listázása");

                string valasztas=Console.ReadLine();
                switch (valasztas) {
                    case "0" : return;
                    case "1" : Console.WriteLine("e-mailek listázása"); break;
                    case "2" : Console.WriteLine("új e-mailek"); break;
                    case "3" : Console.WriteLine("e-mailek törlése"); break;
                    case "4" : Console.WriteLine("évényesek listázása"); break;
                    default: Console.Clear(); Console.WriteLine("rossz parancs"); break;
                }
                Console.ReadKey();
            }
        }
    }
}
