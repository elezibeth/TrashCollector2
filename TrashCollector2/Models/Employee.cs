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
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public int ZipCode { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmployeeIdentifierName { get; set; }

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }

    }
}
