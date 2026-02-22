namespace ITCS_3112_Lab_1_Checkout;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Equipment Checkout System!");
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. Add items to inventory");
        Console.WriteLine("2. List available items");
        Console.WriteLine("3. List unavailable items");
        Console.WriteLine("4. Checkout item");
        Console.WriteLine("5. Return item");
        Console.WriteLine("6. Show due soon (next 24 hours)");
        Console.WriteLine("7. Show overdue items");
        Console.WriteLine("8. Search items");
        Console.WriteLine("9. Mark items as lost");
        Console.WriteLine("0. Exit");
    }
}