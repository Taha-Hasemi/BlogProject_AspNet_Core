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

        public virtual List<MessageSender> MessageSenders { get; set; }
        public virtual List<MessageReceiver> MessageReceivers { get; set; }

        public string Subject { get; set; }
        public string MessageDetailes { get; set; }
        public DateTime MessageDate { get; set; }
        public bool MessageStatus { get; set; }
        public bool MessageReadStatus { get; set; }
    }
}
