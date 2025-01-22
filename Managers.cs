namespace Oop_Group
{
    public class Managers : Employee
    {
        private const decimal _allownce = 100;
        private decimal _netSalery()
        {
            return _allownce + Salery();
        }

        public override string print()
        {
            return $"------{nameof(Managers)}------\n" +
                $"Id: {Id.ToString().PadLeft(3, '0')}\n" +
                $"Name: {FullNAme}\n" +
                $"Hours logged: {LogedHoure} hur\n" +
                $"Basic Salary: {ExpectedSalery()} $\n" +
                $"Over Time (1.5X): {OverTimeSalery()} $\n" +
                $"Allowns: {_allownce} $\n" +
                $"TAX Amount (10%): {TAX()} $\n" +
                $"Net Salary: {_netSalery()} $\n\n";
        }
    }
}