using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace test.DbEntites.Models
{
    public class MessageWithAttachemtns
    {
        public MessageModel Message { get; set; }
        public IEnumerable<AttachmentModel> Attachment { get; set; }
    }
}