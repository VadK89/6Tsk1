using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6Tsk2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Обязательная задача*. Ввести с клавиатуры предложение. 
             * Предложение представляет собой слова, разделенные пробелом. Знаки препинания не используются. 
             * Составить программу, определяющую является ли строка палиндромом без учёта пробелов и регистра 
             * (пример палиндрома – «А роза упала на лапу Азора»). 
             */
            // Ввод исходной строки
            Console.WriteLine("Введите предложение");
            string s1 = Console.ReadLine(); 
            //Убираем пробелы и понижаем регистр символов
            string srep = s1.Replace(" ","").ToLower();
            //Инвертируем строку
            char[] srev = srep.ToCharArray();
            Array.Reverse(srev);
            // Записываем инвертированную строку для сравнения
            string s2 = new string(srev);
            // Сравнение строк
            int res = string.Compare(srep, s2);
            // По результату сравнения выводится результат является ли введнное предложение палиндромом            
            if (res==0)
            {
                Console.WriteLine("Вы ввели палиндром");
            }
            else if (res>0||res<0)
            {
                Console.WriteLine("Вы ввели не палиндром");
            }            
            Console.ReadKey();
        }
    }
}
