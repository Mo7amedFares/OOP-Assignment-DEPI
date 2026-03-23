namespace ThirdProject
{
    class NoDiscount : Discount
    {
        public NoDiscount()
        {
            Name = "No Discount";
        }

        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return 0;
        }
    }
}
