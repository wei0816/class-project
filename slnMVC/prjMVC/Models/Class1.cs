using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prjMVC.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Chinese { get; set; }
        public int English { get; set; }
        public int Math { get; set; }

    }
}