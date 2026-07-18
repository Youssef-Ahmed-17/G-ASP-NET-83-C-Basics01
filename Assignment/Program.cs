using System.Numerics;
using System.Timers;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment
{
    internal class Program
    {
        class Book
        {
            public string tittle;
            public int pages;
        }
        static void Main(string[] args)
        {

            #region Question 01 
            //Create a Book object and store it in a variable of type object. Print it.

            //Object book = new Book();
            //Console.WriteLine(book);

            #endregion

            #region Question 02
            /*
              Using the Book class above, print the result of calling ToString()
              , Equals() (compare book with itself), GetHashCode(), and GetType() on book.
            */

            //Book book = new Book(); 

            //Console.WriteLine(book.ToString()) ;
            //Console.WriteLine(book.Equals(book) );
            //Console.WriteLine(book.GetHashCode()); 
            //Console.WriteLine(book.GetType()); 
            #endregion

            #region Question 03 
            /*
            Look at the line below. Is it a compile-time error, a runtime error, or a logical error? Fix it.
            int pages = "464";
            */

            // Compile - time error — you can't put text (string) into an int variable.

            // int pages = 464;

            //Console.WriteLine(pages); 

            #endregion

            #region Question 04 
            /*
             Write code that divides 10 by 0 inside a try block, catches the exception, 
            prints "Cannot divide by zero", and then prints "Done" in a finally block  
             */
            //try
            //{
            //    int firstNumber = 10;
            //    int secondNumber = 0; 
            //    int div = firstNumber / secondNumber ;
            //    Console.WriteLine(div);
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine("Cannot divide by zero");
            //}
            //finally
            //{
            //    Console.WriteLine("Done"); 
            //}


            #endregion
        }
    }
}
