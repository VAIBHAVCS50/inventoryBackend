using System.ComponentModel.DataAnnotations;

namespace inventBackend.Models
{
    public class Request
    {
        [Key]
        public int RequestId { get; set; }

        public int EquipmentId { get; set; }

        public string UserId { get; set; }

        public enum RequestStatus
        {
            Approved,
            Denied,
            Pending
        }
        public RequestStatus Status { get; set; }

        public DateTime RequestDate { get; set; }

        public Equipment Equipment { get; set; }
        public User User { get; set; }

    }
}
