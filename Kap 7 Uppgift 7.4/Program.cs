using System;
using System.Collections.Generic;
namespace Uppgift7_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "hej", "ja", "jaså", "jjjj" };
            Console.WriteLine(FinnsTecknetIAllaSträngar(words, 'e'));
        }

        /// <summary>
        /// Söker igenom en array och ser om ett visst tecken finns i alla strängar i arrayen.
        /// </summary>
        /// <param name="words">Arrayen som ska sökas.</param>
        /// <param name="search">Vilket tecken som ska sökas efter.</param>
        /// <returns></returns>
        static bool FinnsTecknetIAllaSträngar(string[] words, char search)
        {
            foreach (string word in words)
            {
                if (word.Contains(search) == false)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
/*Skapa ett program som innehåller en metod som heter FinnsTecknetIAllaSträngar.
Metoden ska ha två parametrar, en string-array samt en char, och den ska undersöka
om char-parametern finns i varje sträng i string-arrayen. Metoden ska svara med true
eller false.
Om metoden till exempel anropas med arrayen { &quot;hej&quot;, &quot;nej&quot;, &quot;ja&quot; } och tecknet j ska den
returnera true, men om man i stället anropar med samma lista och tecknet e ska den
returnera false.*/