using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using test.DbEntites.Entities.Abstract;

namespace test.DbEntites.Entities
{
    public class Attachment : EntityBase
    {
        public string Link { get; set; }
        public int IdMessage { get; set; }
    }
}