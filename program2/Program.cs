namespace program2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("insert number1");
            int  num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("insert number 2");
            int  num2 = Convert.ToInt32(Console.ReadLine());

            int product = num1 * num2;
            int additional = num2 + num1;
            Console.WriteLine("the product of number is " + product);
            Console.WriteLine("the additional of number is " + additional);


        }
    }
}
