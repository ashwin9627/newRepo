using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HRMS_Web_Project.Models
{
   
    public class EmployeeDetails
    {
        [Key]
      //  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public virtual int EmpId { get; set; }
            public virtual string EmpName { get; set; }
            public virtual string Email { get; set; }
            public virtual string PhoneNumber { get; set; }
            public virtual string Location { get; set; }
            public virtual DateTime? DOB { get; set; }
            public virtual string Division { get; set; }
            public virtual string Designation { get; set; }
            public virtual string DesignationId { get; set; }

            public virtual DateTime? DOJ { get; set; }
            public virtual string Status { get; set; }
            public virtual string Password { get; set; }
            public virtual string EmployeeImage { get; set; }
        }
    }