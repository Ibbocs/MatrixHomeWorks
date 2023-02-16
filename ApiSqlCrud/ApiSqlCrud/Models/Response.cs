using System.Collections.Generic;

namespace ApiSqlCrud.Models
{
    public class Response
    {
        public int StatusCode { get; set; }
        public string StatusMassage{ get; set; }
        //public Book Book { get; set; }

        public string exception { get { return "All Things Are Good"; } set { } }

        public List<Book> listOfBooks { get; set; }
    }
}
