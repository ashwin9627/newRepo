using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HRMS_Web_Project.Models
{
    public class DesignationTable
    {
        [Key]
        public virtual int ID { get; set; }
        public virtual int DesignationId { get; set; }
        public virtual int EmpID { get; set; }
        public virtual int Designation { get; set; }
    }
}