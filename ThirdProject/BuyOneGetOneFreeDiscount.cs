namespace ThirdProject
{
    class BuyOneGetOneFreeDiscount : Discount
    {
        public BuyOneGetOneFreeDiscount()
        {
            Name = "Buy One Get One Free";
        }
        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return (price/2) * (quantity / 2);
        }
    }
}
