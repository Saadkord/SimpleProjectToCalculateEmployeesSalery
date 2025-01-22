namespace Oop_Group
{
    public class SoftWareEngineering : Employee
    {
        private const decimal _traningAllowns = 50m;
        public decimal MissionCompleted;

        private decimal _missionCompleted()
        {
            return MissionCompleted >= 8 ? Salery() * 0.1m : 0;
        }
        private decimal _netSalery()
        {
            return Salery() + _traningAllowns + _missionCompleted();
        }
        public override string print()
        {
            return $"------{nameof(SoftWareEngineering)}------\n" +
                $"Id: {Id.ToString().PadLeft(3, '0')}\n" +
                $"Name: {FullNAme}\n" +
                $"Hours logged: {LogedHoure} hur\n" +
                $"Basic Salary: {ExpectedSalery()} $\n" +
                $"Over Time (1.5X): {OverTimeSalery()} $\n" +
                $"TraningAllowns: {_traningAllowns} $\n" +
                $"Mission Completed: {_missionCompleted()} $\n" +
                $"TAX Amount (10%): {TAX()} $\n" +
                $"Net Salary: {_netSalery()} $\n";
        }
    }
}