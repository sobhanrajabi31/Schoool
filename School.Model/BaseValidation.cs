using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace School.Model
{
    public class BaseValidation
    {
        List<ValidationResult> results;
        public bool IsValid
        {
            get
            {
                results = new List<ValidationResult>();
                return Validator.TryValidateObject(this, new ValidationContext(this), results, true);
            }
        }
        public string ErrorMessage
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                
                foreach (var item in results)
                    sb.AppendLine(item.ErrorMessage);

                return sb.ToString();
            }
        }
    }
}
