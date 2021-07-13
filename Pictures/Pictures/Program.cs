using System;

namespace Pictures
{
    class Program
    {
        static void Main(string[] args)
        {
            int pictures = 52;
            int riad = 3;
            int kolriad = 0;

            for (kolriad = 0; riad < 52; kolriad++)
            {
                riad = riad + 3;
            }
            if (pictures < riad) riad = riad - pictures;

            Console.WriteLine("Количество полностью заполненных рядов = " + kolriad);
            Console.WriteLine("Количество картинок сверх меры = " + riad);
        }
    }
}
