namespace dotnetapi
{
    public class RoboticRover
    {
        public Position position { get; set; }
        public Directions directions { get; set; }

        public RoboticRover(Position position, Directions directions)
        {
            this.position = position;
            this.directions = directions;
        }

        public void Start(string lines)
        {
            for (int i = 0; i < lines.Length; i++)
            {
                string word = lines[i].ToString();

                if (word == "L")
                {
                    Left();
                }
                else if (word == "R")
                {
                    Right();
                }
                else if (word == "M")
                {
                    Move();
                }
            }
        }

        private void Left()
        {
            bool isItLessThanTheSmallestValue = (directions - 1) < Directions.N;
            directions = isItLessThanTheSmallestValue ? Directions.W : directions - 1;
        }

        private void Right()
        {
            bool IsItGreaterThanTheHighestValue = (directions + 1) > Directions.W;
            directions = IsItGreaterThanTheHighestValue ? Directions.N : directions + 1;
        }

        private void Move()
        {
            if (directions == Directions.N)
            {
                position.y++;
            }
            else if (directions == Directions.E)
            {
                position.x++;
            }
            else if (directions == Directions.S)
            {
                position.y--;
            }
            else if (directions == Directions.W)
            {
                position.x--;
            }
        }

        public string GetResult()
        {
            return position.x.ToString() + position.y.ToString() + directions.ToString();
        }
    }
}
