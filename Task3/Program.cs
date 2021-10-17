using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3.Вручную подготовьте текстовый файл с фрагментом текста. Напишите программу, которая выводит статистику по файлу - количество символов, строк и слов в тексте.
            
            string path = "C:/Users/Сергей/Desktop/Log2.txt";

            if (!File.Exists(path))
            {
                Console.WriteLine("Файл не существует по указанному пути");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Текст из файла:");
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string sentence = sr.ReadToEnd();
                Console.WriteLine(sentence);
                string[] words = sentence.Split(' ');
                int j = 0;
                for (int i = 0; i < words.Length; i++)
                {
                    j++;
                }
                Console.WriteLine();
                Console.WriteLine("Количество слов = {0}", j);
               

                string symbols = new string(sentence.ToCharArray());
                int k = 0;
                for (int i = 0; i < symbols.Length; i++)
                {
                    k++;
                }
                Console.WriteLine("Количество символов (с учетом пробелов и переносом строк) = {0}", k);
            }

            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string s;
                int line = 0;

                while ((s = sr.ReadLine()) != null)
                {
                    line++;
                }
                Console.WriteLine("Число строк {0}", line);
            }
            Console.ReadKey();
        }

    }

}
