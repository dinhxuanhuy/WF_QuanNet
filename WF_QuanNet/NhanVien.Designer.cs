﻿namespace WF_QuanNet
{
    partial class frmNhanVien
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.rbChi = new System.Windows.Forms.RadioButton();
            this.rbThu = new System.Windows.Forms.RadioButton();
            this.txtNhanvien = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtProfitOtherMonth = new System.Windows.Forms.TextBox();
            this.gbKhoang = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tpKt = new System.Windows.Forms.DateTimePicker();
            this.tpBd = new System.Windows.Forms.DateTimePicker();
            this.txtOut = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProfit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIn = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tpTe = new System.Windows.Forms.DateTimePicker();
            this.tpTs = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProfitMonth = new System.Windows.Forms.TextBox();
            this.gbHai = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rbHai = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbKhoang = new System.Windows.Forms.RadioButton();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.gbKhoang.SuspendLayout();
            this.gbHai.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnReset);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.rbChi);
            this.groupBox2.Controls.Add(this.rbThu);
            this.groupBox2.Controls.Add(this.txtNhanvien);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox2.Location = new System.Drawing.Point(8, 46);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1001, 70);
            this.groupBox2.TabIndex = 73;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bộ lọc";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnReset.Location = new System.Drawing.Point(812, 25);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(167, 37);
            this.btnReset.TabIndex = 72;
            this.btnReset.Text = "Làm mới bộ lọc";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(8, 31);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 25);
            this.label12.TabIndex = 65;
            this.label12.Text = "Nhân viên";
            // 
            // rbChi
            // 
            this.rbChi.AutoSize = true;
            this.rbChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbChi.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rbChi.Location = new System.Drawing.Point(661, 28);
            this.rbChi.Margin = new System.Windows.Forms.Padding(4);
            this.rbChi.Name = "rbChi";
            this.rbChi.Size = new System.Drawing.Size(63, 29);
            this.rbChi.TabIndex = 71;
            this.rbChi.TabStop = true;
            this.rbChi.Text = "Chi";
            this.rbChi.UseVisualStyleBackColor = true;
            // 
            // rbThu
            // 
            this.rbThu.AutoSize = true;
            this.rbThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThu.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rbThu.Location = new System.Drawing.Point(565, 28);
            this.rbThu.Margin = new System.Windows.Forms.Padding(4);
            this.rbThu.Name = "rbThu";
            this.rbThu.Size = new System.Drawing.Size(68, 29);
            this.rbThu.TabIndex = 69;
            this.rbThu.TabStop = true;
            this.rbThu.Text = "Thu";
            this.rbThu.UseVisualStyleBackColor = true;
            // 
            // txtNhanvien
            // 
            this.txtNhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhanvien.Location = new System.Drawing.Point(121, 27);
            this.txtNhanvien.Margin = new System.Windows.Forms.Padding(4);
            this.txtNhanvien.Name = "txtNhanvien";
            this.txtNhanvien.Size = new System.Drawing.Size(404, 30);
            this.txtNhanvien.TabIndex = 70;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(-408, 38);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 25);
            this.label9.TabIndex = 65;
            this.label9.Text = "Nhân viên";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(23, 60);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 25);
            this.label11.TabIndex = 72;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(1116, 681);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(181, 37);
            this.btnPrint.TabIndex = 75;
            this.btnPrint.Text = "In hóa đơn";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // txtProfitOtherMonth
            // 
            this.txtProfitOtherMonth.Enabled = false;
            this.txtProfitOtherMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfitOtherMonth.Location = new System.Drawing.Point(113, 160);
            this.txtProfitOtherMonth.Margin = new System.Windows.Forms.Padding(4);
            this.txtProfitOtherMonth.Name = "txtProfitOtherMonth";
            this.txtProfitOtherMonth.Size = new System.Drawing.Size(211, 26);
            this.txtProfitOtherMonth.TabIndex = 64;
            this.txtProfitOtherMonth.Text = "0";
            this.txtProfitOtherMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gbKhoang
            // 
            this.gbKhoang.Controls.Add(this.label1);
            this.gbKhoang.Controls.Add(this.tpKt);
            this.gbKhoang.Controls.Add(this.tpBd);
            this.gbKhoang.Controls.Add(this.txtOut);
            this.gbKhoang.Controls.Add(this.label2);
            this.gbKhoang.Controls.Add(this.label5);
            this.gbKhoang.Controls.Add(this.txtProfit);
            this.gbKhoang.Controls.Add(this.label3);
            this.gbKhoang.Controls.Add(this.label4);
            this.gbKhoang.Controls.Add(this.txtIn);
            this.gbKhoang.Enabled = false;
            this.gbKhoang.Location = new System.Drawing.Point(1050, 72);
            this.gbKhoang.Margin = new System.Windows.Forms.Padding(4);
            this.gbKhoang.Name = "gbKhoang";
            this.gbKhoang.Padding = new System.Windows.Forms.Padding(4);
            this.gbKhoang.Size = new System.Drawing.Size(345, 246);
            this.gbKhoang.TabIndex = 72;
            this.gbKhoang.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(23, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 56;
            this.label1.Text = "Từ ngày";
            // 
            // tpKt
            // 
            this.tpKt.CustomFormat = "dd/MM/yyyy HH:mm";
            this.tpKt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpKt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tpKt.Location = new System.Drawing.Point(113, 69);
            this.tpKt.Margin = new System.Windows.Forms.Padding(4);
            this.tpKt.Name = "tpKt";
            this.tpKt.Size = new System.Drawing.Size(211, 26);
            this.tpKt.TabIndex = 54;
            this.tpKt.Value = new System.DateTime(2024, 5, 26, 22, 11, 0, 0);
            // 
            // tpBd
            // 
            this.tpBd.CustomFormat = "dd/MM/yyyy HH:mm";
            this.tpBd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpBd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tpBd.Location = new System.Drawing.Point(113, 28);
            this.tpBd.Margin = new System.Windows.Forms.Padding(4);
            this.tpBd.Name = "tpBd";
            this.tpBd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tpBd.Size = new System.Drawing.Size(211, 26);
            this.tpBd.TabIndex = 55;
            this.tpBd.Value = new System.DateTime(2024, 5, 25, 19, 10, 0, 0);
            // 
            // txtOut
            // 
            this.txtOut.Enabled = false;
            this.txtOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOut.Location = new System.Drawing.Point(113, 150);
            this.txtOut.Margin = new System.Windows.Forms.Padding(4);
            this.txtOut.Name = "txtOut";
            this.txtOut.Size = new System.Drawing.Size(211, 26);
            this.txtOut.TabIndex = 64;
            this.txtOut.Text = "0";
            this.txtOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(56, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 57;
            this.label2.Text = "Đến";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(19, 153);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 63;
            this.label5.Text = "Tổng chi";
            // 
            // txtProfit
            // 
            this.txtProfit.Enabled = false;
            this.txtProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfit.Location = new System.Drawing.Point(113, 191);
            this.txtProfit.Margin = new System.Windows.Forms.Padding(4);
            this.txtProfit.Name = "txtProfit";
            this.txtProfit.Size = new System.Drawing.Size(211, 26);
            this.txtProfit.TabIndex = 62;
            this.txtProfit.Text = "0";
            this.txtProfit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(19, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 59;
            this.label3.Text = "Tổng thu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(12, 192);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 61;
            this.label4.Text = "Lợi nhuận";
            // 
            // txtIn
            // 
            this.txtIn.Enabled = false;
            this.txtIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIn.Location = new System.Drawing.Point(113, 110);
            this.txtIn.Margin = new System.Windows.Forms.Padding(4);
            this.txtIn.Name = "txtIn";
            this.txtIn.Size = new System.Drawing.Size(211, 26);
            this.txtIn.TabIndex = 60;
            this.txtIn.Text = "0";
            this.txtIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(12, 164);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 20);
            this.label8.TabIndex = 63;
            this.label8.Text = "Lợi nhuận";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(28, 41);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 56;
            this.label6.Text = "Tháng";
            // 
            // tpTe
            // 
            this.tpTe.CustomFormat = "MM/yyyy";
            this.tpTe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpTe.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tpTe.Location = new System.Drawing.Point(113, 126);
            this.tpTe.Margin = new System.Windows.Forms.Padding(4);
            this.tpTe.Name = "tpTe";
            this.tpTe.Size = new System.Drawing.Size(211, 26);
            this.tpTe.TabIndex = 54;
            this.tpTe.Value = new System.DateTime(2024, 5, 26, 22, 11, 0, 0);
            // 
            // tpTs
            // 
            this.tpTs.CustomFormat = "MM/yyyy ";
            this.tpTs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpTs.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tpTs.Location = new System.Drawing.Point(113, 34);
            this.tpTs.Margin = new System.Windows.Forms.Padding(4);
            this.tpTs.Name = "tpTs";
            this.tpTs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tpTs.Size = new System.Drawing.Size(211, 26);
            this.tpTs.TabIndex = 55;
            this.tpTs.Value = new System.DateTime(2024, 5, 25, 19, 10, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(32, 132);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 57;
            this.label7.Text = "Tháng";
            // 
            // txtProfitMonth
            // 
            this.txtProfitMonth.Enabled = false;
            this.txtProfitMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfitMonth.Location = new System.Drawing.Point(113, 69);
            this.txtProfitMonth.Margin = new System.Windows.Forms.Padding(4);
            this.txtProfitMonth.Name = "txtProfitMonth";
            this.txtProfitMonth.Size = new System.Drawing.Size(211, 26);
            this.txtProfitMonth.TabIndex = 62;
            this.txtProfitMonth.Text = "0";
            this.txtProfitMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gbHai
            // 
            this.gbHai.Controls.Add(this.txtProfitOtherMonth);
            this.gbHai.Controls.Add(this.label8);
            this.gbHai.Controls.Add(this.label6);
            this.gbHai.Controls.Add(this.tpTe);
            this.gbHai.Controls.Add(this.tpTs);
            this.gbHai.Controls.Add(this.label7);
            this.gbHai.Controls.Add(this.txtProfitMonth);
            this.gbHai.Controls.Add(this.label10);
            this.gbHai.Enabled = false;
            this.gbHai.Location = new System.Drawing.Point(1050, 424);
            this.gbHai.Margin = new System.Windows.Forms.Padding(4);
            this.gbHai.Name = "gbHai";
            this.gbHai.Padding = new System.Windows.Forms.Padding(4);
            this.gbHai.Size = new System.Drawing.Size(345, 226);
            this.gbHai.TabIndex = 73;
            this.gbHai.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(12, 73);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 20);
            this.label10.TabIndex = 61;
            this.label10.Text = "Lợi nhuận";
            // 
            // rbHai
            // 
            this.rbHai.AutoSize = true;
            this.rbHai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHai.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rbHai.Location = new System.Drawing.Point(1050, 387);
            this.rbHai.Margin = new System.Windows.Forms.Padding(4);
            this.rbHai.Name = "rbHai";
            this.rbHai.Size = new System.Drawing.Size(213, 29);
            this.rbHai.TabIndex = 74;
            this.rbHai.TabStop = true;
            this.rbHai.Text = "Thống kê theo tháng";
            this.rbHai.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvNhanVien);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.Location = new System.Drawing.Point(3, -23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1017, 757);
            this.groupBox1.TabIndex = 71;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lịch sử thanh toán";
            // 
            // rbKhoang
            // 
            this.rbKhoang.AutoSize = true;
            this.rbKhoang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbKhoang.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rbKhoang.Location = new System.Drawing.Point(1050, 35);
            this.rbKhoang.Margin = new System.Windows.Forms.Padding(4);
            this.rbKhoang.Name = "rbKhoang";
            this.rbKhoang.Size = new System.Drawing.Size(229, 29);
            this.rbKhoang.TabIndex = 70;
            this.rbKhoang.TabStop = true;
            this.rbKhoang.Text = "Thống kê theo khoảng";
            this.rbKhoang.UseVisualStyleBackColor = true;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AllowUserToDeleteRows = false;
            this.dgvNhanVien.AllowUserToOrderColumns = true;
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.HoTen,
            this.SDT,
            this.DiaChi,
            this.GioiTinh,
            this.NgaySinh});
            this.dgvNhanVien.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvNhanVien.Location = new System.Drawing.Point(9, 118);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.RowTemplate.Height = 24;
            this.dgvNhanVien.Size = new System.Drawing.Size(1015, 633);
            this.dgvNhanVien.TabIndex = 74;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "MaNV";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "HoTen";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SDT";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "DiaChi";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "GioiTinh";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "NgaySinh";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1398, 710);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.gbKhoang);
            this.Controls.Add(this.gbHai);
            this.Controls.Add(this.rbHai);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rbKhoang);
            this.Name = "frmNhanVien";
            this.Text = "NhanVien";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbKhoang.ResumeLayout(false);
            this.gbKhoang.PerformLayout();
            this.gbHai.ResumeLayout(false);
            this.gbHai.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton rbChi;
        private System.Windows.Forms.RadioButton rbThu;
        private System.Windows.Forms.TextBox txtNhanvien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtProfitOtherMonth;
        private System.Windows.Forms.GroupBox gbKhoang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker tpKt;
        private System.Windows.Forms.DateTimePicker tpBd;
        private System.Windows.Forms.TextBox txtOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProfit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker tpTe;
        private System.Windows.Forms.DateTimePicker tpTs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProfitMonth;
        private System.Windows.Forms.GroupBox gbHai;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rbHai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbKhoang;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
    }
}