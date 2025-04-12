decimal []sofia = {93, 87, 98, 95, 100};
decimal []nicolas = {80, 83, 82, 88, 85};
decimal []zahirah = {84, 96, 73, 85, 79};
decimal []jeong = {90, 92, 98, 100, 97};

Dictionary<string, decimal> grades =
    new Dictionary<string, decimal>()
    {
        {"Sofia", sofia.Average()},
        {"Nicolas", nicolas.Average()},
        {"Zahirah", zahirah.Average()},
        {"Jeong", jeong.Average()}
    };
char grade;
Console.WriteLine("Student\tGrade");
int counter = 0;
foreach(var value in grades)
{
    if(value.Value >= 90 && counter <= 4){
        Console.WriteLine(value.Key+"\t"+value.Value+"  A");
    }
    else if(value.Value < 90 && value.Value >= 80 && counter <= 4){
        Console.WriteLine(value.Key+"\t"+value.Value+"  B");
    }
    counter++;
}
int saleAmount = 1001;
// int discount = saleAmount > 1000 ? 100 : 50;

Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");
Random coin = new();
int coinState = coin.Next(0, 2);
Console.WriteLine($"Coin falls by {(coinState == 1 ? "Head" : "Tail")} ");

Console.WriteLine("Welcome, Admin user.");
string permission = "Manager";
int level = 10;
Console.WriteLine($"{(permission.Contains("Admin") ? (level <= 55 ? "Welcome, Admin User." : "Welcome, Super Admin user.") : (permission.Contains("Manager") ? (level >= 20 ? "Contact an admin for access." : "You do not have sufficient privileges.") : "You do not have sufficient privileges."))}"); 
