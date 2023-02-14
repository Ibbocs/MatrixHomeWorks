using ApiSqlCrud.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiSqlCrud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyBookController : ControllerBase
    {
        [HttpGet]
        public Response GetBooks()
        {
            
            MyApiCrud myApiCrud = new MyApiCrud();
            //Response response = new Response();
            Response response = myApiCrud.GetAllBooks("SellectPro");

            return response;
        }

        [HttpPost]
        public Response AddBook([FromQuery] Book book)
        {
            //bookun icini niye null gonderir ki?
            
            Response response = new Response();
            MyApiCrud myApiCrud = new MyApiCrud();

            response = myApiCrud.AddBook("InsertPro", book);


            return response;
        }

        [HttpPut]
        public Response UpdateBook([FromQuery] Book book)
        {
            //bookun icini niye null gonderir ki?
            Response response = new Response();
            MyApiCrud myApiCrud = new MyApiCrud();

            response = myApiCrud.UpdateBook("UpdatePro", book);


            return response;
        }

        [HttpDelete]
        public Response DeleteBook(int id)
        {
            //bookun icini niye null gonderir ki?
            Response response = new Response();
            MyApiCrud myApiCrud = new MyApiCrud();

            response = myApiCrud.DeleteBook("DeletePro", id);


            return response;
        }
    }
}
