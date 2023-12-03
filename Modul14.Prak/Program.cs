using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul14.Prak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Вот дом, Который построил Джек." +
                " А это пшеница, Кото­рая в темном чулане хранится В доме, Который построил Джек." +
                " А это веселая птица­ синица, Которая часто вору­ет пшеницу," +
                " Которая в темном чулане хранится В доме, Который построил Джек.";

            var wordCount = CountWords(text);
            // Вывод статистики в консоль в виде таблицы
            Console.WriteLine("Слово\tКоличество");
            foreach (var pair in wordCount)
            {
                Console.WriteLine($"{pair.Key}\t{pair.Value}");
            }
            Console.ReadKey();
        }
        static Dictionary<string, int> CountWords(string text)
        {
            var wordCount = new Dictionary<string, int>();
            var words = text.Split(new char[] { ' ', '.', ',', '-', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in words)
            {
                string lowerWord = word.ToLower();
                if (wordCount.ContainsKey(lowerWord))
                {
                    wordCount[lowerWord]++;
                }
                else
                {
                    wordCount[lowerWord] = 1;
                }
            }

            return wordCount;
        }
    }
}
