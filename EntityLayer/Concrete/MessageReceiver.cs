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
        [ForeignKey("Message")]
        public int MessageID { get; set; }
        public virtual Message Message { get; set; }


        [ForeignKey("Writer")]
        public int WriterID { get; set; }
        public virtual Writer Writer { get; set; }


    }
}
