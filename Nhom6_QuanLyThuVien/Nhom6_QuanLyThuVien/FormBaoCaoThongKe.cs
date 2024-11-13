using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom6_QuanLyThuVien
{
    public partial class FormBaoCaoThongKe : Form
    {
        Docgia docgia = new Docgia();
        Sach sach = new Sach();
        MuonTraSach muonTra = new MuonTraSach();
        public FormBaoCaoThongKe()
        {
            InitializeComponent();
            LoadThongKeOptions();
        }
        private void LoadThongKeOptions()
        {

            cbThongKe.Items.Add("Báo Cáo Tài Chính");

            cbThongKe.Items.Add("Tình trạng sách");
            cbThongKe.SelectedIndex = 0;
        }

        private void btnbaocao_Click(object sender, EventArgs e)
        {
            string selectedOption = cbThongKe.SelectedItem.ToString();
            DataTable result = new DataTable();

            switch (selectedOption)
            {


                case "Báo cáo tài chính":
                  result = muonTra.GetDocGiaDaTra(); // Lấy thông tin độc giả đã trả sách
                    break;



                case "Tình trạng sách":
                    result = sach.Getallbook(); // Lấy thông tin sách
                    break;

                    // Không có tùy chọn "Độc giả theo lượt mượn" nữa
            }
            DataTable docGiaDaTra = muonTra.GetDocGiaDaTra();
            // Đổ dữ liệu vào DataGridView
            dgv_baocao.DataSource = result;
        }
    }
}
    

