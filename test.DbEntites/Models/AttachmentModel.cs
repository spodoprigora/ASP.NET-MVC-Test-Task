using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test.DbEntites.Models
{
    public class AttachmentModel
    {
        public string Attachment { get; set; }

        public AttachmentModel(string link)
        {
            Attachment = link;
        }
      
    }
}