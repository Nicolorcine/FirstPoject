using System;
using myFirstProject.Computation;




namespace FirstPoject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an operation to use? + - * /");

            FirstPart Calcuone = new FirstPart();

            SecondPart Calcutwo = new SecondPart(); 

            Calcuone.operationAnswer();

            Calcutwo.secondContainer();

            Calcutwo.finalAnswer();

           
    
           
   
        }
    }
}
