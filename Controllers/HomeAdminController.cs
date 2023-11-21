using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebBanHang.Models;
using X.PagedList;

namespace WebBanHang.Controllers
{
    
    [Route("Admin")]
    [Route("Admin/HomeAdmin")]
    public class HomeAdminController : Controller
    {
        QlbanVaLiContext db = new QlbanVaLiContext();
        [Route("")]
        [Route("Index")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("Danhmucsanpham")]
        public IActionResult DanhMucSanPham(int? page)
        {
            int pageSize = 15;
            int pageNumber = page == null || page < 0 ? 1 : page.Value;

            var lstsanpham = db.TDanhMucSps.AsNoTracking().OrderBy(x => x.TenSp);
            PagedList<TDanhMucSp> lst = new PagedList<TDanhMucSp>(lstsanpham, pageNumber, pageSize);
            return View(lst);
        }
    }
}
