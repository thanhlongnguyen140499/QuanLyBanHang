using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThreeLayoutAgain.DTO;

namespace ThreeLayoutAgain.DAL
{
    class DAL_KH
    {
        public Dbhelper db { get; set; }

        public DAL_KH(string s)
        {
            db = new Dbhelper(s);
        }

        public KhachHang getKH(string HoTen)
        {
            string query = "Select * from ThongTinGiaoDich where HoTen= '" + HoTen + "'";
            DataTable dt = db.getTable(query);
            KhachHang kh = new KhachHang
            {
                HoTen = dt.Rows[0]["HoTen"].ToString(),
                DongXe = dt.Rows[0]["DongXe"].ToString(),
                LoaiGiaoDich = dt.Rows[0]["LoaiGiaoDich"].ToString(),
                ThoiGianGiaoDich = Convert.ToDateTime(dt.Rows[0]["ThoiGianGiaoDich"]),

                //HoTen = dt.Rows[0][0].ToString(),
                //DongXe = dt.Rows[0][1].ToString(),
                //LoaiGiaoDich = dt.Rows[0][2].ToString(),
                //ThoiGianGiaoDich = Convert.ToDateTime(dt.Rows[0][3])
            };
            return kh;
        }

        public KhachHang getKH(DataRow x)
        {
            KhachHang kh = new KhachHang();
            kh.HoTen = x["HoTen"].ToString();
            kh.DongXe = x["DongXe"].ToString();
            kh.LoaiGiaoDich = x["LoaiGiaoDich"].ToString();
            kh.ThoiGianGiaoDich = Convert.ToDateTime(x["ThoiGianGiaoDich"]);
            return kh;
        }

        public List<KhachHang> getListKH_DAL()
        {
            string query = "select * from ThongTinGiaoDich";
            List<KhachHang> l = new List<KhachHang>();
            DataTable dt = db.getTable(query);

            foreach (DataRow item in dt.Rows)
            {
                l.Add(getKH(item));
            }

            return l;
        }

        public bool Update_DAL(string HoTen)
        {
            //string query_Update = string.Format("UPDATE dbo.ThongTinGiaoDich SET DongXe = N'{0}',LoaiGiaoDich = N'{1}',ThoiGianGiaoDich = '{2}' WHERE HoTen = N'{3}'"
            //                                                    , kh.DongXe, kh.LoaiGiaoDich, kh.ThoiGianGiaoDich, kh.HoTen);

            string query_Update = "UPDATE dbo.ThongTinGiaoDich SET DongXe = N'Hello'" +
                                                                 ",LoaiGiaoDich = N'Hello'" +
                                                                // ",ThoiGianGiaoDich = '20/10/2019'" +
                                                            " WHERE HoTen = N'" + HoTen + "';";
            db.ExcuteDB(query_Update);
            return true;
        }
    }
}

