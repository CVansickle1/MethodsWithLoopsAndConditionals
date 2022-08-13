using MethodsWithLoopsAndConditionals;





Console.WriteLine("Please Provide 2 numbers you would like to see the range of:");
Console.WriteLine("Enter Your First number: ");
int firstInput = Methods.GetInput();

Console.WriteLine("Enter a Second number: ");
int secondInput = Methods.GetInput();

Methods.RangeFinder(firstInput, secondInput);

Console.WriteLine("\n----------------------------------\n");

Console.WriteLine("Please Provide 2 numbers you would like to see the range with an interval of 3: ");
Console.WriteLine("Enter Your First number: ");

int startingNum = Methods.GetInput();

Console.WriteLine("Enter a Second number: ");
int expectedNum = Methods.GetInput();

Methods.TimesThreeRange(startingNum, expectedNum);

Console.WriteLine("\n----------------------------------\n");

Console.WriteLine("Are These two numbers equal?");
Console.WriteLine("Enter the First number: ");

int areThese = Methods.GetInput();

Console.WriteLine("Enter a Second number: ");
int equal = Methods.GetInput();

Console.WriteLine(Methods.EqualOrNot(areThese, equal));

Console.WriteLine("\n----------------------------------\n");

Console.WriteLine("To find out if the number is even or odd enter it below");

int myInt = Methods.GetInput();

Console.WriteLine(Methods.Even(myInt));

Console.WriteLine("\n----------------------------------\n");

Console.WriteLine("Is your number Positive or Negative?");
Console.WriteLine("Enter Below to Test: ");

var positivelyNegative = Methods.GetInput();

Console.WriteLine(Methods.IsThisPositive(positivelyNegative));

Console.WriteLine("\n----------------------------------\n");

Console.WriteLine("Can you vote?");
Console.WriteLine("Enter your age to find out!");

var age = Methods.GetInput();

Console.WriteLine(Methods.CanYouVote(age));

Console.WriteLine("\n----------------------------------\n");

Console.WriteLine("Pick a number -10 - 10");

var inRange = Methods.GetInput();

Console.WriteLine(Methods.IsItInRange(inRange));

Console.WriteLine("\n----------------------------------\n");

Console.WriteLine("Enter a Number you would like to see the multiplication table of (Up to x12): ");

var initialVal = Methods.GetInput();

Console.WriteLine("-------------------------------");
Methods.MulplicationTable(initialVal);



