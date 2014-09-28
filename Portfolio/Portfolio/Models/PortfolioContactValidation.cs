using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Portfolio.Models
{
    [MetadataType(typeof(PortfolioContactValidation))]
    public partial class PortfolioContact
    {
    }
    public class PortfolioContactValidation
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required,EmailAddress]
        public string Email { get; set; }
        [Required,Phone]
        public string PhoneNumber { get; set; }
        [Required]
        public string Comment { get; set; }
    }
}