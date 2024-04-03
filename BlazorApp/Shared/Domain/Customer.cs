using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.Shared.Domain
{
    public class Customer
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Please enter Company name.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Company Name does not meet the length requirements")]
        public string CompanyName { get; set; }
        [Required(ErrorMessage = "Please enter Contact name.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Contact Name does not meet the length requirements")]
        public string ContactName { get; set; }
        [Required(ErrorMessage = "Please enter the Address.")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please enter City name.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "City does not meet the length requirements")]
        public string City { get; set; }

        public string Region { get; set; }

        public string PostalCode { get; set; }
        [Required(ErrorMessage = "Please enter Country.")]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "Country does not meet the length requirements")]
        public string Country { get; set; }
        [Required(ErrorMessage = "Please enter contact number.")]
        [DataType(DataType.PhoneNumber)]
        [Phone(ErrorMessage = "Enter a valid number")]
        public string Phone { get; set; }
    }
}
