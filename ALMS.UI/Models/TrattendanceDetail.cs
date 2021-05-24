using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ALMS.UI.Models
{
    public class TrattendanceDetail
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

    }
}
