using HotelProject.WebUI.Dtos.ContactDto;
using HotelProject.WebUI.Dtos.MessageCategoryDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public ContactController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient(); //_httpClientFactory aracılığıyla bir HTTP istemcisi oluşturuyoruz. Bu, HTTP isteklerini yapmak için kullanılacak olan istemciyi sağlar.

            var responseMessage = await client.GetAsync("http://localhost:3523/api/MessageCategory"); //Oluşturulan istemci üzerinden,veri listelemek istediğimiz için GetAsync kullanıyoruz,Bu istek,belirtilen adrese gitmek ve oradan veri almak içindir.

            var jsonData = await responseMessage.Content.ReadAsStringAsync(); //Sunucudan gelen yanıtı JSON formatında okuyoruz ve bu JSON verisini bir dize olarak alıyoruz.

            var values = JsonConvert.DeserializeObject<List<ResultMessageCategoryDto>>(jsonData); //Aldığımız JSON verisini ResultMessageCategoryDto türündeki bir listeye dönüştürüyoruz. Bu işlem, JSON verisini C# nesnelerine çevirir.

            List<SelectListItem> values2 = (from x in values
                                            select new SelectListItem
                                            {
                                                Text = x.MessageCategoryName, //Text özelliği, dropdown listesinde görünecek metni belirtir.
                                                Value = x.MessageCategoryID.ToString() //Value özelliği, seçeneğin değerini belirtir.
                                            }).ToList(); //SelectListItem listesi oluşturuyoruz. Bu, bir dropdown listesi için seçenekleri oluşturur.
            ViewBag.v = values2; //Elde ettiğimiz dropdown listesini, ViewBag üzerinden view'e aktarıyoruz. ViewBag dinamik bir yapıdır ve view tarafında kullanılabilir.
            return View();
        }

        [HttpGet]
        public PartialViewResult SendMessage()
        {
            return PartialView();
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage(CreateContactDto createContactDto)
        {
            createContactDto.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createContactDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            await client.PostAsync("http://localhost:3523/api/Contact", stringContent);
            return RedirectToAction("Index", "Default");
        }
    }
}
