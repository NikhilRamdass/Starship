using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarshipCaptain.Models;

namespace StarshipCaptain
{
    enum LocationType
    {
        Planet,
        SpaceMonster
    }

    public class Location
    {
        private Position position { get; set; }
        private LocationType locationType { get; set; }
    }
}
