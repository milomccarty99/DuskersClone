using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuskersClone
{
    internal class Bot
    {
        public float x;
        public float y;
        protected String name;
        protected String faction;

        public Bot(float x, float y, String name, String faction)
        {
            this.x = x;
            this.y = y;
            this.name = name;
            this.faction = faction;
        }

        public float getX() { return x; }
        public float getY() { return y; }
        public String getName() { return name; }
        public String getFaction() { return faction; }
        public void setFaction(String faction) {
            this.faction = faction; }

    }
}
