using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using test.DbEntites.Entities.Abstract;


namespace test.DbEntites.Entities
{
    public class User : EntityBase
    {
        public string Name { get; set; }
    }
}