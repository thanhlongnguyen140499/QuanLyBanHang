using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThreeLayoutAgain.DAL;
using ThreeLayoutAgain.DTO;


namespace ThreeLayoutAgain.BLL
{
    class BLL_KH
    {
        public DAL_KH dal { get; set; }
        public BLL_KH(string s)
        {
            dal = new DAL_KH(s);
        }

        public List<KhachHang> SearchKH_BLL(List<KhachHang> l , string x)
        {
            List<KhachHang> result = new List<KhachHang>();
            foreach (KhachHang item in l)
            {
                if(item.HoTen.Contains(x)  || item.DongXe.Contains(x) || item.LoaiGiaoDich.Contains(x) || item.ThoiGianGiaoDich.ToShortDateString() == x)
                {
                    result.Add(item);
                }
            }
            return result;
        }

        public delegate bool MyDel(object a , object b);
        public static void Swap(object[] o, int i, int j)
        {
            object temp;
            temp = o[i];
            o[i] = o[j];
            o[j] = temp;
        }
        public static void Sort(object[] s, MyDel d)
        {
            for (int i = 0; i < s.Length - 1; i++)
            {
                for (int j = s.Length - 1; j > i; j--)
                {
                    if (d(s[j], s[j - 1]))
                    {
                        Swap(s, i, j);
                    }
                }
            }
        }
        public KhachHang[] sortKH_HoTen()
        {
            List<KhachHang> l = dal.getListKH_DAL();
            KhachHang[] temp = l.ToArray();  // tao mang phu sao chep cac phan tu cu~ va`o day
            Sort(temp, KhachHang.compareHoTen);

            return temp;
        }
        public KhachHang[] sortKH_LoaiGiaoDich()
        {
            List<KhachHang> l = dal.getListKH_DAL();
            KhachHang[] temp = l.ToArray();  // tao mang phu sao chep cac phan tu cu~ va`o day
            Sort(temp, KhachHang.compareLoaiGiaoDich);

            return temp;
        }
        public KhachHang[] sortKH_ThoiGianGiaoDich()
        {
            List<KhachHang> l = dal.getListKH_DAL();
            KhachHang[] temp = l.ToArray();  // tao mang phu sao chep cac phan tu cu~ va`o day
            Sort(temp, KhachHang.compareThoiGianGiaoDich);

            return temp;
        }

        public void Show_BLL(DataGridView data)
        {
            data.DataSource = dal.getListKH_DAL();
        }

        public bool Update_BLL(DataGridView data)
        {
            KhachHang kh = dal.getKH(data.SelectedRows[0].Cells[0].Value.ToString());    //tra ve 1 KH
            return dal.Update_DAL(kh.HoTen);
        }
    }
}
