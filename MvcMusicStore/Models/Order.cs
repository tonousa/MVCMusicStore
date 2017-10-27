using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using MvcMusicStore.Infrastructure;
using System.ComponentModel;

namespace MvcMusicStore.Models
{
    public class Order : IValidatableObject
    {
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (LastName != null && 
                LastName.Split(' ').Length > 10)
            {
                yield return new ValidationResult("Last name has too many words!",
                    new[] { "LastName" });
            }
        }

        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        [ScaffoldColumn(false)]
        public string Username { get; set; }
        //[CustomValidator(ErrorMessage ="crappy name")]
        [Display(Name ="First Name", Order=15001)]
        public string FirstName { get; set; }
        //[MaxWords]
        [Required(ErrorMessage ="Last Name required")]
        [Display(Name ="Last Name", Order=15000)]
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage ="Email not valid")]
        public string Email { get; set; }
        [ReadOnly(true)]
        [DisplayFormat(ApplyFormatInEditMode =false, DataFormatString ="{0:c}")]
        public decimal Total { get; set; }
    }
}