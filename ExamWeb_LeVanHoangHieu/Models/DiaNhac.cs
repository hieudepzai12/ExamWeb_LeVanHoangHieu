using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace ExamWeb_LeVanHoangHieu.Models
{
    public class DiaNhac
    {
        public int Id { get; set; }
        [StringLength(250)]
        [Required(ErrorMessage = "Tên đĩa nhạc không được để trống")]
        public string TuaCD { get; set; }
        [StringLength(50)]
        [Required(ErrorMessage = "Tên nghệ sĩ không được để trống")]
        public string NgheSi { get; set; }
        public bool TrongNuoc { get; set; }
        [Range(0, double.MaxValue, ErrorMessage = "Giá bán phải lớn hơn hoặc bằng 0")]
        public double GiaBan { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Số lượng phải lớn hơn hoặc bằng 0")]
        public int SoLuong { get; set; }

    }
}
