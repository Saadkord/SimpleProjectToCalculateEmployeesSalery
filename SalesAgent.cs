namespace Oop_Group
{
    public class SalesAgent : Employee
    {
        private const decimal _comission = 0.05m;
        private decimal Comission()
        {
            return  Salery()*_comission;
        }
        private decimal _netSalery()
        {
            return Salery() + Comission();
        }

        public override string print()
        {
            return $"------{nameof(SalesAgent)}------\n" +
                $"Id: {Id.ToString().PadLeft(3, '0')}\n" +
                $"Name: {FullNAme}\n" +
                $"Hours logged: {LogedHoure} hur\n" +
                $"Basic Salary: {ExpectedSalery()} $\n" +
                $"Over Time (1.5X): {OverTimeSalery()} $\n" +
                $"Comission: {Comission()} $\n" +
                $"TAX Amount (10%): {TAX()} $\n" +
                $"Net Salary: {_netSalery()} $\n";
        }
    }
}