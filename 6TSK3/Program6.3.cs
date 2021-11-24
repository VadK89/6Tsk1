using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// Добавлено пространство имен
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace _6TSK3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            /*Дана строка S. Из строки требуется удалить текст, заключенный в фигурные скобки. 
             * В строке может быть несколько фрагментов, заключённых в фигурные скобки. 
             * Возможно использование вложенных фигурных скобок, необходимо, чтобы программа это учитывала.
             */
            // Ввод исходной строки
            Console.WriteLine("Введите предложение");
            string s1 = Console.ReadLine();
            //Удаление текста в фигурных скобках и фигурных скобок с помощью регулярных выражений
            string s2 = Regex.Replace(s1, @"{[\d\D*]+}", "");
            Console.WriteLine(s2);
            Console.ReadKey();
        }
    }
}
