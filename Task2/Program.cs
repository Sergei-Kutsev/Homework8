using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*2.    Программно создайте текстовый файл и запишите в него 10 случайных чисел.
            Затем программно откройте созданный файл, рассчитайте сумму чисел в нем, ответ выведите на консоль.*/

            string path = "C:/Users/Сергей/Desktop/Log.txt";

            if (!File.Exists(path))
            {
                File.Create(path);
            }
            using (StreamWriter sw = new StreamWriter(path))
            {
                int[] numbers = new int[10];
                Random random = new Random();
                for (int i = 0; i < 10; i++)
                {
                    numbers[i] = random.Next(0, 10);
                    sw.WriteLine(numbers[i]);
                }
            }
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string s;
                int Sum = 0;
                Console.WriteLine("Числа из файла:");
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                    Sum += Convert.ToInt32(s);
                }
                Console.WriteLine("Сумма всех введенных чисел равна {0}", Sum);
                Console.ReadKey();
            }
        }
    }
}
