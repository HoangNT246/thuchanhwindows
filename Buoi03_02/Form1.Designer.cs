namespace Buoi03_02
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
            this.txtNS = new System.Windows.Forms.TextBox();
            this.txtHT = new System.Windows.Forms.TextBox();
            this.txtMSV = new System.Windows.Forms.TextBox();
            this.chbDulich = new System.Windows.Forms.CheckBox();
            this.chbMuasam = new System.Windows.Forms.CheckBox();
            this.chbThethao = new System.Windows.Forms.CheckBox();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.txtST = new System.Windows.Forms.Label();
            this.txtGT = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb1Thongbao = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDanhsach = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNS);
            this.groupBox1.Controls.Add(this.txtHT);
            this.groupBox1.Controls.Add(this.txtMSV);
            this.groupBox1.Controls.Add(this.chbDulich);
            this.groupBox1.Controls.Add(this.chbMuasam);
            this.groupBox1.Controls.Add(this.chbThethao);
            this.groupBox1.Controls.Add(this.rbNu);
            this.groupBox1.Controls.Add(this.rbNam);
            this.groupBox1.Controls.Add(this.txtST);
            this.groupBox1.Controls.Add(this.txtGT);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(73, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 358);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin";
            // 
            // txtNS
            // 
            this.txtNS.Location = new System.Drawing.Point(90, 141);
            this.txtNS.Name = "txtNS";
            this.txtNS.Size = new System.Drawing.Size(153, 22);
            this.txtNS.TabIndex = 9;
            // 
            // txtHT
            // 
            this.txtHT.Location = new System.Drawing.Point(90, 94);
            this.txtHT.Name = "txtHT";
            this.txtHT.Size = new System.Drawing.Size(153, 22);
            this.txtHT.TabIndex = 8;
            // 
            // txtMSV
            // 
            this.txtMSV.Location = new System.Drawing.Point(90, 38);
            this.txtMSV.Name = "txtMSV";
            this.txtMSV.Size = new System.Drawing.Size(153, 22);
            this.txtMSV.TabIndex = 2;
            // 
            // chbDulich
            // 
            this.chbDulich.AutoSize = true;
            this.chbDulich.Location = new System.Drawing.Point(66, 283);
            this.chbDulich.Name = "chbDulich";
            this.chbDulich.Size = new System.Drawing.Size(69, 20);
            this.chbDulich.TabIndex = 7;
            this.chbDulich.Text = "Du lịch";
            this.chbDulich.UseVisualStyleBackColor = true;
            // 
            // chbMuasam
            // 
            this.chbMuasam.AutoSize = true;
            this.chbMuasam.Location = new System.Drawing.Point(66, 319);
            this.chbMuasam.Name = "chbMuasam";
            this.chbMuasam.Size = new System.Drawing.Size(84, 20);
            this.chbMuasam.TabIndex = 6;
            this.chbMuasam.Text = "Mua sắm";
            this.chbMuasam.UseVisualStyleBackColor = true;
            // 
            // chbThethao
            // 
            this.chbThethao.AutoSize = true;
            this.chbThethao.Location = new System.Drawing.Point(66, 247);
            this.chbThethao.Name = "chbThethao";
            this.chbThethao.Size = new System.Drawing.Size(82, 20);
            this.chbThethao.TabIndex = 0;
            this.chbThethao.Text = "Thể thao";
            this.chbThethao.UseVisualStyleBackColor = true;
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Location = new System.Drawing.Point(129, 194);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(45, 20);
            this.rbNu.TabIndex = 5;
            this.rbNu.TabStop = true;
            this.rbNu.Text = "Nữ";
            this.rbNu.UseVisualStyleBackColor = true;
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Location = new System.Drawing.Point(66, 196);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(57, 20);
            this.rbNam.TabIndex = 0;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            // 
            // txtST
            // 
            this.txtST.AutoSize = true;
            this.txtST.Location = new System.Drawing.Point(6, 251);
            this.txtST.Name = "txtST";
            this.txtST.Size = new System.Drawing.Size(54, 16);
            this.txtST.TabIndex = 4;
            this.txtST.Text = "Sở thích";
            // 
            // txtGT
            // 
            this.txtGT.AutoSize = true;
            this.txtGT.Location = new System.Drawing.Point(6, 198);
            this.txtGT.Name = "txtGT";
            this.txtGT.Size = new System.Drawing.Size(54, 16);
            this.txtGT.TabIndex = 3;
            this.txtGT.Text = "Giới tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb1Thongbao);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtDanhsach);
            this.groupBox2.Location = new System.Drawing.Point(387, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 217);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách ghi chú";
            // 
            // lb1Thongbao
            // 
            this.lb1Thongbao.AutoSize = true;
            this.lb1Thongbao.Location = new System.Drawing.Point(147, 60);
            this.lb1Thongbao.Name = "lb1Thongbao";
            this.lb1Thongbao.Size = new System.Drawing.Size(0, 16);
            this.lb1Thongbao.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 1;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtDanhsach
            // 
            this.txtDanhsach.Location = new System.Drawing.Point(28, 30);
            this.txtDanhsach.Multiline = true;
            this.txtDanhsach.Name = "txtDanhsach";
            this.txtDanhsach.Size = new System.Drawing.Size(306, 168);
            this.txtDanhsach.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnThoat);
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.Location = new System.Drawing.Point(387, 85);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(359, 100);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(259, 46);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(143, 46);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(28, 46);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm vào DS";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chbDulich;
        private System.Windows.Forms.CheckBox chbMuasam;
        private System.Windows.Forms.CheckBox chbThethao;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.Label txtST;
        private System.Windows.Forms.Label txtGT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtNS;
        private System.Windows.Forms.TextBox txtHT;
        private System.Windows.Forms.TextBox txtMSV;
        private System.Windows.Forms.TextBox txtDanhsach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb1Thongbao;
    }
}

