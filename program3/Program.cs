namespace program3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("enter the age");
            int age =Convert.ToInt32( Console.ReadLine());
            if (age < 12)
            {
                Console.WriteLine("you are Child");
            }
            else if (age > 12 && age <=18)
            {
                Console.WriteLine("you are Teenage");
            }
            else if(age > 18)
            {
                Console.WriteLine("you are Adult");
            }
        }
    }
}
