public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    // Конструктор
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}
public class Employee : Person
{
    public int EmployeeId { get; set; }

    // Конструктор наследуемого класса
    public Employee(string name, int age, int employeeId) : base(name, age)
    {
        EmployeeId = employeeId;
    }
}
class MicrosoftLearn
{
    static int RomanToInt(string s)
    {
        int currentNumeral;
        int sum = 0;
        List<char> stripedRomanNumber = new List<char>();
        var romanToDigit = new Dictionary<char, int>()
            {
                { 'I', 1},
                { 'V', 5},
                { 'X' , 10},
                { 'L' , 50},
                { 'C' , 100},
                { 'D' , 500},
                { 'M' , 1000}
            };
        foreach (char c in s)
        {
            stripedRomanNumber.Add(c);
        }
        int lastElement = stripedRomanNumber.Count() - 1;
        for (int i = 0; i < lastElement; i++)
        {
            currentNumeral = romanToDigit[stripedRomanNumber[i]];

                if (i+1 <= lastElement && stripedRomanNumber[i] >= stripedRomanNumber[i + 1])
                { 
                    sum += currentNumeral; 
                }  
                else
                {
                    sum -= currentNumeral;
                }  
            
           
        }
        return sum;
    }
    static void main(string[] args) // Main - точка входа в программу / main - метод
    {
        /*
        int firstValue = 500;
        int secondValue = 600;
        int largerValue = Math.Max(firstValue, secondValue);

        Console.WriteLine("Larger value: " + largerValue);
        // See https://aka.ms/new-console-template for more information
        Random dice = new Random();
        int k = dice.Next(1, 10);
        Console.WriteLine("Hello, World!" + "\nRandom num: " + k);

        // Создание объекта с использованием конструктора
        Person person = new Person("Alice", 30);
        int roll1 = dice.Next();
        int roll2 = dice.Next(101);
        int roll3 = dice.Next(50, 101);

        Console.WriteLine($"First roll: {roll1}");
        Console.WriteLine($"Second roll: {roll2}");
        Console.WriteLine($"Third roll: {roll3}");
        string[] fraudulentOrderIDs = new string[3];
        fraudulentOrderIDs[0] = "A123";
        fraudulentOrderIDs[1] = "B456";
        fraudulentOrderIDs[2] = "C789";
        string[] names = new string[] { "B123", "G234", "A345", "C15", "B177", "G3003", "C235", "B179" };
        foreach (string name in names)
        {
            if (name.StartsWith("B"))
            {
                Console.WriteLine(name);
            }
        }

        List<int> Items = new List<int>(){200, 450, 700, 175, 250};
        int sum = 0;
        foreach (int item in Items)
        {
            sum += item;
        }
        */
        

        string romanNumber = "III";
        Console.WriteLine($"Roman Number: {romanNumber} - Digital number: {RomanToInt(romanNumber)}");

        // Code sample 1
        bool flag = true;
        int value;

        if (flag)
        {
            value = 10;
            Console.WriteLine($"Inside the code block: {value}");
        }

        //Console.WriteLine($"Outside the code block: {value}"); // Error: Use of unassigned local variable 'value'

        // Code sample 2
        int valueTwo;

        if (true)
        {
            valueTwo = 10;
            Console.WriteLine($"Inside the code block: {valueTwo}");
        }

        Console.WriteLine($"Outside the code block: {valueTwo}");

        string name = "steve";
        if (name == "bob") Console.WriteLine("Found Bob");
        else if (name == "steve") Console.WriteLine("Found Steve");
        else Console.WriteLine("Found Chuck");

        int[] numbers = { 4, 8, 15, 16, 23, 42 };
        int total = 0;
        bool found = false;
        foreach (int number in numbers)
        {
            

            total += number;

            if (number == 42)
            {
                found = true;

            }

        }

        if (found)
        {
            Console.WriteLine("Set contains 42");

        }

        Console.WriteLine($"Total: {total}");

    }
}

