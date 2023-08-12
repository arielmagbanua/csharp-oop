Console.WriteLine("What is your fullname?");
string myName = Console.ReadLine();
Console.WriteLine("What is your nickname?");
string nickName = Console.ReadLine();
Console.WriteLine("What is your age?");
string ageSrt = Console.ReadLine();
Console.WriteLine("What is your favorite number?");
string faveNumStr = Console.ReadLine();
Console.WriteLine("What is cartoon character?");
string faveCartoon = Console.ReadLine();

int age = Int32.Parse(ageSrt);
int favNum = Int32.Parse(faveNumStr);

Console.WriteLine("Hi! My name is " + myName + ", you can call me " + nickName + "!");
Console.WriteLine("I am " + age + " years old. My favorite number is " + favNum + " and I love " + faveCartoon + "!");
