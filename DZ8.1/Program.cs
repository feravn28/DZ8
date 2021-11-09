using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DZ8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string path = "Log1";
            //if (!Directory.Exists(path))
            //{
            //    Directory.CreateDirectory(path);
            //}

            //string path = "Log1/Log.txt";
            //if (!File.Exists(path))
            //{
            //    File.Create(path);
            //}
            StreamWriter sw = new StreamWriter("Log1/Log.txt");
            int[] array = new int[10];
            Random random = new Random();
            int S = 0;
            for (int i = 0; i < 10; i++)
            {

                array[i] = random.Next(0, 10);
                S += array[i];
                sw.Write("{0}\t", array[i]);
                Console.WriteLine("{0}\t", array[i]);
            }
            sw.WriteLine();
            sw.WriteLine("Сумма случайных чисел:" + S);
            sw.Close();
            Console.WriteLine();
            Console.WriteLine("Сумма случайных чисел: " + S);
            Console.ReadKey();
        }
    }
}
