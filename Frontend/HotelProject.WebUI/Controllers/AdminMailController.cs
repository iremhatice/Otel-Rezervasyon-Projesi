using HotelProject.WebUI.Models.Mail;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
    public class AdminMailController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(AdminMailViewModel model)
        {
            MimeMessage mimeMessage = new MimeMessage();

            //Kimden?
            MailboxAddress mailboxAdressForm = new MailboxAddress("HotelierAdmin", "iremhaticekars@gmail.com"); //Mail Kim Tarafından gönderildi?,Maili Gönderen Adres
            mimeMessage.From.Add(mailboxAdressForm); //mimemessage'ın kimden olduğu kısmına mailboxAdressForm'dan gelen değeri ekle.

            //Kime?
            MailboxAddress mailboxAddressTo = new MailboxAddress("User", model.ReceiverMail);
            mimeMessage.To.Add(mailboxAddressTo);

            //Mesajın İçeriği
            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = model.Body; //bodybuilder'ın metin kısmına modelden gelen body kısmını al.
            mimeMessage.Body = bodyBuilder.ToMessageBody();
            mimeMessage.Subject = model.Subject;

            SmtpClient client = new SmtpClient();
            client.Connect("smtp.gmail.com", 587, false); //Nereye bağlanacak?
            client.Authenticate("iremhaticekars@gmail.com", "iotz bimo ifgc ietg"); //Yetkilendir
            client.Send(mimeMessage);
            client.Disconnect(true);

            //Gönderilen Mailin Veri Tabanına Kaydedilmesi

            return View();
        }
    }
}
