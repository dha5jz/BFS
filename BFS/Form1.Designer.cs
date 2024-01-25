namespace BFS
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grbImg = new System.Windows.Forms.GroupBox();
            this.ptbCoTrongSO = new System.Windows.Forms.PictureBox();
            this.ptBKhongTrongSo = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTrongSo = new System.Windows.Forms.TextBox();
            this.btnADD = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lstDanhSachBFSkhong = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbTrongso = new System.Windows.Forms.Label();
            this.txtDinhKe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDinh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoDinh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grbChucNang = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnVe = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.lbBFD = new System.Windows.Forms.Label();
            this.lbBFDcotrongso = new System.Windows.Forms.Label();
            this.btnBFSko = new System.Windows.Forms.Button();
            this.btnBFSco = new System.Windows.Forms.Button();
            this.grbLoai = new System.Windows.Forms.GroupBox();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lstBFSco = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.grbImg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCoTrongSO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptBKhongTrongSo)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.grbChucNang.SuspendLayout();
            this.grbLoai.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grbImg);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.txtSoDinh);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(624, 376);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // grbImg
            // 
            this.grbImg.Controls.Add(this.ptbCoTrongSO);
            this.grbImg.Controls.Add(this.ptBKhongTrongSo);
            this.grbImg.Location = new System.Drawing.Point(337, 18);
            this.grbImg.Name = "grbImg";
            this.grbImg.Size = new System.Drawing.Size(281, 352);
            this.grbImg.TabIndex = 6;
            this.grbImg.TabStop = false;
            this.grbImg.Text = "Hướng dẫn (Hình ảnh minh họa)";
            // 
            // ptbCoTrongSO
            // 
            this.ptbCoTrongSO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbCoTrongSO.Image = global::BFS.Properties.Resources.bfdcots;
            this.ptbCoTrongSO.Location = new System.Drawing.Point(3, 18);
            this.ptbCoTrongSO.Name = "ptbCoTrongSO";
            this.ptbCoTrongSO.Size = new System.Drawing.Size(275, 331);
            this.ptbCoTrongSO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbCoTrongSO.TabIndex = 1;
            this.ptbCoTrongSO.TabStop = false;
            // 
            // ptBKhongTrongSo
            // 
            this.ptBKhongTrongSo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptBKhongTrongSo.Image = global::BFS.Properties.Resources.bfd1;
            this.ptBKhongTrongSo.Location = new System.Drawing.Point(3, 18);
            this.ptBKhongTrongSo.Name = "ptBKhongTrongSo";
            this.ptBKhongTrongSo.Size = new System.Drawing.Size(275, 331);
            this.ptBKhongTrongSo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptBKhongTrongSo.TabIndex = 0;
            this.ptBKhongTrongSo.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Controls.Add(this.btnSua);
            this.groupBox3.Controls.Add(this.txtTrongSo);
            this.groupBox3.Controls.Add(this.btnADD);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.lbTrongso);
            this.groupBox3.Controls.Add(this.txtDinhKe);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtDinh);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(9, 58);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(322, 312);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nhập các đỉnh và đỉnh kề của đỉnh đó:";
            // 
            // txtTrongSo
            // 
            this.txtTrongSo.Location = new System.Drawing.Point(92, 61);
            this.txtTrongSo.Name = "txtTrongSo";
            this.txtTrongSo.Size = new System.Drawing.Size(129, 22);
            this.txtTrongSo.TabIndex = 8;
            this.txtTrongSo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTrongSo_KeyPress);
            // 
            // btnADD
            // 
            this.btnADD.Location = new System.Drawing.Point(241, 35);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(75, 23);
            this.btnADD.TabIndex = 4;
            this.btnADD.Text = "Thêm";
            this.btnADD.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lstBFSco);
            this.groupBox5.Controls.Add(this.lstDanhSachBFSkhong);
            this.groupBox5.Location = new System.Drawing.Point(9, 141);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(310, 168);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Danh sách đỉnh";
            // 
            // lstDanhSachBFSkhong
            // 
            this.lstDanhSachBFSkhong.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstDanhSachBFSkhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstDanhSachBFSkhong.GridLines = true;
            this.lstDanhSachBFSkhong.HideSelection = false;
            this.lstDanhSachBFSkhong.Location = new System.Drawing.Point(3, 18);
            this.lstDanhSachBFSkhong.Name = "lstDanhSachBFSkhong";
            this.lstDanhSachBFSkhong.Size = new System.Drawing.Size(304, 147);
            this.lstDanhSachBFSkhong.TabIndex = 0;
            this.lstDanhSachBFSkhong.UseCompatibleStateImageBehavior = false;
            this.lstDanhSachBFSkhong.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Đỉnh";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Danh sách đỉnh kề";
            this.columnHeader2.Width = 185;
            // 
            // lbTrongso
            // 
            this.lbTrongso.AutoSize = true;
            this.lbTrongso.Location = new System.Drawing.Point(3, 67);
            this.lbTrongso.Name = "lbTrongso";
            this.lbTrongso.Size = new System.Drawing.Size(64, 16);
            this.lbTrongso.TabIndex = 7;
            this.lbTrongso.Text = "Trọng số:";
            // 
            // txtDinhKe
            // 
            this.txtDinhKe.Location = new System.Drawing.Point(89, 91);
            this.txtDinhKe.Name = "txtDinhKe";
            this.txtDinhKe.Size = new System.Drawing.Size(132, 22);
            this.txtDinhKe.TabIndex = 8;
            this.txtDinhKe.TextChanged += new System.EventHandler(this.txtDinhKe_TextChanged);
            this.txtDinhKe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDinhKe_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Đỉnh kề:";
            // 
            // txtDinh
            // 
            this.txtDinh.Location = new System.Drawing.Point(92, 26);
            this.txtDinh.Name = "txtDinh";
            this.txtDinh.Size = new System.Drawing.Size(129, 22);
            this.txtDinh.TabIndex = 6;
            this.txtDinh.TextChanged += new System.EventHandler(this.txtDinh_TextChanged);
            this.txtDinh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDinh_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Đỉnh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 2;
            // 
            // txtSoDinh
            // 
            this.txtSoDinh.Location = new System.Drawing.Point(92, 30);
            this.txtSoDinh.Name = "txtSoDinh";
            this.txtSoDinh.Size = new System.Drawing.Size(105, 22);
            this.txtSoDinh.TabIndex = 1;
            this.txtSoDinh.TextChanged += new System.EventHandler(this.txtSoDinh_TextChanged);
            this.txtSoDinh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoDinh_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số đỉnh:";
            // 
            // grbChucNang
            // 
            this.grbChucNang.Controls.Add(this.btnSave);
            this.grbChucNang.Controls.Add(this.btnTim);
            this.grbChucNang.Controls.Add(this.btnVe);
            this.grbChucNang.Controls.Add(this.btnImport);
            this.grbChucNang.Location = new System.Drawing.Point(642, 155);
            this.grbChucNang.Name = "grbChucNang";
            this.grbChucNang.Size = new System.Drawing.Size(143, 233);
            this.grbChucNang.TabIndex = 1;
            this.grbChucNang.TabStop = false;
            this.grbChucNang.Text = "Chức năng";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(6, 189);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 37);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save file";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(6, 20);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(124, 37);
            this.btnTim.TabIndex = 0;
            this.btnTim.Text = "Tìm đường đi";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // btnVe
            // 
            this.btnVe.Location = new System.Drawing.Point(6, 71);
            this.btnVe.Name = "btnVe";
            this.btnVe.Size = new System.Drawing.Size(124, 37);
            this.btnVe.TabIndex = 1;
            this.btnVe.Text = "Vẽ đồ thị";
            this.btnVe.UseVisualStyleBackColor = true;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(6, 130);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(124, 37);
            this.btnImport.TabIndex = 2;
            this.btnImport.Text = "Import File";
            this.btnImport.UseVisualStyleBackColor = true;
            // 
            // lbBFD
            // 
            this.lbBFD.AutoSize = true;
            this.lbBFD.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBFD.Location = new System.Drawing.Point(297, 1);
            this.lbBFD.Name = "lbBFD";
            this.lbBFD.Size = new System.Drawing.Size(199, 26);
            this.lbBFD.TabIndex = 2;
            this.lbBFD.Text = "BFS không trọng số";
            // 
            // lbBFDcotrongso
            // 
            this.lbBFDcotrongso.AutoSize = true;
            this.lbBFDcotrongso.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBFDcotrongso.Location = new System.Drawing.Point(297, 1);
            this.lbBFDcotrongso.Name = "lbBFDcotrongso";
            this.lbBFDcotrongso.Size = new System.Drawing.Size(162, 26);
            this.lbBFDcotrongso.TabIndex = 3;
            this.lbBFDcotrongso.Text = "BFS có trọng số";
            // 
            // btnBFSko
            // 
            this.btnBFSko.Location = new System.Drawing.Point(6, 23);
            this.btnBFSko.Name = "btnBFSko";
            this.btnBFSko.Size = new System.Drawing.Size(124, 51);
            this.btnBFSko.TabIndex = 4;
            this.btnBFSko.Text = "BFS không trọng số";
            this.btnBFSko.UseVisualStyleBackColor = true;
            this.btnBFSko.Click += new System.EventHandler(this.btnBFDko_Click);
            // 
            // btnBFSco
            // 
            this.btnBFSco.Location = new System.Drawing.Point(6, 75);
            this.btnBFSco.Name = "btnBFSco";
            this.btnBFSco.Size = new System.Drawing.Size(124, 43);
            this.btnBFSco.TabIndex = 5;
            this.btnBFSco.Text = "BFS có trọng số";
            this.btnBFSco.UseVisualStyleBackColor = true;
            this.btnBFSco.Click += new System.EventHandler(this.btnBFDco_Click);
            // 
            // grbLoai
            // 
            this.grbLoai.Controls.Add(this.btnBFSko);
            this.grbLoai.Controls.Add(this.btnBFSco);
            this.grbLoai.Location = new System.Drawing.Point(642, 30);
            this.grbLoai.Name = "grbLoai";
            this.grbLoai.Size = new System.Drawing.Size(143, 124);
            this.grbLoai.TabIndex = 6;
            this.grbLoai.TabStop = false;
            this.grbLoai.Text = "Thuật toán";
            // 
            // lblThongBao
            // 
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongBao.Location = new System.Drawing.Point(182, 1);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(475, 26);
            this.lblThongBao.TabIndex = 7;
            this.lblThongBao.Text = "Vui lòng chọn một trong hai thuật toán để bắt dầu";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(241, 64);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(241, 98);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // lstBFSco
            // 
            this.lstBFSco.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lstBFSco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstBFSco.FullRowSelect = true;
            this.lstBFSco.GridLines = true;
            this.lstBFSco.HideSelection = false;
            this.lstBFSco.Location = new System.Drawing.Point(3, 18);
            this.lstBFSco.Name = "lstBFSco";
            this.lstBFSco.Size = new System.Drawing.Size(304, 147);
            this.lstBFSco.TabIndex = 2;
            this.lstBFSco.UseCompatibleStateImageBehavior = false;
            this.lstBFSco.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đỉnh";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Trọng số";
            this.columnHeader4.Width = 86;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Danh sách đỉnh kề";
            this.columnHeader5.Width = 155;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 443);
            this.Controls.Add(this.lblThongBao);
            this.Controls.Add(this.grbLoai);
            this.Controls.Add(this.lbBFDcotrongso);
            this.Controls.Add(this.lbBFD);
            this.Controls.Add(this.grbChucNang);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbImg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbCoTrongSO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptBKhongTrongSo)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.grbChucNang.ResumeLayout(false);
            this.grbLoai.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoDinh;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grbChucNang;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnVe;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.GroupBox grbImg;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDinhKe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListView lstDanhSachBFSkhong;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label lbBFDcotrongso;
        private System.Windows.Forms.Label lbBFD;
        private System.Windows.Forms.Button btnBFSco;
        private System.Windows.Forms.Button btnBFSko;
        private System.Windows.Forms.TextBox txtTrongSo;
        private System.Windows.Forms.Label lbTrongso;
        private System.Windows.Forms.GroupBox grbLoai;
        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.PictureBox ptBKhongTrongSo;
        private System.Windows.Forms.PictureBox ptbCoTrongSO;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.ListView lstBFSco;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}

