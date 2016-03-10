using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using conekta.io.Service;

namespace conekta.io
{
    public class Conekta
    {
        public static void setApiKey(String api)
        {
            Configuration.Default.Username = api;
        }
    }
}
