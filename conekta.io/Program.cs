using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace conekta.io
{
    class Program
    {
        static void Main(string[] args)
        {
            Client.Configuration.Default.Username = "key_eYvWV7gSDkNYXsmr";
            var api = new Conekta.io.Api.DefaultApi();

            var resp = api.ChargesGet();

            Console.WriteLine(resp.ToString());
        }
    }
}
