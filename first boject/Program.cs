// See https://aka.ms/new-console-template for more information
Console.WriteLine("enter your name: ");
string Name = Console.ReadLine();
Console.WriteLine($"hello , {Name}"); //string interpolication
Console.WriteLine("hello "+Name);//concatination


Console.WriteLine("enter your Age: ");
int age=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("your age :" + age);


Console.WriteLine("enter your  favorite number between 1 and 100: ");
int num=Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"your number is {num}");
