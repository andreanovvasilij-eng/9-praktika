using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_praktika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char letter = 'a';
            char digit = '2';
            char symbol = '$';

            char heart = '\u2665';
            Console.WriteLine(heart);

            char.IsLetter('H');  // проверяет это буква?
            char.IsDigit('3');  // проверяет это цифра?
            char.ToLower('5'); // к нижнему регистру
            char.ToUpper('3');// к вверхнему регистру

            string name = "Артем";
            string group = "224 СИС";
            string empty = " ";
            Console.WriteLine(name + empty + group); // конкатенация
            Console.WriteLine($"Студент {name}, обучается в группе {group}."); // интерполяция

            int len = group.Length; //7       
            char firstLatter = name[0]; //A
            Console.WriteLine(len);


            // поиск подстроки
            string sentence = "Кот сидит на трубе";
            int position = sentence.IndexOf("cидит"); //4
            bool contains = sentence.Contains("на"); // true
            Console.WriteLine(position);

            // проверка начала и конца строки
            bool start = sentence.StartsWith("кот"); // начало
            bool end = sentence.EndsWith("Трубе"); // конец

            // изменение регистра 
            string mixed = "ПрИвет";
            string lower = mixed.ToLower();
            Console.WriteLine(mixed.ToUpper());
            Console.WriteLine(lower);

            // удаление лишних пробелов
            string withSpaces = "   text     ";
            Console.WriteLine(withSpaces);
            Console.WriteLine(withSpaces.Trim());
            Console.WriteLine(withSpaces.TrimStart()); // в начале строки
            Console.WriteLine(withSpaces.TrimEnd());   // в конце строки

            // замена слова 
            string original = "Я люблю яблоки";
            string replaced = original.Replace("яблоки", "груши");
            Console.WriteLine(original);
            Console.WriteLine(replaced);


            string kansTowars = "карандаш,ручка,линейка,тетрадь";
            string[] kansTowArray = kansTowars.Split(',');
            // KansTowArray будет хранить:
            // [0] карандаш
            // [1] ручка
            // [2] линейка 
            // [3] тетрадь

            // объеденение подстрок (склейка)
            string[] worlds = { "Привет", "224", "группа" };
            string sentence1 = string.Join(" ", worlds);
            string sentence2 = string.Join(", ", worlds);
            Console.WriteLine(sentence1);
            Console.WriteLine(sentence2);

            StringBuilder sb = new StringBuilder();
            // быстрое добавление 
            sb.Append("Привет");
            sb.Append(" ");
            sb.Append("Мир");

            // метод вставки(Вставка в определенную позицию)
            sb.Insert(6, "Дорогой");
            sb.Replace("Дорогой", " Любимый");
            string finalString = sb.ToString();
            Console.WriteLine(finalString);
        }
    }
}
