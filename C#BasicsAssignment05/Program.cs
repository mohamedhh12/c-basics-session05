using System.Text;

using System;

namespace C_BasicsAssignment05
{
    internal class Program
    {
        enum Genre
        {
            Fiction,
            NonFiction,
            Science
        }
        class Book
        {
            // Access Modifiers
            private string password = "secret";
            internal int copiesInStock = 5;
            public string? Title;

            // Property
            public Genre BookGenre { get; set; }

            // Method to access private field
            public void PrintPassword()
            {
                Console.WriteLine(password);
            }


        }
        static void Main(string[] args)
        {
            Console.WriteLine("===================== Q12 ===============");
            #region Assignment 03 from Q12 to Q18
            #region Q12 
            // Q13 is related to Q12, so I will complete Q11 first.
            /*Given string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };, use a for loop to print each book with its position number, like 1. Clean Code. */
            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };


            for (int counter = 0; counter < books.Length; counter++)
            {
                Console.WriteLine($"{counter + 1}. {books[counter]}");
            }

            #endregion
            Console.WriteLine("===================== Q13 ===============");
            #region Q13
            /*Using the same books array, use a while loop to print every book title. */


            int counter13 = 0;

            while (counter13 < books.Length)
            {
                Console.WriteLine($" {counter13} - {books[counter13]}");
                counter13++;
            }
            #endregion
            Console.WriteLine("==================== Q14 =================");

            Console.WriteLine("===================== Q15 ================");
            #region Q15
            /*Using the same books array, use a foreach loop to print every book title. */


            foreach (string book15 in books)

            {
                Console.WriteLine(book15);
            }
            #endregion
            Console.WriteLine("===================== Q16 ================");
            #region Q16
            /*Using the same books array, loop through it and print each title, but stop completely (break) once you reach "Refactoring". */


            foreach (string book16 in books)
            {
                if (book16 == "Refactoring")
                {
                    break;
                }

                Console.WriteLine(book16);
            }
            #endregion
            Console.WriteLine("===================== Q17=================");
            #region Q17
            /*Using the same books array, print every title except "The Pragmatic Programmer" (skip it with continue, don't stop the loop). */
            foreach (string book17 in books)
            {
                if (book17 == "The Pragmatic Programmer")
                {
                    continue;
                }

                Console.WriteLine(book17);
            }
            #endregion
            Console.WriteLine("===================== Q18 ================");
            #region Q18
            /*Write a method PrintFirstBook() that prints the first book in the books array. If the array is empty, use return to exit the method early instead of printing anything.  */
            static void PrintFirstBook(string[] books)
            {
                if (books.Length == 0)
                {
                    return;
                }

                Console.WriteLine(books[0]);
            }
            PrintFirstBook(books);
            #endregion

            #endregion

            Console.WriteLine($"================= End of Assignment03 =================");

            Console.WriteLine($"================== Start of Assignment05 ==================");
            #region Task1 to Task9 assignment05
            #region Task 1 
            // Task 1: Private field
            Book book = new Book();

            // This would cause a compilation error:
            // Console.WriteLine(book.password);
            Console.WriteLine("====================== Q1 ===================");
            // Access private field through a public method
            book.PrintPassword();
            #endregion
            #region Task02 
            Console.WriteLine("====================== Q2 ===================");
            // Task 2: Internal field
            Console.WriteLine(book.copiesInStock);
            #endregion
            #region Task03
            Console.WriteLine("====================== Q3 ===================");
            // Task 3: Public field
            book.Title = "Clean Code";
            Console.WriteLine(book.Title);
            #endregion
            #region Task 4
            Console.WriteLine("====================== Q4 ===================");
            // Task 4: Enum property
            book.BookGenre = Genre.Science;
            Console.WriteLine(book.BookGenre);
            #endregion
            #region Task05
            Console.WriteLine("====================== Q5 ===================");
            // Task 5: Convert enum values to int
            Console.WriteLine((int)Genre.Fiction);
            Console.WriteLine((int)Genre.NonFiction);
            Console.WriteLine((int)Genre.Science);
            #endregion
            #region Task06
            Console.WriteLine("====================== Q6 ===================");
            // Task 6: Convert int to enum
            int genreNumber = 1;
            Genre convertedGenre = (Genre)genreNumber;
            Console.WriteLine(convertedGenre);
            #endregion
            #region Task07
            Console.WriteLine("====================== Q7 ===================");
            // Task 7: Convert enum to string
            Genre genre = Genre.Fiction;
            string genreString = genre.ToString();
            Console.WriteLine(genreString);
            #endregion
            #region Task08
            Console.WriteLine("====================== Q8 ===================");
            // Task 8: Convert string to enum using Enum.Parse
            string genreText = "Science";
            Genre parsedGenre = (Genre)Enum.Parse(
                typeof(Genre), genreText
            );
            Console.WriteLine(parsedGenre);
            #endregion
            #region Task09
            Console.WriteLine("====================== Q9 ===================");
            // Task 9: Convert string using Enum.TryParse
            string invalidGenreText = "Mystery";

            if (Enum.TryParse<Genre>(
                invalidGenreText, out Genre result))
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Unknown genre");
            }
            #endregion
            #endregion


        }
    }
}