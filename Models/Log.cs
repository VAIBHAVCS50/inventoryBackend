using System.ComponentModel.DataAnnotations;

namespace inventBackend.Models
{
    public class Log
    {
        [Key]
        public int LogId { get; set; }

        public int RequestId { get; set; }

        public DateTime IssueDate { get; set; }

        public DateTime ExpiryDate { get; set; }

        public int CategoryId { get; set; }

        public string ApproverId { get; set; }

        public string EquipmentId { get; set; }

        public string UserId { get; set; }

        public Request Request { get; set; }
        public Equipment Equipment { get; set; }
        public User Approver { get; set; }
        public User User { get; set; }
    }

}
