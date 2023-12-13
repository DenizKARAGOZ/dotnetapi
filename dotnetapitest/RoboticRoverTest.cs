using dotnetapi;

namespace dotnetapitest
{
    public class RoboticRoverTest
    {
        [Fact]
        public void ShouldReturn13N_WhenLineIsLMLMLMLMM()
        {
            RoboticRover roboticRover = new RoboticRover(POSITION1, Directions.N);

            roboticRover.Start(LINE1);

            string result = roboticRover.GetResult();

            Assert.True(result == EXPECTED_RESULT1);
        }

        [Fact]
        public void ShouldReturn51E_WhenLineIsMMRMMRMRRM()
        {
            RoboticRover roboticRover = new RoboticRover(POSITION2, Directions.E);

            roboticRover.Start(LINE2);

            string result = roboticRover.GetResult();

            Assert.True(result == EXPECTED_RESULT2);
        }

        private static readonly string EXPECTED_RESULT1 = "13N";
        private static readonly string LINE1 = "LMLMLMLMM";
        private static readonly Position POSITION1 = new Position()
        {
            x = 1,
            y = 2
        };

        private static readonly string EXPECTED_RESULT2 = "51E";
        private static readonly string LINE2 = "MMRMMRMRRM";
        private static readonly Position POSITION2 = new Position()
        {
            x = 3,
            y = 3
        };
    }
}
