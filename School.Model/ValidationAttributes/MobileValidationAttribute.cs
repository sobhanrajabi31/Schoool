using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Model
{
    public class MobileValidationAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            string mobile = value.ToString();

            if (string.IsNullOrEmpty(mobile) || mobile.Length != 11 || !mobile.StartsWith("09"))
            {
                ErrorMessage = "شماره موبایل وارد شده نامعتبر است";
                return false;
            }

            return true;
        }
    }
}
