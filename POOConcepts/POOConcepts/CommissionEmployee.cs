namespace POOConcepts
{
    public class CommissionEmployee : Employee
    {
        public float CommissionPercentaje { get; set; }

        public decimal Sales { get; set; }

        public override decimal GetValueToPay()
        {
            return Sales * (decimal)CommissionPercentaje;
        }

        public override string ToString()
        {
            return $"{base.ToString()} " +
                $"\n\tSales................: {$"{Sales:C2}",18}" +
                $"\n\tCommission percentaje: {$"{CommissionPercentaje:P2}",18}" +
                $"\n\tValue yo pay.........: {$"{GetValueToPay():C2}",18}";
        }
    }
}
