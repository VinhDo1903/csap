namespace btdc10_dịch_vụ_khám_chữa_răng_
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chkCaovoi = new System.Windows.Forms.CheckBox();
            this.chkTaytrang = new System.Windows.Forms.CheckBox();
            this.chkChuphinhrang = new System.Windows.Forms.CheckBox();
            this.numTramrang = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnTinhtien = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numTramrang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(130, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dental Payment Form";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(461, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "100.000đ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(449, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "1.200.000đ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(461, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "200.000đ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(447, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "80.000đ/cái";
            // 
            // chkCaovoi
            // 
            this.chkCaovoi.AutoSize = true;
            this.chkCaovoi.Location = new System.Drawing.Point(50, 184);
            this.chkCaovoi.Name = "chkCaovoi";
            this.chkCaovoi.Size = new System.Drawing.Size(81, 21);
            this.chkCaovoi.TabIndex = 5;
            this.chkCaovoi.Text = " Cạo vôi";
            this.chkCaovoi.UseVisualStyleBackColor = true;
            this.chkCaovoi.CheckedChanged += new System.EventHandler(this.chkCaovoi_CheckedChanged);
            // 
            // chkTaytrang
            // 
            this.chkTaytrang.AutoSize = true;
            this.chkTaytrang.Location = new System.Drawing.Point(50, 226);
            this.chkTaytrang.Name = "chkTaytrang";
            this.chkTaytrang.Size = new System.Drawing.Size(91, 21);
            this.chkTaytrang.TabIndex = 6;
            this.chkTaytrang.Text = "Tẩy trắng";
            this.chkTaytrang.UseVisualStyleBackColor = true;
            this.chkTaytrang.CheckedChanged += new System.EventHandler(this.chkTaytrang_CheckedChanged);
            // 
            // chkChuphinhrang
            // 
            this.chkChuphinhrang.AutoSize = true;
            this.chkChuphinhrang.Location = new System.Drawing.Point(50, 272);
            this.chkChuphinhrang.Name = "chkChuphinhrang";
            this.chkChuphinhrang.Size = new System.Drawing.Size(127, 21);
            this.chkChuphinhrang.TabIndex = 7;
            this.chkChuphinhrang.Text = "Chụp hình răng";
            this.chkChuphinhrang.UseVisualStyleBackColor = true;
            this.chkChuphinhrang.CheckedChanged += new System.EventHandler(this.chkChuphinhrang_CheckedChanged);
            // 
            // numTramrang
            // 
            this.numTramrang.Location = new System.Drawing.Point(136, 316);
            this.numTramrang.Name = "numTramrang";
            this.numTramrang.Size = new System.Drawing.Size(120, 22);
            this.numTramrang.TabIndex = 8;
            this.numTramrang.ValueChanged += new System.EventHandler(this.numTramrang_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Trám răng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tên khách hàng";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(180, 70);
            this.txtTen.Multiline = true;
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(183, 27);
            this.txtTen.TabIndex = 11;
            this.txtTen.TextChanged += new System.EventHandler(this.txtTen_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(303, 397);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Tổng tiền";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(384, 386);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(123, 28);
            this.txtTotal.TabIndex = 13;
            this.txtTotal.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnTinhtien
            // 
            this.btnTinhtien.Location = new System.Drawing.Point(190, 439);
            this.btnTinhtien.Name = "btnTinhtien";
            this.btnTinhtien.Size = new System.Drawing.Size(85, 29);
            this.btnTinhtien.TabIndex = 14;
            this.btnTinhtien.Text = "Tính tiền";
            this.btnTinhtien.UseVisualStyleBackColor = true;
            this.btnTinhtien.Click += new System.EventHandler(this.btnTinhtien_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(306, 439);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(85, 29);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(422, 439);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(85, 29);
            this.btnThoat.TabIndex = 16;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(69, 439);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(89, 29);
            this.btnIn.TabIndex = 17;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(180, 116);
            this.txtSDT.Multiline = true;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(183, 27);
            this.txtSDT.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Số điện thoại";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 487);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(494, 195);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 694);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnTinhtien);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numTramrang);
            this.Controls.Add(this.chkChuphinhrang);
            this.Controls.Add(this.chkTaytrang);
            this.Controls.Add(this.chkCaovoi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numTramrang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkCaovoi;
        private System.Windows.Forms.CheckBox chkTaytrang;
        private System.Windows.Forms.CheckBox chkChuphinhrang;
        private System.Windows.Forms.NumericUpDown numTramrang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnTinhtien;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

