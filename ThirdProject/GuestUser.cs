namespace ThirdProject
{
    class GuestUser : User
    {
        public override Discount GetDiscount()
        {
            return new NoDiscount();
        }
    }
}
