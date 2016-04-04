using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using test.DbEntites.Models;


namespace test.ViewModel
{
    public class MessagesViewModel
    {
        public List<MessageWithAttachemtns> Messages { get; set; }
        public PagingModel Paging { get; set; }
    }
}