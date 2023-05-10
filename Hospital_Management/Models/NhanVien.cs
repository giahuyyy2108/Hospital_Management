using System.ComponentModel.DataAnnotations;

namespace Hospital_Management.Models
{
    public class NhanVien
    {

        [Required(ErrorMessage="Vui lòng nhập Email")]
        [EmailAddress] public string Email { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập mật khẩu")]
        [DataType(DataType.Password)]
        public string MatKhau { get; set; }
        [Compare("MatKhau", ErrorMessage ="Mật khẩu không khớp")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập họ tên")]
        public string HoTen { get; set; }

        [RegularExpression(@"^\(?([0-9]{3})[-. ]?([0-9]{4})[-. ]?([0-9]{3})$", ErrorMessage = "Số điện thoại không đúng")]
        [Required(ErrorMessage = "Bạn cần nhập số điện thoại")]
        public string SDTNV { get; set; }

        [Required(ErrorMessage = "Bạn cần chọn chức vụ")]
        public byte ChucVu { get; set; }
        public bool TrangThai { get; set; }
        public string img { get; set; }

    }
}
