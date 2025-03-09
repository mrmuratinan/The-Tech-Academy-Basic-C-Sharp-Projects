using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submission03_Operators
{
    public class Employee
    {
      // Properties
      public int Id { get; set; }
      public string FirstName { get; set; }
      public string LastName { get; set; }

      // Constructor
      public Employee(int id, string firstName, string lastName)
      {
         Id = id;
         FirstName = firstName;
         LastName = lastName;
      }
      // Overload the == operator
      public static bool operator ==(Employee emp1, Employee emp2)
      {
         return emp1.Id == emp2.Id;
      }

      // Overload the != operator (must be overloaded in pairs with ==)
      public static bool operator !=(Employee emp1, Employee emp2)
      {
         return !(emp1 == emp2);
      }
   }
}
