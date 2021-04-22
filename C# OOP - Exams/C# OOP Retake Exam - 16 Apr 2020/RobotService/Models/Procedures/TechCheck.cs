using RobotService.Models.Robots.Contracts;

namespace RobotService.Models.Procedures
{
    public class TechCheck : Procedure
    {
        private const int Value = 8;

        public override void DoService(IRobot robot, int procedureTime)
        {
            base.DoService(robot, procedureTime);

            if (robot.IsChecked == true)
            {
                robot.Energy -= Value;
            }

            robot.Energy -= Value;
            robot.IsChecked = true;

        }
    }
}
