namespace Static_Members_Kohnen_Christian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //intigers
            Console.WriteLine("Intiger adition, subtraction, multiplication, and division of 92 and 42");
            Console.WriteLine(Calculate.Add(92, 42));
            Console.WriteLine(Calculate.Sub(92, 42));
            Console.WriteLine(Calculate.Mult(92, 42));
            Console.WriteLine(Calculate.Div(92, 42));

            //floats
            Console.WriteLine("float adition, subtraction, multiplication, and division of 92.45 and 42.88");
            Console.WriteLine(Calculate.Add(92.45f, 42.88f));
            Console.WriteLine(Calculate.Sub(92.45f, 42.88f));
            Console.WriteLine(Calculate.Mult(92.45f, 42.88f));
            Console.WriteLine(Calculate.Div(92.45f, 42.88f));
        }
    }
}