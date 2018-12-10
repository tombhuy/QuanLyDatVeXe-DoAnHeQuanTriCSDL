namespace QLChuyenXe
{
    partial class Schedule
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblDiemKhoiHanh = new System.Windows.Forms.Label();
            this.dgvLichTrinh = new MetroFramework.Controls.MetroGrid();
            this.IDChuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioKhoiHanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TuyenDuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMuaVe = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cbDiemDen = new System.Windows.Forms.ComboBox();
            this.cbDiemKhoiHanh = new System.Windows.Forms.ComboBox();
            this.lblDiemDen = new System.Windows.Forms.Label();
            this.btnSearch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnReload = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichTrinh)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDiemKhoiHanh
            // 
            this.lblDiemKhoiHanh.AutoSize = true;
            this.lblDiemKhoiHanh.BackColor = System.Drawing.Color.White;
            this.lblDiemKhoiHanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiemKhoiHanh.Location = new System.Drawing.Point(19, 63);
            this.lblDiemKhoiHanh.Name = "lblDiemKhoiHanh";
            this.lblDiemKhoiHanh.Size = new System.Drawing.Size(140, 22);
            this.lblDiemKhoiHanh.TabIndex = 32;
            this.lblDiemKhoiHanh.Text = "Điểm Khởi Hành";
            // 
            // dgvLichTrinh
            // 
            this.dgvLichTrinh.AllowUserToAddRows = false;
            this.dgvLichTrinh.AllowUserToOrderColumns = true;
            this.dgvLichTrinh.AllowUserToResizeRows = false;
            this.dgvLichTrinh.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvLichTrinh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLichTrinh.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvLichTrinh.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLichTrinh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLichTrinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichTrinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDChuyen,
            this.GioKhoiHanh,
            this.GiaVe,
            this.TuyenDuong,
            this.colMuaVe});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLichTrinh.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLichTrinh.EnableHeadersVisualStyles = false;
            this.dgvLichTrinh.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvLichTrinh.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvLichTrinh.Location = new System.Drawing.Point(6, 6);
            this.dgvLichTrinh.Name = "dgvLichTrinh";
            this.dgvLichTrinh.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLichTrinh.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLichTrinh.RowHeadersVisible = false;
            this.dgvLichTrinh.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvLichTrinh.RowTemplate.Height = 24;
            this.dgvLichTrinh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLichTrinh.Size = new System.Drawing.Size(1152, 569);
            this.dgvLichTrinh.TabIndex = 31;
            this.dgvLichTrinh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLichTrinh_CellContentClick);
            // 
            // IDChuyen
            // 
            this.IDChuyen.DataPropertyName = "IDChuyen";
            this.IDChuyen.HeaderText = "ID Chuyến xe";
            this.IDChuyen.Name = "IDChuyen";
            // 
            // GioKhoiHanh
            // 
            this.GioKhoiHanh.DataPropertyName = "GioKhoiHanh";
            this.GioKhoiHanh.HeaderText = "Giờ khởi hành";
            this.GioKhoiHanh.Name = "GioKhoiHanh";
            // 
            // GiaVe
            // 
            this.GiaVe.DataPropertyName = "GiaVe";
            this.GiaVe.HeaderText = "Giá vé";
            this.GiaVe.Name = "GiaVe";
            // 
            // TuyenDuong
            // 
            this.TuyenDuong.DataPropertyName = "IDTuyenDuong";
            this.TuyenDuong.HeaderText = "Tuyến đường";
            this.TuyenDuong.Name = "TuyenDuong";
            // 
            // colMuaVe
            // 
            this.colMuaVe.HeaderText = "";
            this.colMuaVe.Name = "colMuaVe";
            this.colMuaVe.Text = "Mua vé";
            this.colMuaVe.UseColumnTextForButtonValue = true;
            // 
            // cbDiemDen
            // 
            this.cbDiemDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbDiemDen.FormattingEnabled = true;
            this.cbDiemDen.Location = new System.Drawing.Point(562, 61);
            this.cbDiemDen.Name = "cbDiemDen";
            this.cbDiemDen.Size = new System.Drawing.Size(241, 26);
            this.cbDiemDen.TabIndex = 30;
            // 
            // cbDiemKhoiHanh
            // 
            this.cbDiemKhoiHanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbDiemKhoiHanh.FormattingEnabled = true;
            this.cbDiemKhoiHanh.Location = new System.Drawing.Point(195, 61);
            this.cbDiemKhoiHanh.Name = "cbDiemKhoiHanh";
            this.cbDiemKhoiHanh.Size = new System.Drawing.Size(231, 26);
            this.cbDiemKhoiHanh.TabIndex = 29;
            this.cbDiemKhoiHanh.SelectedIndexChanged += new System.EventHandler(this.cbDiemKhoiHanh_SelectedIndexChanged);
            // 
            // lblDiemDen
            // 
            this.lblDiemDen.AutoSize = true;
            this.lblDiemDen.BackColor = System.Drawing.Color.White;
            this.lblDiemDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiemDen.Location = new System.Drawing.Point(444, 63);
            this.lblDiemDen.Name = "lblDiemDen";
            this.lblDiemDen.Size = new System.Drawing.Size(89, 22);
            this.lblDiemDen.TabIndex = 28;
            this.lblDiemDen.Text = "Điểm Đến";
            // 
            // btnSearch
            // 
            this.btnSearch.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(119)))), ((int)(((byte)(81)))));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(139)))), ((int)(((byte)(101)))));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.BorderRadius = 7;
            this.btnSearch.ButtonText = "SEARCH";
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.DisabledColor = System.Drawing.Color.Gray;
            this.btnSearch.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSearch.Iconimage = global::QLChuyenXe.Properties.Resources.search;
            this.btnSearch.Iconimage_right = null;
            this.btnSearch.Iconimage_right_Selected = null;
            this.btnSearch.Iconimage_Selected = null;
            this.btnSearch.IconMarginLeft = 0;
            this.btnSearch.IconMarginRight = 0;
            this.btnSearch.IconRightVisible = true;
            this.btnSearch.IconRightZoom = 0D;
            this.btnSearch.IconVisible = true;
            this.btnSearch.IconZoom = 40D;
            this.btnSearch.IsTab = false;
            this.btnSearch.Location = new System.Drawing.Point(893, 46);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(139)))), ((int)(((byte)(101)))));
            this.btnSearch.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(119)))), ((int)(((byte)(81)))));
            this.btnSearch.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSearch.selected = false;
            this.btnSearch.Size = new System.Drawing.Size(122, 47);
            this.btnSearch.TabIndex = 33;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Textcolor = System.Drawing.Color.White;
            this.btnSearch.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReload
            // 
            this.btnReload.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(72)))), ((int)(((byte)(24)))));
            this.btnReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(92)))), ((int)(((byte)(44)))));
            this.btnReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReload.BorderRadius = 7;
            this.btnReload.ButtonText = "RELOAD";
            this.btnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReload.DisabledColor = System.Drawing.Color.Gray;
            this.btnReload.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReload.Iconimage = global::QLChuyenXe.Properties.Resources.circular_arrow;
            this.btnReload.Iconimage_right = null;
            this.btnReload.Iconimage_right_Selected = null;
            this.btnReload.Iconimage_Selected = null;
            this.btnReload.IconMarginLeft = 0;
            this.btnReload.IconMarginRight = 0;
            this.btnReload.IconRightVisible = true;
            this.btnReload.IconRightZoom = 0D;
            this.btnReload.IconVisible = true;
            this.btnReload.IconZoom = 38D;
            this.btnReload.IsTab = false;
            this.btnReload.Location = new System.Drawing.Point(1037, 46);
            this.btnReload.Margin = new System.Windows.Forms.Padding(4);
            this.btnReload.Name = "btnReload";
            this.btnReload.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(92)))), ((int)(((byte)(44)))));
            this.btnReload.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(72)))), ((int)(((byte)(24)))));
            this.btnReload.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReload.selected = false;
            this.btnReload.Size = new System.Drawing.Size(120, 47);
            this.btnReload.TabIndex = 34;
            this.btnReload.Text = "RELOAD";
            this.btnReload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReload.Textcolor = System.Drawing.Color.White;
            this.btnReload.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.dgvLichTrinh);
            this.panel1.Location = new System.Drawing.Point(24, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1164, 581);
            this.panel1.TabIndex = 35;
            // 
            // Schedule
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblDiemKhoiHanh);
            this.Controls.Add(this.cbDiemDen);
            this.Controls.Add(this.cbDiemKhoiHanh);
            this.Controls.Add(this.lblDiemDen);
            this.Name = "Schedule";
            this.Size = new System.Drawing.Size(1212, 736);
            this.Load += new System.EventHandler(this.Schedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichTrinh)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDiemKhoiHanh;
        private MetroFramework.Controls.MetroGrid dgvLichTrinh;
        private System.Windows.Forms.ComboBox cbDiemDen;
        private System.Windows.Forms.ComboBox cbDiemKhoiHanh;
        private System.Windows.Forms.Label lblDiemDen;
        private Bunifu.Framework.UI.BunifuFlatButton btnSearch;
        private Bunifu.Framework.UI.BunifuFlatButton btnReload;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDChuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioKhoiHanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn TuyenDuong;
        private System.Windows.Forms.DataGridViewButtonColumn colMuaVe;
    }
}
