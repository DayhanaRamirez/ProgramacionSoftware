namespace POOConcepts
{
    public class HourlyEmployee : Employee
    {
        public float Hours { get; set; }

        public decimal HourValue { get; set; }

        public override decimal GetValueToPay()
        {
            return (decimal)Hours * HourValue;
        }

        public override string ToString()
        {
            return $"{base.ToString()} " +
            $"\n\tHours................: {$"{Hours:N2}",18}" +
            $"\n\tHourValue............: {$"{HourValue:C2}",18}" +
            $"\n\tValue yo pay.........: {$"{GetValueToPay():C2}",18}";
        }
    }
}
