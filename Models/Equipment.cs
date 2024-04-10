using Azure.Core;
using System.ComponentModel.DataAnnotations;

namespace inventBackend.Models
{
    public class Equipment
    {
        [Key]
        public int EquipmentId { get; set; }

        public int CategoryId { get; set; }

        [Required]
        public string CategoryName { get; set; }

        [Required]
        public string Brand { get; set; }

        [Required]
        public string Description { get; set; }

        public string Pdf { get; set; }

        public enum EquipmentStatus
        {
            Working,
            NonWorking
        }
        public EquipmentStatus Status { get; set; }

        public bool IsDeleted { get; set; } = false;

        public enum RequestStatus
        {
            Approved,
            Pending
        }
        public RequestStatus Rstatus { get; set; }

        public ICollection<Request> Requests { get; set; } = new List<Request>();

    }
}
