namespace PruuImageDownloader
{
    partial class F_Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Principal));
            this.pb_principal = new System.Windows.Forms.PictureBox();
            this.lbl_product = new System.Windows.Forms.Label();
            this.lbl_version = new System.Windows.Forms.Label();
            this.lbl_arch = new System.Windows.Forms.Label();
            this.btn_start_download = new System.Windows.Forms.Button();
            this.lbl_language = new System.Windows.Forms.Label();
            this.cb_product = new System.Windows.Forms.ComboBox();
            this.cb_version = new System.Windows.Forms.ComboBox();
            this.cb_language = new System.Windows.Forms.ComboBox();
            this.cb_arch = new System.Windows.Forms.ComboBox();
            this.lbl_contact = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pb_principal)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_principal
            // 
            this.pb_principal.Image = global::PruuImageDownloader.Properties.Resources._52987_bird_gray_bird_grey_icon;
            this.pb_principal.Location = new System.Drawing.Point(12, 4);
            this.pb_principal.Name = "pb_principal";
            this.pb_principal.Size = new System.Drawing.Size(256, 256);
            this.pb_principal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_principal.TabIndex = 0;
            this.pb_principal.TabStop = false;
            // 
            // lbl_product
            // 
            this.lbl_product.AutoSize = true;
            this.lbl_product.Location = new System.Drawing.Point(305, 43);
            this.lbl_product.Name = "lbl_product";
            this.lbl_product.Size = new System.Drawing.Size(55, 14);
            this.lbl_product.TabIndex = 1;
            this.lbl_product.Text = "Product";
            // 
            // lbl_version
            // 
            this.lbl_version.AutoSize = true;
            this.lbl_version.Location = new System.Drawing.Point(305, 86);
            this.lbl_version.Name = "lbl_version";
            this.lbl_version.Size = new System.Drawing.Size(53, 14);
            this.lbl_version.TabIndex = 2;
            this.lbl_version.Text = "Version";
            // 
            // lbl_arch
            // 
            this.lbl_arch.AutoSize = true;
            this.lbl_arch.Location = new System.Drawing.Point(305, 169);
            this.lbl_arch.Name = "lbl_arch";
            this.lbl_arch.Size = new System.Drawing.Size(82, 14);
            this.lbl_arch.TabIndex = 3;
            this.lbl_arch.Text = "Architecture";
            // 
            // btn_start_download
            // 
            this.btn_start_download.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_start_download.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_start_download.Enabled = false;
            this.btn_start_download.FlatAppearance.BorderSize = 0;
            this.btn_start_download.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start_download.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_start_download.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_start_download.Location = new System.Drawing.Point(463, 216);
            this.btn_start_download.Name = "btn_start_download";
            this.btn_start_download.Size = new System.Drawing.Size(170, 30);
            this.btn_start_download.TabIndex = 4;
            this.btn_start_download.Text = "START DOWNLOAD";
            this.btn_start_download.UseVisualStyleBackColor = false;
            this.btn_start_download.Click += new System.EventHandler(this.btn_start_download_Click);
            // 
            // lbl_language
            // 
            this.lbl_language.AutoSize = true;
            this.lbl_language.Location = new System.Drawing.Point(305, 126);
            this.lbl_language.Name = "lbl_language";
            this.lbl_language.Size = new System.Drawing.Size(70, 14);
            this.lbl_language.TabIndex = 6;
            this.lbl_language.Text = "Language";
            // 
            // cb_product
            // 
            this.cb_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_product.FormattingEnabled = true;
            this.cb_product.Items.AddRange(new object[] {
            "Windows",
            "Office"});
            this.cb_product.Location = new System.Drawing.Point(394, 40);
            this.cb_product.Name = "cb_product";
            this.cb_product.Size = new System.Drawing.Size(239, 22);
            this.cb_product.TabIndex = 7;
            this.cb_product.SelectedIndexChanged += new System.EventHandler(this.cb_product_SelectedIndexChanged);
            // 
            // cb_version
            // 
            this.cb_version.Enabled = false;
            this.cb_version.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_version.FormattingEnabled = true;
            this.cb_version.Location = new System.Drawing.Point(394, 83);
            this.cb_version.Name = "cb_version";
            this.cb_version.Size = new System.Drawing.Size(239, 22);
            this.cb_version.TabIndex = 8;
            this.cb_version.SelectedIndexChanged += new System.EventHandler(this.cb_version_SelectedIndexChanged);
            // 
            // cb_language
            // 
            this.cb_language.Enabled = false;
            this.cb_language.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_language.FormattingEnabled = true;
            this.cb_language.Location = new System.Drawing.Point(394, 123);
            this.cb_language.Name = "cb_language";
            this.cb_language.Size = new System.Drawing.Size(239, 22);
            this.cb_language.TabIndex = 9;
            this.cb_language.SelectedIndexChanged += new System.EventHandler(this.cb_language_SelectedIndexChanged);
            // 
            // cb_arch
            // 
            this.cb_arch.Enabled = false;
            this.cb_arch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_arch.FormattingEnabled = true;
            this.cb_arch.Location = new System.Drawing.Point(394, 166);
            this.cb_arch.Name = "cb_arch";
            this.cb_arch.Size = new System.Drawing.Size(239, 22);
            this.cb_arch.TabIndex = 10;
            this.cb_arch.SelectedIndexChanged += new System.EventHandler(this.cb_arch_SelectedIndexChanged);
            // 
            // lbl_contact
            // 
            this.lbl_contact.AutoSize = true;
            this.lbl_contact.LinkColor = System.Drawing.Color.LightSteelBlue;
            this.lbl_contact.Location = new System.Drawing.Point(548, 9);
            this.lbl_contact.Name = "lbl_contact";
            this.lbl_contact.Size = new System.Drawing.Size(85, 14);
            this.lbl_contact.TabIndex = 11;
            this.lbl_contact.TabStop = true;
            this.lbl_contact.Text = "@danhpaiva";
            this.lbl_contact.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_contact_LinkClicked);
            // 
            // F_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(676, 272);
            this.Controls.Add(this.lbl_contact);
            this.Controls.Add(this.cb_arch);
            this.Controls.Add(this.cb_language);
            this.Controls.Add(this.cb_version);
            this.Controls.Add(this.cb_product);
            this.Controls.Add(this.lbl_language);
            this.Controls.Add(this.btn_start_download);
            this.Controls.Add(this.lbl_arch);
            this.Controls.Add(this.lbl_version);
            this.Controls.Add(this.lbl_product);
            this.Controls.Add(this.pb_principal);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "F_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pruu Image Downloader";
            ((System.ComponentModel.ISupportInitialize)(this.pb_principal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pb_principal;
        private Label lbl_product;
        private Label lbl_version;
        private Label lbl_arch;
        private Button btn_start_download;
        private Label lbl_language;
        private ComboBox cb_product;
        private ComboBox cb_version;
        private ComboBox cb_language;
        private ComboBox cb_arch;
        private LinkLabel lbl_contact;
    }
}