using System;
using Xunit;
using rover;

namespace rovertest
{
    public class PlateauShould
    {
        [Fact]
        public void AddandMoveRover()
        {
            //arrange
            Plateau plateau = new Plateau("5 5");

            //act
            plateau.AddandMoveRover("1 2 N", "LMLMLMLMM");

            //assert
            Assert.Equal("1 3 N", plateau.rovers[0].x + " " + plateau.rovers[0].y + " " + plateau.rovers[0].direction);

        }
    }
}
