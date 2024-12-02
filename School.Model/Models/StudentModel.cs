using System.ComponentModel.DataAnnotations;

namespace School.Model.CreateModel
{
    public class StudentModel : BaseValidation
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "وارد کردن نام اجباری است")]
        [MinLength(1, ErrorMessage = "حداقل کاراکتر مجاز رعایت نشده است")]
        [MaxLength(32, ErrorMessage = "حداکثر کاراکتر مجاز رعایت نشده است")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "وارد کردن فامیلی اجباری است")]
        [MinLength(1, ErrorMessage = "حداقل کاراکتر مجاز رعایت نشده است")]
        [MaxLength(50, ErrorMessage = "حداکثر کاراکتر مجاز رعایت نشده است")]
        public string LastName { get; set; }

        [MobileValidation]
        public string Mobile { get; set; }
    }
}
