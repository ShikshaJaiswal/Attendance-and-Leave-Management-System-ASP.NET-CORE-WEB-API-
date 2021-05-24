using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ALMS.UI.Models
{
    public class TrprojectAllocation
    {
        public int AllocationId { get; set; }
        public int? ProjectId { get; set; }
        public long? EmployeeId { get; set; }
        public string Status { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
