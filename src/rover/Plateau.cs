using System;
using System.Collections.Generic;

namespace rover
{
    public class Plateau
    {
        public int maxX;
        public int maxY;

        public int minX = 0;
        public int minY = 0;
        private const char seperator = ' ';

        public List<Rover> rovers = new List<Rover>();

        public Plateau(string maximumCoordinates)
        {
            Int32.TryParse(maximumCoordinates.Split(seperator)[0], out maxX);
            Int32.TryParse(maximumCoordinates.Split(seperator)[1], out maxY);
        }

        public void AddandMoveRover(string roverPosition, string roverCommands)
        {
            Rover rover = new Rover(roverPosition);
            if (ValidateRoverPosition(rover.x, rover.y))
            {
                rover.Move(roverCommands);
                if (ValidateRoverPosition(rover.x, rover.y))
                {
                    rovers.Add(rover);
                }
                else
                    throw new ArgumentException();
            }
            else
                throw new ArgumentException();
        }

        public bool ValidateRoverPosition(int roverPositionX, int roverPositionY)
        {
            if (roverPositionX <= maxX && roverPositionX >= minX && roverPositionY <= maxY && roverPositionY >= minY)
            {
                return true;
            }

            return false;
        }
    }
}
