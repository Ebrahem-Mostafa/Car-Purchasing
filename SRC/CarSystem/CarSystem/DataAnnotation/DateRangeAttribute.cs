using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CarSystem.DataAnnotation
{
    public class DateRangeAttribute : ValidationAttribute, IClientValidatable
    {
        public int YearsInFuture { get; set; }

        public DateRangeAttribute(int yearsInFuture)
        {
            YearsInFuture = yearsInFuture;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is DateTime dateValue)
            {
                var minDate = DateTime.Today;
                var maxDate = DateTime.Today.AddYears(YearsInFuture);

                if (dateValue < minDate || dateValue > maxDate)
                {
                    return new ValidationResult(ErrorMessage ?? $"Invalid Input");
                }
            }

            return ValidationResult.Success;
        }

        // Implement IClientValidatable for client-side validation
        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(System.Web.Mvc.ModelMetadata metadata, System.Web.Mvc.ControllerContext context)
        {
            var rule = new ModelClientValidationRule
            {
                ErrorMessage = this.ErrorMessage,
                ValidationType = "daterange" // This matches the jQuery adapter name
            };

            rule.ValidationParameters.Add("yearsinfuture", YearsInFuture);
            yield return rule;
        }

    }
}