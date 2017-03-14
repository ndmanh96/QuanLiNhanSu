namespace GUI.UC
{
    partial class PhongBan
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
            this.dgvPB = new System.Windows.Forms.DataGridView();
            this.txtmapb = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txttenpb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_capnhat = new GUI.ComponentForm.Thin_Button();
            this.btn_xoa = new GUI.ComponentForm.Thin_Button();
            this.btn_sua = new GUI.ComponentForm.Thin_Button();
            this.btn_them = new GUI.ComponentForm.Thin_Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPB)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPB
            // 
            this.dgvPB.AllowUserToAddRows = false;
            this.dgvPB.AllowUserToDeleteRows = false;
            this.dgvPB.AllowUserToResizeRows = false;
            this.dgvPB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPB.Location = new System.Drawing.Point(0, 264);
            this.dgvPB.Name = "dgvPB";
            this.dgvPB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPB.Size = new System.Drawing.Size(819, 248);
            this.dgvPB.TabIndex = 0;
            this.dgvPB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPB_CellClick);
            // 
            // txtmapb
            // 
            this.txtmapb.Location = new System.Drawing.Point(110, 26);
            this.txtmapb.Name = "txtmapb";
            this.txtmapb.Size = new System.Drawing.Size(199, 20);
            this.txtmapb.TabIndex = 1;
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(110, 161);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(199, 20);
            this.txtsdt.TabIndex = 2;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(110, 114);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(199, 20);
            this.txtemail.TabIndex = 3;
            // 
            // txttenpb
            // 
            this.txttenpb.Location = new System.Drawing.Point(110, 69);
            this.txttenpb.Name = "txttenpb";
            this.txttenpb.Size = new System.Drawing.Size(199, 20);
            this.txttenpb.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(39, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã PB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(39, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên PB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(39, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(39, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "SDT";
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
            this.btn_capnhat.Location = new System.Drawing.Point(531, 208);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(75, 25);
            this.btn_capnhat.SizeBorder = 1;
            this.btn_capnhat.TabIndex = 12;
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
            this.btn_xoa.Location = new System.Drawing.Point(362, 208);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 25);
            this.btn_xoa.SizeBorder = 1;
            this.btn_xoa.TabIndex = 11;
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
            this.btn_sua.Location = new System.Drawing.Point(196, 208);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 25);
            this.btn_sua.SizeBorder = 1;
            this.btn_sua.TabIndex = 10;
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
            this.btn_them.Location = new System.Drawing.Point(42, 208);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 25);
            this.btn_them.SizeBorder = 1;
            this.btn_them.TabIndex = 9;
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
            // PhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_capnhat);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttenpb);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.txtmapb);
            this.Controls.Add(this.dgvPB);
            this.Name = "PhongBan";
            this.Size = new System.Drawing.Size(822, 515);
            this.Load += new System.EventHandler(this.PhongBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPB;
        private System.Windows.Forms.TextBox txtmapb;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txttenpb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private ComponentForm.Thin_Button btn_them;
        private ComponentForm.Thin_Button btn_sua;
        private ComponentForm.Thin_Button btn_xoa;
        private ComponentForm.Thin_Button btn_capnhat;
    }
}
