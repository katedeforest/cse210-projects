using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        
        Console.WriteLine("");
        Console.WriteLine("––––––––––––––––––––––––––");
        // Order 1
        Customer customer1 = new Customer("Kate DeForest", "1320 E Canberra Dr, Lindon, UT, United States");
        Order order1 = new Order(customer1);
        order1.AddProduct("Elderberry Lemon Balm Herbal Tea", 12345, 4.46m, 4);
        order1.AddProduct("Spiral Notebook Journal", 67891, 12.99m, 1);
        order1.AddProduct("Raisin Cinnamon Bagels", 23456, 2.98m, 1);
        
        Console.WriteLine($"PACKING LABEL\n{order1.GetPackingLabel()}");
        Console.WriteLine($"\nSHIPPING LABEL\n{order1.GetShippingLabel()}");
        Console.WriteLine($"\nTOTAL COST: {order1.GetTotalCost():C}");

        Console.WriteLine("");
        Console.WriteLine("––––––––––––––––––––––––––");
        // Order 2
        Customer customer2 = new Customer("Melissa Safuan", "1234 N Real St, Sao Paulo, Sao Paulo, Brazil");
        Order order2 = new Order(customer2);
        order2.AddProduct("Newmans Own Mango Salsa", 78912, 2.98m, 1);
        order2.AddProduct("Don Julio Mexican Style Tortilla Chips", 34567, 3.62m, 2);
        order2.AddProduct("Propel Peach, Black Cherry & Watermelon Flavor (18 pack)", 89123, 14.27m, 1);

        Console.WriteLine($"PACKING LABEL\n{order2.GetPackingLabel()}");
        Console.WriteLine($"\nSHIPPING LABEL\n{order2.GetShippingLabel()}");
        Console.WriteLine($"\nTOTAL COST: {order2.GetTotalCost():C}");
    }
}