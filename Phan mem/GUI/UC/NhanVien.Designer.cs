namespace GUI.UC
{
    partial class NhanVien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvNV = new System.Windows.Forms.DataGridView();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txttennv = new System.Windows.Forms.TextBox();
            this.txtdc = new System.Windows.Forms.TextBox();
            this.datepk = new System.Windows.Forms.DateTimePicker();
            this.com_gt = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtluong = new System.Windows.Forms.TextBox();
            this.com_pb = new System.Windows.Forms.ComboBox();
            this.btn_them = new GUI.ComponentForm.Thin_Button();
            this.btn_sua = new GUI.ComponentForm.Thin_Button();
            this.btn_xoa = new GUI.ComponentForm.Thin_Button();
            this.btn_capnhat = new GUI.ComponentForm.Thin_Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNV
            // 
            this.dgvNV.AllowUserToAddRows = false;
            this.dgvNV.AllowUserToDeleteRows = false;
            this.dgvNV.AllowUserToResizeRows = false;
            this.dgvNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNV.Location = new System.Drawing.Point(3, 273);
            this.dgvNV.Name = "dgvNV";
            this.dgvNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNV.Size = new System.Drawing.Size(819, 241);
            this.dgvNV.TabIndex = 0;
            this.dgvNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNV_CellClick);
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(108, 17);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(207, 20);
            this.txtmanv.TabIndex = 1;
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(530, 51);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(207, 20);
            this.txtsdt.TabIndex = 2;
            // 
            // txttennv
            // 
            this.txttennv.Location = new System.Drawing.Point(108, 54);
            this.txttennv.Name = "txttennv";
            this.txttennv.Size = new System.Drawing.Size(207, 20);
            this.txttennv.TabIndex = 4;
            this.txttennv.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtdc
            // 
            this.txtdc.Location = new System.Drawing.Point(530, 17);
            this.txtdc.Name = "txtdc";
            this.txtdc.Size = new System.Drawing.Size(207, 20);
            this.txtdc.TabIndex = 5;
            // 
            // datepk
            // 
            this.datepk.Location = new System.Drawing.Point(108, 100);
            this.datepk.Name = "datepk";
            this.datepk.Size = new System.Drawing.Size(207, 20);
            this.datepk.TabIndex = 6;
            // 
            // com_gt
            // 
            this.com_gt.FormattingEnabled = true;
            this.com_gt.Items.AddRange(new object[] {
            "Nam\t",
            "Nữ"});
            this.com_gt.Location = new System.Drawing.Point(108, 145);
            this.com_gt.Name = "com_gt";
            this.com_gt.Size = new System.Drawing.Size(207, 22);
            this.com_gt.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 14);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã NV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 14);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tên NV";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 14);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ngày Sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 14);
            this.label4.TabIndex = 11;
            this.label4.Text = "Giới Tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(464, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 14);
            this.label5.TabIndex = 12;
            this.label5.Text = "Địa Chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(464, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 14);
            this.label6.TabIndex = 13;
            this.label6.Text = "SDT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(464, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 14);
            this.label7.TabIndex = 14;
            this.label7.Text = "Lương";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(464, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 14);
            this.label8.TabIndex = 15;
            this.label8.Text = "Phòng Ban";
            // 
            // txtluong
            // 
            this.txtluong.Location = new System.Drawing.Point(530, 94);
            this.txtluong.Name = "txtluong";
            this.txtluong.Size = new System.Drawing.Size(207, 20);
            this.txtluong.TabIndex = 16;
            // 
            // com_pb
            // 
            this.com_pb.FormattingEnabled = true;
            this.com_pb.Location = new System.Drawing.Point(530, 145);
            this.com_pb.Name = "com_pb";
            this.com_pb.Size = new System.Drawing.Size(207, 22);
            this.com_pb.TabIndex = 17;
            // 
            // btn_them
            // 
            this.btn_them.Active = false;
            this.btn_them.BackColor = System.Drawing.Color.Transparent;
            this.btn_them.BoderColorDisable = System.Drawing.Color.Empty;
            this.btn_them.BorderColorClick = System.Drawing.Color.Empty;
            this.btn_them.BorderColorHover = System.Drawing.Color.Empty;
            this.btn_them.BorderColorNomal = System.Drawing.Color.Green;
            this.btn_them.InnerColorClick = System.Drawing.Color.Empty;
            this.btn_them.InnerColorDisable = System.Drawing.Color.Empty;
            this.btn_them.InnerColorHover = System.Drawing.Color.Empty;
            this.btn_them.InnerColorNomal = System.Drawing.Color.Transparent;
            this.btn_them.Location = new System.Drawing.Point(57, 226);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 25);
            this.btn_them.SizeBorder = 1;
            this.btn_them.TabIndex = 18;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextAlignmentHorizontal = System.Drawing.StringAlignment.Center;
            this.btn_them.TextAlignmentVertical = System.Drawing.StringAlignment.Center;
            this.btn_them.TextColorClick = System.Drawing.Color.Empty;
            this.btn_them.TextColorDisable = System.Drawing.Color.Empty;
            this.btn_them.TextColorHover = System.Drawing.Color.Empty;
            this.btn_them.TextColorNomal = System.Drawing.Color.Black;
            this.btn_them.UseActive = false;
            this.btn_them.UseBorderColorHoverClick = false;
            this.btn_them.UseInnerColorHoverClick = false;
            this.btn_them.UseTextColorHoverClick = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Active = false;
            this.btn_sua.BackColor = System.Drawing.Color.Transparent;
            this.btn_sua.BoderColorDisable = System.Drawing.Color.Empty;
            this.btn_sua.BorderColorClick = System.Drawing.Color.Empty;
            this.btn_sua.BorderColorHover = System.Drawing.Color.Empty;
            this.btn_sua.BorderColorNomal = System.Drawing.Color.Green;
            this.btn_sua.InnerColorClick = System.Drawing.Color.Empty;
            this.btn_sua.InnerColorDisable = System.Drawing.Color.Empty;
            this.btn_sua.InnerColorHover = System.Drawing.Color.Empty;
            this.btn_sua.InnerColorNomal = System.Drawing.Color.Transparent;
            this.btn_sua.Location = new System.Drawing.Point(287, 226);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 25);
            this.btn_sua.SizeBorder = 1;
            this.btn_sua.TabIndex = 19;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.TextAlignmentHorizontal = System.Drawing.StringAlignment.Center;
            this.btn_sua.TextAlignmentVertical = System.Drawing.StringAlignment.Center;
            this.btn_sua.TextColorClick = System.Drawing.Color.Empty;
            this.btn_sua.TextColorDisable = System.Drawing.Color.Empty;
            this.btn_sua.TextColorHover = System.Drawing.Color.Empty;
            this.btn_sua.TextColorNomal = System.Drawing.Color.Black;
            this.btn_sua.UseActive = false;
            this.btn_sua.UseBorderColorHoverClick = false;
            this.btn_sua.UseInnerColorHoverClick = false;
            this.btn_sua.UseTextColorHoverClick = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Active = false;
            this.btn_xoa.BackColor = System.Drawing.Color.Transparent;
            this.btn_xoa.BoderColorDisable = System.Drawing.Color.Empty;
            this.btn_xoa.BorderColorClick = System.Drawing.Color.Empty;
            this.btn_xoa.BorderColorHover = System.Drawing.Color.Empty;
            this.btn_xoa.BorderColorNomal = System.Drawing.Color.Green;
            this.btn_xoa.InnerColorClick = System.Drawing.Color.Empty;
            this.btn_xoa.InnerColorDisable = System.Drawing.Color.Empty;
            this.btn_xoa.InnerColorHover = System.Drawing.Color.Empty;
            this.btn_xoa.InnerColorNomal = System.Drawing.Color.Transparent;
            this.btn_xoa.Location = new System.Drawing.Point(486, 226);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 25);
            this.btn_xoa.SizeBorder = 1;
            this.btn_xoa.TabIndex = 20;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextAlignmentHorizontal = System.Drawing.StringAlignment.Center;
            this.btn_xoa.TextAlignmentVertical = System.Drawing.StringAlignment.Center;
            this.btn_xoa.TextColorClick = System.Drawing.Color.Empty;
            this.btn_xoa.TextColorDisable = System.Drawing.Color.Empty;
            this.btn_xoa.TextColorHover = System.Drawing.Color.Empty;
            this.btn_xoa.TextColorNomal = System.Drawing.Color.Black;
            this.btn_xoa.UseActive = false;
            this.btn_xoa.UseBorderColorHoverClick = false;
            this.btn_xoa.UseInnerColorHoverClick = false;
            this.btn_xoa.UseTextColorHoverClick = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.Active = false;
            this.btn_capnhat.BackColor = System.Drawing.Color.Transparent;
            this.btn_capnhat.BoderColorDisable = System.Drawing.Color.Empty;
            this.btn_capnhat.BorderColorClick = System.Drawing.Color.Empty;
            this.btn_capnhat.BorderColorHover = System.Drawing.Color.Empty;
            this.btn_capnhat.BorderColorNomal = System.Drawing.Color.Green;
            this.btn_capnhat.InnerColorClick = System.Drawing.Color.Empty;
            this.btn_capnhat.InnerColorDisable = System.Drawing.Color.Empty;
            this.btn_capnhat.InnerColorHover = System.Drawing.Color.Empty;
            this.btn_capnhat.InnerColorNomal = System.Drawing.Color.Transparent;
            this.btn_capnhat.Location = new System.Drawing.Point(694, 226);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(75, 25);
            this.btn_capnhat.SizeBorder = 1;
            this.btn_capnhat.TabIndex = 21;
            this.btn_capnhat.Text = "Cập Nhật";
            this.btn_capnhat.TextAlignmentHorizontal = System.Drawing.StringAlignment.Center;
            this.btn_capnhat.TextAlignmentVertical = System.Drawing.StringAlignment.Center;
            this.btn_capnhat.TextColorClick = System.Drawing.Color.Empty;
            this.btn_capnhat.TextColorDisable = System.Drawing.Color.Empty;
            this.btn_capnhat.TextColorHover = System.Drawing.Color.Empty;
            this.btn_capnhat.TextColorNomal = System.Drawing.Color.Black;
            this.btn_capnhat.UseActive = false;
            this.btn_capnhat.UseBorderColorHoverClick = false;
            this.btn_capnhat.UseInnerColorHoverClick = false;
            this.btn_capnhat.UseTextColorHoverClick = false;
            this.btn_capnhat.Click += new System.EventHandler(this.btn_capnhat_Click);
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_capnhat);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.com_pb);
            this.Controls.Add(this.txtluong);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.com_gt);
            this.Controls.Add(this.datepk);
            this.Controls.Add(this.txtdc);
            this.Controls.Add(this.txttennv);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.txtmanv);
            this.Controls.Add(this.dgvNV);
            this.Name = "NhanVien";
            this.Size = new System.Drawing.Size(822, 515);
            this.Load += new System.EventHandler(this.NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNV;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txttennv;
        private System.Windows.Forms.TextBox txtdc;
        private System.Windows.Forms.DateTimePicker datepk;
        private System.Windows.Forms.ComboBox com_gt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtluong;
        private System.Windows.Forms.ComboBox com_pb;
        private ComponentForm.Thin_Button btn_them;
        private ComponentForm.Thin_Button btn_sua;
        private ComponentForm.Thin_Button btn_xoa;
        private ComponentForm.Thin_Button btn_capnhat;
    }
}
