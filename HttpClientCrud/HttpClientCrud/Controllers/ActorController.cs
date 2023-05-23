using HttpClientCrud.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Numerics;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace HttpClientCrud.Controllers
{
    public class ActorController : Controller
    {

        //private readonly IHttpClientFactory _httpClientFactory;

        public ActorController(/*IHttpClientFactory httpClientFactory*/)
        {
            //_httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            //httpCrud.GetAll("Actor");
            using (HttpClient client = /*_httpClientFactory.CreateClient()*/ new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44397/api/");
                var response = await client.GetAsync("Actor");
                var readedData = await response.Content.ReadAsStringAsync();
                var modelData = JsonConvert.DeserializeObject<List<Actor>>(readedData);
                return View(modelData);
            }

        }
        [HttpGet]
        public IActionResult Add(Actor actor)
        {
            return View(actor);
        }

        [HttpPost]
        public async Task<IActionResult> AddActor(Actor actor)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = "https://localhost:44397/api/Actor/new-actor";
                //string json = JsonConvert.SerializeObject(actor);

                //StringContent Sendedata = new StringContent(json, Encoding.UTF8, "application/json");

                //var response = await client.PostAsync(url, Sendedata);

                var content = new StringContent(JsonConvert.SerializeObject(actor), Encoding.UTF8, "application/json");
                var response = await client.PostAsync(url, content);
            }
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(int id)
        {
            using (HttpClient client =  new HttpClient())
            {
                client.BaseAddress = new Uri($"https://localhost:44397/api/{id}");
                var response = await client.GetAsync($"Actor/{id}");
                var readedData = await response.Content.ReadAsStringAsync();
                var modelData = JsonConvert.DeserializeObject<List<Actor>>(readedData);
                return View(modelData);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Update(int id, Actor actor)
        {
            using (HttpClient client = new HttpClient())
            {
                //string url = "https://localhost:44397/api/Actor/change-actor";
                var contentType = new MediaTypeWithQualityHeaderValue("application/json");
                client.DefaultRequestHeaders.Accept.Add(contentType);

                var status = JsonConvert.SerializeObject(actor);

                StringContent content = new StringContent(status, Encoding.UTF8, "application/json");
                

                var request = client.PutAsync($"https://localhost:44397/api/Actor/new-actor", content).Result;
                return RedirectToAction("Index");


                //var content = new StringContent(JsonConvert.SerializeObject(actor), Encoding.UTF8, "application/json");
                //var response = await client.PutAsync($"{url}/{id}", content);

            }
        }

        public async Task<IActionResult> Delete(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                var contentType = new MediaTypeWithQualityHeaderValue("application/json");
                client.DefaultRequestHeaders.Accept.Add(contentType);

                var request = client.DeleteAsync($"https://localhost:44397/api/Actor/remove-actor/{id}");

            }
            return RedirectToAction("Index");
        }

        //[HttpDelete]
        //public async Task<IActionResult> Delete(int id)
        //{
        //    using (HttpClient client = new HttpClient())
        //    {
        //        var contentType = new MediaTypeWithQualityHeaderValue("application/json");
        //        client.DefaultRequestHeaders.Accept.Add(contentType);

        //        var request = client.DeleteAsync($"https://localhost:44397/api/Actor/remove-actor/{id}");

        //    }
        //    return RedirectToAction("Index");
        //}

    }
}
