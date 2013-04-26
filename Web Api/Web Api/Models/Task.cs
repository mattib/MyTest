using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_Api.Models
{
    public class Task
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CompanyId { get; set; }
        public string PickupName { get; set; }
        public string DeliverypName { get; set; }
        public string PickupAddress { get; set; }
        public string DeliveryAddress { get; set; }
        public DateTime? PickUpTime { get; set; }
        public DateTime? DeliveryTime { get; set; }
        public string PickupContactPerson { get; set; }
        public string DelieryContactPerson { get; set; }
        public string PickupContactPhoneNumber { get; set; }
        public string DelieryContactPhoneNumber { get; set; }
        public bool Delivered { get; set; }
        public bool? Rejected { get; set; }
        public string RejectionReason{ get; set; }
        public int Status { get; set; }
    }
}