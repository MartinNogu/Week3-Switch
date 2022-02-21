using System;

namespace PersonalityTestSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutajal sisestada tema lemmikvärvi;
            //kui kasutaja sisestab "punane",siis konsool kuvab "oled romantiline";
            //kui kasutaja sisestab sinine, siis konsool kuvab "oled töökas";
            //kui kasutaja sisestab roheline, siis konsool kuvab "oled looduse sõber";
            //kui kasutaja sisestab midagi muud, siis konsool kuvab "oled {userColor} ükssarvik";

            Console.WriteLine("Sisesta oma lemmikvärv:");
            string userColor = Console.ReadLine().ToLower();

            switch (userColor)
            {
                case "punane":
                    Console.WriteLine("Oled romantiline.");
                    break;
                case "sinine":
                    Console.WriteLine("Oled töökas.");
                    break;
                case "roehline":
                    Console.WriteLine("Oled looduse sõber.");
                    break;
                default:
                    Console.WriteLine($"Oled {userColor} ükssarvik.");
                    break;
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
