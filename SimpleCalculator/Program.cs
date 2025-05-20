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
