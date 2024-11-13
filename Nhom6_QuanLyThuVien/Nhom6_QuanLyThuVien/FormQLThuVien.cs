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
    public partial class FormQLThuVien : Form
    {
        public FormQLThuVien()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

 
        

        private void quảnLýĐộcGiảToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormQLDocGia formQLDocgia = new FormQLDocGia();
            formQLDocgia.MdiParent = this;
            formQLDocgia.Show();
        }

        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQLSach formQlSach = new FormQLSach();
            formQlSach.MdiParent = this;
            formQlSach.Show();
        }

        private void quảnLýTácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQLTacGia formQLTacGia = new FormQLTacGia();
            formQLTacGia.MdiParent = this;
            formQLTacGia.Show();
        }

        

        private void quảnLýMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQLMuon formQLMuon = new FormQLMuon();
            formQLMuon.MdiParent = this;
            formQLMuon.Show();
        }

        private void quảnLýTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQLTra formQLTra = new FormQLTra();
            formQLTra.MdiParent = this;
            formQLTra.Show();
        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBaoCaoThongKe formBaoCaoThongKe = new FormBaoCaoThongKe();
            formBaoCaoThongKe.MdiParent = this;
            formBaoCaoThongKe.Show();
        }
    }
}
