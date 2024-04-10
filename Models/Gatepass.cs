using System.ComponentModel.DataAnnotations;

namespace inventBackend.Models
{
    public class Gatepass
    {
        [Key]
        public int GatepassId { get; set; }

        public string UserId { get; set; }

        public int RequestId { get; set; }

        public DateTime IssueDate { get; set; }

        public DateTime ApprovalDate { get; set; }

        public DateTime ExpiryDate { get; set; }

        public string ApproverId { get; set; }

        public Request Request { get; set; }
        public User User { get; set; }
    }

}
