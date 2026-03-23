namespace ThirdProject
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Whats Type (Regular / Premium / Guest)");
            string type = Console.ReadLine().ToLower();
            while (type != "regular" && type != "premium" && type != "guest")
            {
                Console.WriteLine("Invalid Type. Please enter Regular, Premium, or Guest.");
                type = Console.ReadLine().ToLower();
            }
            User user = type switch
            {
                "regular" => new RegularUser(),
                "premium" => new PremiumUser(),
                "guest" => new GuestUser(),


            };
            Console.WriteLine("Enter price:");
            decimal price ;
            while(!decimal.TryParse(Console.ReadLine(), out price) || price < 0)
            {
                Console.WriteLine("Invalid price. Please enter a valid decimal number greater than or equal to 0.");
            }

            int quantity;
            while (true)
            {
                Console.WriteLine("Enter quantity:");
                if (int.TryParse(Console.ReadLine(), out quantity) && quantity >= 0)
                {
                    break;
                }
                Console.WriteLine("Invalid quantity. Please enter a valid integer greater than or equel 0.");
            }

            Discount discount = user.GetDiscount();
            decimal discountAmount = discount.CalculateDiscount(price, quantity);
            decimal finalPrice = (price * quantity) - discountAmount;
            Console.WriteLine($"Discount Applied: {discount.Name}");
            Console.WriteLine($"Discount Amount: {discountAmount}");
            Console.WriteLine($"Final Price = {finalPrice}");
        }
    }
}
