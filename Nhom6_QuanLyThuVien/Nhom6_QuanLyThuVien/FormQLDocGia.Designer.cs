namespace Nhom6_QuanLyThuVien
{
    partial class FormQLDocGia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btntimkiem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.dtp_ngaydangky = new System.Windows.Forms.DateTimePicker();
            this.dgv_docgia = new System.Windows.Forms.DataGridView();
            this.dtp_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.txt_dienthoai = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_gioitinh = new System.Windows.Forms.TextBox();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.txt_madocgia = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_docgia)).BeginInit();
            this.SuspendLayout();
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(895, 135);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(122, 44);
            this.btntimkiem.TabIndex = 77;
            this.btntimkiem.Text = "Tìm Kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(361, 292);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(122, 44);
            this.btnsua.TabIndex = 76;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(779, 292);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(122, 44);
            this.btnthoat.TabIndex = 75;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(559, 292);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(122, 44);
            this.btnxoa.TabIndex = 74;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(121, 292);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(122, 44);
            this.btnthem.TabIndex = 73;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // dtp_ngaydangky
            // 
            this.dtp_ngaydangky.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngaydangky.Location = new System.Drawing.Point(615, 188);
            this.dtp_ngaydangky.Name = "dtp_ngaydangky";
            this.dtp_ngaydangky.Size = new System.Drawing.Size(158, 22);
            this.dtp_ngaydangky.TabIndex = 72;
            // 
            // dgv_docgia
            // 
            this.dgv_docgia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_docgia.Location = new System.Drawing.Point(12, 357);
            this.dgv_docgia.Name = "dgv_docgia";
            this.dgv_docgia.RowHeadersWidth = 51;
            this.dgv_docgia.RowTemplate.Height = 24;
            this.dgv_docgia.Size = new System.Drawing.Size(1177, 221);
            this.dgv_docgia.TabIndex = 71;
            this.dgv_docgia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_docgia_CellClick);
            // 
            // dtp_ngaysinh
            // 
            this.dtp_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngaysinh.Location = new System.Drawing.Point(221, 183);
            this.dtp_ngaysinh.Name = "dtp_ngaysinh";
            this.dtp_ngaysinh.Size = new System.Drawing.Size(158, 22);
            this.dtp_ngaysinh.TabIndex = 70;
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(615, 33);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(158, 22);
            this.txt_diachi.TabIndex = 69;
            // 
            // txt_dienthoai
            // 
            this.txt_dienthoai.Location = new System.Drawing.Point(615, 82);
            this.txt_dienthoai.Name = "txt_dienthoai";
            this.txt_dienthoai.Size = new System.Drawing.Size(158, 22);
            this.txt_dienthoai.TabIndex = 68;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(615, 132);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(158, 22);
            this.txt_email.TabIndex = 67;
            // 
            // txt_gioitinh
            // 
            this.txt_gioitinh.Location = new System.Drawing.Point(221, 135);
            this.txt_gioitinh.Name = "txt_gioitinh";
            this.txt_gioitinh.Size = new System.Drawing.Size(158, 22);
            this.txt_gioitinh.TabIndex = 66;
            // 
            // txt_hoten
            // 
            this.txt_hoten.Location = new System.Drawing.Point(221, 85);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(158, 22);
            this.txt_hoten.TabIndex = 65;
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(884, 79);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(143, 22);
            this.txt_timkiem.TabIndex = 64;
            // 
            // txt_madocgia
            // 
            this.txt_madocgia.Location = new System.Drawing.Point(221, 39);
            this.txt_madocgia.Name = "txt_madocgia";
            this.txt_madocgia.Size = new System.Drawing.Size(158, 22);
            this.txt_madocgia.TabIndex = 63;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(881, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 16);
            this.label9.TabIndex = 62;
            this.label9.Text = "Tìm Kiếm Mã Độc Giả";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(489, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 16);
            this.label8.TabIndex = 61;
            this.label8.Text = "Ngày Đăng Ký";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(513, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 60;
            this.label7.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(118, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 59;
            this.label6.Text = "Ngày Sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(513, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 58;
            this.label5.Text = "Điện Thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 57;
            this.label4.Text = "Giới Tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(513, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 56;
            this.label3.Text = "Địa Chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 55;
            this.label2.Text = "Họ Và Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 54;
            this.label1.Text = "Mã Độc Giả";
            // 
            // FormQLDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 594);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dtp_ngaydangky);
            this.Controls.Add(this.dgv_docgia);
            this.Controls.Add(this.dtp_ngaysinh);
            this.Controls.Add(this.txt_diachi);
            this.Controls.Add(this.txt_dienthoai);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_gioitinh);
            this.Controls.Add(this.txt_hoten);
            this.Controls.Add(this.txt_timkiem);
            this.Controls.Add(this.txt_madocgia);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormQLDocGia";
            this.Text = "FormQLDocGia";
            this.Load += new System.EventHandler(this.FormQLDocGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_docgia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DateTimePicker dtp_ngaydangky;
        private System.Windows.Forms.DataGridView dgv_docgia;
        private System.Windows.Forms.DateTimePicker dtp_ngaysinh;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.TextBox txt_dienthoai;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_gioitinh;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.TextBox txt_madocgia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}