using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Management
{
    abstract class Order
    {
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string DueDate { get; set; }
        public int OrderNumber { get; set; }
        public List<Shape> OrderedBlocks { get; set; }

        public abstract void GenerateReport();

        // thinking about inheritance here. thought about adding something like the below?
        // based on this: https://learn.microsoft.com/en-us/dotnet/api/system.object.tostring?view=net-70#overriding-the-objecttostring-method
        // and this: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/knowing-when-to-use-override-and-new-keywords
        // this relates to that new/override Object.ToString() warning stated in lings-notes 
        // im not much of a c# person but you could try separate the below into its own class:

       /*  public class OrderOutput
        {
            public static void Main()
            {
                Order order = new Order('Name');
                Console.WriteLine(order.ToString());
            }
        } */

        // suggestion: add new... ie public new string ToString()
        // what is the expected output / behaviour of the current object instance? is it string? 
        // if so, use new, else override depending on the type.
        public string ToString()
        {
            return "\nName: " + CustomerName + " Address: " + Address + " Due Date: " + DueDate + " Order #: " + OrderNumber;
        }
    }
}
