using CNPMNC_Giao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CNPMNC_Giao.Controllers
{
    public class CartController : Controller
    {
        private DAPM_1Entities1 db = new DAPM_1Entities1();

        // GET: Cart
        public ActionResult Index()
        {
            var cart = Session["Cart"] as List<ChiTietGioHang>;
            if (cart == null)
            {
                cart = new List<ChiTietGioHang>();
                Session["Cart"] = cart;
            }
            return View(cart);
        }

        // Thêm sản phẩm vào giỏ hàng
        public ActionResult AddToCart(int id, int size, int SoLuong)
        {
            // Tìm sản phẩm dựa trên id
            var product = db.SanPham.Find(id);
            if (product == null)
            {
                return HttpNotFound(); // Kiểm tra nếu sản phẩm không tồn tại
            }

            // Lấy giỏ hàng từ Session, nếu chưa có thì khởi tạo mới
            var cart = Session["Cart"] as List<ChiTietGioHang>;
            if (cart == null)
            {
                cart = new List<ChiTietGioHang>();
            }

            // Kiểm tra sản phẩm đã có trong giỏ hàng chưa
            var cartItem = cart.FirstOrDefault(c => c.MaSanPham == id && c.SoKichCo == size);
            if (cartItem != null)
            {
                // Tăng số lượng nếu sản phẩm đã có trong giỏ hàng
                cartItem.SoLuong++;
            }
            else
            {
                // Thêm sản phẩm mới vào giỏ hàng
                cart.Add(new ChiTietGioHang
                {
                    MaSanPham = product.MaSanPham,
                    SoLuong = SoLuong,
                    GiaBan = product.GiaTienMoi,
                    SoKichCo = size,
                    SanPham = product // Liên kết sản phẩm với ChiTietGioHang
                });
            }

            // Cập nhật lại giỏ hàng trong Session
            Session["Cart"] = cart;

            // Chuyển hướng về trang giỏ hàng
            return RedirectToAction("Index");
        }


        // Xóa sản phẩm khỏi giỏ hàng
        public ActionResult RemoveFromCart(int id)
        {
            var cart = Session["Cart"] as List<ChiTietGioHang>;
            var cartItem = cart.FirstOrDefault(c => c.MaSanPham == id);

            if (cartItem != null)
            {
                cart.Remove(cartItem);
            }

            Session["Cart"] = cart;
            return RedirectToAction("Index");
        }

        // Cập nhật số lượng sản phẩm trong giỏ hàng
        public ActionResult UpdateQuantity(int id, int quantity)
        {
            var cart = Session["Cart"] as List<ChiTietGioHang>;
            var cartItem = cart.FirstOrDefault(c => c.MaSanPham == id);

            if (cartItem != null && quantity > 0)
            {
                cartItem.SoLuong = quantity;
            }

            Session["Cart"] = cart;
            return RedirectToAction("Index");
        }





    }
}