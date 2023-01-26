using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_1
{
    class Request
    {
        private List<RequestPart> parts = new List<RequestPart>();
        public void addPart(Instrument instrument, int time)
        { 
            parts.Add(new RequestPart(instrument, time));
        }
        public List<RequestPart> getParts() 
        { 
            return parts; 
        }
    }
}
