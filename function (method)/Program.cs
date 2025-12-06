namespace function__method_
{
    internal class Program
    {
        static void hello()
        {
            Console.WriteLine("Hello, World!");
        }

        static void mainas(int num1,int num2)
        {
            Console.WriteLine($"num1-num2= {num1 - num2}");
        }
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello, World!");
           hello();
            int num1 = 10;
            int num2 = 20;
            mainas(num1: num1,num2:num2);
        }
    }
}
