using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventofCode
{
    public class NoTimeForATaxiCab
    {
        internal int Horizontal;
        internal int Vertical;
        internal DirectionFacing Direction;

        public void HandleStep(string step)
        {
            if (step.Substring(0, 1).Equals("L"))
            {
                TurnLeft();
            }
            else
            {
                TurnRight();
            }

            int distance;
            var parsed = int.TryParse(step.Substring(1), out distance);

            if (!parsed)
            {
                return;
            }

            TravelDistance(distance);
        }

        public void TurnLeft()
        {
            Direction = (DirectionFacing)(((int)Direction + 3) % 4);
        }

        public void TurnRight()
        {
            Direction = (DirectionFacing) (((int) Direction + 1) % 4);
        }

        public void TravelDistance(int distance)
        {
    
            switch (Direction)
            {
                case DirectionFacing.North:
                    Vertical += distance;
                    break;

                case DirectionFacing.East:
                    Horizontal += distance;
                    break;

                case DirectionFacing.South:
                    Vertical -= distance;
                    break;

                case DirectionFacing.West:
                    Horizontal -= distance;
                    break;
            }
        }
    }
}
