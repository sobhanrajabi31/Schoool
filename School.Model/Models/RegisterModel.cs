using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Model.CreateModel
{
    public class RegisterModel : BaseValidation
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "وارد کردن ایدی دانش آموز اجباری است")]
        [MinLength(1, ErrorMessage = "حداقل کاراکتر مجاز رعایت نشده است")]
        [MaxLength(int.MaxValue, ErrorMessage = "حداکثر کاراکتر مجاز رعایت نشده است")]
        public int StudentId { get; set; }

        [Required(ErrorMessage = "وارد کردن ایدی درس اجباری است")]
        [MinLength(1, ErrorMessage = "حداقل کاراکتر مجاز رعایت نشده است")]
        [MaxLength(int.MaxValue, ErrorMessage = "حداکثر کاراکتر مجاز رعایت نشده است")]
        public int LessonId { get; set; }
    }
}
