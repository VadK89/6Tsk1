using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6Tsk1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1.    Обязательная задача*. Ввести с клавиатуры предложение.
            Предложение представляет собой слова, разделенные пробелом.
            Знаки препинания не используются. Найти самое длинное слово в строке. */
            //Ввод иходной строки
            Console.WriteLine("Введите предложение") ;
            string str = Console.ReadLine();
            //Преобразование строки в массив , попутно убираем знаки препинания и пробелы 
            string[] strmas = str.Split(new Char[] { ' ',',','.',':','!','?',';' }, StringSplitOptions.RemoveEmptyEntries);
            //Ввод пустых переменных для записи результата 
            int tmp1 = 0;
            int tmp2 = 0;
            //Цикл сравнения  слов в предложении
            for (int i = 0; i < strmas.Length; i++)
            {
                if (strmas[i].Length>tmp1)
                {
                    tmp1 = strmas[i].Length;
                    tmp2 = i;
                }
                else if (strmas[i].Length == tmp1)
                {
                    Console.WriteLine("Есть слова одинаковой длины");
                }
            }
            //вывод результата
            Console.WriteLine("Самое длинное слово в строке: {0}",strmas[tmp2]);
            Console.ReadKey();
        }
    }
}
