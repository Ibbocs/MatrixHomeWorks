using ApiSqlCrud.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace ApiSqlCrud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyBookController : ControllerBase
    {
        //private IOptions<bookAppsetting> _options;
        //public MyBookController(IOptions<bookAppsetting> options)
        //{
        //    _options = options;
        //}


        [HttpGet]
        public Response GetBooks()
        {

            MyApiCrud myApiCrud = new MyApiCrud();
            //Response response = new Response();
            Response response = myApiCrud.GetAllBooks("SellectPro");

            return response;
        }

        //[HttpGet]
        //public IOptions<bookAppsetting> GetBook()
        //{
        //    return _options;
        //}

        [HttpPost]
        public Response AddBook([FromQuery] BookDTO bookDTO)
        {
            //bookun icini niye null gonderir ki?
            
            Response response = new Response();
            MyApiCrud myApiCrud = new MyApiCrud();

            response = myApiCrud.AddBook("InsertPro", bookDTO);


            return response;
        }

        [HttpPut]
        public Response UpdateBook([FromQuery] BookDTO bookDTO, [FromQuery] int id)
        {
            //bookun icini niye null gonderir ki?
            Response response = new Response();
            MyApiCrud myApiCrud = new MyApiCrud();

            response = myApiCrud.UpdateBook("UpdatePro", bookDTO, id);


            return response;
        }

        [HttpDelete]
        public Response DeleteBook([FromQuery]int id)
        {
            //bookun icini niye null gonderir ki?
            Response response = new Response();
            MyApiCrud myApiCrud = new MyApiCrud();

            response = myApiCrud.DeleteBook("DeletePro", id);


            return response;
        }
    }
}
