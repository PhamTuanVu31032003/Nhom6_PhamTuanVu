using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;



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
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
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
            DataTable docGiaDaTra = muonTra.GetDocGiaDaTra();
            // Đổ dữ liệu vào DataGridView
            dgv_baocao.DataSource = result;
        }

        private void FormBaoCaoThongKe_Load(object sender, EventArgs e)
        {

        }
        private void ExportToExcel(DataGridView dataGridView)
        {
            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                var workSheet = excelPackage.Workbook.Worksheets.Add("Sheet1");

                // Lấy tiêu đề
                for (int i = 1; i <= dataGridView.Columns.Count; i++)
                {
                    workSheet.Cells[1, i].Value = dataGridView.Columns[i - 1].HeaderText;
                }

                // Xuất dữ liệu từ DataGridView sang Excel
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        workSheet.Cells[i + 2, j + 1].Value = dataGridView.Rows[i].Cells[j].Value?.ToString();
                    }
                }

                // Lưu file Excel
                using (var saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel Files|*.xlsx";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        FileInfo fi = new FileInfo(saveFileDialog.FileName);
                        excelPackage.SaveAs(fi);
                        // mở sau khi lưu
                        Process.Start(new ProcessStartInfo(saveFileDialog.FileName) { UseShellExecute = true });
                    }
                }
            }
        }


        private void btnexcel_Click(object sender, EventArgs e)
        {
            ExportToExcel(dgv_baocao);
        }
    }
}
    

