namespace ConsoleApp25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding =
                Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Въведете десетично число");
            int n = int.Parse(Console.ReadLine());
            string binary = "";
            while (n > 0)
            {
                binary = (n % 2) + binary;
                n /= 2;


            }
            Console.WriteLine(binary);
        }
    }
}
