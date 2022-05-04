using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekend_assignment
{
    public class employee
    {
        public string FirstName { get; set; }   
        public string LastName { get; set; }
        public int Age { get; set; }    

        public static List<employee> GetEmployees()
        {
            return new List<employee>
            {
                new employee { FirstName = "Jude", LastName = "Smith", Age = 41},
                new employee { FirstName = "Sarah", LastName = "Jones", Age = 22},
                new employee { FirstName = "Stacy", LastName = "Baker", Age = 21},
                new employee { FirstName = "Samuel", LastName = "Dexter", Age = 17},
                new employee { FirstName = "Richy", LastName = "Smith", Age = 49},
                new employee { FirstName = "Brett", LastName = "Joy", Age = 51},
                new employee { FirstName = "Mark", LastName = "Parker", Age = 116},
                new employee { FirstName = "Alice", LastName = "Thompson", Age = 18},
                new employee { FirstName = "Evelyn", LastName = "Winsome", Age = 58},
                new employee { FirstName = "Mort", LastName = "Martin", Age = 58},
                new employee { FirstName = "Eugene", LastName = "deLauter", Age = 84},
                new employee { FirstName = "Gail", LastName = "Dude", Age = 34},

            };
        }
    }
    
    
   
   
}
