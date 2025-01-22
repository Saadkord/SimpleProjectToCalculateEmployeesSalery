namespace Oop_Group
{
    public class Handyman : Employee
    {
        private const decimal _hardShip = 75m;
        private decimal _netSalery()
        {
            return Salery() + _hardShip;
        }

        public override string print()
        {
            return $"------{nameof(Handyman)}------\n" +
                $"Id: {Id.ToString().PadLeft(3, '0')}\n" +
                $"Name: {FullNAme}\n" +
                $"Hours logged: {LogedHoure} hur\n" +
                $"Basic Salary: {ExpectedSalery()} $\n" +
                $"Over Time (1.5X): {OverTimeSalery()} $\n" +
                $"HardShip: {_hardShip} $\n" +
                $"TAX Amount (10%): {TAX()} $\n" +
                $"Net Salary: {_netSalery()} $\n";
        }
    }
}