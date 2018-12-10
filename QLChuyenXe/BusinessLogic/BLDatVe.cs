using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataProvider.Model;
namespace BusinessLogic
{
    public class BLDatVe
    {
        DbQLBanVeXeKhachContext db = new DbQLBanVeXeKhachContext();
        public List<BEN> getALLBenXe()
        {
           return db.sp_SelectAllBenXe().ToList();
        }

        public List<TUYENDUONG> getTuyenDuongByDiemKhoiHanh(string idDiemKhoiHanh)
        {
            return db.sp_GetTuyenDuongByDiemKhoiHanh(idDiemKhoiHanh).ToList();
        }

        public List<sp_GetTuyenDuongByDiemKhoiHanh2_Result> getTuyenDuongByDiemKhoiHanh2(string idDiemKhoiHanh)
        {
            return db.sp_GetTuyenDuongByDiemKhoiHanh2(idDiemKhoiHanh).ToList();
        }

        public List<CHUYENXE> getAllChuyenXeByTuyenDuong(int idtuyenduong)
        {
            return db.sp_GetChuyenXeByTuyenDuong(idtuyenduong).ToList();
        }

        public List<CHUYENXETHUCTE> GetChuyenXeThucTeByIDTuyenDuongNgayKhoiHanhAndSoluong(int idtuyenduong,DateTime ngaykhoihanh,int soluong)
        {
                
        }

    }
}
