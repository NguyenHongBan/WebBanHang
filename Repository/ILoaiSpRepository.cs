using Microsoft.AspNetCore.Identity;
using WebBanHang.Models;

namespace WebBanHang.Repository
{
    public interface ILoaiSpRepository
    {
        TLoaiSp Add(TLoaiSp loaiSp);
        TLoaiSp Update(TLoaiSp loaiSp);
        TLoaiSp Delete(TLoaiSp maloaiSp);
        TLoaiSp GetLoaiSp(TLoaiSp maloaiSp);
        IEnumerable<TLoaiSp> GetAllLoaiSp();
    }
}
