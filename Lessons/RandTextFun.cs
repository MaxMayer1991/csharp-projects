namespace Git
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Random dice = new();
            int roll = dice.Next(1, 10);
            Console.WriteLine("a" == "a" + "\n" + roll);
            Console.WriteLine("a" == "A");
            Console.WriteLine(1 == 2);
            string myValue = "a";
            string yourValue = " bab ";
            yourValue = yourValue.Trim().ToUpper();
            Console.WriteLine(myValue == "a");
            Console.WriteLine(yourValue);
            string value1 = " a";
            string value2 = "A ";
            Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());
            string pangram = "The quick brown fox jumps over the lazy dog.";
            Console.WriteLine(pangram.Contains("fox"));
            Console.WriteLine(pangram.Contains("cow"));
            // These two lines of code will create the same output

            Console.WriteLine(pangram.Contains("fox") == false);
            Console.WriteLine(!pangram.Contains("fox"));
            int num1 = 5;
            int num2 = 2;
            decimal division = num1 / (decimal)num2;
            Console.WriteLine($"Division of Num1 and Num2 equals: {division}");
        }
    }
}