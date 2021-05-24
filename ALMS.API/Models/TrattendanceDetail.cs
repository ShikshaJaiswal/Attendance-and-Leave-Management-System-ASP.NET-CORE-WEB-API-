using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace ALMS.API.Models
{
    public partial class TrattendanceDetail
    {
        [Key]
        public int AttendanceId { get; set; }
        [Required(ErrorMessage = "Project Id Required")]
        public int? ProjectId { get; set; }
        [Required(ErrorMessage = "Employee Id Required")]
        public long? EmployeeId { get; set; }
        public DateTime AttedanceDate { get; set; }
        public string AttendanceStatus { get; set; }
        public DateTime? StatusUpdateDate { get; set; }
        public long? StatusUpdatedBy { get; set; }

        //public virtual MsemployeeDetail Employee { get; set; }
        //public virtual MsprojectDetail Project { get; set; }
    }
}
