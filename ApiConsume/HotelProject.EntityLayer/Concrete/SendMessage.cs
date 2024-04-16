using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.EntityLayer.Concrete
{
    public class SendMessage //Gönderilen Mesaj
    {
        public int SendMessageID { get; set; }
        public string ReceiverName { get; set; } //Alıcının Adı
        public string ReceiverMail { get; set; }
        public string SenderName { get; set; } //Göndericinin Adı
        public string SenderMail { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
    }
}
