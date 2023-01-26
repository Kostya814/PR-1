using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_1
{
    class RequestPart
    {
        private Instrument instrument;
        private int time;
        private int startTime = 0;

        public RequestPart(Instrument instrument, int time )
        {
            this.instrument = instrument;
            this.time = time;
        }
        public Instrument GetInstrument() { return instrument; }
        public int GetTime() { return time; }
        public void SetStartTime(int startTime) { this.startTime = startTime; }
        public int GetStartTime() { return startTime; }
    }
}
