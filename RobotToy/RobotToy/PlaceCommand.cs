using RobotToy.Enums;

namespace RobotToy
{
    public class PlaceCommand
    {
        public Position Position { get; set; }
        public Direction Direction { get; set; }
        public PlaceCommand(Position position, Direction direction)
        {
            this.Position = position;
            this.Direction = direction;
        }
    }
}
