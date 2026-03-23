namespace ThirdProject
{
    abstract class User
    {
        public string Name { get; set; }

        public abstract Discount GetDiscount();
    }
}
