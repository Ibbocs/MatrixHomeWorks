using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using StudentMVC.Models;
using StudentMVC.Models.Entity;
using System.Diagnostics;
using System.Security.Policy;
using System.Text;

namespace StudentMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHttpClientFactory httpClientFactory;
        public HomeController(ILogger<HomeController> logger, IHttpClientFactory _httpClientFactory)
        {
            _logger = logger;
            httpClientFactory = _httpClientFactory;
        }

        public async Task<IActionResult> Index(Student student)
        {
            using (HttpClient client = httpClientFactory.CreateClient())
            {
                //client.BaseAddress = new Uri("https://localhost:44384/api/Comment/");
                //var response = await client.GetAsync("GetAllComments");
                //var data = await response.Content.ReadAsStringAsync();
                //var normalData = JsonConvert.DeserializeObject<List<Root>>(data);
                //Console.WriteLine();
            }
            //using (HttpClient client = new HttpClient())
            //{
            //    client.BaseAddress = new Uri("https://localhost:44384/api/Comment/");
            //    var response = await client.GetAsync("GetAllComments");
            //    var data = await response.Content.ReadAsStringAsync();
            //    var normalData = JsonConvert.DeserializeObject<List<Root>>(data);
            //    Console.WriteLine();
            //}

           
            return View();
        }

        public async void Post(Post root)
        {
            using (HttpClient client = httpClientFactory.CreateClient())
            {
                string url = "https://localhost:44384/api/Comment/";
                string json = JsonConvert.SerializeObject(root, Formatting.Indented);
                var data = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await client.PostAsync(url, data);
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}