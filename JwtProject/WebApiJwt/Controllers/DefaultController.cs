using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiJwt.Models;

namespace WebApiJwt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpGet("[action]")]
        public IActionResult TokenOlustur()  //Test metodu çalışınca Token üretsin.
        {
            return Ok(new CreateToken().TokenCreate());
        }

        [HttpGet("[action]")]
        public IActionResult AdminTokenOlustur() //Admin İçin Token üretir.
        {
            return Ok(new CreateToken().TokenCreateAdmin());
        }

        [Authorize]
        [HttpGet("[action]")]
        public IActionResult Test2() //TokenOlustur metodunda oluşan Token ile Test2 methodu Authorize edildi.
        {
            return Ok("Hoşgeldiniz");
        }

        [Authorize(Roles = "Admin,Visitor")]  //Authorize sayesinde admin ve visitor rolleri olmayan token kabul edilmiyor.Admin ve Visitor Rollerine sahip olan kişiler Test3 methoduna erişebilir.
        [HttpGet("[action]")]
        public IActionResult Test3() //AdminTokenOlustur metodunda admin için üretilen token ile Test3 metodu Authorize edildi.
        {
            return Ok("Token Başarılı Bir Şekilde Giriş Yaptı");
        }
    }
}
