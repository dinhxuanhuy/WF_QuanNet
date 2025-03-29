using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data.SqlClient;

namespace BusinessAcessLayer
{
    public class DBNhanVien
    {
        public static DataSet LayDsNhanVien()
        {
            return DAL.ExecuteQueryDataSet("select * from NHANVIEN", CommandType.Text, null);
        }
        public static void ThemNhanVien(string Hoten, string SDT, string DiaChi, string GioiTinh, DateTime NgaySinh)
        {
            string error = "Loi";
            DAL.MyExecuteNonQuery("sp_ThemNhanVien", CommandType.StoredProcedure, ref error, new SqlParameter("@Hoten", Hoten), new SqlParameter("@SDT", SDT), new SqlParameter("@DiaChi", DiaChi), new SqlParameter("@GioiTinh", GioiTinh), new SqlParameter("@NgaySinh", NgaySinh));
        }
        public static void SuaNhanVien(string MaNV, string Hoten, string SDT, string DiaChi, string GioiTinh, DateTime NgaySinh)
        {
            string error = "";
            DAL.MyExecuteNonQuery("sp_SuaNhanVien", CommandType.StoredProcedure, ref error, new SqlParameter("@MaNV", MaNV), new SqlParameter("@Hoten", Hoten), new SqlParameter("@SDT", SDT), new SqlParameter("@DiaChi", DiaChi), new SqlParameter("@GioiTinh", GioiTinh), new SqlParameter("@NgaySinh", NgaySinh));
        }
        public static void XoaNhanVien(string MaNV)
        {
            string error = "";
            DAL.MyExecuteNonQuery("sp_XoaNhanVien", CommandType.StoredProcedure, ref error, new SqlParameter("@MaNV", MaNV));
        }
    }
}
