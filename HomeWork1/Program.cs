namespace HomeWork1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 16;
            int y = 5;
            int c = x + y;
            Console.WriteLine("x " + "+ " + "y " + "= " + c);
            int q = x - y;
            Console.WriteLine("x " + "- " + "y " + "= " + q);
            int k = x * y;
            Console.WriteLine("x " + "* " + "y " + "= " + k);
            int t = x / y;
            Console.WriteLine("x " + "/ " + "y " + "= " + t);
            int z = x % y;
            Console.WriteLine("x " + "% " + "y " + "= " + z);

            if (x > y)
            {
                y++;
                Console.WriteLine(y);
            }
            else
            {
                x--;
                Console.WriteLine(x);
            }
            var a = x < y ? ++x : --y;
            Console.WriteLine(a);

        }
    }
}