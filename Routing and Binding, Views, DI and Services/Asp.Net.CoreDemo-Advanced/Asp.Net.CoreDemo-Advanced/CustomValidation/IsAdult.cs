using System.ComponentModel.DataAnnotations;

namespace Asp.Net.CoreDemo_Advanced.CustomValidation
{
    public class IsAdult : ValidationAttribute
    {
        private readonly DateTime minumumYears = DateTime.Today.AddYears(-18);
        protected override ValidationResult? IsValid(object? value
            , ValidationContext validationContext)
        {
           
            if(value!=null && (DateTime)value <= minumumYears)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult(ErrorMessage);
        }
    }
}
