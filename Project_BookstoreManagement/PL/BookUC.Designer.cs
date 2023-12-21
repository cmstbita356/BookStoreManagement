namespace Project_BookstoreManagement.PL
{
    partial class BookUC
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
            this.btn_themSP = new System.Windows.Forms.Button();
            this.btn_editSP = new System.Windows.Forms.Button();
            this.btn_deleteSP = new System.Windows.Forms.Button();
            this.grid_SP = new System.Windows.Forms.DataGridView();
            this.lbl_notifSP = new System.Windows.Forms.Label();
            this.combox_booktype = new System.Windows.Forms.ComboBox();
            this.btn_refreshSP = new System.Windows.Forms.Button();
            this.txtbox_bookid = new System.Windows.Forms.TextBox();
            this.txtbox_bookname = new System.Windows.Forms.TextBox();
            this.txtbox_publisher = new System.Windows.Forms.TextBox();
            this.txtbox_price = new System.Windows.Forms.TextBox();
            this.lbl_maSP = new System.Windows.Forms.Label();
            this.lbl_tenSP = new System.Windows.Forms.Label();
            this.lbl_dơngiaSP = new System.Windows.Forms.Label();
            this.lbl_solgSP = new System.Windows.Forms.Label();
            this.lbl_LSP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_DVTinh = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbox_author = new System.Windows.Forms.TextBox();
            this.grid_LSP = new System.Windows.Forms.DataGridView();
            this.lbl_notifLSP = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_tenLSP = new System.Windows.Forms.Label();
            this.lbl_maLSP = new System.Windows.Forms.Label();
            this.txtbox_tenLSP = new System.Windows.Forms.TextBox();
            this.txtbox_maLSP = new System.Windows.Forms.TextBox();
            this.btn_deleteLSP = new System.Windows.Forms.Button();
            this.btn_editLSP = new System.Windows.Forms.Button();
            this.btn_themLSP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_SP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_LSP)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_themSP
            // 
            this.btn_themSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themSP.Location = new System.Drawing.Point(867, 204);
            this.btn_themSP.Name = "btn_themSP";
            this.btn_themSP.Size = new System.Drawing.Size(66, 36);
            this.btn_themSP.TabIndex = 6;
            this.btn_themSP.Text = "Thêm";
            this.btn_themSP.UseVisualStyleBackColor = true;
            this.btn_themSP.Click += new System.EventHandler(this.btn_themSP_Click);
            // 
            // btn_editSP
            // 
            this.btn_editSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editSP.Location = new System.Drawing.Point(1049, 204);
            this.btn_editSP.Name = "btn_editSP";
            this.btn_editSP.Size = new System.Drawing.Size(85, 36);
            this.btn_editSP.TabIndex = 8;
            this.btn_editSP.Text = "Cập nhật";
            this.btn_editSP.UseVisualStyleBackColor = true;
            this.btn_editSP.Click += new System.EventHandler(this.btn_editSP_Click);
            // 
            // btn_deleteSP
            // 
            this.btn_deleteSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteSP.Location = new System.Drawing.Point(958, 204);
            this.btn_deleteSP.Name = "btn_deleteSP";
            this.btn_deleteSP.Size = new System.Drawing.Size(64, 36);
            this.btn_deleteSP.TabIndex = 7;
            this.btn_deleteSP.Text = "Xóa";
            this.btn_deleteSP.UseVisualStyleBackColor = true;
            this.btn_deleteSP.Click += new System.EventHandler(this.btn_deleteSP_Click);
            // 
            // grid_SP
            // 
            this.grid_SP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_SP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_SP.Location = new System.Drawing.Point(564, 274);
            this.grid_SP.Name = "grid_SP";
            this.grid_SP.ReadOnly = true;
            this.grid_SP.Size = new System.Drawing.Size(584, 373);
            this.grid_SP.TabIndex = 7;
            this.grid_SP.TabStop = false;
            this.grid_SP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_SP_CellClick);
            // 
            // lbl_notifSP
            // 
            this.lbl_notifSP.AutoSize = true;
            this.lbl_notifSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_notifSP.ForeColor = System.Drawing.Color.Blue;
            this.lbl_notifSP.Location = new System.Drawing.Point(561, 50);
            this.lbl_notifSP.Name = "lbl_notifSP";
            this.lbl_notifSP.Size = new System.Drawing.Size(85, 16);
            this.lbl_notifSP.TabIndex = 12;
            this.lbl_notifSP.Text = "Notification";
            // 
            // combox_booktype
            // 
            this.combox_booktype.BackColor = System.Drawing.Color.White;
            this.combox_booktype.ForeColor = System.Drawing.Color.Blue;
            this.combox_booktype.FormattingEnabled = true;
            this.combox_booktype.Location = new System.Drawing.Point(945, 139);
            this.combox_booktype.Name = "combox_booktype";
            this.combox_booktype.Size = new System.Drawing.Size(153, 21);
            this.combox_booktype.TabIndex = 5;
            // 
            // btn_refreshSP
            // 
            this.btn_refreshSP.BackColor = System.Drawing.Color.Transparent;
            this.btn_refreshSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refreshSP.Location = new System.Drawing.Point(1073, 36);
            this.btn_refreshSP.Name = "btn_refreshSP";
            this.btn_refreshSP.Size = new System.Drawing.Size(75, 30);
            this.btn_refreshSP.TabIndex = 9;
            this.btn_refreshSP.Text = "Refresh";
            this.btn_refreshSP.UseVisualStyleBackColor = false;
            this.btn_refreshSP.Click += new System.EventHandler(this.btn_refreshSP_Click);
            // 
            // txtbox_bookid
            // 
            this.txtbox_bookid.BackColor = System.Drawing.Color.White;
            this.txtbox_bookid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_bookid.Location = new System.Drawing.Point(655, 93);
            this.txtbox_bookid.Name = "txtbox_bookid";
            this.txtbox_bookid.Size = new System.Drawing.Size(153, 13);
            this.txtbox_bookid.TabIndex = 0;
            // 
            // txtbox_bookname
            // 
            this.txtbox_bookname.BackColor = System.Drawing.Color.White;
            this.txtbox_bookname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_bookname.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtbox_bookname.Location = new System.Drawing.Point(655, 136);
            this.txtbox_bookname.Name = "txtbox_bookname";
            this.txtbox_bookname.Size = new System.Drawing.Size(153, 13);
            this.txtbox_bookname.TabIndex = 1;
            // 
            // txtbox_publisher
            // 
            this.txtbox_publisher.BackColor = System.Drawing.Color.White;
            this.txtbox_publisher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_publisher.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtbox_publisher.Location = new System.Drawing.Point(655, 221);
            this.txtbox_publisher.Name = "txtbox_publisher";
            this.txtbox_publisher.Size = new System.Drawing.Size(153, 13);
            this.txtbox_publisher.TabIndex = 3;
            // 
            // txtbox_price
            // 
            this.txtbox_price.BackColor = System.Drawing.Color.White;
            this.txtbox_price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_price.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtbox_price.Location = new System.Drawing.Point(945, 93);
            this.txtbox_price.Name = "txtbox_price";
            this.txtbox_price.Size = new System.Drawing.Size(153, 13);
            this.txtbox_price.TabIndex = 4;
            // 
            // lbl_maSP
            // 
            this.lbl_maSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maSP.Location = new System.Drawing.Point(561, 92);
            this.lbl_maSP.Name = "lbl_maSP";
            this.lbl_maSP.Size = new System.Drawing.Size(60, 20);
            this.lbl_maSP.TabIndex = 16;
            this.lbl_maSP.Text = "Mã sách";
            // 
            // lbl_tenSP
            // 
            this.lbl_tenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tenSP.Location = new System.Drawing.Point(558, 137);
            this.lbl_tenSP.Name = "lbl_tenSP";
            this.lbl_tenSP.Size = new System.Drawing.Size(63, 20);
            this.lbl_tenSP.TabIndex = 17;
            this.lbl_tenSP.Text = "Tên sách";
            // 
            // lbl_dơngiaSP
            // 
            this.lbl_dơngiaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dơngiaSP.Location = new System.Drawing.Point(558, 221);
            this.lbl_dơngiaSP.Name = "lbl_dơngiaSP";
            this.lbl_dơngiaSP.Size = new System.Drawing.Size(91, 20);
            this.lbl_dơngiaSP.TabIndex = 18;
            this.lbl_dơngiaSP.Text = "Nhà xuất bản";
            // 
            // lbl_solgSP
            // 
            this.lbl_solgSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_solgSP.Location = new System.Drawing.Point(865, 93);
            this.lbl_solgSP.Name = "lbl_solgSP";
            this.lbl_solgSP.Size = new System.Drawing.Size(63, 20);
            this.lbl_solgSP.TabIndex = 19;
            this.lbl_solgSP.Text = "Giá bán";
            // 
            // lbl_LSP
            // 
            this.lbl_LSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LSP.Location = new System.Drawing.Point(865, 139);
            this.lbl_LSP.Name = "lbl_LSP";
            this.lbl_LSP.Size = new System.Drawing.Size(74, 20);
            this.lbl_LSP.TabIndex = 20;
            this.lbl_LSP.Text = "Loại sách";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(655, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 2);
            this.label1.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(655, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 2);
            this.label2.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(655, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 2);
            this.label3.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(945, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 2);
            this.label4.TabIndex = 24;
            // 
            // lbl_DVTinh
            // 
            this.lbl_DVTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DVTinh.Location = new System.Drawing.Point(558, 178);
            this.lbl_DVTinh.Name = "lbl_DVTinh";
            this.lbl_DVTinh.Size = new System.Drawing.Size(74, 20);
            this.lbl_DVTinh.TabIndex = 25;
            this.lbl_DVTinh.Text = "Tác giả";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(655, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 2);
            this.label5.TabIndex = 27;
            // 
            // txtbox_author
            // 
            this.txtbox_author.BackColor = System.Drawing.Color.White;
            this.txtbox_author.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_author.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtbox_author.Location = new System.Drawing.Point(655, 178);
            this.txtbox_author.Name = "txtbox_author";
            this.txtbox_author.Size = new System.Drawing.Size(153, 13);
            this.txtbox_author.TabIndex = 2;
            // 
            // grid_LSP
            // 
            this.grid_LSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_LSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_LSP.Location = new System.Drawing.Point(24, 274);
            this.grid_LSP.Name = "grid_LSP";
            this.grid_LSP.Size = new System.Drawing.Size(522, 373);
            this.grid_LSP.TabIndex = 31;
            this.grid_LSP.TabStop = false;
            this.grid_LSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_LSP_CellClick_1);
            // 
            // lbl_notifLSP
            // 
            this.lbl_notifLSP.AutoSize = true;
            this.lbl_notifLSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_notifLSP.ForeColor = System.Drawing.Color.Green;
            this.lbl_notifLSP.Location = new System.Drawing.Point(21, 50);
            this.lbl_notifLSP.Name = "lbl_notifLSP";
            this.lbl_notifLSP.Size = new System.Drawing.Size(85, 16);
            this.lbl_notifLSP.TabIndex = 41;
            this.lbl_notifLSP.Text = "Notification";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(92, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 2);
            this.label6.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(92, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 2);
            this.label7.TabIndex = 39;
            // 
            // lbl_tenLSP
            // 
            this.lbl_tenLSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tenLSP.Location = new System.Drawing.Point(21, 142);
            this.lbl_tenLSP.Name = "lbl_tenLSP";
            this.lbl_tenLSP.Size = new System.Drawing.Size(63, 20);
            this.lbl_tenLSP.TabIndex = 38;
            this.lbl_tenLSP.Text = "Tên loại";
            // 
            // lbl_maLSP
            // 
            this.lbl_maLSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maLSP.Location = new System.Drawing.Point(21, 99);
            this.lbl_maLSP.Name = "lbl_maLSP";
            this.lbl_maLSP.Size = new System.Drawing.Size(52, 20);
            this.lbl_maLSP.TabIndex = 37;
            this.lbl_maLSP.Text = "Mã loại";
            // 
            // txtbox_tenLSP
            // 
            this.txtbox_tenLSP.BackColor = System.Drawing.Color.White;
            this.txtbox_tenLSP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_tenLSP.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtbox_tenLSP.Location = new System.Drawing.Point(92, 142);
            this.txtbox_tenLSP.Name = "txtbox_tenLSP";
            this.txtbox_tenLSP.Size = new System.Drawing.Size(153, 13);
            this.txtbox_tenLSP.TabIndex = 33;
            // 
            // txtbox_maLSP
            // 
            this.txtbox_maLSP.BackColor = System.Drawing.Color.White;
            this.txtbox_maLSP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_maLSP.Location = new System.Drawing.Point(92, 99);
            this.txtbox_maLSP.Name = "txtbox_maLSP";
            this.txtbox_maLSP.Size = new System.Drawing.Size(153, 13);
            this.txtbox_maLSP.TabIndex = 32;
            // 
            // btn_deleteLSP
            // 
            this.btn_deleteLSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteLSP.Location = new System.Drawing.Point(115, 208);
            this.btn_deleteLSP.Name = "btn_deleteLSP";
            this.btn_deleteLSP.Size = new System.Drawing.Size(63, 37);
            this.btn_deleteLSP.TabIndex = 35;
            this.btn_deleteLSP.Text = "Xóa";
            this.btn_deleteLSP.UseVisualStyleBackColor = true;
            this.btn_deleteLSP.Click += new System.EventHandler(this.btn_deleteLSP_Click);
            // 
            // btn_editLSP
            // 
            this.btn_editLSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editLSP.Location = new System.Drawing.Point(204, 208);
            this.btn_editLSP.Name = "btn_editLSP";
            this.btn_editLSP.Size = new System.Drawing.Size(82, 37);
            this.btn_editLSP.TabIndex = 36;
            this.btn_editLSP.Text = "Cập nhật";
            this.btn_editLSP.UseVisualStyleBackColor = true;
            this.btn_editLSP.Click += new System.EventHandler(this.btn_editLSP_Click);
            // 
            // btn_themLSP
            // 
            this.btn_themLSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themLSP.Location = new System.Drawing.Point(24, 208);
            this.btn_themLSP.Name = "btn_themLSP";
            this.btn_themLSP.Size = new System.Drawing.Size(63, 37);
            this.btn_themLSP.TabIndex = 34;
            this.btn_themLSP.Text = "Thêm";
            this.btn_themLSP.UseVisualStyleBackColor = true;
            this.btn_themLSP.Click += new System.EventHandler(this.btn_themLSP_Click);
            // 
            // BookUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbl_notifLSP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_tenLSP);
            this.Controls.Add(this.lbl_maLSP);
            this.Controls.Add(this.txtbox_tenLSP);
            this.Controls.Add(this.txtbox_maLSP);
            this.Controls.Add(this.btn_deleteLSP);
            this.Controls.Add(this.btn_editLSP);
            this.Controls.Add(this.btn_themLSP);
            this.Controls.Add(this.grid_LSP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbox_author);
            this.Controls.Add(this.lbl_DVTinh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_LSP);
            this.Controls.Add(this.lbl_solgSP);
            this.Controls.Add(this.lbl_dơngiaSP);
            this.Controls.Add(this.lbl_tenSP);
            this.Controls.Add(this.lbl_maSP);
            this.Controls.Add(this.txtbox_price);
            this.Controls.Add(this.txtbox_publisher);
            this.Controls.Add(this.txtbox_bookname);
            this.Controls.Add(this.txtbox_bookid);
            this.Controls.Add(this.btn_refreshSP);
            this.Controls.Add(this.combox_booktype);
            this.Controls.Add(this.lbl_notifSP);
            this.Controls.Add(this.grid_SP);
            this.Controls.Add(this.btn_deleteSP);
            this.Controls.Add(this.btn_editSP);
            this.Controls.Add(this.btn_themSP);
            this.Name = "BookUC";
            this.Size = new System.Drawing.Size(1169, 667);
            ((System.ComponentModel.ISupportInitialize)(this.grid_SP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_LSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_themSP;
        private System.Windows.Forms.Button btn_editSP;
        private System.Windows.Forms.Button btn_deleteSP;
        private System.Windows.Forms.DataGridView grid_SP;
        private System.Windows.Forms.Label lbl_notifSP;
        private System.Windows.Forms.ComboBox combox_booktype;
        private System.Windows.Forms.Button btn_refreshSP;
        private System.Windows.Forms.TextBox txtbox_bookid;
        private System.Windows.Forms.TextBox txtbox_bookname;
        private System.Windows.Forms.TextBox txtbox_publisher;
        private System.Windows.Forms.TextBox txtbox_price;
        private System.Windows.Forms.Label lbl_maSP;
        private System.Windows.Forms.Label lbl_tenSP;
        private System.Windows.Forms.Label lbl_dơngiaSP;
        private System.Windows.Forms.Label lbl_solgSP;
        private System.Windows.Forms.Label lbl_LSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_DVTinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbox_author;
        private System.Windows.Forms.DataGridView grid_LSP;
        private System.Windows.Forms.Label lbl_notifLSP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_tenLSP;
        private System.Windows.Forms.Label lbl_maLSP;
        private System.Windows.Forms.TextBox txtbox_tenLSP;
        private System.Windows.Forms.TextBox txtbox_maLSP;
        private System.Windows.Forms.Button btn_deleteLSP;
        private System.Windows.Forms.Button btn_editLSP;
        private System.Windows.Forms.Button btn_themLSP;
    }
}
