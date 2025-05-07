namespace Motobike.Baocao
{
    partial class Baocaobanhang
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
            this.btntimlai = new Guna.UI2.WinForms.Guna2Button();
            this.dgvbaocaoban = new System.Windows.Forms.DataGridView();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cbnmnv = new System.Windows.Forms.ComboBox();
            this.cbntenkhach = new System.Windows.Forms.ComboBox();
            this.cbntenhang = new System.Windows.Forms.ComboBox();
            this.cbnmahd = new System.Windows.Forms.ComboBox();
            this.txtketthuc = new System.Windows.Forms.MaskedTextBox();
            this.txtbdau = new System.Windows.Forms.MaskedTextBox();
            this.txtngay = new System.Windows.Forms.MaskedTextBox();
            this.lblketthuc = new System.Windows.Forms.Label();
            this.lbldau = new System.Windows.Forms.Label();
            this.ckbthoigian = new Guna.UI2.WinForms.Guna2CheckBox();
            this.ckbngay = new Guna.UI2.WinForms.Guna2CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnin = new Guna.UI2.WinForms.Guna2Button();
            this.btntimkiem = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbaocaoban)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btntimlai
            // 
            this.btntimlai.BorderRadius = 14;
            this.btntimlai.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btntimlai.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btntimlai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btntimlai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btntimlai.FillColor = System.Drawing.Color.DodgerBlue;
            this.btntimlai.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntimlai.ForeColor = System.Drawing.Color.White;
            this.btntimlai.Image = global::Motobike.Properties.Resources.research;
            this.btntimlai.ImageSize = new System.Drawing.Size(34, 34);
            this.btntimlai.Location = new System.Drawing.Point(629, 527);
            this.btntimlai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btntimlai.Name = "btntimlai";
            this.btntimlai.Size = new System.Drawing.Size(240, 55);
            this.btntimlai.TabIndex = 8;
            this.btntimlai.Text = "Tìm lại";
            this.btntimlai.Click += new System.EventHandler(this.btntimlai_Click);
            // 
            // dgvbaocaoban
            // 
            this.dgvbaocaoban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbaocaoban.Location = new System.Drawing.Point(227, 316);
            this.dgvbaocaoban.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvbaocaoban.Name = "dgvbaocaoban";
            this.dgvbaocaoban.RowHeadersWidth = 51;
            this.dgvbaocaoban.Size = new System.Drawing.Size(1079, 185);
            this.dgvbaocaoban.TabIndex = 6;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.cbnmnv);
            this.guna2GroupBox1.Controls.Add(this.cbntenkhach);
            this.guna2GroupBox1.Controls.Add(this.cbntenhang);
            this.guna2GroupBox1.Controls.Add(this.cbnmahd);
            this.guna2GroupBox1.Controls.Add(this.txtketthuc);
            this.guna2GroupBox1.Controls.Add(this.txtbdau);
            this.guna2GroupBox1.Controls.Add(this.txtngay);
            this.guna2GroupBox1.Controls.Add(this.lblketthuc);
            this.guna2GroupBox1.Controls.Add(this.lbldau);
            this.guna2GroupBox1.Controls.Add(this.ckbthoigian);
            this.guna2GroupBox1.Controls.Add(this.ckbngay);
            this.guna2GroupBox1.Controls.Add(this.label4);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(103, 21);
            this.guna2GroupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(1301, 274);
            this.guna2GroupBox1.TabIndex = 5;
            this.guna2GroupBox1.Text = "Thông tin";
            // 
            // cbnmnv
            // 
            this.cbnmnv.FormattingEnabled = true;
            this.cbnmnv.Location = new System.Drawing.Point(1068, 142);
            this.cbnmnv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbnmnv.Name = "cbnmnv";
            this.cbnmnv.Size = new System.Drawing.Size(160, 35);
            this.cbnmnv.TabIndex = 14;
            // 
            // cbntenkhach
            // 
            this.cbntenkhach.FormattingEnabled = true;
            this.cbntenkhach.Location = new System.Drawing.Point(1068, 73);
            this.cbntenkhach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbntenkhach.Name = "cbntenkhach";
            this.cbntenkhach.Size = new System.Drawing.Size(160, 35);
            this.cbntenkhach.TabIndex = 13;
            // 
            // cbntenhang
            // 
            this.cbntenhang.FormattingEnabled = true;
            this.cbntenhang.Location = new System.Drawing.Point(312, 142);
            this.cbntenhang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbntenhang.Name = "cbntenhang";
            this.cbntenhang.Size = new System.Drawing.Size(160, 35);
            this.cbntenhang.TabIndex = 12;
            // 
            // cbnmahd
            // 
            this.cbnmahd.FormattingEnabled = true;
            this.cbnmahd.Location = new System.Drawing.Point(312, 73);
            this.cbnmahd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbnmahd.Name = "cbnmahd";
            this.cbnmahd.Size = new System.Drawing.Size(160, 35);
            this.cbnmahd.TabIndex = 11;
            // 
            // txtketthuc
            // 
            this.txtketthuc.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtketthuc.Location = new System.Drawing.Point(1117, 229);
            this.txtketthuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtketthuc.Mask = "00/00/0000";
            this.txtketthuc.Name = "txtketthuc";
            this.txtketthuc.Size = new System.Drawing.Size(132, 32);
            this.txtketthuc.TabIndex = 10;
            this.txtketthuc.ValidatingType = typeof(System.DateTime);
            // 
            // txtbdau
            // 
            this.txtbdau.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbdau.Location = new System.Drawing.Point(855, 226);
            this.txtbdau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbdau.Mask = "00/00/0000";
            this.txtbdau.Name = "txtbdau";
            this.txtbdau.Size = new System.Drawing.Size(132, 32);
            this.txtbdau.TabIndex = 9;
            this.txtbdau.ValidatingType = typeof(System.DateTime);
            // 
            // txtngay
            // 
            this.txtngay.Location = new System.Drawing.Point(171, 226);
            this.txtngay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtngay.Mask = "00/00/0000";
            this.txtngay.Name = "txtngay";
            this.txtngay.Size = new System.Drawing.Size(132, 34);
            this.txtngay.TabIndex = 8;
            this.txtngay.ValidatingType = typeof(System.DateTime);
            // 
            // lblketthuc
            // 
            this.lblketthuc.AutoSize = true;
            this.lblketthuc.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblketthuc.Location = new System.Drawing.Point(1024, 233);
            this.lblketthuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblketthuc.Name = "lblketthuc";
            this.lblketthuc.Size = new System.Drawing.Size(83, 26);
            this.lblketthuc.TabIndex = 7;
            this.lblketthuc.Text = "Kết thúc";
            // 
            // lbldau
            // 
            this.lbldau.AutoSize = true;
            this.lbldau.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldau.Location = new System.Drawing.Point(771, 233);
            this.lbldau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldau.Name = "lbldau";
            this.lbldau.Size = new System.Drawing.Size(74, 26);
            this.lbldau.TabIndex = 6;
            this.lbldau.Text = "Bắt đầu";
            // 
            // ckbthoigian
            // 
            this.ckbthoigian.AutoSize = true;
            this.ckbthoigian.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ckbthoigian.CheckedState.BorderRadius = 0;
            this.ckbthoigian.CheckedState.BorderThickness = 0;
            this.ckbthoigian.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ckbthoigian.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbthoigian.ForeColor = System.Drawing.Color.Black;
            this.ckbthoigian.Location = new System.Drawing.Point(499, 226);
            this.ckbthoigian.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbthoigian.Name = "ckbthoigian";
            this.ckbthoigian.Size = new System.Drawing.Size(214, 31);
            this.ckbthoigian.TabIndex = 5;
            this.ckbthoigian.Text = "Theo mốc thời gian";
            this.ckbthoigian.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ckbthoigian.UncheckedState.BorderRadius = 0;
            this.ckbthoigian.UncheckedState.BorderThickness = 0;
            this.ckbthoigian.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ckbthoigian.CheckedChanged += new System.EventHandler(this.ckbthoigian_CheckedChanged);
            // 
            // ckbngay
            // 
            this.ckbngay.AutoSize = true;
            this.ckbngay.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ckbngay.CheckedState.BorderRadius = 0;
            this.ckbngay.CheckedState.BorderThickness = 0;
            this.ckbngay.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ckbngay.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbngay.ForeColor = System.Drawing.Color.Black;
            this.ckbngay.Location = new System.Drawing.Point(20, 226);
            this.ckbngay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbngay.Name = "ckbngay";
            this.ckbngay.Size = new System.Drawing.Size(132, 31);
            this.ckbngay.TabIndex = 4;
            this.ckbngay.Text = "Theo ngày";
            this.ckbngay.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ckbngay.UncheckedState.BorderRadius = 0;
            this.ckbngay.UncheckedState.BorderThickness = 0;
            this.ckbngay.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ckbngay.CheckedChanged += new System.EventHandler(this.ckbngay_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(824, 142);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(820, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên khách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn";
            // 
            // btnin
            // 
            this.btnin.BorderRadius = 14;
            this.btnin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnin.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnin.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnin.ForeColor = System.Drawing.Color.White;
            this.btnin.Image = global::Motobike.Properties.Resources.print;
            this.btnin.ImageSize = new System.Drawing.Size(34, 34);
            this.btnin.Location = new System.Drawing.Point(1171, 527);
            this.btnin.Margin = new System.Windows.Forms.Padding(4);
            this.btnin.Name = "btnin";
            this.btnin.Size = new System.Drawing.Size(240, 55);
            this.btnin.TabIndex = 9;
            this.btnin.Text = "In báo cáo";
            this.btnin.Click += new System.EventHandler(this.btnin_Click);
            // 
            // btntimkiem
            // 
            this.btntimkiem.BorderRadius = 14;
            this.btntimkiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btntimkiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btntimkiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btntimkiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btntimkiem.FillColor = System.Drawing.Color.DodgerBlue;
            this.btntimkiem.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntimkiem.ForeColor = System.Drawing.Color.White;
            this.btntimkiem.Image = global::Motobike.Properties.Resources.find;
            this.btntimkiem.ImageSize = new System.Drawing.Size(34, 34);
            this.btntimkiem.Location = new System.Drawing.Point(123, 527);
            this.btntimkiem.Margin = new System.Windows.Forms.Padding(4);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(223, 55);
            this.btntimkiem.TabIndex = 7;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // Baocaobanhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1513, 604);
            this.Controls.Add(this.btnin);
            this.Controls.Add(this.btntimlai);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.dgvbaocaoban);
            this.Controls.Add(this.guna2GroupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Baocaobanhang";
            this.Text = "Baocaobanhang";
            this.Load += new System.EventHandler(this.Baocaobanhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbaocaoban)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnin;
        private Guna.UI2.WinForms.Guna2Button btntimlai;
        private Guna.UI2.WinForms.Guna2Button btntimkiem;
        private System.Windows.Forms.DataGridView dgvbaocaoban;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.ComboBox cbnmnv;
        private System.Windows.Forms.ComboBox cbntenkhach;
        private System.Windows.Forms.ComboBox cbntenhang;
        private System.Windows.Forms.ComboBox cbnmahd;
        private System.Windows.Forms.MaskedTextBox txtketthuc;
        private System.Windows.Forms.MaskedTextBox txtbdau;
        private System.Windows.Forms.MaskedTextBox txtngay;
        private System.Windows.Forms.Label lblketthuc;
        private System.Windows.Forms.Label lbldau;
        private Guna.UI2.WinForms.Guna2CheckBox ckbthoigian;
        private Guna.UI2.WinForms.Guna2CheckBox ckbngay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}