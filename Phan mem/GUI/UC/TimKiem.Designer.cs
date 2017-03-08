namespace GUI.UC
{
    partial class TimKiem
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_tk = new GUI.ComponentForm.Thin_Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 221);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(819, 253);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm Kiếm Nhân Viên";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 124);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 20);
            this.textBox1.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(516, 122);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(260, 22);
            this.comboBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(451, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phòng Ban";
            // 
            // btn_tk
            // 
            this.btn_tk.Active = false;
            this.btn_tk.BackColor = System.Drawing.Color.Transparent;
            this.btn_tk.BoderColorDisable = System.Drawing.Color.Empty;
            this.btn_tk.BorderColorClick = System.Drawing.Color.Empty;
            this.btn_tk.BorderColorHover = System.Drawing.Color.Empty;
            this.btn_tk.BorderColorNomal = System.Drawing.Color.Green;
            this.btn_tk.InnerColorClick = System.Drawing.Color.Empty;
            this.btn_tk.InnerColorDisable = System.Drawing.Color.Empty;
            this.btn_tk.InnerColorHover = System.Drawing.Color.Empty;
            this.btn_tk.InnerColorNomal = System.Drawing.Color.Transparent;
            this.btn_tk.Location = new System.Drawing.Point(701, 165);
            this.btn_tk.Name = "btn_tk";
            this.btn_tk.Size = new System.Drawing.Size(75, 25);
            this.btn_tk.SizeBorder = 1;
            this.btn_tk.TabIndex = 6;
            this.btn_tk.Text = "Tìm Kiếm";
            this.btn_tk.TextAlignmentHorizontal = System.Drawing.StringAlignment.Center;
            this.btn_tk.TextAlignmentVertical = System.Drawing.StringAlignment.Center;
            this.btn_tk.TextColorClick = System.Drawing.Color.Empty;
            this.btn_tk.TextColorDisable = System.Drawing.Color.Empty;
            this.btn_tk.TextColorHover = System.Drawing.Color.Empty;
            this.btn_tk.TextColorNomal = System.Drawing.Color.Black;
            this.btn_tk.UseActive = false;
            this.btn_tk.UseBorderColorHoverClick = false;
            this.btn_tk.UseInnerColorHoverClick = false;
            this.btn_tk.UseTextColorHoverClick = false;
            // 
            // TimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_tk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TimKiem";
            this.Size = new System.Drawing.Size(822, 477);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private ComponentForm.Thin_Button btn_tk;
    }
}
