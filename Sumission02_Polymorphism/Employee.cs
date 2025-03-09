using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submission02_Polymorphism
{
    class Employee : IQuittable
    {
      public string Name { get; set; }
      public void Quit()
      {
         Console.WriteLine(Name + " quitted the job.");
      }
    }  
}
