using RobotToy.Enums;

namespace RobotToy
{
    public class RobotToy
    {
        //private bool isPlaceExecuted = false;

        public Position Position { get; set; }
        public Direction Direction { get; set; }


        public void Place(Position postion, Direction direction)
        {
            this.Position = postion;
            this.Direction = direction;
            //this.isPlaceExecuted = true;            
        }

        public Position Move()
        {
            var newPosition = new Position(Position.X, Position.Y);
            switch (Direction)
            {
                case Direction.NORTH:
                    newPosition.Y++;
                    break;
                case Direction.EAST:
                    newPosition.X++;
                    break;
                case Direction.SOUTH:
                    newPosition.Y--;
                    break;
                case Direction.WEST:
                    newPosition.X--;
                    break;
            }
            return newPosition;
        }

        public void Left()
        {
            switch (Direction)
            {
                case Direction.NORTH:
                    Direction = Direction.WEST;
                    break;
                case Direction.EAST:
                    Direction = Direction.NORTH;
                    break;
                case Direction.SOUTH:
                    Direction = Direction.EAST;
                    break;
                case Direction.WEST:
                    Direction = Direction.SOUTH;
                    break;
            }
        }

        public void Right()
        {
            switch (Direction)
            {
                case Direction.NORTH:
                    Direction = Direction.EAST;
                    break;
                case Direction.EAST:
                    Direction = Direction.SOUTH;
                    break;
                case Direction.SOUTH:
                    Direction = Direction.WEST;
                    break;
                case Direction.WEST:
                    Direction = Direction.NORTH;
                    break;
            }
        }        

        public string Report()
        {
            return $"Output: {Position.X},{Position.Y},{Direction.ToString().ToUpper()}";
        }
       
    }
}
