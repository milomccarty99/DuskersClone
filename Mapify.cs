using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuskersClone
{
    internal class Mapify
    {
        protected int length;
        protected int width;

        public Mapify(int length, int width) // update with areas player can move/interact with
        {
            this.length = length;
            this.width = width;

        }

        public String GetMap(Bot a, Bot b)
        {
            return "";
        }
        
    }
}
