using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDP
{
    public class AdapterWebRagil : IAirline
    {
        private WebAirline web;

        public AdapterWebRagil(WebAirline web)
        {
            this.web = web;
        }
        public Airline GetAirline()
        {
            return new Airline() { Name = web.Name };
        }
    }
}
