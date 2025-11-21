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
            //adatszerkezet
            List<string> e_mailok = new List<string>();
            e_mailok.Add("alma1@kört.hu");
            e_mailok.Add("alma2@asda.hu");
            e_mailok.Add("alma3@kirk.hu");
            e_mailok.Add("bencsb@kkszki.hu");
            e_mailok.Add("avavavavav@aaaa.hu");
            //menüvezérlés
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
                    case "1" : Console.WriteLine("e-mail címet:");
                        int sorszam = 0;
                        foreach (String e_mail in e_mailok)
                        {
                            Console.WriteLine($"{sorszam++} {e_mail}");
                        }
                        break;
                    case "2" : Console.WriteLine("Adja meg az új e-mailcímet:");
                        String uj = Console.ReadLine();
                        e_mailok.Add(uj);
                        break;
                    case "3" : Console.WriteLine("Adja meg a törlendő e-mail azonosítóját:");
                        int index = Convert.ToInt32(Console.ReadLine());
                        e_mailok.RemoveAt(index);
                        break;
                    case "4" : Console.WriteLine("évényesek listázása"); break;
                    default: Console.Clear(); Console.WriteLine("rossz parancs"); break;
                }
                Console.ReadKey();
            }
        }
    }
}
