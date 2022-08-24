Console.Write("Hello");
Console.Write(" Hey");

Console.WriteLine("Hi");

int myInt = 5;
double myDouble = 1.1;
float myFloat = 2.2f;
decimal myDecimal = 99.9M;
string myString = "Vanier";
byte myByte = 1;
char myChar = 'A';
long myLong = 1111;
bool myBool = true;
//enum level { low, medium, high };

const String lastDayOfWeek = "Friday";

myString = "55";

Console.WriteLine(lastDayOfWeek);

int sum = 10 + Convert.ToInt32(myString);
Console.WriteLine(sum);

string result = "Output is: " + Convert.ToString(sum);
Console.WriteLine(result);

sum += 5;
Console.WriteLine(sum);

myString = "Vanier";
string myNewString = (string) myString.Clone();

Console.WriteLine(myNewString);

Console.WriteLine(myString.CompareTo(myNewString));
Console.WriteLine(result.CompareTo(lastDayOfWeek));

Console.WriteLine(myNewString.Contains("VA"));
Console.WriteLine(myNewString.EndsWith("er"));
Console.WriteLine(myNewString.IndexOf("i"));
Console.WriteLine(myNewString.ToUpper());
Console.WriteLine(myNewString.ToLower());

myNewString = myNewString.Insert(0, "Thank you ");
Console.WriteLine(myNewString);

Console.WriteLine(myNewString.Length);
myNewString = myNewString.Remove(10);
Console.WriteLine(myNewString);

myNewString = myNewString.Replace('y', 'u');
Console.WriteLine(myNewString);

Console.WriteLine(myNewString.StartsWith("Th"));

Console.WriteLine(myNewString.Substring(2, 6));

myNewString = "  Thanks    ";

Console.WriteLine(myNewString);
myNewString = myNewString.Trim();
Console.WriteLine(myNewString);

// --------------------------

int[] nums = { 1, 2, 3, -5 };
string[] words = { "Vanier", "Dawson" }; 

Console.WriteLine(nums[0]);
Console.WriteLine(nums.Length);
Console.WriteLine();

//Array.Clear(nums);
//Console.WriteLine(nums[0]);

int[] numsCopy = (int[]) nums.Clone();

Console.WriteLine(numsCopy[0]);

Console.WriteLine(numsCopy.Equals(nums));
Console.WriteLine(Array.IndexOf(words, "Dawson"));

Array.Sort(nums);

Console.WriteLine(nums[0]);

Array.Reverse(words);

Console.WriteLine(words[0]);

for(int i = 0; i < nums.Length; i++)
{
    Console.WriteLine(nums[i]);
}

//Console.WriteLine("Please input a string: ");
//String input = Console.ReadLine();

//Console.WriteLine(input);

int counter = 1;

while(counter < 5)
{
    Console.WriteLine(counter);
    ++counter;
}

int input;
int realPIN = 9999;

//do
//{
//    Console.WriteLine("Please input you PIN: ");
//    input = Convert.ToInt32(Console.ReadLine());

//} while (input != realPIN);

if(realPIN == 999)
{
    Console.WriteLine("True!");
} else
{
    Console.WriteLine("False :(");
}

//for(; ; )
//{
//    Console.WriteLine("Hey I'm Trapped");
//}

foreach(int each in nums)
{
    Console.WriteLine(each);
}

switch(realPIN)
{
    case 999:
        Console.WriteLine("you're 999");
        break;
    case 9999:
        Console.WriteLine("your pass is 9999");
        break;
    default:
        Console.WriteLine("None of the above");
        break;
}