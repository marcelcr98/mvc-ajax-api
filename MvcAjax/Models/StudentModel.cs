using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcAjax.Models
{
    public class StudentModel
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public string Address { get; set; }
        public string LastName { get; set; }
        public int Code { get; set; }
        public int Enabled { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public string NameAddress { get; set; }

        public string Title { get; set; }
    }
}