using RobotService.Models.Robots.Contracts;

namespace RobotService.Models.Procedures
{
    public class Work : Procedure
    {
        private const int Value = 6;
        private const int SecondValue = 12;

        public override void DoService(IRobot robot, int procedureTime)
        {
            base.DoService(robot, procedureTime);

            robot.Energy -= Value;
            robot.Happiness += SecondValue;

        }
    }
}
