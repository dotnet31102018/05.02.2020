using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDP
{
    class Program
    {
        static void Rest(WebAirline web_airline)
        {
            ArilineFacade facade = new ArilineFacade();
            facade.ShowAirline(new AdapterWebRagil(web_airline));
        }
        static void Main(string[] args)
        {
        }
    }
}
