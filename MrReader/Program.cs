using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrReader
{
    class Program
    {
        static bool again = true;

        static void Main(string[] args)
        {
            while (again)
            {
                InformativeStrings.informativeSequence();
                ReadUrl urlReader = new ReadUrl();

                string url = urlReader.getUrl();
                JsonReader jsonReader = new JsonReader(url);
                Console.Write(jsonReader.getJson());

                Console.WriteLine("\r\n====================================>\r\n");
                Console.Write("Press Q to finish, 1 to Re-Try ...");
                Console.WriteLine("\r\n");

                ConsoleKeyInfo cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.Q)
                    again = false;
            }
        }
    }
}
