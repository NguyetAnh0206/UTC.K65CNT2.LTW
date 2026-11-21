using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PhamThiNguyetAnh_QLHH_241230658.Models;

public partial class HangHoa
{
    public int MaHang { get; set; }

    [Required(ErrorMessage ="Vui lòng chọn loại hàng.")]
    public int MaLoai { get; set; }


    [Required(ErrorMessage = "Tên hàng không được để trống.")]
    public string TenHang { get; set; } = null!;

    [Required(ErrorMessage = "Giá không được để trống.")]
    [Range(100,5000, ErrorMessage ="Giá phải là số từ 100 đến 5000.")]
    public decimal? Gia { get; set; }

    [Required(ErrorMessage = "File ảnh không được để trống.")]
    [RegularExpression(@".*\.(jpg|png|gif|tiff)$", ErrorMessage ="Tên file ảnh phải có đuôi .jpg, .png, .gif hoặc .tiff")]
    public string? Anh { get; set; }

    public virtual LoaiHang MaLoaiNavigation { get; set; } = null!;
}
