using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PhamThiNguyetAnhDM_241230658.Models;

public partial class Sach
{
    public int MaSach { get; set; }

    public int MaTl { get; set; }

    [Required(ErrorMessage ="Tên sách không được để trống.")]
    public string TenSach { get; set; } = null!;

    [Required(ErrorMessage = "Giá không được để trống.")]
    [Range(50,1000, ErrorMessage ="Giá phải là số và nằm trong khoảng từ 50 đến 1000.")]
    public decimal? Gia { get; set; }

    [RegularExpression(@".*\.(jpg|jpeg|png|webp)$", ErrorMessage ="Tên file phải có đuôi .jpg, .jpeg, .png hoặc .webp")]
    public string? Anh { get; set; }

    public virtual TheLoai MaTlNavigation { get; set; } = null!;
}
