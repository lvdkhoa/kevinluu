using RobotToy.Enums;
using RobotToy.Interface;
using System;

namespace RobotToy
{
    public class Simulator
    {
        private readonly ISquareBoard squareBoard;
        private readonly RobotToy toyRobot;

        public Simulator(ISquareBoard squareBoard, RobotToy toyRobot)
        {
            this.toyRobot = toyRobot;
            this.squareBoard = squareBoard;            
        }
        public string ProcessCommand(string commandText)
        {
            Command command;
            if (!Enum.TryParse(commandText.Split(' ')[0], true, out command))
                return "Invalid Command! Please try again.";

            if (toyRobot.Position == null && command != Command.PLACE)
                return string.Empty;

            switch (command)
            {
                case Command.PLACE:
                    try
                    {
                        PlaceCommandParser parser = new PlaceCommandParser();
                        PlaceCommand placeCommand = parser.ParsePlaceCommand(commandText);

                        if (squareBoard.IsValidPosition(placeCommand.Position))
                            toyRobot.Place(placeCommand.Position, placeCommand.Direction);
                    }
                    catch (ArgumentException ex)
                    {
                        return ex.Message;
                    }
                    break;
                case Command.MOVE:
                    var newPosition = toyRobot.Move();
                    if (squareBoard.IsValidPosition(newPosition))
                        toyRobot.Position = newPosition;
                    break;
                case Command.LEFT:
                    toyRobot.Left();
                    break;
                case Command.RIGHT:
                    toyRobot.Right();
                    break;
                case Command.REPORT:
                    return toyRobot.Report();

            }
            return string.Empty;
        }
    }
}
