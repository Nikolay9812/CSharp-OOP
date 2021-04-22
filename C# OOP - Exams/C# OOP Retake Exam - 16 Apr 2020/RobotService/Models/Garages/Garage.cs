using RobotService.Models.Garages.Contracts;
using RobotService.Models.Robots.Contracts;
using RobotService.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RobotService.Models.Garages
{
    public class Garage : IGarage
    {
        private readonly IDictionary<string, IRobot> robots;

        public Garage()
        {
            this.Capacity = 10;
            this.robots = new Dictionary<string, IRobot>();
        }

        public IReadOnlyDictionary<string, IRobot> Robots => (IReadOnlyDictionary<string, IRobot>)this.robots;

        public int Capacity { get; set; }

        public void Manufacture(IRobot robot)
        {
            if (this.Capacity > 10)
            {
                throw new InvalidOperationException(ExceptionMessages.NotEnoughCapacity);
            }

            if (this.robots.Any(r => r.Key == robot.Name))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.InvalidRobotType, robot.Name));

            }

            this.robots.Add(robot.Name, robot);
        }

        public void Sell(string robotName, string ownerName)
        {
            if (this.robots.Any(r => r.Key == robotName))
            {
                this.robots.Remove

            }
            else
            {
                throw new ArgumentException(string.Format(ExceptionMessages.InexistingRobot, robotName));
            }
        }
    }
}
