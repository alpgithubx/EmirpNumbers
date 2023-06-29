using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers2
{
    internal class Program
    {
        public static List<int> list = new List<int> ();
        static void Main(string[] args)
        { 
            for(int i = 2; i <= 1000000; i++)
            {
                if ((i > 2 && i % 2 == 0) || (i > 3 && i % 3 == 0) || (i > 5 && i % 5 == 0) || (i > 7 && i % 7 == 0))
                {
                }
                else
                {
                    if (!Kontrol(i)) continue;
                    list.Add(i);

                } 
            }
            foreach (int i in list) {
                string str = Convert.ToString(i);
                string rev = "";
                for (int j = str.Length - 1; j >= 0; j--) {
                    string sub = str.Substring(j, 1);
                    rev = rev + sub;
                }
                if (list.Contains(Convert.ToInt32(rev))) {
                    Console.WriteLine($"{str} bir lasa sayı!");
                }

            }
            foreach(int alp in list) {

            }
            Console.ReadKey();
        }

        static bool Kontrol(int i) {
            bool durum = true;
            foreach(int sayi in list)
            {
                if(sayi != i && i % sayi == 0)
                {
                    durum = false;
                    break;
                }
            }
            return durum;
        }
    }
}
