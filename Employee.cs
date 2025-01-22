namespace Oop_Group
{
    public abstract class Employee
    {
        private const decimal _tax = 0.1m;
        private const decimal _expectedHoure = 40;
        private const decimal _overTimePouns = 1.5m;
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        private const decimal HourlyRate = 10;
        public decimal LogedHoure { get; set; }
        protected string FullNAme => $"{FName} {LName}";
        protected decimal ExpectedSalery()
        {
            return HourlyRate * _expectedHoure;
        }
        protected decimal OverTimeSalery()
        {
            return HourlyRate * (LogedHoure - _expectedHoure) * _overTimePouns;
        }
        protected decimal TAX()
        {
            return (OverTimeSalery() + ExpectedSalery()) * _tax;
        }
        protected decimal Salery()
        {
            return ExpectedSalery() + OverTimeSalery() - TAX();
        }
        public abstract string print();
    }
}