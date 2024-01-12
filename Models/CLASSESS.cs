using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace myproject_NVIT.Models
{
    public class CLASSESS
    {
        [Key]
        public int ClassID { get; set; }
        public string Name { get; set; }
        public int SeatCapacity { get; set; }
        public string Section { get; set; }
        public int RoomNo { get; set; }
        public int teacherID { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}