using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class MessageReceiver
    {
        [Key]
        public int MessageReceiverID { get; set; }

        [ForeignKey("Writer")]
        public int WriterID { get; set; }
        public virtual Writer Writer { get; set; }


        public List<Message> Messages { get; set; }
    }
}
