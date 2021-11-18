using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Message
    {
        [Key]
        public int MessageID { get; set; }

        public int? SenderID { get; set; }
        public int? RecieverID { get; set; }

        public Writer Sender { get; set; }
        public Writer Reciever { get; set; }

        public string Subject { get; set; }
        public string MessageDetailes { get; set; }
        public DateTime MessageDate { get; set; }
        public bool MessageStatus { get; set; }
        public bool MessageReadStatus { get; set; }
    }
}
