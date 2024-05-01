namespace HASHTABLE
{
    partial class frmMain
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.txbEng = new System.Windows.Forms.TextBox();
            this.txbViet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbNotify = new System.Windows.Forms.Label();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(552, 116);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(126, 42);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm Từ";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseLeave += new System.EventHandler(this.btnSearch_MouseLeave);
            this.btnAdd.MouseHover += new System.EventHandler(this.btnSearch_MouseHover);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.PaleGreen;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemove.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(552, 278);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(126, 42);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Xóa Từ";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            this.btnRemove.MouseLeave += new System.EventHandler(this.btnSearch_MouseLeave);
            this.btnRemove.MouseHover += new System.EventHandler(this.btnSearch_MouseHover);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.PaleGreen;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuit.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(905, 12);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(126, 42);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "Thoát";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click_1);
            this.btnQuit.MouseLeave += new System.EventHandler(this.btnSearch_MouseLeave);
            this.btnQuit.MouseHover += new System.EventHandler(this.btnSearch_MouseHover);
            // 
            // txbEng
            // 
            this.txbEng.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEng.Location = new System.Drawing.Point(12, 116);
            this.txbEng.Multiline = true;
            this.txbEng.Name = "txbEng";
            this.txbEng.Size = new System.Drawing.Size(271, 63);
            this.txbEng.TabIndex = 4;
            this.txbEng.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbEng.TextChanged += new System.EventHandler(this.txbEng_TextChanged);
            // 
            // txbViet
            // 
            this.txbViet.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbViet.Location = new System.Drawing.Point(12, 282);
            this.txbViet.Multiline = true;
            this.txbViet.Name = "txbViet";
            this.txbViet.Size = new System.Drawing.Size(271, 61);
            this.txbViet.TabIndex = 5;
            this.txbViet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(13, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tiếng Anh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(13, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tiếng Việt";
            // 
            // lbNotify
            // 
            this.lbNotify.BackColor = System.Drawing.Color.Transparent;
            this.lbNotify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNotify.ForeColor = System.Drawing.Color.Yellow;
            this.lbNotify.Location = new System.Drawing.Point(8, 76);
            this.lbNotify.Name = "lbNotify";
            this.lbNotify.Size = new System.Drawing.Size(491, 37);
            this.lbNotify.TabIndex = 8;
            this.lbNotify.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picSearch
            // 
            this.picSearch.BackColor = System.Drawing.Color.Yellow;
            this.picSearch.Image = global::HASHTABLE.Properties.Resources.search;
            this.picSearch.Location = new System.Drawing.Point(322, 116);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(80, 63);
            this.picSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSearch.TabIndex = 9;
            this.picSearch.TabStop = false;
            this.picSearch.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSave.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(552, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 42);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HASHTABLE.Properties.Resources.backg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1110, 470);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.picSearch);
            this.Controls.Add(this.lbNotify);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbViet);
            this.Controls.Add(this.txbEng);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DICTIONARY";
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.TextBox txbEng;
        private System.Windows.Forms.TextBox txbViet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbNotify;
        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.Button btnSave;
    }
}

