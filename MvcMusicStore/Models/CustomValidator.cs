using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcMusicStore.Models
{
    public class CustomValidator : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string _FirstName = Convert.ToString(value);
            if (_FirstName != "Mark")
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("Not a good name");
        }
    }
}