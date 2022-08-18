System.Console.Write("Enter your name: ");
string name = Console.ReadLine();
System.Console.Write($"\n{name}, enter your age, please: ");
int age = int.Parse(Console.ReadLine());
int keschasAge = 3;

if(age < keschasAge)
{
    System.Console.WriteLine("You are younger than Kescha");
}else if(age==keschasAge)
{
    System.Console.WriteLine("you are equals");
}else
{
    System.Console.WriteLine("You are older");
}