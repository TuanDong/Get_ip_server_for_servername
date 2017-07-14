using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delete_Tables_PO.FO_Moduel
{
	class FO
	{
		List<string> FO_Databases;
		public List<string> FO_List()
		{
			FO_Databases = new List<string>
                {
					"Hoadondichvuchitiet","Hoadondichvu","Hoadondichvucu","hoaDonbanhang",
					"ThanhToan","AllotmentChitietHistory","Inhousebackup", "CDR","CDR_BK","cuoc","AFU3801", "FB_Donbanhang","FB_Chitietdonbanhang","FB_SanPham","FB_ChitietSanpham","FB_ThucDon",
					"FB_Thucdon_sanpham","Minibar_DichVu","HoaDonBanHangCu","HoaDonBHChiTiet",
					"HoaDonMinibarChiTiet","HoaDonMinibar","HoaDonTienPhong","Phongthuedichvutudong"
                };
			return FO_Databases;
		}
		public string Condition(string item, string query)
		{
			switch (item)
			{
				case "Khach":
					query = "delete Khach where Maso in (select MaKhach from Phongthuekhach where Maphongthue in (select Ma from Phongthue where Phong not in (select Ma from Phong where Ma like '0%%') or Phong is null))";
					break;
				case "Phongthuekhach":
					query = "delete Phongthuekhach where Maphongthue  in (select Ma from Phongthue where Phong not in (select Ma from Phong where Ma like '0%%' )or Phong is null)";
					break;
				case "PhongThue":
					query = "delete PhongThue where Phong not in (select Ma from Phong where Ma like '0%%') or Phong is null";
					break;
				case "Phong":
					query = "delete Phong where Ma not like '0%%'";
					break;
				case "Congty":
					query = "delete Congty where Ma not in (select GiaTri from Thongso where Thongso='HT_CongTyDefault')";
					break;
				case "MaGiaPhong":
					query = "delete MaGiaPhong where Ma not in ('HU','FOC') or Ma not like 'Foc%'";
					break;
				case "Users":
					query = "delete Users where Username <> 'admin'";
					break;
				case "DAngphong":
					query = "delete DAngphong where Ma not in (select MaDangphong from Phong where Ma like '0%%')";
					break;
				case "LoaiPhong":
					query = "delete LoaiPhong where Ma not in (select MaLoaiPhong from Phong where Ma like '0%%')";
					break;
				default:
					query = "delete from " + item;
					break;
			}
			return query;
		}
	}
}
