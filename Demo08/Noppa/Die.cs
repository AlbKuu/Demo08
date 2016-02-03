using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noppa
{
    class Die
    {
        private Random rnd = new Random();
        public int DieRoll()
        {
            //TAI 0-5+1 -> 1-6
            return rnd.Next(1,7);
        }

    }
}
