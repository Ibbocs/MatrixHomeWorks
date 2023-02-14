using System.Collections.Generic;

namespace ApiSqlCrud.Models
{
    public class Response
    {
        public int StatusCode { get; set; }
        public string StatusMassage{ get; set; }
        //public Book Book { get; set; }

        public string exception = "All Things Are Good";

        public List<Book> listOfBooks { get; set; }
    }
}
