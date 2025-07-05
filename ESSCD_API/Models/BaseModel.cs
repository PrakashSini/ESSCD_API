namespace ESSCD_API.Models
{
    public class BaseModel
    {
        public bool IsActive { get; set; } 
        public int CreatedBy { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDateTime { get; set; } = DateTime.Now;
    }
}
