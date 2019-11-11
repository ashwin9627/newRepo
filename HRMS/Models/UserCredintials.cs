using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HRMS_Web_Project.Models
{
    public class UserCredintials
    {
        
            [Key] public int UserCredintialId { get; set; }
            public virtual int EmpId { get; set; }
            public virtual string EmpName { get; set; }
            public virtual string Password { get; set; }
        }
    }