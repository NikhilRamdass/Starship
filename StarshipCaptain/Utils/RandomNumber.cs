using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarshipCaptain.Utils
{
    public static class RandomNumberGenerator
    {
        public static int RandomNumber(int max)
        {
            Random random = new Random(max);
            return random.Next();
        }
    }
}
