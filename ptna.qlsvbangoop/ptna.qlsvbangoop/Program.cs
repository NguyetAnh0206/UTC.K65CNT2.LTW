using System;
using System.Collections.Generic;

namespace ptna.qlsvbangoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice;
            // Danh sách sinh viên
            List<Student> students = new List<Student>()
            {
                new Student{masv = "SV001",hoTen = "Nguyen Van A",ngaySinh = new DateTime(2004, 5, 10),gioiTinh = true,email = "nguyenvana@gmail.com",soDienThoai = "0978611889",nganhHoc = "Cong nghe thong tin",dtb = 8.5f,trangThai = true},
                new Student{masv = "SV002",hoTen = "Tran Van B",ngaySinh = new DateTime(2004, 8, 20),gioiTinh = true,email = "tranvanb@gmail.com",soDienThoai = "0978611889",nganhHoc = "Thuong mai dien tu",dtb = 7.5f,trangThai = true},
                new Student{masv = "SV003",hoTen = "Trinh Van C",ngaySinh = new DateTime(2004, 2, 15),gioiTinh = false,email = "trinhvanc@gmail.com",soDienThoai = "0912345678",nganhHoc = "Cong nghe thong tin",dtb = 9.2f,trangThai = true}
            };
            // MENU
            do
            {
                menu();
                Console.Write("Chon chuc nang: ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        // Thêm sinh viên
                        ThemSinhVien(students);
                        break;
                    case "2":
                        // Hiển thị danh sách
                        HienThiThongTin(students);
                        break;
                    case "3":
                        // Tìm sinh viên theo mã
                        TimSinhVienTheoMa(students);
                        break;
                    case "4":
                        // Tìm gần đúng theo họ tên
                        TimGanDungTheoHoTen(students);
                        break;
                    case "5":
                        // Cập nhật sinh viên
                        CapNhatSinhVien(students);
                        break;
                    case "6":
                        // Xóa sinh viên
                        XoaSinhVien(students);
                        break;
                    case "7":
                        // Sắp xếp theo họ tên
                        SapXepTheoHoTen(students);
                        break;
                    case "8":
                        // Sắp xếp theo điểm trung bình
                        SapXepTheoDiem(students);
                        break;
                    case "9":
                        // Hiển thị sinh viên có điểm từ 8 trở lên
                        HienThiSinhVienTu8Diem(students);
                        break;
                    case "10":
                        // Hiển thị sinh viên có điểm cao nhất
                        HienThiSinhVienDiemCaoNhat(students);
                        break;
                    case "11":
                        // Tính điểm trung bình toàn bộ sinh viên
                        TinhDiemTrungBinhToanBo(students);
                        break;
                    case "12":
                        // Thống kê sinh viên theo ngành
                        ThongKeTheoNganh(students);
                        break;
                    case "13":
                        // Thống kê sinh viên theo trạng thái
                        ThongKeTheoTrangThai(students);
                        break;
                    case "14":
                        Console.WriteLine("Ket thuc chuong trinh");
                        break;
                    default:
                        Console.WriteLine("chon sai chuc nang");
                        break;
                }
            } while (choice != "14");
        }
        // MENU
        static void menu()
        {
            Console.WriteLine("============== Chuc nang ==============");
            Console.WriteLine(
                "\n1. Them Sinh vien" +
                "\n2. Hien thi danh sach" +
                "\n3. Tim sinh vien theo ma" +
                "\n4. Tim gan dung theo ho ten" +
                "\n5. Cap nhat sinh vien" +
                "\n6. Xoa sinh vien" +
                "\n7. Sap xep theo ho ten" +
                "\n8. Sap xep theo diem tb" +
                "\n9. Hien thi sinh vien co diem tu 8 tro len" +
                "\n10. Hien thi sv co diem cao nhat" +
                "\n11. Tinh diem tb toan bo sinh vien" +
                "\n12. Thong ke sinh vien theo nganh" +
                "\n13. Thong ke sinh vien theo trang thai" +
                "\n14. Thoat"
            );
            Console.WriteLine("========================================");
        }
        // 1.Thêm sv
        static void ThemSinhVien(List<Student> students)
        {
            Console.WriteLine("\n========== Them sinh vien ==========");
            Student student = new Student();
            Console.Write("Ma sinh vien: ");
            student.masv = Console.ReadLine();
            Console.Write("Ho ten: ");
            student.hoTen = Console.ReadLine();
            Console.Write("Ngay sinh (dd/MM/yyyy): ");
            DateTime ngaySinh;
            if (DateTime.TryParse(Console.ReadLine(), out ngaySinh))
            {
                student.ngaySinh = ngaySinh;
            }
            Console.Write("Gioi tinh (Nam = 1, Nu = 0): ");
            string gt = Console.ReadLine();
            if (gt == "1")
            {
                student.gioiTinh = true;
            }
            else
            {
                student.gioiTinh = false;
            }
            Console.Write("Email: ");
            student.email = Console.ReadLine();
            Console.Write("SDT: ");
            student.soDienThoai = Console.ReadLine();
            Console.Write("Nganh hoc: ");
            student.nganhHoc = Console.ReadLine();
            Console.Write("Diem tb: ");

            float dtb;
            if (float.TryParse(Console.ReadLine(), out dtb))
            {
                student.dtb = dtb;
            }
            Console.Write("Trang thai (Dang hoc = 1, Bao luu = 0): ");
            string tt = Console.ReadLine();
            if (tt == "1")
            {
                student.trangThai = true;
            }
            else
            {
                student.trangThai = false;
            }
            students.Add(student);
        }
        // 2.Hiển thị ds
        static void HienThiThongTin(List<Student> students)
        {
            Console.WriteLine("\n========== Danh sach sinh vien ==========");
            foreach (Student item in students)
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Ma sinh vien: " + item.masv);
                Console.WriteLine("Ho va ten: " + item.hoTen);
                if (item.ngaySinh.HasValue)
                {
                    Console.WriteLine("Ngay sinh: " + item.ngaySinh.Value.ToString("dd/MM/yyyy"));
                }
                if (item.gioiTinh == true)
                {
                    Console.WriteLine("Gioi tinh: Nam");
                }
                else
                {
                    Console.WriteLine("Gioi tinh: Nu");
                }
                Console.WriteLine("Email: " + item.email);
                Console.WriteLine("SDT: " + item.soDienThoai);
                Console.WriteLine("Nganh hoc: " + item.nganhHoc);
                Console.WriteLine("Diem tb: " + item.dtb);
                if (item.trangThai == true)
                {
                    Console.WriteLine("Trang thai: Dang hoc");
                }
                else
                {
                    Console.WriteLine("Trang thai: Bao luu");
                }
            }
            Console.WriteLine("------------------------------------------");
        }
        // 3.Tìm sv theo mã
        static void TimSinhVienTheoMa(List<Student> students)
        {
            Console.WriteLine("\n========== Tim sinh vien theo ma ==========");
            Console.Write("Nhap ma sv ");
            string ma = Console.ReadLine();
            bool timThay = false;
            foreach (Student item in students)
            {
                if (item.masv == ma)
                {
                    Console.WriteLine("\nThong tin sinh vien: ");
                    Console.WriteLine("Ma sinh vien: " + item.masv);
                    Console.WriteLine("ho ten: " + item.hoTen);
                    if (item.ngaySinh.HasValue)
                    {
                        Console.WriteLine("Ngay sinh: " + item.ngaySinh.Value.ToString("dd/MM/yyyy"));
                    }
                    if (item.gioiTinh == true)
                    {
                        Console.WriteLine("Gioi tinh: Nam");
                    }
                    else
                    {
                        Console.WriteLine("Gioi tinh: Nu");
                    }
                    Console.WriteLine("Email: " + item.email);
                    Console.WriteLine("SDT: " + item.soDienThoai);
                    Console.WriteLine("Nganh hoc: " + item.nganhHoc);
                    Console.WriteLine("Diem TB: " + item.dtb);
                    if (item.trangThai == true)
                    {
                        Console.WriteLine("Trang thai: Dang hoc");
                    }
                    else
                    {
                        Console.WriteLine("Trang thai: Bao luu");
                    }
                    timThay = true;
                    break;
                }
            }
            if (timThay == false)
            {
                Console.WriteLine("Khong tim thay sinh vien");
            }
        }
        // 4.Tìm gần đúng theo họ tên
        static void TimGanDungTheoHoTen(List<Student> students)
        {
            Console.WriteLine("\n========== tim gan dung ==========");
            Console.Write("Nhap ho ten can tim: ");
            string hoTen = Console.ReadLine();
            bool timThay = false;
            foreach (Student item in students)
            {
                if (item.hoTen.Contains(hoTen))
                {
                    Console.WriteLine(item.masv + " - " + item.hoTen + " - " + item.nganhHoc + " - " + item.dtb);
                    timThay = true;
                }
            }
            if (timThay == false)
            {
                Console.WriteLine("Khong tim thay sinh vien");
            }
        }
        // 5.Cập nhật sv
        static void CapNhatSinhVien(List<Student> students)
        {
            Console.WriteLine("\n========== Cap nhat sv ==========");
            Console.Write("Nhap ma sinh vien: ");
            string ma = Console.ReadLine();
            Student student = null;
            foreach (Student item in students)
            {
                if (item.masv == ma)
                {
                    student = item;
                    break;
                }
            }
            if (student == null)
            {
                Console.WriteLine("Khong tim thay sinh vien");
                return;
            }
            Console.Write("Ho ten moi: ");
            student.hoTen = Console.ReadLine();
            Console.Write("Ngay sinh moi (dd/MM/yyyy): ");
            DateTime ngaySinh;
            if (DateTime.TryParse(Console.ReadLine(), out ngaySinh))
            {
                student.ngaySinh = ngaySinh;
            }

            Console.Write("Gioi tinh (Nam = 1, Nu = 0): ");
            string gt = Console.ReadLine();
            if (gt == "1")
            {
                student.gioiTinh = true;
            }
            else
            {
                student.gioiTinh = false;
            }
            Console.Write("Email moi: ");
            student.email = Console.ReadLine();
            Console.Write("SDT moi: ");
            student.soDienThoai = Console.ReadLine();
            Console.Write("Nganh hoc moi: ");
            student.nganhHoc = Console.ReadLine();
            Console.Write("Diem tb moi: ");
            float dtb;
            if (float.TryParse(Console.ReadLine(), out dtb))
            {
                student.dtb = dtb;
            }
            Console.Write("Trang thai (Dang hoc = 1, Bao luu = 0): ");
            string tt = Console.ReadLine();
            if (tt == "1")
            {
                student.trangThai = true;
            }
            else
            {
                student.trangThai = false;
            }
        }
        // 6.Xoá sv
        static void XoaSinhVien(List<Student> students)
        {
            Console.WriteLine("\n========== xoa sinh vien ==========");
            Console.Write("Nhap ma sv can xoa: ");
            string ma = Console.ReadLine();
            int viTri = -1;
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].masv == ma)
                {
                    viTri = i;
                    break;
                }
            }
            if (viTri == -1)
            {
                Console.WriteLine("Khong tim thay sinh vien");
            }
            else
            {
                students.RemoveAt(viTri);
                Console.WriteLine("Da xoa sinh vien");
            }
        }
        // 7.Sắp xếp theo họ tên
        static void SapXepTheoHoTen(List<Student> students)
        {
            Console.WriteLine("\n========== Sap xep theo hoten ==========");
            for (int i = 0; i < students.Count - 1; i++)
            {
                for (int j = i + 1; j < students.Count; j++)
                {
                    if (students[i].hoTen.CompareTo(students[j].hoTen) > 0)
                    {
                        Student temp = students[i];
                        students[i] = students[j];
                        students[j] = temp;
                    }
                }
            }
            HienThiThongTin(students);
        }
        // 8.Sắp xếp theo điểm tb
        static void SapXepTheoDiem(List<Student> students)
        {
            Console.WriteLine("\n========== sap xep theo diem ==========");
            for (int i = 0; i < students.Count - 1; i++)
            {
                for (int j = i + 1; j < students.Count; j++)
                {
                    if (students[i].dtb < students[j].dtb)
                    {
                        Student temp = students[i];
                        students[i] = students[j];
                        students[j] = temp;
                    }
                }
            }
            HienThiThongTin(students);
        }
        // 9.Điểm từ 8 trở lên
        static void HienThiSinhVienTu8Diem(List<Student> students)
        {
            Console.WriteLine("\n========== sinh vien co diem tu 8 tro len ==========");
            bool coSinhVien = false;
            foreach (Student item in students)
            {
                if (item.dtb >= 8)
                {
                    Console.WriteLine(item.masv + " - " + item.hoTen + " - " + item.dtb);
                    coSinhVien = true;
                }
            }
            if (coSinhVien == false)
            {
                Console.WriteLine("Khong co sinh vien nao");
            }
        }
        // 10.SV có điẻm cao nhất
        static void HienThiSinhVienDiemCaoNhat(List<Student> students)
        {
            Console.WriteLine("\n========== Sinh vien co diem cao nhat ==========");
            if (students.Count == 0)
            {
                Console.WriteLine("Khong co sinh vien nao");
                return;
            }
            float max = students[0].dtb;
            foreach (Student item in students)
            {
                if (item.dtb > max)
                {
                    max = item.dtb;
                }
            }
            foreach (Student item in students)
            {
                if (item.dtb == max)
                {
                    Console.WriteLine(item.masv + " - " + item.hoTen + " - Diem: " + item.dtb);
                }
            }
        }
        // 11.Tính điểm tb toàn bộ
        static void TinhDiemTrungBinhToanBo(List<Student> students)
        {
            Console.WriteLine("\n========== Diem tb toan bo ==========");
            if (students.Count == 0)
            {
                Console.WriteLine("Danh sach trong");
                return;
            }
            float tong = 0;
            foreach (Student item in students)
            {
                tong = tong + item.dtb;
            }
            float dtb = tong / students.Count;
            Console.WriteLine("Diem tb toan bo sinh vien: " + dtb);
        }
        // 12.Thống kê theo ngành
        static void ThongKeTheoNganh(List<Student> students)
        {
            Console.WriteLine("\n========== Thong ke theo nganh ==========");
            List<string> dsNganh = new List<string>();
            foreach (Student item in students)
            {
                bool daCo = false;
                foreach (string nganh in dsNganh)
                {
                    if (nganh == item.nganhHoc)
                    {
                        daCo = true;
                        break;
                    }
                }
                if (daCo == false)
                {
                    dsNganh.Add(item.nganhHoc);
                }
            }
            // Đếm số sinh viên của từng ngành
            foreach (string nganh in dsNganh)
            {
                int soLuong = 0;
                foreach (Student item in students)
                {
                    if (item.nganhHoc == nganh)
                    {
                        soLuong++;
                    }
                }
                Console.WriteLine("Nganh: " +nganh +" - So luong: " +soLuong);
            }
        }
        // 13.Thống kê theo trạng thái
        static void ThongKeTheoTrangThai(List<Student> students)
        {
            Console.WriteLine("\n========== Thong ke theo trang thai ==========");
            int dangHoc = 0;
            int baoLuu = 0;
            foreach (Student item in students)
            {
                if (item.trangThai == true)
                {
                    dangHoc++;
                }
                else
                {
                    baoLuu++;
                }
            }
            Console.WriteLine("Dang hoc: " + dangHoc);
            Console.WriteLine("Bao luu: " + baoLuu);
        }
    }
}
