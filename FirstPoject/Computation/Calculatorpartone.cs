using System;

namespace myFirstProject.Computation
{
    class FirstPart
    {
        public static string questionAnswer;
        public static int firstNumber;

        public void operationAnswer()
        {
            questionAnswer = Console.ReadLine();
            checkQuestionAnswer();
        }


        void firstContainer()
        { 
            Console.Write("Enter a number: ");
            try { 
                firstNumber = Int32.Parse(Console.ReadLine());
            }
            catch(FormatException)
            {
                firstContainer();
            }
        }



        void checkQuestionAnswer()
        {
            if ( questionAnswer == "+" || questionAnswer == "-" || questionAnswer == "*" || questionAnswer == "/")
            {
                firstContainer();
            }
            else
            {
                Console.WriteLine("Choose the correct operation! >:| ");
                operationAnswer();
            }
        }

   
    }



    class SecondPart
    {

        public int secondNumber;
        public void secondContainer()
        {
            Console.Write("Enter a second number: ");
            try
            {
                secondNumber = Int32.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                secondContainer();
            }
        }

        public void finalAnswer()
        {
            if ( FirstPart.questionAnswer == "+")
            {
                Console.WriteLine($"The answer is {FirstPart.firstNumber + secondNumber}");
            }
            else if (FirstPart.questionAnswer == "-")
            {
                Console.WriteLine($"The answer is {FirstPart.firstNumber - secondNumber}");
            }
            else if (FirstPart.questionAnswer == "*")
            {
                Console.WriteLine($"The answer is {FirstPart.firstNumber * secondNumber}");
            }
            else if (FirstPart.questionAnswer == "/")
            {
                Console.WriteLine($"The answer is {FirstPart.firstNumber / secondNumber}");
            }
         
        }

    }
}
