using System;
using System.Collections.Generic;

namespace Lab3._2
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Dictionary<string, decimal> market = new Dictionary<string, decimal>();
            market.Add("Banana", 0.25m);
            market.Add("Apple", 0.65m);
            market.Add("Orange", 0.70m);
            market.Add("Grapes", 1.99m);
            market.Add("Lettuce", 1.00m);
            market.Add("Kiwi", 0.75m);
            market.Add("Onion", 1.29m);
            market.Add("Spinach", 2.00m);

            List<string> food = new List<string>();
            List<decimal> price = new List<decimal>();

            /*food.Add("Kiwi");
            food.Add("Grapes");
            price.Add(0.75m);
            price.Add(1.99m);

            Console.WriteLine(food[0]);
            Console.WriteLine(price[0]);
            Console.WriteLine(food[1]);
            Console.WriteLine(price[1]);*/ 

            bool done = false;
            Console.WriteLine("Welcome to Farmer Jack's!\n");

            while (done == false)
            {
                decimal total = 0;
                decimal average = 0;
                foreach (var item in market)
                {
                    Console.WriteLine($"{item.Key}   ${item.Value}");
                }
                Console.WriteLine();
                Console.Write("What item would you like to order? ");
                string order = Console.ReadLine();

                if (market.ContainsKey(order) == false)
                {
                    Console.WriteLine("Sorry, we dont have those. Please order something else.\n\n"); ;
                }
                else if (market.ContainsKey(order) == true)
                {
                    Console.WriteLine($"Adding {order} to cart at ${market[order]}\n\n");
                    food.Add(order);
                    price.Add(market[order]);
                    Console.Write("Would you like to order anything else (y/n)? ");
                    
                    string resp = Console.ReadLine().ToLower();
                    Console.WriteLine();
                    if (resp == "n")
                    {
                        Console.WriteLine("Thanks for shopping at Farmer Jack's!");
                        Console.WriteLine("Here is you receipt:");
                        for (int i = 0; i < food.Count; i++)
                        {
                            Console.WriteLine($"{food[i]} ${price[i]}");
                            total= total + price[i];
                            average = total / price.Count;
                            average = Math.Round(average, 2);
                        }
                        Console.WriteLine($"Your Total is ${total}.");
                        Console.WriteLine($"Average price per item in order was ${average}.");
                        done = true;
                    }
                
                }
              
            }

        }
    }
}

