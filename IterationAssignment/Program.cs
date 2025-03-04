using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Xml.Linq;

class Program

{
   static void Main(string[] args)
   {
      // Part 1
      //A one-dimensional array of strings
      string[] strFirstPart =
      {
         "Your name is ",
         "Your surname is ",
         "You are studying "
      };

      List<string> lstSecondPart = new();

      //Ask the user to input some text.
      Console.Write("Please enter your name: ");
      lstSecondPart.Add(Console.ReadLine());
      Console.Write("Please enter your surname: ");
      lstSecondPart.Add(Console.ReadLine());
      Console.Write("Please enter the course you are studying: ");
      lstSecondPart.Add(Console.ReadLine());

      //Create a loop that iterates through each string in the array and adds the user's text input to the end of each string
      for (int i = 0; i < strFirstPart.Length; i++)
      {
         strFirstPart[i] += lstSecondPart[i];
      }

      //Then create a second loop that prints off each string in the array one at a time.
      Console.WriteLine("Press anykey to display the result...");
      Console.ReadLine();
      for (int i = 0; i < strFirstPart.Length; i++)
      {
         Console.Write(strFirstPart[i]);
         Console.WriteLine(i == strFirstPart.Length-1 ? ".": ",");
      }
      Console.WriteLine("\nEnd of the PART 1. Press anykey to continue...");
      Console.ReadLine();

      //Part 2
      // Create an infinite loop 
      int j= 0;
      while (true)
      {
         //To fix the infinite loop I added a break statement
         if (j > 5) { break; }

         Console.WriteLine("Count = {0}.", j);
         j++;
      }
      Console.WriteLine("\nEnd of the PART 2. Press anykey to continue...");
      Console.ReadLine();

      //Part 3
      //Create a loop where the comparison that’s used to determine whether to continue iterating the loop is a “<” operator.
      j = 0;
      while (j < 5)
      {
         Console.Write(j);
         j++;
      }

      Console.WriteLine("\n");

      //Create a loop where the comparison that’s used to determine whether to continue iterating the loop is a “<=” operator.
      j = 0;
      while (j <= 5)
      {
         Console.Write(j);
         j++;
      }
      Console.WriteLine("\n\nEnd of the PART 3. Press anykey to continue...");
      Console.ReadLine();

      //Part 4
      //Create a List of strings where each item in the list is unique.

      List<string> strCountries = new List<string>() 
      {
        "Antigua and Barbuda",
         "Bahamas",
         "Barbados",
         "Belize",
         "Canada",
         "Costa Rica",
         "Cuba",
         "Dominica",
         "Dominican Republic",
         "El Salvador",
         "Grenada",
         "Guatemala",
         "Haiti",
         "Honduras",
         "Jamaica",
         "Mexico",
         "Nicaragua",
         "Panama",
         "Saint Kitts and Nevis",
         "Saint Lucia",
         "Saint Vincent and the Grenadines",
         "Trinidad and Tobago",
         "United States of America"
      };
      //Ask the user to input text to search for in the List.
      Console.Write("\nEnter an independent country name in North America: ");
      string strInputCountry = Console.ReadLine();
      strInputCountry = char.ToUpper(strInputCountry[0])+ strInputCountry.Substring(1);
      int intIndex = 0;
      bool isValid = false;
      //Create a loop that iterates through the list and then displays the index of the array that contains matching text on the screen.
      foreach (string strCountry in strCountries)
      {
         if (strInputCountry == strCountry)
         {
            isValid = true;
            intIndex = strCountries.IndexOf(strCountry);
            break;
         }
      }
      string result= (isValid) ? "\n\nCongats! " + strInputCountry + " is a North America country with a index " + intIndex : "\n\nSorry! " + strInputCountry + " is not a North America country.";
      Console.WriteLine(strInputCountry + result);

      Console.WriteLine("\n\nEnd of the PART 4. Press anykey to continue...");
      Console.ReadLine();

      // Part 5
      // Create a List of strings that has at least two identical strings in the List.
      List<string> lstLetters = new() { "a", "b", "c", "b" };

      //Ask the user to select text to search for in the list.

      Console.Write("Enter a or b or c): ");
      int origRow = Console.CursorTop;
      int origCol = Console.CursorLeft;
      string strInput = "";

      while (!(strInput == "a" || strInput == "b" || strInput == "c"))
      {
         if (strInput != "") {
            Console.SetCursorPosition(origCol, origRow);
            Console.Write(" ");
            Console.SetCursorPosition(0, origRow+1);
            Console.Write("Please enter letters a or b or c only!"); 
         }
         Console.SetCursorPosition(origCol, origRow);
         strInput = Console.ReadLine();
      }
      Console.SetCursorPosition(0, origRow + 1);
      Console.Write(new string(' ', Console.WindowWidth));
      Console.WriteLine("The matching letter is at the index(s): ");
      //Create a loop that iterates through the loop and then displays the indices of the array that contain matching text on the screen.
      j = 0;
      for (j = 0; j < lstLetters.Count; j++)
      {
         if (strInput == lstLetters[j]) { Console.WriteLine(j); }
      }
      Console.WriteLine("\n\nEnd of the PART 5. Press anykey to continue...");
      Console.ReadLine();

      //Part 6
      //Create a List of strings that has at least two identical strings in the List.
      lstLetters=new List<string>() { "A", "B", "C", "D", "C", "B" };
      List<string> lstCheck = new();
      Console.WriteLine("Duplicate report:");
      //Create a foreach loop that evaluates each item in the list, and displays a message showing the string and whether or not it has already appeared in the list.
      foreach (string strLetter in lstLetters)
      {
         Console.Write(strLetter);
         if (lstCheck.Contains(strLetter))
         {
            Console.WriteLine(" - This item is a duplicate.");
         }
         else
         {
            Console.WriteLine(" - Unique.");
            lstCheck.Add(strLetter);
         }
      }
      Console.WriteLine("\n\nEnd of the PART 6. Press anykey to continue...");
      Console.ReadLine();
   }
}


