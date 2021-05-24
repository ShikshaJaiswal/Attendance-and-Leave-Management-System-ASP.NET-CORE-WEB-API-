using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace ALMS.API.Models
{
    public partial class TrleaveRequestDetail
    {
        [Key]
        public int LeaveRequestId { get; set; }
        [Required(ErrorMessage = "Employee Id Required")]
        public long? EmployeeId { get; set; }
        public int LeavesRemaining { get; set; }
        [Required(ErrorMessage = "Enter a start date")]
        public DateTime LeaveRequestFrom { get; set; }
        [Required(ErrorMessage = "Enter an end date")]
        public DateTime LeaveRequestTo { get; set; }
        public string LeaveDescription { get; set; }
        public string LeaveStatus { get; set; }
        public DateTime? LeaveRequestCreatedDate { get; set; }
        public DateTime? LeaveStatusUpdateDate { get; set; }
        public long? LeaveStatusUpdatedBy { get; set; }

        //public virtual MsemployeeDetail Employee { get; set; }
    }
}
