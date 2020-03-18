using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeLayoutAgain.DTO
{
    class KhachHang
    {
        public string HoTen { get; set; }
        public string DongXe { get; set; }
        public string LoaiGiaoDich { get; set; }
        public DateTime ThoiGianGiaoDich { get; set; }

        public static bool compareHoTen(object o1,object o2)
        {
            if (string.Compare(((KhachHang)o1).HoTen, ((KhachHang)o2).HoTen) > 0)
                return true;
            else return false;
        }
        public static bool compareDongXe(object o1, object o2)
        {
            if (string.Compare(((KhachHang)o1).DongXe, ((KhachHang)o2).DongXe) > 0)
                return true;
            else return false;
        }
        public static bool compareLoaiGiaoDich(object o1, object o2)
        {
            if (string.Compare(((KhachHang)o1).LoaiGiaoDich, ((KhachHang)o2).LoaiGiaoDich) > 0)
                return true;
            else return false;
        }
        public static bool compareThoiGianGiaoDich(object o1, object o2)
        {
            if (  string.Compare( ( (KhachHang)o1).ThoiGianGiaoDich.ToShortDateString(), ((KhachHang)o2).ThoiGianGiaoDich.ToShortDateString() ) > 0)
                return true;
            else return false;
        }
    }
}
