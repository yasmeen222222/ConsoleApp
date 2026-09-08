using System.Drawing;
using System.Reflection;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp4
{
    internal class Program
    {
        //question 3
        static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Library!");
        }
        //question 4
        static void PrintBookTitle(string title)
        {
            Console.WriteLine($"Book title: {title}");
        }
        //question 5
        static void AddBonusPages(int pages)
        {
            pages=pages+50;
        }
        //question 6
       static void ApplyDiscount(double[] prices)
        {
            prices[0] = prices[0] - 5;  
        }
        //question 7
       static void  AddBonusPagesByRef(ref int pages) { 
            pages=pages+50;
        }
        //question 8
         static void ReplaceArray(ref double[] prices)
        {
            double[] prices2 = { 10.0, 12.5, 15.0 };
        }
        //question 9
        static bool TryGetPrice(string title, out double price) { 
            
            if (title == "Clean Code")
            {
                price = 25.5;
                return true;
            }
            else
            {
                price = 0;
                return false;
            }
        }
        //question 10
        static void PrintBookInfo(string title, int pages = 300)
        {
            Console.WriteLine($"Book title: {title}, Pages: {pages}");
        }

        static void Main(string[] args)
        {
            #region question 1
            //Create a one - dimensional array double[] prices with the values 25.5, 40.0, 33.75.Print
            //the second price(index 1).
            //double[] prices = { 25.5, 40.0, 33.75 };
            //Console.WriteLine(prices[1]);
            #endregion
            #region question 2
            //            Create a 2x2 multidimensional array int[,] shelfCopies where shelf 0 has 3, 5 copies and
            //shelf 1 has 1, 4 copies.Print the number of copies on shelf 1, slot 0.
            //int[,] shelfCopies = { { 3, 5 }, { 1, 4 } };
            //Console.WriteLine(shelfCopies[1, 0]);

            #endregion
            #region question 3
            // Write a method called PrintWelcomeMessage that takes no parameters and prints
            //"Welcome to the Library!".Call it from Main.
            PrintWelcomeMessage();
            #endregion
            #region question 4
            // Write a method Write a method PrintBookTitle(string title) that prints "Book title: " + title. Call it with
            // "Clean Code".
            PrintBookTitle("Clean Code");

            #endregion
            #region question 5
            //Write a method AddBonusPages(int pages) that adds 50 to pages. Call it with a variable
            //int pages = 400; and print pages afterward. What do you expect to see, and why?]
            int pages = 400;
            Console.WriteLine(pages);
            AddBonusPages(pages);
            Console.WriteLine( pages); // الاتنيين 400 عشان ده  passing by value value type
            #endregion
            #region question 6
            //Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0].Call it
            // with double[] prices = { 25.5, 40.0 }; and print prices[0] afterward.What do you expect to
            //see, and why?
            double[] prices = { 25.5, 40.0 };
            Console.WriteLine(prices[0]);
            ApplyDiscount(prices);
            Console.WriteLine(prices[0]); // 20.5 عشان ده passing by value reference type
            #endregion
            #region question 7
            //Rewrite the method from question 5 as AddBonusPagesByRef(ref int pages) using ref.
            //Call it and print pages afterward. How is the result different from question 5 ?
            Console.WriteLine(pages); // 400
            AddBonusPagesByRef(ref pages);
            Console.WriteLine(pages); //450 عشان ده passing by reference value type
            #endregion
            #region question 8
            ///Write a method ReplaceArray(ref double[] prices) that replaces prices entirely with a
            //new array { 10.0, 12.5, 15.0 }.Call it with your prices array and print prices.Length
            //afterward.
            ReplaceArray(ref prices);
            Console.WriteLine(prices.Length);
            #endregion
            #region question 9

            //          //  Write a method bool TryGetPrice(string title, out double price) that returns true and sets
            //        price to 25.5 if title is "Clean Code", otherwise returns false and sets price to 0.Call it
            //and print the price if found
           double price = 0;
            TryGetPrice("Clean Code", out price);
            Console.WriteLine(price);


            #endregion
            #region question 10
            // Write a method PrintBookInfo(string title, int pages = 300) where pages is optional.Call
            //it once with only a title, and once passing both a title and pages.
            PrintBookInfo("Clean Code");
            PrintBookInfo("Clean Code", 400);

            #endregion
        }


    }
}
