using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessAcessLayer
{
    public class DBNhanVien
    {
        public DataSet LayDsNhanVien()
        {
            return DAL.ExecuteQueryDataSet("select * from NHANVIEN", CommandType.Text, null);
        }
    }
}
