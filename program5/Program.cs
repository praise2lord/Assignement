namespace program5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int sum = Add(num1, num2);
            Console.WriteLine($"The sum of {num1} and {num2} is {sum}");
        }
        public static int Add(int num1, int num2)
            {
            return num1 + num2;
            
            }
    }
}
