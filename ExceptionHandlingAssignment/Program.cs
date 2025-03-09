using System;

class Program
{
   static void Main()
   {

      //Create a list of integers
      List<int> intList = new List<int>() { 5, 99, 23, 10, 185, 22, 12, 2994, 101, 77000 };
      //Ask the user for input and loop through the list dividing each number by the input 
      bool numValid = false;
      while (!numValid)
      {
         //Using a try/catch block to give error message
         try
         {
            Console.WriteLine("\nEnter a number to divide the above list by: ");
            float numDivide = float.Parse(Console.ReadLine());
            //If statement to check if the user entered 0
            if (numDivide == 0)
            {
               Console.WriteLine("Please enter a number other than 0.");
            }
            //Dividing each number in the list by the input 
            else
            {
               foreach (int num in intList)
               {
                  float result = num / numDivide;
                  Console.WriteLine(num + " divided by " + numDivide + " equals " + result);
               }
               numValid = true;
            }
         }
         catch (FormatException)
         {
            Console.WriteLine("Please type a whole number!");
         }
         catch (DivideByZeroException)
         {
            Console.WriteLine("Please enter a number other than 0.");
         }
         catch (Exception xp)
         {
            Console.WriteLine(xp.Message);
         }
      }
      //Message to let the user know the program has exited the try/catch block 
      Console.WriteLine("The program has exited the try/catch block.");
   }
}
