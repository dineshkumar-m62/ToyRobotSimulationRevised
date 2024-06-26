﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyRobot.Repository;

namespace ToyRobot
{
    public class CommandParser
    {
        private readonly Command _command;
        public CommandParser(Command command)
        {
            _command = command;
        }
        private bool _placed = false;

        public void ParseCommand(string inputCommand)
        {
            var commandParts = inputCommand.Split();

            switch (commandParts[0])
            {
                case "PLACE":
                    _placed = true;
                    var args = commandParts[1].Split(',');

                    _command.PlaceCommand(int.Parse(args[0]), int.Parse(args[1]), args[2]);
                    break;
                case "MOVE":
                    if (_placed) _command.MoveCommand();
                    break;
                case "LEFT":
                    if (_placed) _command.LeftCommand();
                    break;
                case "RIGHT":
                    if (_placed) _command.RightCommand();
                    break;
                case "REPORT":
                    if (_placed) _command.ReportCommand();
                    break;
            }
        }
    }
}
