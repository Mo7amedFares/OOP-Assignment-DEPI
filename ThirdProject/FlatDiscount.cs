namespace ThirdProject
{
    class FlatDiscount : Discount
    {
        public decimal Amount { get; set; }
        public FlatDiscount(decimal amount)
        {
            Amount = amount;
            Name = $"Flat Discount of {amount:C}";
        }
        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return Amount * Math.Min(quantity, 1);
        }
    }
}
