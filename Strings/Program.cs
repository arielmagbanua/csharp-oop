using Strings;
using System.Text;

string sentences = "The quick brown fox jumps.";
bool contains = sentences.Contains("Fox");

Console.WriteLine(contains);

string str1 = "the red fox";
string str2 = "The red fox";

if (str1.Equals(str2))
{
    Console.WriteLine("Equal");
}
else
{
    Console.WriteLine("Not Equal");
}

string strTest = "The quick brown fox.";
string replaced = strTest.Replace('x', 'b');
Console.WriteLine(replaced);

double grade = 90.5;
string strgrade = grade.ToString();
Console.WriteLine(strgrade);

Person myPerson = new Person("John", 34);
Console.WriteLine(myPerson);

string message = "bayad utang!!!";
Console.WriteLine(message.ToUpper());

StringBuilder strBuilder = new StringBuilder("Computer");
strBuilder.Append("\n");
strBuilder.AppendLine("Super");
strBuilder.Append("Hello");

Console.WriteLine(strBuilder.ToString());

strBuilder.Replace("test", "test2");

string baseStr = "Hello World";
string replacedStr = baseStr.Replace("World", "Earth");
Console.WriteLine(replacedStr);
