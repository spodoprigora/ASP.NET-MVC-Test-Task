﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using test.DbEntites.Entities.Abstract;

namespace test.DbEntites.Entities
{
    public class Message : EntityBase
    {
        public int IdUser { get; set; }
        public string Text { get; set; }
        public string MessageDate { get; set; }
        public int LikeCount { get; set; }
    }
}