using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myproject_NVIT.Models
{
    public class Parent
    {
        public int ParentID {  get; set; }
        public string Name { get; set; }
        public int NID { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Occupation { get; set; }
        public string Income { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}