System.Console.Write("Enter your name: ");
string name = Console.ReadLine();
System.Console.Write($"\n{name}, enter your age, please: ");
int age = int.Parse(Console.ReadLine());
int keschasAge = 3;

string message =
  age >= keschasAge
    ? "You are older than Kescha"
    : "You are younger than Kescha";

System.Console.WriteLine(message);    
