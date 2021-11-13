using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Message
    {
        [Key]
        public int MessageID { get; set; }

        public int MessageSenderID { get; set; }

        public int MessageReceiverID { get; set; }
        public virtual MessageReceiver MessageReceiver { get; set; }

    }
}
