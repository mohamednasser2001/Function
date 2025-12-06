// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("enter your number week");
int week=Convert.ToInt32(Console.ReadLine());
switch (week)
{

    case 1:
        Console.WriteLine("today is sunday");
        break;
        case 2:
        Console.WriteLine("today is monday");
        break;
        case 3:
        Console.WriteLine("today is tuday");
        break;
        case 4:
        Console.WriteLine("today is weday");
        break;
        case 5:
        Console.WriteLine("today is thrday");
        break;
        case 6:
        Console.WriteLine("today is friday");
        break;
        case 7:
        Console.WriteLine("today is satarday");

        break;
    default:
        Console.WriteLine("faild)");
        break;
}

for(int i=0;i<=10;i += 2)
{
    Console.WriteLine($"{i}");
}

string[] nams = ["mohamed", "nasser", "omar"];

foreach(string item in nams)
{
    Console.WriteLine(item);
}

List<int> numms = [1, 2, 3];
numms.Add(10);
numms.Add(22);