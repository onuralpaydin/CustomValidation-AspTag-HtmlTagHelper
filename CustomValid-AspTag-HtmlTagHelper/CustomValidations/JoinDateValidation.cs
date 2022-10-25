using System.ComponentModel.DataAnnotations;

namespace CustomValid_AspTag_HtmlTagHelper.CustomValidations
{
    public class JoinDateValidation:ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            DateTime _dateJoin = Convert.ToDateTime(value);
            if (_dateJoin<=DateTime.Now && _dateJoin>DateTime.Now.AddYears(-10))
            {
                return ValidationResult.Success;

            }
            else if(_dateJoin>= DateTime.Now)
            {
                return new ValidationResult("Joindate cannot be greater than current date");
            }

            else
            {
                return new ValidationResult("Joindate is invalid.");

            }
        }

    }
}
