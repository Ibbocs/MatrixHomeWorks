using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentorOOP.Task4
{
    public class Book : ITypeBook
    {

        private string[] bookWithType;
        private string[] books;
        private string[] booksType;

        public Book(string[] _bookWithType) 
        {
            bookWithType= _bookWithType;

            //book
        }

        public List<string[]> Books => new List<string[]> { books };

        public List<string[]> BookType => new List<string[]> { booksType };

        public void CheckingOut()
        {

        }

        public void ReturningBooks()
        {

        }
    }

    public class Borrower
    {

    }

    public class Librarian
    {

    }
}
