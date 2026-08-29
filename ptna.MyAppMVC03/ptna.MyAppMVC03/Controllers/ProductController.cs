using Microsoft.AspNetCore.Mvc;
using ptna.MyAppMVC03.Models;

namespace ptna.MyAppMVC03.Controllers
{
    public class ProductController : Controller
    {
        private List<Category> categories = new List<Category>
        {
            new Category { Id = 1, Name = "Quần Áo" },
            new Category { Id = 2, Name = "Túi xách" },
            new Category { Id = 3, Name = "Đồng hồ" },
            new Category { Id = 4, Name = "Tivi" },
            new Category { Id = 5, Name = "Tủ lạnh" },
            new Category { Id = 6, Name = "Máy bơm" },
            new Category { Id = 7, Name = "Quạt điện" },
            new Category { Id = 8, Name = "Lò sưởi" }
        };

        private List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Bộ đồ bơi cho trẻ em nam", Image = "/Avatar/02.jfif", Price = 50000, SalePrice = 35000, CategoryId = 1, Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit.", Status = 1, CreatedAt = new DateTime(2021, 7, 15, 12, 0, 0) },
            new Product { Id = 2, Name = "Bộ đồ bơi cho trẻ em nữ", Image = "/Avatar/03.jfif", Price = 50000, SalePrice = 35000, CategoryId = 1, Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit.", Status = 1, CreatedAt = new DateTime(2021, 7, 15, 12, 0, 0) },
            new Product { Id = 3, Name = "Bộ đồ bơi cho trẻ em từ 3-5 tuổi", Image = "/Avatar/04.jfif", Price = 50000, SalePrice = 35000, CategoryId = 1, Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit.", Status = 1, CreatedAt = new DateTime(2021, 7, 15, 12, 0, 0) },
            new Product { Id = 4, Name = "Bộ đồ bơi cho trẻ em thời trang", Image = "/Avatar/02.jfif", Price = 50000, SalePrice = 35000, CategoryId = 1, Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit.", Status = 1, CreatedAt = new DateTime(2021, 7, 15, 12, 0, 0) },
            new Product { Id = 5, Name = "Túi thời trang mẫu mới 2021", Image = "/Avatar/03.jfif", Price = 50000, SalePrice = 35000, CategoryId = 2, Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit.", Status = 1, CreatedAt = new DateTime(2021, 7, 15, 12, 0, 0) },
            new Product { Id = 6, Name = "Túi thời trang da cá sấu", Image = "/Avatar/04.jfif", Price = 50000, SalePrice = 35000, CategoryId = 2, Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit.", Status = 1, CreatedAt = new DateTime(2021, 7, 15, 12, 0, 0) }
        };

        [Route("san-pham", Name = "san-pham")]
        [Route("san-pham/{id?}", Name = "san-pham-category")]
        public IActionResult Index(int? id)
        {
            ViewBag.Categories = categories;

            var listProduct = products;
            if (id != null)
            {
                // Lọc sản phẩm theo CategoryId khi bấm vào danh mục bên trái
                listProduct = products.Where(p => p.CategoryId == id).ToList();
            }

            ViewBag.Products = listProduct;
            return View();
        }
        public IActionResult Detail(int id)
        {
            // Tìm 1 sản phẩm theo id
            Product product = products.FirstOrDefault(p => p.Id == id);
            ViewBag.Product = product;
            return View();
        }
    }
}
