namespace Project_BookstoreManagement.PL
{
    partial class UCGhiNhanHuHong
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
            this.grid_book = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_tenSP = new System.Windows.Forms.Label();
            this.lbl_maSP = new System.Windows.Forms.Label();
            this.txtbox_quantity = new System.Windows.Forms.TextBox();
            this.txtbox_bookid = new System.Windows.Forms.TextBox();
            this.lbl_notiCus = new System.Windows.Forms.Label();
            this.btn_ghinhan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_book)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_book
            // 
            this.grid_book.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_book.Location = new System.Drawing.Point(168, 105);
            this.grid_book.Name = "grid_book";
            this.grid_book.Size = new System.Drawing.Size(536, 539);
            this.grid_book.TabIndex = 154;
            this.grid_book.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_book_CellClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(164, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(138, 20);
            this.label13.TabIndex = 155;
            this.label13.Text = "Danh sách sách";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(924, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 2);
            this.label2.TabIndex = 164;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(921, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 2);
            this.label1.TabIndex = 163;
            // 
            // lbl_tenSP
            // 
            this.lbl_tenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tenSP.Location = new System.Drawing.Point(783, 150);
            this.lbl_tenSP.Name = "lbl_tenSP";
            this.lbl_tenSP.Size = new System.Drawing.Size(100, 20);
            this.lbl_tenSP.TabIndex = 161;
            this.lbl_tenSP.Text = "Số lượng hỏng";
            // 
            // lbl_maSP
            // 
            this.lbl_maSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maSP.Location = new System.Drawing.Point(783, 105);
            this.lbl_maSP.Name = "lbl_maSP";
            this.lbl_maSP.Size = new System.Drawing.Size(60, 20);
            this.lbl_maSP.TabIndex = 160;
            this.lbl_maSP.Text = "Mã sách";
            // 
            // txtbox_quantity
            // 
            this.txtbox_quantity.BackColor = System.Drawing.Color.White;
            this.txtbox_quantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_quantity.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtbox_quantity.Location = new System.Drawing.Point(924, 150);
            this.txtbox_quantity.Name = "txtbox_quantity";
            this.txtbox_quantity.Size = new System.Drawing.Size(153, 13);
            this.txtbox_quantity.TabIndex = 157;
            // 
            // txtbox_bookid
            // 
            this.txtbox_bookid.BackColor = System.Drawing.Color.White;
            this.txtbox_bookid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_bookid.Location = new System.Drawing.Point(921, 107);
            this.txtbox_bookid.Name = "txtbox_bookid";
            this.txtbox_bookid.Size = new System.Drawing.Size(156, 13);
            this.txtbox_bookid.TabIndex = 156;
            // 
            // lbl_notiCus
            // 
            this.lbl_notiCus.AutoSize = true;
            this.lbl_notiCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_notiCus.ForeColor = System.Drawing.Color.Blue;
            this.lbl_notiCus.Location = new System.Drawing.Point(783, 291);
            this.lbl_notiCus.Name = "lbl_notiCus";
            this.lbl_notiCus.Size = new System.Drawing.Size(85, 16);
            this.lbl_notiCus.TabIndex = 165;
            this.lbl_notiCus.Text = "Notification";
            // 
            // btn_ghinhan
            // 
            this.btn_ghinhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ghinhan.Location = new System.Drawing.Point(995, 197);
            this.btn_ghinhan.Name = "btn_ghinhan";
            this.btn_ghinhan.Size = new System.Drawing.Size(82, 36);
            this.btn_ghinhan.TabIndex = 166;
            this.btn_ghinhan.Text = "Ghi nhận";
            this.btn_ghinhan.UseVisualStyleBackColor = true;
            this.btn_ghinhan.Click += new System.EventHandler(this.btn_ghinhan_Click);
            // 
            // UCGhiNhanHuHong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btn_ghinhan);
            this.Controls.Add(this.lbl_notiCus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_tenSP);
            this.Controls.Add(this.lbl_maSP);
            this.Controls.Add(this.txtbox_quantity);
            this.Controls.Add(this.txtbox_bookid);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.grid_book);
            this.Name = "UCGhiNhanHuHong";
            this.Size = new System.Drawing.Size(1348, 703);
            this.Load += new System.EventHandler(this.UCGhiNhanHuHong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_book)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_book;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_tenSP;
        private System.Windows.Forms.Label lbl_maSP;
        private System.Windows.Forms.TextBox txtbox_quantity;
        private System.Windows.Forms.TextBox txtbox_bookid;
        private System.Windows.Forms.Label lbl_notiCus;
        private System.Windows.Forms.Button btn_ghinhan;
    }
}
