System.Console.Write("Enter your name: ");
string name = Console.ReadLine();
System.Console.Write($"\n{name}, enter your age, please: ");
int age = int.Parse(Console.ReadLine());
int keschasAge = 3;


System.Console.WriteLine($"{name} your age is older than Kescha's age: {age > keschasAge}");

System.Console.WriteLine($"{name} your age is younger than Kescha's age: {age < keschasAge}");

System.Console.WriteLine($"{name} your age is equal to Kescha's age: {age == keschasAge}");