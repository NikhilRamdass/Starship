using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarshipCaptain
{
    public class Planet: Location
    {
        public bool isHabitable { get; set; }
        public double surfaceArea { get; set; }
        public bool isColonized { get; set; }

        public Planet()
        {

        }

        public bool isNeighbourSpaceMonster()
        {
            return false;
        }
    }
}
