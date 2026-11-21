using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PhamThiNguyetAnh_QLTS1_241230658.Models;

public partial class TaiSan
{
    public int MaTs { get; set; }

    public int MaLoai { get; set; }

    [Required(ErrorMessage = "Tên tài sản không được để trống.")]
    public string TenTs { get; set; } = null!;

    [Range(1,2000,ErrorMessage ="Nguyên giá phải là số từ 1 đến 2000.")]
    public decimal? NguyenGia { get; set; }

    [RegularExpression(@".*\.(jpg|jpeg|png|webp)$", ErrorMessage ="Ảnh phải có đuôi .jpg, .jpeg, .png hoặc .webp")]
    public string? Anh { get; set; }

    public virtual LoaiTaiSan MaLoaiNavigation { get; set; } = null!;
}
