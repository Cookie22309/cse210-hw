using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter customer name: ");
        string name = Console.ReadLine();
        Console.Write("Enter customer email: ");
        string email = Console.ReadLine();
        Customer customer = new Customer(name, email);
        Console.WriteLine("\nChoose a receipt type:\n1. Online Receipt\n2. Store Receipt\n3. Subscription Receipt\n4. Donation Receipt\nEnter option (1-4): ");
        int choice = int.Parse(Console.ReadLine());
        Console.Write("\nEnter item name: ");
        string itemName = Console.ReadLine();
        Console.Write("Enter item price: ");
        float price = float.Parse(Console.ReadLine());
        Item item = new Item(itemName, price);
        Receipt receipt = null;
        switch (choice)
        {
            case 1:
                Console.Write("Enter shipping cost: ");
                float shipping = float.Parse(Console.ReadLine());
                Console.Write("Enter tax rate (example: 0.05 for 5%): ");
                float taxOnline = float.Parse(Console.ReadLine());
                receipt = new Online(itemName, price, shipping, taxOnline);
                break;
            case 2:
                Console.Write("Enter tax rate (example: 0.07 for 7%): ");
                float taxStore = float.Parse(Console.ReadLine());
                receipt = new Store(itemName, price, taxStore);
                break;
            case 3:
                float rate = price;
                Console.Write("Enter number of months: ");
                int months = int.Parse(Console.ReadLine());
                string monthlyPlan = "y";
                if (monthlyPlan.ToLower() == "y")
                {
                    bool monthly = true;
                    receipt = new Subscription(itemName, rate, months, monthly);
                }
                if (monthlyPlan.ToLower() == "y")
                {
                    bool monthly = false;
                    receipt = new Subscription(itemName, rate, months, monthly);
                }
                break;
            case 4:
                receipt = new Donation(itemName, price);
                break;
            default:
                Console.WriteLine("Invalid choice.");
                return;
        }
        Purchase purchase = new Purchase(customer, item, receipt);
        purchase.DisplayPurchase();
    }
}