using RobotToy.Interface;
using System;

namespace RobotToy
{
    class Program
    {
        const string instruction =
        @"Instruction to use command for RobotToy
          1: Place the robot on a square grid with dimensions of 5 units X 5 units.
             Use the following command to place the robot.

             PLACE X,Y, F (F = NORTH SOUTH EAST or WEST)

          2: Once the robot is placed, interact with it using the following commands.
                
             MOVE – Moves the robot 1 unit forward in the direction it is currently facing.
             LEFT and RIGHT – Rotates the robot 90 degrees in the specified direction without changing the position of the robot.
             REPORT – announces the X,Y and F of the robot. 
             EXIT – Close Robot Simulator.
        ";
        static void Main(string[] args)
        {
            ISquareBoard squareBoard = new SquareBoard(5);
            RobotToy toyRobot = new RobotToy();
            Simulator simulator = new Simulator(squareBoard, toyRobot);
            Console.WriteLine(instruction);

            do
            {
                string command = Console.ReadLine();

                if (command == "EXIT")
                    break;

                var output = simulator.ProcessCommand(command);

                if (!string.IsNullOrEmpty(output))
                    Console.WriteLine(output);
            } while (true);
        }
    }
}
           