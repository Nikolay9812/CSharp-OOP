using RobotService.Models.Robots.Contracts;

namespace RobotService.Models.Procedures
{
    public class Rest : Procedure
    {
        private const int Value = 3;
        private const int SecondValue = 10;

        public override void DoService(IRobot robot, int procedureTime)
        {
            base.DoService(robot, procedureTime);

            robot.Happiness -= Value;
            robot.Energy += SecondValue;

        }
    }
}
