using System;

class FoodOrder
{
    static void Main()
    {
        Console.Write("Is restaurant open? (true/false): ");
        bool isRestaurantOpen = Convert.ToBoolean(Console.ReadLine());

        Console.Write("Is delivery partner available? (true/false): ");
        bool isDeliveryAvailable = Convert.ToBoolean(Console.ReadLine());

        Console.Write("Enter order amount: ");
        int orderAmount = Convert.ToInt32(Console.ReadLine());

        Console.Write("Is customer Prime? (true/false): ");
        bool isPrime = Convert.ToBoolean(Console.ReadLine());

        if (isRestaurantOpen && isDeliveryAvailable)
        {
            if (orderAmount >= 200 || isPrime)
            {
                Console.WriteLine("Order Accepted");
            }
            else
            {
                Console.WriteLine("Order Rejected: Minimum order amount is ₹200");
            }
        }
        else
        {
            Console.WriteLine("Order Rejected: Restaurant closed or delivery unavailable");
        }
    }
}
