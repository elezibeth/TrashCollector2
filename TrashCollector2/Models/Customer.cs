using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TrashCollector2;

namespace TrashCollector2.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public int AddressNumber { get; set; }
        [Required]
        public string StreetName { get; set; }
        [Required]
        public string StreetType { get; set; }
        [Required]
        public string UnitNumber { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public int ZipCode { get; set; }
      
        [Display(Name = "When would you like to suspend your service?")]
        public DateTime SuspendServiceStartDate { get; set; }// optional - start and end date must both be entered if one is

        [Display(Name = "When would you like your suspended service to end?")]
        public DateTime SuspendServiceEndDate { get; set; }// optional
        
        public double AmountOwed { get; set; }
        public double PaymentAmountDisplay { get; set; }
        public DayOfWeek DayOfWeekForTrashPickup { get; set; }
        public DateTime OneTimePickupRequest { get; set; }
        public DateTime LastPickupDate { get; set; }
        private Employee LastPickupEmployee { get; set; }
        public double LastPickupCharge { get; set; }

        [Required]
        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser{ get; set; }
    }
}
