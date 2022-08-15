using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsWithLoopsAndConditionals
{
    internal class Methods
    {

        public static int GetInput()
        {
            bool numCheck;

            numCheck = int.TryParse(Console.ReadLine(), out int num);

            while (!numCheck)
            {
                Console.WriteLine("Please enter a number: ");
                numCheck = int.TryParse(Console.ReadLine(), out num);
            }

            return num;
        }


        public static void RangeFinder(int firstNum, int secondNum)
        {
            var myLargelist = new List<int>();

            if (firstNum > secondNum)
            {
                do
                {
                    myLargelist.Add(firstNum);
                    firstNum--;
                }

                while (firstNum >= secondNum);

                Console.WriteLine("Here is the range of those two numbers: \n");

                foreach (int x in myLargelist)
                {

                    Console.WriteLine(x);
                }
            }

            else if (secondNum > firstNum)
            {
                do
                {
                    myLargelist.Add(firstNum);
                    firstNum++;
                }

                while (secondNum >= firstNum);

                Console.WriteLine("Here is the range of those two numbers: \n");
                foreach (int x in myLargelist)
                {
                    Console.WriteLine(x);
                }
            }

            else
            {
                Console.WriteLine("Those two numbers are equal!");

            }
        }

        public static void TimesThreeRange(int startingNum, int expectedNum)
        {
            var myThreelist = new List<int>();


            if (startingNum < expectedNum)
            {
                Console.WriteLine($"Here is the range of those two numbers by an interval of 3: \n");
                do
                {
                    myThreelist.Add(startingNum);
                    startingNum += 3;
                }

                while (startingNum <= expectedNum);


                foreach (int x in myThreelist)
                {
                    Console.WriteLine(x);
                }
                
            }

            else if (startingNum > expectedNum)
            {
                Console.WriteLine($"Here is the range of those two numbers by an interval of 3: \n");

                do
                {
                    myThreelist.Add(startingNum);
                    startingNum -= 3;
                }

                while (startingNum >= expectedNum);


                foreach (int x in myThreelist)
                {
                    Console.WriteLine(x);
                }


            }

            else
            {
                Console.WriteLine("Those two numbers are equal!");
            }


        }

        public static string EqualOrNot(int isThis, int equalTo)
        {
            return (isThis == equalTo) ? $"Yup, {isThis} is equal to {equalTo} " : $"Nope, {isThis} is not equal to {equalTo}";
        }

        public static string Even(int evenORnot)
        {
            return (evenORnot % 2 == 0) ? $"{evenORnot} is EVEN" : $"{evenORnot} is ODD";
        }

        public static string IsThisPositive(int userInput)
        {
            if (userInput > 0)
            {
                return "This is Positive!";
            }
            else if (userInput < 0)
            {
                return "This is Negative";
            }
            else
            {
                return "Thats 0!";
            }

        }
        public static string CanYouVote(int age)
        {
            return (age >= 18) ? "Yes! You can vote! Dont forget to register in your area! :)" : "Sorry! You cannot vote at the moment, you have to be at least 18 years old :(";
        }
        
       public static string IsItInRange(int rangeCheck)
        {
            var tenList = new List<int>();
            var startNum = -10;
            
            do
            {
                tenList.Add(startNum);
                startNum++;
            }
            while (startNum <= 10);

            return (tenList.Contains(rangeCheck)) ? "That number is in range of -10 - 10!" : "That number is not in range of -10 - 10";

        }

        public static void MulplicationTable(int initialVal)
        {
            var Table = new List<int>();
            var results = new List<int>();
            var startingNum = initialVal;

            for (int i = 1; i <= 12; i++)
            {
                Table.Add(i);
       
                do
                {
                    var finalResults = initialVal * i;
                    results.Add(finalResults);
                   
                    Console.WriteLine($"{startingNum}* {i} = {finalResults}");
 
                }
                while (Table.Count >= 13);
            }


            
        }
    }
}
