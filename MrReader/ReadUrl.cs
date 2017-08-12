using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrReader
{
    class ReadUrl : ReadOperations
    {
        public string url;

        public ReadUrl()
        {
            Console.WriteLine("Please inform the URL to be read (with http://):");
            Console.WriteLine("---------------------------------------------------------------------");
            this.url = this.ReadInputString();
        }

        public string ReadInputString()
        {
            string url = Console.ReadLine();
            return url;
        }

        public string getUrl()
        {
            return this.url;
        }
    }
}
