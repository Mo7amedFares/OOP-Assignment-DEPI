namespace ThirdProject
{
    class PercentageDiscount : Discount
    {
        public decimal Percentage { get; set; }
        public PercentageDiscount(decimal percentage)
        {
            Percentage = percentage;
            Name = $"Percentage Discount of {percentage}%";
        }
        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return price * quantity * (Percentage / 100);
        }
    }
}
