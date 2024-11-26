using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Model.CreateModel
{
    public class ClassModel : BaseValidation
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "وارد کردن نام کلاس اجباری است")]
        [MinLength(1, ErrorMessage = "حداقل کاراکتر مجاز رعایت نشده است")]
        [MaxLength(32, ErrorMessage = "حداکثر کاراکتر مجاز رعایت نشده است")]
        public string Title { get; set; }

        [Required(ErrorMessage = "وارد کردن تعداد عضو اجباری است")]
        [MinLength(1, ErrorMessage = "حداقل کاراکتر مجاز رعایت نشده است")]
        [MaxLength(32, ErrorMessage = "حداکثر کاراکتر مجاز رعایت نشده است")]
        public int Capacity { get; set; }
    }
}
