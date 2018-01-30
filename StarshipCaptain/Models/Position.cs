using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarshipCaptain.Utils;

namespace StarshipCaptain.Models
{
    public struct CoOrdinate
    {
        int[,,,] pos;

        public CoOrdinate(int a, int b, int c, int d)
        {
            pos = new int[a, b, c, d];
        }
    }

    public class Position
    {
        CoOrdinate xCoOrdinate;
        CoOrdinate yCoOrdinate;


        public Position(CoOrdinate x, CoOrdinate y)
        {
            xCoOrdinate = x;
            yCoOrdinate = y;
        }

        public Position()
        {

        }

        private CoOrdinate generatePosition()
        {
            //TODO - Delete a and uncomment bottom line
            CoOrdinate a = new CoOrdinate(RandomNumberGenerator.RandomNumber(999), RandomNumberGenerator.RandomNumber(999), RandomNumberGenerator.RandomNumber(99), RandomNumberGenerator.RandomNumber(9));
            Console.Write(a);
            return a;
                //new CoOrdinate(RandomNumberGenerator.RandomNumber(999), RandomNumberGenerator.RandomNumber(999), RandomNumberGenerator.RandomNumber(99), RandomNumberGenerator.RandomNumber(9));
        }
    }
}
