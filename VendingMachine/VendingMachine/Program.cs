using System;

namespace VendingMachine
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Customer customer = new Customer();

            Console.WriteLine("Press 'B' for Beverages and 'C' for Candy. 'I' to view inventory. Any other key to quit: ");
            char itemType = Console.ReadKey().KeyChar;

            Console.WriteLine();

            while (itemType != 'q') 
            { 

            switch (itemType)
            {
                    case 'b':
                    case 'B':
                    Console.WriteLine("\nPress the corresponding buttons to choose a vending machine item. Any other button to go back <--.");
                    foreach (Beverage beverages in Beverage.Menu)
                    {
                        Console.WriteLine($"{beverages.ID}: {beverages.Name} ({beverages.Price:c})");
                    }
                    char customerItem = Console.ReadKey().KeyChar;

                    switch (customerItem)
                    {
                        case '1':
                                if (customer.Money >= Beverage.CocaCola.Price)
                                {
                                    customer.Money -= Beverage.CocaCola.Price;
                                    customer.customerInventoryList.Add(Beverage.CocaCola);
                                    Console.WriteLine($"\nYou bought a {Beverage.CocaCola.Name} for {Beverage.CocaCola.Price:c}.");
                                }
                                else Console.WriteLine($"You dont have enough money. Your balance is: {customer.Money:c}.");
                            break;
                         case '2':
                                if (customer.Money >= Beverage.PepsiMax.Price)
                                {
                                    customer.Money -= Beverage.PepsiMax.Price;
                                    customer.customerInventoryList.Add(Beverage.PepsiMax);
                                    Console.WriteLine($"\nYou bought a {Beverage.PepsiMax.Name} for {Beverage.PepsiMax.Price:c}.");
                                }
                                else Console.WriteLine($"You dont have enough money. Your balance is: {customer.Money:c}.");
                            break;
                         case '3':
                                if (customer.Money >= Beverage.Fanta.Price)
                                {
                                    customer.Money -= Beverage.Fanta.Price;
                                    customer.customerInventoryList.Add(Beverage.Fanta);
                                    Console.WriteLine($"\nYou bought a {Beverage.Fanta.Name} for {Beverage.Fanta.Price:c}.");
                                }
                                else Console.WriteLine($"You dont have enough money. Your balance is: {customer.Money:c}.");
                            break;
                         case '4':
                                if (customer.Money >= Beverage.Sprite.Price)
                                {
                                    customer.Money -= Beverage.Sprite.Price;
                                    customer.customerInventoryList.Add(Beverage.Sprite);
                                    Console.WriteLine($"\nYou bought a {Beverage.Sprite.Name} for {Beverage.Sprite.Price:c}.");
                                }
                            break;
                    }
                     break;

                    case 'c':
                    case 'C':
                    Console.WriteLine("\nPress the corresponding buttons to choose a vending machine item. Any other button to go back <--.");
                    foreach (Candy candys in Candy.Menu)
                    {
                        Console.WriteLine($"{candys.ID}: {candys.Name} ({candys.Price:c})");
                    }
                    customerItem = Console.ReadKey().KeyChar;

                    switch (customerItem)
                    {
                        case '1':

                                if(customer.Money >= Candy.ChocolateBar.Price)
                                {
                                    customer.Money -= Candy.ChocolateBar.Price;
                                    customer.customerInventoryList.Add(Candy.ChocolateBar);
                                    Console.WriteLine($"\nYou bought a {Candy.ChocolateBar.Name} for {Candy.ChocolateBar.Price:c}.");
                                }
                                else Console.WriteLine($"You dont have enough money. Your balance is: {customer.Money:c}.");

                            break;
                        case '2':
                                if (customer.Money >= Candy.Chips.Price)
                                {
                                    customer.Money -= Candy.Chips.Price;
                                    customer.customerInventoryList.Add(Candy.Chips);
                                    Console.WriteLine($"\nYou bought a {Candy.Chips.Name} for {Candy.Chips.Price:c}.");
                                }
                                else Console.WriteLine($"You dont have enough money. Your balance is: {customer.Money:c.}");

                            break;
                    }
                    break;

                    case 'I':
                    case 'i':
                        Console.WriteLine($"\nCustomer money: {customer.Money:c}.");
                        Console.WriteLine($"Customer inventory:");
                        foreach (VendingMachine customerItemInventory in customer.customerInventoryList)
                        {
                            Console.WriteLine(customerItemInventory.Name);
                        }
                        break;


                default:
                    break;
            }
                Console.WriteLine("\n\nPress 'B' for Beverages and 'C' for Candy. 'I' to view inventory. Any other key to quit: ");
                itemType = Console.ReadKey().KeyChar;
            }



        }
    }
}
