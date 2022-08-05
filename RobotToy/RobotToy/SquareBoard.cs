using RobotToy.Interface;

namespace RobotToy
{
    class SquareBoard : ISquareBoard
    {
        public int XLength { get; set; }
        public int YLength { get; set; }

        public SquareBoard(int length)
        {
            this.XLength = length;
            this.YLength = length;
        }
        public bool IsValidPosition(Position position)
        {
            return position.X <= XLength && position.X >= 0
                && position.Y <= YLength && position.Y >= 0;
        }        
    }
}
