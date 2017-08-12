using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MrReader
{
    class JsonReader
    {
        public string json = " Failed to read.";

        public JsonReader(string url)
        {
            using (WebClient wc = new WebClient())
            {
                try
                {
                    this.json = wc.DownloadString(url);
                }catch(Exception e)
                {
                    Console.Write(e.Message);
                }
            }
        }

        public string getJson()
        {
            return this.json;
        }
    }
}
