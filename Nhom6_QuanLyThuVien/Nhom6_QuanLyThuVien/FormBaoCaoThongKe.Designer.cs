namespace Nhom6_QuanLyThuVien
{
    partial class FormBaoCaoThongKe
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
            this.cbThongKe = new System.Windows.Forms.ComboBox();
            this.btnlammoi = new System.Windows.Forms.Button();
            this.btnexcel = new System.Windows.Forms.Button();
            this.dgv_baocao = new System.Windows.Forms.DataGridView();
            this.btnbaocao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_baocao)).BeginInit();
            this.SuspendLayout();
            // 
            // cbThongKe
            // 
            this.cbThongKe.FormattingEnabled = true;
            this.cbThongKe.Location = new System.Drawing.Point(318, 56);
            this.cbThongKe.Name = "cbThongKe";
            this.cbThongKe.Size = new System.Drawing.Size(283, 24);
            this.cbThongKe.TabIndex = 25;
            // 
            // btnlammoi
            // 
            this.btnlammoi.Location = new System.Drawing.Point(352, 142);
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.Size = new System.Drawing.Size(75, 36);
            this.btnlammoi.TabIndex = 24;
            this.btnlammoi.Text = "Làm mới";
            this.btnlammoi.UseVisualStyleBackColor = true;
            // 
            // btnexcel
            // 
            this.btnexcel.Location = new System.Drawing.Point(515, 142);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.Size = new System.Drawing.Size(100, 36);
            this.btnexcel.TabIndex = 23;
            this.btnexcel.Text = "Xuất excel";
            this.btnexcel.UseVisualStyleBackColor = true;
            // 
            // dgv_baocao
            // 
            this.dgv_baocao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_baocao.Location = new System.Drawing.Point(-157, 283);
            this.dgv_baocao.Name = "dgv_baocao";
            this.dgv_baocao.ReadOnly = true;
            this.dgv_baocao.RowHeadersWidth = 51;
            this.dgv_baocao.RowTemplate.Height = 24;
            this.dgv_baocao.Size = new System.Drawing.Size(1233, 225);
            this.dgv_baocao.TabIndex = 22;
            // 
            // btnbaocao
            // 
            this.btnbaocao.Location = new System.Drawing.Point(145, 142);
            this.btnbaocao.Name = "btnbaocao";
            this.btnbaocao.Size = new System.Drawing.Size(112, 36);
            this.btnbaocao.TabIndex = 21;
            this.btnbaocao.Text = "Tạo báo cáo";
            this.btnbaocao.UseVisualStyleBackColor = true;
            this.btnbaocao.Click += new System.EventHandler(this.btnbaocao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, -58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Báo cáo thống kê thư viện";
            // 
            // FormBaoCaoThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 450);
            this.Controls.Add(this.cbThongKe);
            this.Controls.Add(this.btnlammoi);
            this.Controls.Add(this.btnexcel);
            this.Controls.Add(this.dgv_baocao);
            this.Controls.Add(this.btnbaocao);
            this.Controls.Add(this.label1);
            this.Name = "FormBaoCaoThongKe";
            this.Text = "FormBaoCaoThongKe";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_baocao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbThongKe;
        private System.Windows.Forms.Button btnlammoi;
        private System.Windows.Forms.Button btnexcel;
        private System.Windows.Forms.DataGridView dgv_baocao;
        private System.Windows.Forms.Button btnbaocao;
        private System.Windows.Forms.Label label1;
    }
}