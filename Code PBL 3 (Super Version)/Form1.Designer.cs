namespace Code_PBL_3__Super_Version_
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
            this.btnChonfile = new System.Windows.Forms.Button();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ptbBanvedap = new System.Windows.Forms.PictureBox();
            this.btnDraw = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbMNHL = new System.Windows.Forms.ComboBox();
            this.cbbMNTL = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDientich = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbMatcat = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnDrawSlide = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtLuuluongq = new System.Windows.Forms.TextBox();
            this.txtChieucaoh1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBanvedap)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Controls.Add(this.btnChonfile);
            this.groupBox1.Controls.Add(this.txtLink);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(415, 129);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LẤY DỮ LIỆU TỪ EXCEL";
            // 
            // btnChonfile
            // 
            this.btnChonfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonfile.Location = new System.Drawing.Point(306, 91);
            this.btnChonfile.Name = "btnChonfile";
            this.btnChonfile.Size = new System.Drawing.Size(102, 30);
            this.btnChonfile.TabIndex = 2;
            this.btnChonfile.Text = "Chọn File";
            this.btnChonfile.UseVisualStyleBackColor = true;
            this.btnChonfile.Click += new System.EventHandler(this.btnChonfile_Click);
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(12, 58);
            this.txtLink.Margin = new System.Windows.Forms.Padding(4);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(395, 29);
            this.txtLink.TabIndex = 1;
            this.txtLink.Text = "D:\\Nguyễn Ngọc Hân1.xlsx";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đường dẫn";
            // 
            // ptbBanvedap
            // 
            this.ptbBanvedap.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ptbBanvedap.Location = new System.Drawing.Point(16, 151);
            this.ptbBanvedap.Margin = new System.Windows.Forms.Padding(4);
            this.ptbBanvedap.Name = "ptbBanvedap";
            this.ptbBanvedap.Size = new System.Drawing.Size(1596, 645);
            this.ptbBanvedap.TabIndex = 1;
            this.ptbBanvedap.TabStop = false;
            this.ptbBanvedap.Paint += new System.Windows.Forms.PaintEventHandler(this.ptbBanvedap_Paint);
            // 
            // btnDraw
            // 
            this.btnDraw.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDraw.Location = new System.Drawing.Point(16, 805);
            this.btnDraw.Margin = new System.Windows.Forms.Padding(4);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(147, 46);
            this.btnDraw.TabIndex = 2;
            this.btnDraw.Text = "DRAW";
            this.btnDraw.UseVisualStyleBackColor = false;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(1465, 805);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(147, 46);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbbMNHL);
            this.groupBox2.Controls.Add(this.cbbMNTL);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(440, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(388, 129);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CHỌN MỰC NƯỚC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mực nước hạ lưu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mực nước thượng lưu";
            // 
            // cbbMNHL
            // 
            this.cbbMNHL.FormattingEnabled = true;
            this.cbbMNHL.Items.AddRange(new object[] {
            "MNHLBT",
            "MNHL MAX"});
            this.cbbMNHL.Location = new System.Drawing.Point(219, 69);
            this.cbbMNHL.Margin = new System.Windows.Forms.Padding(4);
            this.cbbMNHL.Name = "cbbMNHL";
            this.cbbMNHL.Size = new System.Drawing.Size(160, 32);
            this.cbbMNHL.TabIndex = 1;
            // 
            // cbbMNTL
            // 
            this.cbbMNTL.FormattingEnabled = true;
            this.cbbMNTL.Items.AddRange(new object[] {
            "MNDBT",
            "MNLTK",
            "MNLKT"});
            this.cbbMNTL.Location = new System.Drawing.Point(219, 30);
            this.cbbMNTL.Margin = new System.Windows.Forms.Padding(4);
            this.cbbMNTL.Name = "cbbMNTL";
            this.cbbMNTL.Size = new System.Drawing.Size(160, 32);
            this.cbbMNTL.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox3.Controls.Add(this.txtDientich);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cbbMatcat);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(836, 15);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(349, 129);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CHỌN MẶT CẮT ĐẬP";
            // 
            // txtDientich
            // 
            this.txtDientich.Location = new System.Drawing.Point(219, 69);
            this.txtDientich.Name = "txtDientich";
            this.txtDientich.Size = new System.Drawing.Size(121, 29);
            this.txtDientich.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Diện tích mặt cắt (m2)";
            // 
            // cbbMatcat
            // 
            this.cbbMatcat.FormattingEnabled = true;
            this.cbbMatcat.Items.AddRange(new object[] {
            "Mặt cắt 1",
            "Mặt cắt 2",
            "Mặt cắt 3",
            "Mặt cắt 4",
            "Mặt cắt 5",
            "Mặt cắt 6",
            "Mặt cắt 7",
            "Mặt cắt 8",
            "Mặt cắt 9",
            "Mặt cắt 10"});
            this.cbbMatcat.Location = new System.Drawing.Point(219, 30);
            this.cbbMatcat.Margin = new System.Windows.Forms.Padding(4);
            this.cbbMatcat.Name = "cbbMatcat";
            this.cbbMatcat.Size = new System.Drawing.Size(121, 32);
            this.cbbMatcat.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 35);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mặt cắt";
            // 
            // btnDrawSlide
            // 
            this.btnDrawSlide.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnDrawSlide.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrawSlide.Location = new System.Drawing.Point(171, 805);
            this.btnDrawSlide.Margin = new System.Windows.Forms.Padding(4);
            this.btnDrawSlide.Name = "btnDrawSlide";
            this.btnDrawSlide.Size = new System.Drawing.Size(147, 46);
            this.btnDrawSlide.TabIndex = 6;
            this.btnDrawSlide.Text = "DRAW SLICE";
            this.btnDrawSlide.UseVisualStyleBackColor = false;
            this.btnDrawSlide.Click += new System.EventHandler(this.btnDrawSlide_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox4.Controls.Add(this.txtLuuluongq);
            this.groupBox4.Controls.Add(this.txtChieucaoh1);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(1193, 15);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(333, 129);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "SỐ LIỆU TÍNH TOÁN";
            // 
            // txtLuuluongq
            // 
            this.txtLuuluongq.Location = new System.Drawing.Point(196, 71);
            this.txtLuuluongq.Name = "txtLuuluongq";
            this.txtLuuluongq.Size = new System.Drawing.Size(128, 28);
            this.txtLuuluongq.TabIndex = 3;
            // 
            // txtChieucaoh1
            // 
            this.txtChieucaoh1.Location = new System.Drawing.Point(196, 36);
            this.txtChieucaoh1.Name = "txtChieucaoh1";
            this.txtChieucaoh1.Size = new System.Drawing.Size(128, 28);
            this.txtChieucaoh1.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 22);
            this.label7.TabIndex = 1;
            this.label7.Text = "Lưu lượng q (m2/s)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Chiều cao h1 (m)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1711, 902);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnDrawSlide);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.ptbBanvedap);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBanvedap)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ptbBanvedap;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbMNHL;
        private System.Windows.Forms.ComboBox cbbMNTL;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbbMatcat;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnDrawSlide;
        private System.Windows.Forms.Button btnChonfile;
        private System.Windows.Forms.TextBox txtDientich;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtLuuluongq;
        private System.Windows.Forms.TextBox txtChieucaoh1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

