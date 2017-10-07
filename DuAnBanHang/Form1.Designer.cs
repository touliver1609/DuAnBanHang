namespace DuAnBanHang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btSearch = new System.Windows.Forms.Button();
            this.ckbAo = new System.Windows.Forms.CheckedListBox();
            this.gbAo = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbQuan = new System.Windows.Forms.GroupBox();
            this.ckbQuan = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.panel1.SuspendLayout();
            this.gbAo.SuspendLayout();
            this.gbQuan.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.gbQuan);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.gbAo);
            this.panel1.Controls.Add(this.btSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 533);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // btSearch
            // 
            this.btSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.btSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btSearch.Location = new System.Drawing.Point(343, 403);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(157, 41);
            this.btSearch.TabIndex = 1;
            this.btSearch.Text = "Tìm kiếm";
            this.btSearch.UseVisualStyleBackColor = true;
            // 
            // ckbAo
            // 
            this.ckbAo.BackColor = System.Drawing.SystemColors.Control;
            this.ckbAo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ckbAo.Cursor = System.Windows.Forms.Cursors.Default;
            this.ckbAo.Font = new System.Drawing.Font("Curlz MT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbAo.FormattingEnabled = true;
            this.ckbAo.Items.AddRange(new object[] {
            "Áo kiểu",
            "Áo thun",
            "Áo khoác",
            "Áo hoodie",
            "Áo vest",
            "Áo sơ mi"});
            this.ckbAo.Location = new System.Drawing.Point(38, 44);
            this.ckbAo.Name = "ckbAo";
            this.ckbAo.Size = new System.Drawing.Size(171, 168);
            this.ckbAo.TabIndex = 3;
            // 
            // gbAo
            // 
            this.gbAo.Controls.Add(this.ckbAo);
            this.gbAo.Font = new System.Drawing.Font("Ravie", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAo.ForeColor = System.Drawing.Color.Black;
            this.gbAo.Location = new System.Drawing.Point(12, 94);
            this.gbAo.Name = "gbAo";
            this.gbAo.Size = new System.Drawing.Size(229, 231);
            this.gbAo.TabIndex = 4;
            this.gbAo.TabStop = false;
            this.gbAo.Text = "Áo thời trang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(319, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 43);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mua bán online";
            // 
            // gbQuan
            // 
            this.gbQuan.Controls.Add(this.ckbQuan);
            this.gbQuan.Font = new System.Drawing.Font("Ravie", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbQuan.ForeColor = System.Drawing.Color.Black;
            this.gbQuan.Location = new System.Drawing.Point(284, 94);
            this.gbQuan.Name = "gbQuan";
            this.gbQuan.Size = new System.Drawing.Size(264, 231);
            this.gbQuan.TabIndex = 6;
            this.gbQuan.TabStop = false;
            this.gbQuan.Text = "Quần phong cách";
            // 
            // ckbQuan
            // 
            this.ckbQuan.BackColor = System.Drawing.SystemColors.Control;
            this.ckbQuan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ckbQuan.Cursor = System.Windows.Forms.Cursors.Default;
            this.ckbQuan.Font = new System.Drawing.Font("Curlz MT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbQuan.FormattingEnabled = true;
            this.ckbQuan.Items.AddRange(new object[] {
            "Quần jeans",
            "Quần short",
            "Legging & Tregging",
            "Quần kaki",
            "Quần baggy"});
            this.ckbQuan.Location = new System.Drawing.Point(38, 44);
            this.ckbQuan.Name = "ckbQuan";
            this.ckbQuan.Size = new System.Drawing.Size(207, 168);
            this.ckbQuan.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkedListBox1);
            this.groupBox1.Font = new System.Drawing.Font("Ravie", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(587, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 231);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phụ kiện chất";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkedListBox1.Font = new System.Drawing.Font("Curlz MT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Tất/vớ",
            "Găng tay",
            "Khăn quàng",
            "Dây đeo",
            "Vòng cổ",
            "Vòng tay"});
            this.checkedListBox1.Location = new System.Drawing.Point(38, 44);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(171, 168);
            this.checkedListBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 533);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbAo.ResumeLayout(false);
            this.gbQuan.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckedListBox ckbAo;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbAo;
        private System.Windows.Forms.GroupBox gbQuan;
        private System.Windows.Forms.CheckedListBox ckbQuan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}

