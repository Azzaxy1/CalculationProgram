using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pilihan;
            double a, b, hasilA, hasilB;

            Console.WriteLine("---------------------");
            Console.WriteLine(" PROGRAM PERHITUNGAN ");
            Console.WriteLine("---------------------");

            Console.WriteLine();
            Console.WriteLine(" MENU PILIHAN  : ");
            Console.WriteLine(" A. PEMBAGIAN   ");
            Console.WriteLine(" B. PENGURANGAN ");
            Console.WriteLine();

            Console.WriteLine();
            Console.Write(" Masukan Pilihan Anda : ");
            pilihan = Convert.ToString(Console.ReadLine());

            if (pilihan == "A" || pilihan == "a")
            {
                Console.WriteLine();
                Console.WriteLine(" PEMBAGIAN ");
                Console.WriteLine("-----------");

                Console.Write(" Angka 1 = ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write(" Angka 2 = ");
                b = Convert.ToDouble(Console.ReadLine());

                hasilA = a / b;
                Console.WriteLine("----------------");
                Console.WriteLine($" Hasil {a} : {b} = {hasilA} ");


            }
            else if (pilihan == "B" || pilihan == "b")
            {
                Console.WriteLine();
                Console.WriteLine(" PENGURANGAN ");
                Console.WriteLine("-----------");

                Console.Write(" Angka 1 = ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write(" Angka 2 = ");
                b = Convert.ToDouble(Console.ReadLine());

                hasilB = a - b;
                Console.WriteLine("----------------");
                Console.WriteLine($" Hasil {a} - {b} = {hasilB} ");


            }
            Console.ReadKey();
        }
    }
}
