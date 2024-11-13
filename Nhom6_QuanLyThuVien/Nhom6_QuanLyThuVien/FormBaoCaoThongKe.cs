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
        Ketnoi ketnoi = new Ketnoi();
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


                case "Báo Cáo Tài Chính":
                    
                    result = muonTra.timkiemsachdatra();
                    label2.Text = $"Tong tien: {ketnoi.TongTien()}";
                    break;



                case "Tình trạng sách":
                    result = sach.Getallbook(); // Lấy thông tin sách
                    label2.Text = null;
                    break;

            }

            // Đổ dữ liệu vào DataGridView
            dgv_baocao.DataSource = result;
        }

        private void FormBaoCaoThongKe_Load(object sender, EventArgs e)
        {

        }
    }
}
    

