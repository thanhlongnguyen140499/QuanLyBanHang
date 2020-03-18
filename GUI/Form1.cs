using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThreeLayoutAgain.DAL;
using ThreeLayoutAgain.DTO;
using ThreeLayoutAgain.BLL;

namespace ThreeLayoutAgain
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string s = @"Data Source=PC-20161209ULNU;Initial Catalog=CSDLwithC#threelayers;User ID=sa;Password=123456";
        private void btn_Show_Click(object sender, EventArgs e)
        {
            //Dbhelper db = new Dbhelper(s);
            //dataGridView_Data.DataSource = db.getTable("select * from ThongTinGiaoDich"); 
            BLL_KH bll = new BLL_KH(s);
            bll.Show_BLL(dataGridView_Data);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string query_Add ;
            if (radiobtn_ThanhToanDu.Checked)
            {
                query_Add = "insert into dbo.ThongTinGiaoDich(HoTen,DongXe,LoaiGiaoDich,ThoiGianGiaoDich) values(N'" + txtBox_HoTen.Text + "'"
                                                                                                        + ",N'" + cbBox_DongXe.Text + "'"
                                                                                                        + ",N'" + radiobtn_ThanhToanDu.Text + "'"
                                                                                                        + ",'" + dateTimePicker_GiaoDich.Value.ToString("yyyy/MM/dd") + "');";
            }
            else
            {
                query_Add = "insert into dbo.ThongTinGiaoDich(HoTen,DongXe,LoaiGiaoDich,ThoiGianGiaoDich) values(N'" + txtBox_HoTen.Text + "'"
                                                                                                        + ",N'" + cbBox_DongXe.Text + "'"
                                                                                                        + ",N'" + radiobtn_TraGop.Text + "'"
                                                                                                        + ",'" + dateTimePicker_GiaoDich.Value.ToString("yyyy/MM/dd") + "');";
            }
            Dbhelper db = new Dbhelper(s);
            db.ExcuteDB(query_Add);
            dataGridView_Data.DataSource = db.getTable("select * from ThongTinGiaoDich");
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            //string query_Update;
            //if (radiobtn_ThanhToanDu.Checked)
            //{
            //    //query_Update = "UPDATE dbo.ThongTinGiaoDich SET DongXe =" + "N'" + cbBox_DongXe.Text + "'" +
            //    //                                                     ",LoaiGiaoDich =" + "N'" + radiobtn_ThanhToanDu.Text + "'" +
            //    //                                                     ",ThoiGianGiaoDich =" + "'" + dateTimePicker_GiaoDich.Value.ToString("yyyy/MM/dd") + "'" +
            //    //                                                " WHERE HoTen = N'" + txtBox_HoTen.Text + "';";
            //    query_Update = string.Format("UPDATE dbo.ThongTinGiaoDich SET DongXe = N'{0}',LoaiGiaoDich = N'{1}',ThoiGianGiaoDich = '{2}' WHERE HoTen = N'{3}'"
            //                                                    , cbBox_DongXe.Text, radiobtn_ThanhToanDu.Text, dateTimePicker_GiaoDich.Value.ToString("yyyy/MM/dd"), txtBox_HoTen.Text);
            //}
            //else
            //{
            //    query_Update = "UPDATE dbo.ThongTinGiaoDich SET DongXe =" + "N'" + cbBox_DongXe.Text + "'" +
            //                                                         ",LoaiGiaoDich =" + "N'" + radiobtn_TraGop.Text + "'" +
            //                                                         ",ThoiGianGiaoDich =" + "'" + dateTimePicker_GiaoDich.Value.ToString("yyyy/MM/dd") + "'" +
            //                                                    " WHERE HoTen = N'" + txtBox_HoTen.Text + "';";
            //}
            //Dbhelper db = new Dbhelper(s);
            //db.ExcuteDB(query_Update);
            //dataGridView_Data.DataSource = db.getTable("select * from dbo.ThongTinGiaoDich");


            BLL_KH bll = new BLL_KH(s);
            bll.Update_BLL(dataGridView_Data);
            btn_Show_Click(sender, e);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string query_Delete = "DELETE dbo.ThongTinGiaoDich WHERE HoTen = N'" + txtBox_HoTen.Text + "'";

            Dbhelper db = new Dbhelper(s);
            db.ExcuteDB(query_Delete);
            dataGridView_Data.DataSource = db.getTable("select * from dbo.ThongTinGiaoDich");
        }

        private void dataGridView_Data_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DAL_KH dal = new DAL_KH(s);
            KhachHang kh = dal.getKH(dataGridView_Data.Rows[e.RowIndex].Cells[0].Value.ToString());

            txtBox_HoTen.Text = kh.HoTen;
            cbBox_DongXe.Text = kh.DongXe;
            radiobtn_ThanhToanDu.Text = kh.LoaiGiaoDich;
            dateTimePicker_GiaoDich.Value = kh.ThoiGianGiaoDich;
        }

        private void txtBox_Search_TextChanged(object sender, EventArgs e)
        {
            BLL_KH bll = new BLL_KH(s);
            DAL_KH dal = new DAL_KH(s);
            dataGridView_Data.DataSource = bll.SearchKH_BLL(dal.getListKH_DAL(), txtBox_Search.Text);
        }

        private void btn_Sort_Click(object sender, EventArgs e)
        {
            if (cbBox_Sort.Text.ToString() == "HoTen")
            {
                BLL_KH bll = new BLL_KH(s);
                dataGridView_Data.DataSource = bll.sortKH_HoTen();
            }
            else if (cbBox_Sort.Text.ToString() == "LoaiGiaoDich")
            {
                BLL_KH bll = new BLL_KH(s);
                dataGridView_Data.DataSource = bll.sortKH_LoaiGiaoDich();
            }
            else if (cbBox_Sort.Text.ToString() == "ThoiGianGiaoDich")
            {
                BLL_KH bll = new BLL_KH(s);
                dataGridView_Data.DataSource = bll.sortKH_ThoiGianGiaoDich();
            }
        }


    }
}
