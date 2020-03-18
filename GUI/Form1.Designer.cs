namespace ThreeLayoutAgain
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
            this.dataGridView_Data = new System.Windows.Forms.DataGridView();
            this.grbox_ThongTin = new System.Windows.Forms.GroupBox();
            this.lb_TimeGiaoDich = new System.Windows.Forms.Label();
            this.lb_DongXe = new System.Windows.Forms.Label();
            this.lb_HoTen = new System.Windows.Forms.Label();
            this.radiobtn_ThanhToanDu = new System.Windows.Forms.RadioButton();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.dateTimePicker_GiaoDich = new System.Windows.Forms.DateTimePicker();
            this.radiobtn_TraGop = new System.Windows.Forms.RadioButton();
            this.cbBox_DongXe = new System.Windows.Forms.ComboBox();
            this.txtBox_HoTen = new System.Windows.Forms.TextBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.txtBox_Search = new System.Windows.Forms.TextBox();
            this.btn_Show = new System.Windows.Forms.Button();
            this.btn_Sort = new System.Windows.Forms.Button();
            this.cbBox_Sort = new System.Windows.Forms.ComboBox();
            this.btn_Search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Data)).BeginInit();
            this.grbox_ThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_Data
            // 
            this.dataGridView_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Data.Location = new System.Drawing.Point(23, 38);
            this.dataGridView_Data.MultiSelect = false;
            this.dataGridView_Data.Name = "dataGridView_Data";
            this.dataGridView_Data.Size = new System.Drawing.Size(517, 84);
            this.dataGridView_Data.TabIndex = 30;
            this.dataGridView_Data.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_Data_RowHeaderMouseClick);
            // 
            // grbox_ThongTin
            // 
            this.grbox_ThongTin.Controls.Add(this.lb_TimeGiaoDich);
            this.grbox_ThongTin.Controls.Add(this.lb_DongXe);
            this.grbox_ThongTin.Controls.Add(this.lb_HoTen);
            this.grbox_ThongTin.Controls.Add(this.radiobtn_ThanhToanDu);
            this.grbox_ThongTin.Controls.Add(this.btn_Cancel);
            this.grbox_ThongTin.Controls.Add(this.btn_Ok);
            this.grbox_ThongTin.Controls.Add(this.dateTimePicker_GiaoDich);
            this.grbox_ThongTin.Controls.Add(this.radiobtn_TraGop);
            this.grbox_ThongTin.Controls.Add(this.cbBox_DongXe);
            this.grbox_ThongTin.Controls.Add(this.txtBox_HoTen);
            this.grbox_ThongTin.Location = new System.Drawing.Point(601, 38);
            this.grbox_ThongTin.Name = "grbox_ThongTin";
            this.grbox_ThongTin.Size = new System.Drawing.Size(399, 220);
            this.grbox_ThongTin.TabIndex = 29;
            this.grbox_ThongTin.TabStop = false;
            this.grbox_ThongTin.Text = "Thông tin giao dịch";
            // 
            // lb_TimeGiaoDich
            // 
            this.lb_TimeGiaoDich.AutoSize = true;
            this.lb_TimeGiaoDich.Location = new System.Drawing.Point(192, 100);
            this.lb_TimeGiaoDich.Name = "lb_TimeGiaoDich";
            this.lb_TimeGiaoDich.Size = new System.Drawing.Size(78, 13);
            this.lb_TimeGiaoDich.TabIndex = 9;
            this.lb_TimeGiaoDich.Text = "Ngày giao dịch";
            // 
            // lb_DongXe
            // 
            this.lb_DongXe.AutoSize = true;
            this.lb_DongXe.Location = new System.Drawing.Point(10, 65);
            this.lb_DongXe.Name = "lb_DongXe";
            this.lb_DongXe.Size = new System.Drawing.Size(47, 13);
            this.lb_DongXe.TabIndex = 8;
            this.lb_DongXe.Text = "Dòng xe";
            // 
            // lb_HoTen
            // 
            this.lb_HoTen.AutoSize = true;
            this.lb_HoTen.Location = new System.Drawing.Point(7, 35);
            this.lb_HoTen.Name = "lb_HoTen";
            this.lb_HoTen.Size = new System.Drawing.Size(54, 13);
            this.lb_HoTen.TabIndex = 7;
            this.lb_HoTen.Text = "Họ và tên";
            // 
            // radiobtn_ThanhToanDu
            // 
            this.radiobtn_ThanhToanDu.AutoSize = true;
            this.radiobtn_ThanhToanDu.Checked = true;
            this.radiobtn_ThanhToanDu.Location = new System.Drawing.Point(24, 119);
            this.radiobtn_ThanhToanDu.Name = "radiobtn_ThanhToanDu";
            this.radiobtn_ThanhToanDu.Size = new System.Drawing.Size(96, 17);
            this.radiobtn_ThanhToanDu.TabIndex = 6;
            this.radiobtn_ThanhToanDu.TabStop = true;
            this.radiobtn_ThanhToanDu.Text = "Thanh toán đủ";
            this.radiobtn_ThanhToanDu.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(298, 161);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(94, 23);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(192, 161);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(100, 23);
            this.btn_Ok.TabIndex = 4;
            this.btn_Ok.Text = "OK";
            this.btn_Ok.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_GiaoDich
            // 
            this.dateTimePicker_GiaoDich.Location = new System.Drawing.Point(192, 119);
            this.dateTimePicker_GiaoDich.Name = "dateTimePicker_GiaoDich";
            this.dateTimePicker_GiaoDich.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_GiaoDich.TabIndex = 3;
            // 
            // radiobtn_TraGop
            // 
            this.radiobtn_TraGop.AutoSize = true;
            this.radiobtn_TraGop.Location = new System.Drawing.Point(24, 161);
            this.radiobtn_TraGop.Name = "radiobtn_TraGop";
            this.radiobtn_TraGop.Size = new System.Drawing.Size(62, 17);
            this.radiobtn_TraGop.TabIndex = 2;
            this.radiobtn_TraGop.Text = "Trả góp";
            this.radiobtn_TraGop.UseVisualStyleBackColor = true;
            // 
            // cbBox_DongXe
            // 
            this.cbBox_DongXe.FormattingEnabled = true;
            this.cbBox_DongXe.Items.AddRange(new object[] {
            "Sirius",
            "Exciter",
            "Grande",
            "Freego"});
            this.cbBox_DongXe.Location = new System.Drawing.Point(80, 58);
            this.cbBox_DongXe.Name = "cbBox_DongXe";
            this.cbBox_DongXe.Size = new System.Drawing.Size(150, 21);
            this.cbBox_DongXe.TabIndex = 1;
            // 
            // txtBox_HoTen
            // 
            this.txtBox_HoTen.Location = new System.Drawing.Point(80, 32);
            this.txtBox_HoTen.Multiline = true;
            this.txtBox_HoTen.Name = "txtBox_HoTen";
            this.txtBox_HoTen.Size = new System.Drawing.Size(150, 20);
            this.txtBox_HoTen.TabIndex = 0;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(235, 131);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 23;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(132, 131);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 22;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(23, 131);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 21;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txtBox_Search
            // 
            this.txtBox_Search.Location = new System.Drawing.Point(23, 186);
            this.txtBox_Search.Multiline = true;
            this.txtBox_Search.Name = "txtBox_Search";
            this.txtBox_Search.Size = new System.Drawing.Size(154, 23);
            this.txtBox_Search.TabIndex = 27;
            this.txtBox_Search.TextChanged += new System.EventHandler(this.txtBox_Search_TextChanged);
            // 
            // btn_Show
            // 
            this.btn_Show.Location = new System.Drawing.Point(23, 235);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(75, 23);
            this.btn_Show.TabIndex = 26;
            this.btn_Show.Text = "Show";
            this.btn_Show.UseVisualStyleBackColor = true;
            this.btn_Show.Click += new System.EventHandler(this.btn_Show_Click);
            // 
            // btn_Sort
            // 
            this.btn_Sort.Location = new System.Drawing.Point(317, 188);
            this.btn_Sort.Name = "btn_Sort";
            this.btn_Sort.Size = new System.Drawing.Size(75, 23);
            this.btn_Sort.TabIndex = 25;
            this.btn_Sort.Text = "Sort";
            this.btn_Sort.UseVisualStyleBackColor = true;
            // 
            // cbBox_Sort
            // 
            this.cbBox_Sort.FormattingEnabled = true;
            this.cbBox_Sort.Items.AddRange(new object[] {
            "HoTen",
            "LoaiGiaoDich",
            "ThoiGianGiaoDich"});
            this.cbBox_Sort.Location = new System.Drawing.Point(412, 188);
            this.cbBox_Sort.Name = "cbBox_Sort";
            this.cbBox_Sort.Size = new System.Drawing.Size(121, 21);
            this.cbBox_Sort.TabIndex = 28;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(183, 188);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 24;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 326);
            this.Controls.Add(this.dataGridView_Data);
            this.Controls.Add(this.grbox_ThongTin);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txtBox_Search);
            this.Controls.Add(this.btn_Show);
            this.Controls.Add(this.btn_Sort);
            this.Controls.Add(this.cbBox_Sort);
            this.Controls.Add(this.btn_Search);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Data)).EndInit();
            this.grbox_ThongTin.ResumeLayout(false);
            this.grbox_ThongTin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Data;
        private System.Windows.Forms.GroupBox grbox_ThongTin;
        private System.Windows.Forms.Label lb_TimeGiaoDich;
        private System.Windows.Forms.Label lb_DongXe;
        private System.Windows.Forms.Label lb_HoTen;
        private System.Windows.Forms.RadioButton radiobtn_ThanhToanDu;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.DateTimePicker dateTimePicker_GiaoDich;
        private System.Windows.Forms.RadioButton radiobtn_TraGop;
        private System.Windows.Forms.ComboBox cbBox_DongXe;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox txtBox_Search;
        private System.Windows.Forms.Button btn_Show;
        private System.Windows.Forms.Button btn_Sort;
        private System.Windows.Forms.ComboBox cbBox_Sort;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txtBox_HoTen;
    }
}

