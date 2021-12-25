
namespace Report_Post_Facebook
{
    partial class REG
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(REG));
            this.DGVLD = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thêmTàiKhoảngFacebookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaTấtCảNickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.luong = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.UIDPOST = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LoadRow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mabaomat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cookiefb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tokenfb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVLD)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luong)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVLD
            // 
            this.DGVLD.AllowUserToAddRows = false;
            this.DGVLD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVLD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVLD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LoadRow,
            this.STT,
            this.Username,
            this.Password,
            this.Mabaomat,
            this.Cookiefb,
            this.Tokenfb,
            this.Status});
            this.DGVLD.ContextMenuStrip = this.contextMenuStrip1;
            this.DGVLD.Location = new System.Drawing.Point(12, 12);
            this.DGVLD.Name = "DGVLD";
            this.DGVLD.Size = new System.Drawing.Size(1195, 412);
            this.DGVLD.TabIndex = 1;
            this.DGVLD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVLD_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmTàiKhoảngFacebookToolStripMenuItem,
            this.xóaTấtCảNickToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(216, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // thêmTàiKhoảngFacebookToolStripMenuItem
            // 
            this.thêmTàiKhoảngFacebookToolStripMenuItem.Name = "thêmTàiKhoảngFacebookToolStripMenuItem";
            this.thêmTàiKhoảngFacebookToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.thêmTàiKhoảngFacebookToolStripMenuItem.Text = "Thêm tài khoảng facebook";
            this.thêmTàiKhoảngFacebookToolStripMenuItem.Click += new System.EventHandler(this.thêmTàiKhoảngFacebookToolStripMenuItem_Click);
            // 
            // xóaTấtCảNickToolStripMenuItem
            // 
            this.xóaTấtCảNickToolStripMenuItem.Name = "xóaTấtCảNickToolStripMenuItem";
            this.xóaTấtCảNickToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.xóaTấtCảNickToolStripMenuItem.Text = "Xóa tất cả nick";
            this.xóaTấtCảNickToolStripMenuItem.Click += new System.EventHandler(this.xóaTấtCảNickToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "Bắt đầu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // luong
            // 
            this.luong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.luong.Location = new System.Drawing.Point(1131, 437);
            this.luong.Name = "luong";
            this.luong.Size = new System.Drawing.Size(76, 20);
            this.luong.TabIndex = 3;
            this.luong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1073, 441);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Số luồng:";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(150, 434);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 26);
            this.button2.TabIndex = 5;
            this.button2.Text = "Dừng lại";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UIDPOST
            // 
            this.UIDPOST.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UIDPOST.Location = new System.Drawing.Point(372, 436);
            this.UIDPOST.Name = "UIDPOST";
            this.UIDPOST.Size = new System.Drawing.Size(188, 20);
            this.UIDPOST.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(296, 441);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "UID POST:";
            // 
            // LoadRow
            // 
            this.LoadRow.HeaderText = "Column1";
            this.LoadRow.Name = "LoadRow";
            this.LoadRow.Visible = false;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 50;
            // 
            // Username
            // 
            this.Username.HeaderText = "Tài Khoảng";
            this.Username.Name = "Username";
            this.Username.Width = 150;
            // 
            // Password
            // 
            this.Password.HeaderText = "Mật khẩu";
            this.Password.Name = "Password";
            // 
            // Mabaomat
            // 
            this.Mabaomat.HeaderText = "2FA";
            this.Mabaomat.Name = "Mabaomat";
            this.Mabaomat.Width = 50;
            // 
            // Cookiefb
            // 
            this.Cookiefb.HeaderText = "Cookie";
            this.Cookiefb.Name = "Cookiefb";
            // 
            // Tokenfb
            // 
            this.Tokenfb.HeaderText = "Token";
            this.Tokenfb.Name = "Tokenfb";
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Status.HeaderText = "Trạng Thái";
            this.Status.Name = "Status";
            // 
            // REG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 471);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UIDPOST);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.luong);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DGVLD);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "REG";
            this.Text = "Phần mềm report post";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVLD)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.luong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVLD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown luong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thêmTàiKhoảngFacebookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaTấtCảNickToolStripMenuItem;
        private System.Windows.Forms.TextBox UIDPOST;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoadRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mabaomat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cookiefb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tokenfb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}

