void Logo()
{
        Console.WriteLine(@"        
  _________.__               .__           _________        .__               .__          __                
 /   _____/|__| _____ ______ |  |   ____   \_   ___ \_____  |  |   ____  __ __|  | _____ _/  |_  ___________ 
 \_____  \ |  |/     \\____ \|  | _/ __ \  /    \  \/\__  \ |  | _/ ___\|  |  \  | \__  \\   __\/  _ \_  __ \
 /        \|  |  Y Y  \  |_> >  |_\  ___/  \     \____/ __ \|  |_\  \___|  |  /  |__/ __ \|  | (  <_> )  | \/
/_______  /|__|__|_|  /   __/|____/\___  >  \______  (____  /____/\___  >____/|____(____  /__|  \____/|__|   
        \/          \/|__|             \/          \/     \/          \/                \/                   

        ");
}

double first;
double second;

void Input()
{
        Console.Write("Enter first number -> ");
        first = double.Parse(Console.ReadLine());
        Console.Write("Enter second number -> ");
        second = double.Parse(Console.ReadLine());
}

void Menu()
{
        Console.WriteLine("What do you want to do?");
        Console.WriteLine("[A] Add numbers");
        Console.WriteLine("[S] Subtract numbers");
        Console.WriteLine("[M] Multiply numbers");
        Console.Write("Choice -> ");
        string? choice = Console.ReadLine();
        double result = 0;
        if (choice == "A" || choice == "a")
        {
                result = first + second;
                Console.WriteLine($"{first} + {second} = {result:F2}");
        }
        else if (choice == "S" || choice == "s")
        {
                result = first - second;
                Console.WriteLine($"{first} - {second} = {result:F2}");
        }
        else if (choice == "M" || choice == "m")
        {
                result = first * second;
                Console.WriteLine($"{first} * {second} = {result:F2}");
        }
        else
        {
                Console.WriteLine("Invalid choice!");
                Console.WriteLine("Press any key to close.");
                Console.ReadKey();
        }
}