public class Program
{
    public static void Main(string[] args)
    {
        int choice;
        do
        {
            Console.WriteLine("Temperature Conversion Menu:");
            Console.WriteLine("1. Convert Celsius to Fahrenheit");
            Console.WriteLine("2. Convert Fahrenheit to Celsius");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice (1-3): ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter temperature in Celsius: ");
                    double celsius = double.Parse(Console.ReadLine());
                    double fahrenheit = CenciusToFahrenheit(celsius);
                    Console.WriteLine($"{celsius}°C is {fahrenheit}°F");
                    break;
                case 2:
                    Console.Write("Enter temperature in Fahrenheit: ");
                    fahrenheit = double.Parse(Console.ReadLine());
                    celsius = FahrenheitToCencius(fahrenheit);
                    Console.WriteLine($"{fahrenheit}°F is {celsius}°C");
                    break;
                case 3:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        } while (choice != 3);
        
    }
    public static double CenciusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }
    public static double FahrenheitToCencius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }
}