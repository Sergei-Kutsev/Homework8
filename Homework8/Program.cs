using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Homework8
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.    Выберите любую папку на своем компьютере, имеющую вложенные директории. Выведите на консоль ее содержимое и содержимое всех подкаталогов.

            string path = "D:/Работа/Цветы";

            if (Directory.Exists(path))
            {
                Console.WriteLine("Папки:");
                string[] directories = Directory.GetDirectories(path, "*.*", SearchOption.AllDirectories);
                foreach (string s in directories)
                {
                    Console.WriteLine(s);
                }

                Console.WriteLine();
                Console.WriteLine("Файлы:");
                string[] files = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }
            }
            else
            {
                Console.WriteLine("Путь не найден");
            }
            Console.ReadKey();
        }
    }
}
