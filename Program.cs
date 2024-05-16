namespace whiledo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int num = 0;

            num++;
            Thread.Sleep(500);
            while (num < 50)
            {
                Console.WriteLine(num);
            }
            if (num >= 50)
            {
                Console.WriteLine("sitarida");
            }
        }
    }
}
