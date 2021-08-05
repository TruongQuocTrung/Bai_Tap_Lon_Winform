
namespace Bai_Tap_Lon_Winform
{
    partial class frmPhieuNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuNhap));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThemPhieuNhap = new System.Windows.Forms.Button();
            this.btnHuyPhieuNhap = new System.Windows.Forms.Button();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.txtMaNXB = new System.Windows.Forms.TextBox();
            this.txtMaPhieuNhap = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThemCTPN = new System.Windows.Forms.Button();
            this.btnHuyCTPN = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtSoLuongNhap = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtMaPN = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnXemDSPN = new System.Windows.Forms.Button();
            this.btnXemDSCTPN = new System.Windows.Forms.Button();
            this.GridViewPhieuNhap = new System.Windows.Forms.DataGridView();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(480, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phiếu nhập kho";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThemPhieuNhap);
            this.groupBox1.Controls.Add(this.btnHuyPhieuNhap);
            this.groupBox1.Controls.Add(this.dtpNgayNhap);
            this.groupBox1.Controls.Add(this.panel7);
            this.groupBox1.Controls.Add(this.txtMaPhieuNhap);
            this.groupBox1.Controls.Add(this.txtMaNXB);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 206);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phiếu nhập";
            // 
            // btnThemPhieuNhap
            // 
            this.btnThemPhieuNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnThemPhieuNhap.FlatAppearance.BorderSize = 0;
            this.btnThemPhieuNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemPhieuNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemPhieuNhap.Location = new System.Drawing.Point(173, 151);
            this.btnThemPhieuNhap.Name = "btnThemPhieuNhap";
            this.btnThemPhieuNhap.Size = new System.Drawing.Size(124, 35);
            this.btnThemPhieuNhap.TabIndex = 4;
            this.btnThemPhieuNhap.Text = "Thêm phiếu nhập";
            this.btnThemPhieuNhap.UseVisualStyleBackColor = false;
            this.btnThemPhieuNhap.Click += new System.EventHandler(this.btnThemPhieuNhap_Click);
            // 
            // btnHuyPhieuNhap
            // 
            this.btnHuyPhieuNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnHuyPhieuNhap.FlatAppearance.BorderSize = 0;
            this.btnHuyPhieuNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyPhieuNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyPhieuNhap.Location = new System.Drawing.Point(14, 151);
            this.btnHuyPhieuNhap.Name = "btnHuyPhieuNhap";
            this.btnHuyPhieuNhap.Size = new System.Drawing.Size(132, 35);
            this.btnHuyPhieuNhap.TabIndex = 4;
            this.btnHuyPhieuNhap.Text = "Hủy";
            this.btnHuyPhieuNhap.UseVisualStyleBackColor = false;
            this.btnHuyPhieuNhap.Click += new System.EventHandler(this.btnHuyPhieuNhap_Click);
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayNhap.Location = new System.Drawing.Point(130, 66);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(167, 22);
            this.dtpNgayNhap.TabIndex = 3;
            // 
            // txtMaNXB
            // 
            this.txtMaNXB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMaNXB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNXB.Location = new System.Drawing.Point(131, 106);
            this.txtMaNXB.Name = "txtMaNXB";
            this.txtMaNXB.Size = new System.Drawing.Size(167, 15);
            this.txtMaNXB.TabIndex = 2;
            // 
            // txtMaPhieuNhap
            // 
            this.txtMaPhieuNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMaPhieuNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaPhieuNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhieuNhap.Location = new System.Drawing.Point(130, 31);
            this.txtMaPhieuNhap.Name = "txtMaPhieuNhap";
            this.txtMaPhieuNhap.Size = new System.Drawing.Size(167, 15);
            this.txtMaPhieuNhap.TabIndex = 2;
            this.txtMaPhieuNhap.TextChanged += new System.EventHandler(this.txtMaPhieuNhap_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(130, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 1);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã NXB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã phiếu nhập";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThemCTPN);
            this.groupBox2.Controls.Add(this.btnHuyCTPN);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtGiaNhap);
            this.groupBox2.Controls.Add(this.panel6);
            this.groupBox2.Controls.Add(this.txtSoLuongNhap);
            this.groupBox2.Controls.Add(this.panel5);
            this.groupBox2.Controls.Add(this.txtMaSach);
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Controls.Add(this.txtMaPN);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(23, 290);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(311, 250);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết phiếu nhập";
            // 
            // btnThemCTPN
            // 
            this.btnThemCTPN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnThemCTPN.FlatAppearance.BorderSize = 0;
            this.btnThemCTPN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemCTPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemCTPN.Location = new System.Drawing.Point(173, 200);
            this.btnThemCTPN.Name = "btnThemCTPN";
            this.btnThemCTPN.Size = new System.Drawing.Size(125, 35);
            this.btnThemCTPN.TabIndex = 4;
            this.btnThemCTPN.Text = "Thêm CT Phiếu Nhập";
            this.btnThemCTPN.UseVisualStyleBackColor = false;
            this.btnThemCTPN.Click += new System.EventHandler(this.btnThemCTPN_Click);
            // 
            // btnHuyCTPN
            // 
            this.btnHuyCTPN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnHuyCTPN.FlatAppearance.BorderSize = 0;
            this.btnHuyCTPN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyCTPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyCTPN.Location = new System.Drawing.Point(14, 200);
            this.btnHuyCTPN.Name = "btnHuyCTPN";
            this.btnHuyCTPN.Size = new System.Drawing.Size(132, 35);
            this.btnHuyCTPN.TabIndex = 4;
            this.btnHuyCTPN.Text = "Hủy";
            this.btnHuyCTPN.UseVisualStyleBackColor = false;
            this.btnHuyCTPN.Click += new System.EventHandler(this.btnHuyCTPN_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Giá nhập";
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtGiaNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGiaNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaNhap.Location = new System.Drawing.Point(130, 152);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(167, 15);
            this.txtGiaNhap.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Red;
            this.panel6.Location = new System.Drawing.Point(130, 167);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(167, 1);
            this.panel6.TabIndex = 1;
            // 
            // txtSoLuongNhap
            // 
            this.txtSoLuongNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSoLuongNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoLuongNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuongNhap.Location = new System.Drawing.Point(130, 115);
            this.txtSoLuongNhap.Name = "txtSoLuongNhap";
            this.txtSoLuongNhap.Size = new System.Drawing.Size(167, 15);
            this.txtSoLuongNhap.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Red;
            this.panel5.Location = new System.Drawing.Point(130, 130);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(167, 1);
            this.panel5.TabIndex = 1;
            // 
            // txtMaSach
            // 
            this.txtMaSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMaSach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSach.Location = new System.Drawing.Point(130, 81);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(167, 15);
            this.txtMaSach.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Red;
            this.panel4.Location = new System.Drawing.Point(130, 96);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(167, 1);
            this.panel4.TabIndex = 1;
            // 
            // txtMaPN
            // 
            this.txtMaPN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMaPN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPN.Location = new System.Drawing.Point(130, 46);
            this.txtMaPN.Name = "txtMaPN";
            this.txtMaPN.Size = new System.Drawing.Size(167, 15);
            this.txtMaPN.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Location = new System.Drawing.Point(130, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(167, 1);
            this.panel2.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Số lượng nhập";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã sách";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã phiếu nhập";
            // 
            // btnXemDSPN
            // 
            this.btnXemDSPN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnXemDSPN.FlatAppearance.BorderSize = 0;
            this.btnXemDSPN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemDSPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemDSPN.Location = new System.Drawing.Point(357, 544);
            this.btnXemDSPN.Name = "btnXemDSPN";
            this.btnXemDSPN.Size = new System.Drawing.Size(137, 42);
            this.btnXemDSPN.TabIndex = 3;
            this.btnXemDSPN.Text = "Xem DS phiếu nhập";
            this.btnXemDSPN.UseVisualStyleBackColor = false;
            this.btnXemDSPN.Click += new System.EventHandler(this.btnXemDSPN_Click);
            // 
            // btnXemDSCTPN
            // 
            this.btnXemDSCTPN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnXemDSCTPN.FlatAppearance.BorderSize = 0;
            this.btnXemDSCTPN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemDSCTPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemDSCTPN.Location = new System.Drawing.Point(516, 544);
            this.btnXemDSCTPN.Name = "btnXemDSCTPN";
            this.btnXemDSCTPN.Size = new System.Drawing.Size(145, 42);
            this.btnXemDSCTPN.TabIndex = 3;
            this.btnXemDSCTPN.Text = "Xem DS CT phiếu nhập";
            this.btnXemDSCTPN.UseVisualStyleBackColor = false;
            this.btnXemDSCTPN.Click += new System.EventHandler(this.btnXemDSCTPN_Click);
            // 
            // GridViewPhieuNhap
            // 
            this.GridViewPhieuNhap.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GridViewPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewPhieuNhap.Location = new System.Drawing.Point(357, 100);
            this.GridViewPhieuNhap.Name = "GridViewPhieuNhap";
            this.GridViewPhieuNhap.Size = new System.Drawing.Size(664, 428);
            this.GridViewPhieuNhap.TabIndex = 4;
            this.GridViewPhieuNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewPhieuNhap_CellClick);
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnTim.FlatAppearance.BorderSize = 0;
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(357, 67);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(145, 23);
            this.btnTim.TabIndex = 5;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(533, 70);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(488, 20);
            this.txtTim.TabIndex = 6;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnCapNhat.FlatAppearance.BorderSize = 0;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(684, 544);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(110, 42);
            this.btnCapNhat.TabIndex = 3;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(815, 544);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(110, 42);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(967, 552);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(54, 34);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 7;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Red;
            this.panel7.Location = new System.Drawing.Point(129, 123);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(167, 1);
            this.panel7.TabIndex = 1;
            // 
            // frmPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1033, 598);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.GridViewPhieuNhap);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnXemDSCTPN);
            this.Controls.Add(this.btnXemDSPN);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1033, 598);
            this.MinimumSize = new System.Drawing.Size(1033, 598);
            this.Name = "frmPhieuNhap";
            this.Text = "frmPhieuNhap";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.TextBox txtMaNXB;
        private System.Windows.Forms.TextBox txtMaPhieuNhap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThemPhieuNhap;
        private System.Windows.Forms.Button btnHuyPhieuNhap;
        private System.Windows.Forms.Button btnThemCTPN;
        private System.Windows.Forms.Button btnHuyCTPN;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtSoLuongNhap;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtMaPN;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnXemDSPN;
        private System.Windows.Forms.Button btnXemDSCTPN;
        private System.Windows.Forms.DataGridView GridViewPhieuNhap;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.Panel panel7;
    }
}