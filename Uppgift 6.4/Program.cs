namespace Uppgift_6._1
{
    class Program
    {

        static double Potens(int bas, int exponent)
        {
            return Math.Pow(bas, exponent);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in din bas och exponent såhär: 5, 2");
            int[] numbers = Console.ReadLine().Split(',').Select(x => int.Parse(x.Trim())).ToArray();

            Console.WriteLine($"{numbers[0]}^{numbers[1]} = {Potens(numbers[0], numbers[1])}");
        }
    }
}