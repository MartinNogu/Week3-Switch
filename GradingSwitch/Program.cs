using System;

namespace GradingSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib, mis hinde kasutaja sai
            //kui kasutaja sai 'A', siis konsool kuvab "suurepäerane";
            //'B', siis konsool kuva "Väga hea!"
            //'C', siis konsool kuvab "Hea!";
            //'D', siis konsool kuvab "Rahuldav"
            //'E', siis konsool kuvab "Kasin";
            //'F', siis konsool kuvab "Puudulik";
            //kui kasutaja sisestab midagi muud, siis konsool kuvab "vale väärtus"

            Console.WriteLine("Sisesta oma tulemus:");
            //char - character
            char userResult = Convert.ToChar(Console.ReadLine().ToUpper());

            switch(userResult)
            {
                case 'A':
                    Console.WriteLine("Suurepärane!");
                    break;
                case 'B':
                    Console.WriteLine("Väga tubli!");
                    break;
                case 'C':
                    Console.WriteLine("Hea!");
                    break;
                case 'D':
                    Console.WriteLine("Rahuldav");
                    break;
                case 'E':
                    Console.WriteLine("Kasin");
                    break;
                case 'F':
                    Console.WriteLine("Puudulik");
                    break;
                default:
                    Console.WriteLine("Vale väärtus");
                    break;
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
