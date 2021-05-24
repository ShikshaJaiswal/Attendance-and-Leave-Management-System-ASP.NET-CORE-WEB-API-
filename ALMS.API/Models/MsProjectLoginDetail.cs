using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace ALMS.API.Models
{
    public partial class MsProjectLoginDetail
    {
        [Required(ErrorMessage = "ProjectId Name Required")]
        public int? ProjectId { get; set; }
        [Required(ErrorMessage = "Employee Id Required")]
        public long? EmployeeId { get; set; }
        [Required(ErrorMessage = "Password Required")]
        [DataType(DataType.Password)]
        public string ProjectPassword { get; set; }

        //public virtual MsemployeeDetail Employee { get; set; }
        //public virtual MsprojectDetail Project { get; set; }
    }
}
