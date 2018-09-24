using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2 {
    class Program {
        

        static void Main(string[] args) {

            Console.WriteLine("Add meg a szamok mennyiseget");
            int nSzam = Convert.ToInt32(Console.ReadLine());
            int[] t = new int[nSzam];
            for (int i = 0; i < nSzam; i++) {
                Console.WriteLine("Add meg a " + (i + 1) + " szamot");
                t[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            Console.ReadLine();




        }
    }
}
