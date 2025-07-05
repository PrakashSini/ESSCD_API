using System.ComponentModel.DataAnnotations;

namespace ESSCD_API.Models
{
    public class EmployeeMaster : BaseModel
    {
        [Key]
        public int Id { get; set; }
        public string EmployeeName { get; set; } = string.Empty;
        public string EmployeeEmailId { get; set; } = string.Empty;
        public string EmployeeDepartment { get; set; } = string.Empty;
        //public ICollection<Shifts> Shifts { get; set; }

    }
    public class Shifts : BaseModel
    {
        [Key]
        public int Id { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime? StartDateTime { get; set; } 
        public DateTime? EndDateTime { get; set; }
        public EmployeeMaster Employee { get; set; }
    }

    public class EmployeeShiftDTO : BaseModel
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; } = string.Empty;
        public string EmployeeEmailId { get; set; } = string.Empty;
        public string EmployeeDepartment { get; set; } = string.Empty;
        public DateTime? ShiftStartTime { get; set; }    
        public DateTime? ShiftEndTime { get; set; }
    }

}
