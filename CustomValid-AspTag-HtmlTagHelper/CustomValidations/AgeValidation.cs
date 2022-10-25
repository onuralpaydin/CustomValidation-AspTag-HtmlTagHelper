using System.ComponentModel.DataAnnotations;

namespace CustomValid_AspTag_HtmlTagHelper.CustomValidations
{
    public class AgeValidation:ValidationAttribute
    {

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            int _age = Convert.ToInt32(value);

            if (_age < 41 && _age > 19)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Age is not valid.");
            }
        }
        public override bool IsValid(object? value)
        {
            return base.IsValid(value);
        }
    }
}
