using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HRMS_Web_Project.Models
{
    public class Blog
    {
        [Key]
        public virtual int ID { get; set; }
        public virtual string Comment { get; set; }
        public virtual string Font_Color { get; set; }
        public virtual string Bg_Color { get; set; }
        public virtual string Font_Size { get; set; }
        public virtual string Font_Style { get; set; }

    }
}