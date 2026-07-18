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

            #region Question 05 
            //Declare an int pages = 300; then store it in a double variable without using a cast.

            //int pages = 300;
            //double doublePages = pages;
            //Console.WriteLine(doublePages);

            #endregion

            #region Question 06 
            //Declare a double price = 49.99; then convert it into an int using a cast.

            //double price = 49.99;
            //int intPrice = ( int ) price;
            //Console.WriteLine(intPrice);


            #endregion

            #region Question 07
            // Given string pagesText = "464";, convert it into an int using the Convert class.


            //string pagesText = "464";
            //int convertedPages = Convert.ToInt32(pagesText);
            //Console.WriteLine(convertedPages);

            #endregion

            #region Question 08 
            /*Given string yearText = "2023";, convert it using int.Parse().
              Then given string badText = "abc";, use int.
              TryParse() to safely try converting it, and print "Invalid number" if it fails.
            */

            //string yearText = "2023";
            //string badText = "abc";

            //int ParsedYear = int.Parse(yearText);
            //Console.WriteLine(ParsedYear);

            //bool success = int.TryParse(badText, out int ParsedBadText);
            //Console.WriteLine(success);
            //Console.WriteLine(ParsedBadText);


            #endregion

            #region Question 09 
            /*Given int pages = 464;, convert it into a string using ToString() 
            and print its type using GetType() to prove it's now a string.
            */

            //int pages = 464;
            //string stringPages = pages.ToString();
            //Console.WriteLine(stringPages.GetType()); 




            #endregion

            #region Question 10 
            /*
             Declare int copies = 100;. Box it into an object variable,
            then unbox it back into a new int variable, and print both.
            */
            
            //int copies = 100;
            //Object boxedCopies = copies;
            //int unboxedCopies = (int)boxedCopies;
            //Console.WriteLine(unboxedCopies); 


            #endregion

        }
    }
}
