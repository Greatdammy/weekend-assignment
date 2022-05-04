using System;
using System.Collections.Specialized;
using System.Linq;

namespace weekend_assignment
{
    public class Program
    {
        //Question Three data
        public static string[] words = { "Plane", "Ferry", "Car", "Bike" };

       
        static void Main()
        {
            //Question One

            StringCollection stringCol = new StringCollection();
            String[] arr = new String[] 
            {  "abstract", "add*", "alias*", "as", "ascending*","async*", "await*", "base","bool", "break",
               "by*", "byte", "case", "catch", "char", "checked","class", "const", "continue", "decimal", "default",
               "delegate", "descending*", "do", "double","dynamic*", "else", "enum", "event", "equals*",
               "explicit", "extern", "false", "finally", "fixed","from*", "float", "for", "foreach", "get*", "global*",
               "group*", "goto", "if", "implicit", "in", "int","into*", "interface", "internal", "is", "lock", "long",
               "join*", "let*", "nameof*", "namespace", "new", "null","object", "on*", "operator", "orderby*", "out",
               "override", "params", "partial*", "private", "protected","public", "readonly", "ref", "remove*", "return", "sbyte",
               "sealed", "select*", "set*", "short", "sizeof","stackalloc", "static", "string", "struct", "switch",
               "this", "throw", "true", "try", "typeof", "uint", "ulong","unsafe", "ushort", "using", "value*", "var*", "virtual",
               "unchecked", "void", "volatile", "where*", "while", "yield*"
            };

            var collect = arr.Where(x => x.Contains("e"))
                            .OrderBy(x => x);           
            foreach(var x in collect)
            {
                Console.WriteLine($"lists of words with an E: {x} ");
            }
            Console.WriteLine();

            var take = arr.LastOrDefault();
            Console.WriteLine($"The last word in the array is: {take}");
            Console.WriteLine();

            var collect2 = arr.Where(x => x.Contains("*"))
                               .OrderBy(x => x);
            foreach( var y in collect2)
            {
                Console.WriteLine($"Words that contains a *: {y}");
            }
            Console.WriteLine();

            //Question Two
            var Employee = employee.GetEmployees();

            var emp1 = Employee.Where(x => x.LastName.StartsWith("D"))
                                .Select(x => (LastName: x.LastName, FirstName: x.FirstName));
            foreach (var item in emp1)
            {
                Console.WriteLine($"LastName: {item.LastName} FirstName: {item.FirstName}");
            }
            Console.WriteLine();
            var emp = Employee.Where(x => x.Age > 40)
                              .OrderByDescending(x => x.FirstName)
                              .Select(x => (Name: x.FirstName, LName: x.LastName, x.Age));
            foreach (var item in emp)
            {
                Console.WriteLine($"FirstName: {item.Name} : LastName: {item.LName} : Age: {item.Age}");
            }
  
            // Question Three 

            Console.WriteLine();
            var transport = words.Where(x => x.Contains("e"))
                                   .OrderBy(x=> x);
            foreach(var item in transport)
            {
                Console.WriteLine($"Mode of Transportation: {item}");
            }
        }
    }
}
