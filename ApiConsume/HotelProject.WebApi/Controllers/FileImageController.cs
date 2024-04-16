using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileImageController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> UploadImage([FromForm] IFormFile file) //Dosya Yükleme İşlemi,Dosyadan çekildiği için FromForm kullanıldı.
        {
            var fileName = Guid.NewGuid() + Path.GetExtension(file.FileName); //GetExtension ile uzantı alınır.
            var path = Path.Combine(Directory.GetCurrentDirectory(), "images/" + fileName); //Verilen yola kaydeder.
            var stream = new FileStream(path, FileMode.Create); //Oluşturma modunda kullan.
            await file.CopyToAsync(stream); //Değişkenden gelen değeri kopyala
            return Created("", file);
        }
    }
}
