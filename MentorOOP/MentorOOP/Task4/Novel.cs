using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentorOOP.Task4
{
    public class Novel : ITypeBook
    {
        public string Name { get; set; }
    }

    public class Borrower
    {

    }

    public class Librarian
    {
        public static List<ITypeBook> Books { get; set; }
        public static List<Borrowers> Borrowers{ get; set; }

        public void CheckingOut()
        {

        }

        public void ReturningBooks()
        {

        }

    }

    public class Borrowers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BookName { get; set; }
    }
}
