namespace LibraryManagementSystem.ui
{
    partial class SignUp
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
            this.materialDrawer1 = new MaterialSkin.Controls.MaterialDrawer();
            this.idBox = new MaterialSkin.Controls.MaterialTextBox();
            this.nameBox = new MaterialSkin.Controls.MaterialTextBox();
            this.addressBox = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.dataPage = new System.Windows.Forms.TabPage();
            this.genreList = new MaterialSkin.Controls.MaterialComboBox();
            this.ageSlider = new MaterialSkin.Controls.MaterialSlider();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.phoneBox = new MaterialSkin.Controls.MaterialTextBox();
            this.emailBox = new MaterialSkin.Controls.MaterialTextBox();
            this.credentialPage = new System.Windows.Forms.TabPage();
            this.eye2Picture = new System.Windows.Forms.PictureBox();
            this.eyePicture = new System.Windows.Forms.PictureBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.registerBtn = new MaterialSkin.Controls.MaterialButton();
            this.passwordBox2 = new MaterialSkin.Controls.MaterialTextBox();
            this.passwordBox = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTabControl1.SuspendLayout();
            this.dataPage.SuspendLayout();
            this.credentialPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eye2Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // materialDrawer1
            // 
            this.materialDrawer1.AutoHide = false;
            this.materialDrawer1.AutoShow = false;
            this.materialDrawer1.BackgroundWithAccent = false;
            this.materialDrawer1.BaseTabControl = null;
            this.materialDrawer1.Depth = 0;
            this.materialDrawer1.HighlightWithAccent = true;
            this.materialDrawer1.IndicatorWidth = 0;
            this.materialDrawer1.IsOpen = false;
            this.materialDrawer1.Location = new System.Drawing.Point(-250, 188);
            this.materialDrawer1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDrawer1.Name = "materialDrawer1";
            this.materialDrawer1.ShowIconsWhenHidden = false;
            this.materialDrawer1.Size = new System.Drawing.Size(250, 120);
            this.materialDrawer1.TabIndex = 4;
            this.materialDrawer1.Text = "materialDrawer1";
            this.materialDrawer1.UseColors = false;
            // 
            // idBox
            // 
            this.idBox.AnimateReadOnly = false;
            this.idBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idBox.Depth = 0;
            this.idBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.idBox.LeadingIcon = null;
            this.idBox.Location = new System.Drawing.Point(25, 50);
            this.idBox.MaxLength = 50;
            this.idBox.MouseState = MaterialSkin.MouseState.OUT;
            this.idBox.Multiline = false;
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(209, 50);
            this.idBox.TabIndex = 6;
            this.idBox.Text = "";
            this.idBox.TrailingIcon = null;
            // 
            // nameBox
            // 
            this.nameBox.AnimateReadOnly = false;
            this.nameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameBox.Depth = 0;
            this.nameBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.nameBox.LeadingIcon = null;
            this.nameBox.Location = new System.Drawing.Point(24, 129);
            this.nameBox.MaxLength = 50;
            this.nameBox.MouseState = MaterialSkin.MouseState.OUT;
            this.nameBox.Multiline = false;
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(210, 50);
            this.nameBox.TabIndex = 7;
            this.nameBox.Text = "";
            this.nameBox.TrailingIcon = null;
            // 
            // addressBox
            // 
            this.addressBox.AnimateReadOnly = false;
            this.addressBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addressBox.Depth = 0;
            this.addressBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.addressBox.LeadingIcon = null;
            this.addressBox.Location = new System.Drawing.Point(280, 211);
            this.addressBox.MaxLength = 50;
            this.addressBox.MouseState = MaterialSkin.MouseState.OUT;
            this.addressBox.Multiline = false;
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(209, 50);
            this.addressBox.TabIndex = 9;
            this.addressBox.Text = "";
            this.addressBox.TrailingIcon = null;
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.dataPage);
            this.materialTabControl1.Controls.Add(this.credentialPage);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(522, 340);
            this.materialTabControl1.TabIndex = 10;
            // 
            // dataPage
            // 
            this.dataPage.BackColor = System.Drawing.SystemColors.Control;
            this.dataPage.Controls.Add(this.genreList);
            this.dataPage.Controls.Add(this.ageSlider);
            this.dataPage.Controls.Add(this.materialLabel1);
            this.dataPage.Controls.Add(this.phoneBox);
            this.dataPage.Controls.Add(this.emailBox);
            this.dataPage.Controls.Add(this.idBox);
            this.dataPage.Controls.Add(this.addressBox);
            this.dataPage.Controls.Add(this.nameBox);
            this.dataPage.Location = new System.Drawing.Point(4, 22);
            this.dataPage.Name = "dataPage";
            this.dataPage.Padding = new System.Windows.Forms.Padding(3);
            this.dataPage.Size = new System.Drawing.Size(514, 314);
            this.dataPage.TabIndex = 0;
            this.dataPage.Text = "Datos personales";
            // 
            // genreList
            // 
            this.genreList.AutoResize = false;
            this.genreList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.genreList.Depth = 0;
            this.genreList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.genreList.DropDownHeight = 174;
            this.genreList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genreList.DropDownWidth = 121;
            this.genreList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.genreList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.genreList.FormattingEnabled = true;
            this.genreList.IntegralHeight = false;
            this.genreList.ItemHeight = 43;
            this.genreList.Items.AddRange(new object[] {
            "GÉNERO",
            "MASCULINO",
            "FEMENINO"});
            this.genreList.Location = new System.Drawing.Point(24, 210);
            this.genreList.MaxDropDownItems = 4;
            this.genreList.MouseState = MaterialSkin.MouseState.OUT;
            this.genreList.Name = "genreList";
            this.genreList.Size = new System.Drawing.Size(210, 49);
            this.genreList.StartIndex = 0;
            this.genreList.TabIndex = 14;
            // 
            // ageSlider
            // 
            this.ageSlider.Depth = 0;
            this.ageSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ageSlider.Location = new System.Drawing.Point(139, 275);
            this.ageSlider.MouseState = MaterialSkin.MouseState.HOVER;
            this.ageSlider.Name = "ageSlider";
            this.ageSlider.Size = new System.Drawing.Size(250, 40);
            this.ageSlider.TabIndex = 13;
            this.ageSlider.Text = "Edad";
            this.ageSlider.Value = 0;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(176, 13);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(156, 19);
            this.materialLabel1.TabIndex = 12;
            this.materialLabel1.Text = "DATOS PERSONALES";
            // 
            // phoneBox
            // 
            this.phoneBox.AnimateReadOnly = false;
            this.phoneBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoneBox.Depth = 0;
            this.phoneBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.phoneBox.LeadingIcon = null;
            this.phoneBox.Location = new System.Drawing.Point(280, 129);
            this.phoneBox.MaxLength = 50;
            this.phoneBox.MouseState = MaterialSkin.MouseState.OUT;
            this.phoneBox.Multiline = false;
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(209, 50);
            this.phoneBox.TabIndex = 11;
            this.phoneBox.Text = "";
            this.phoneBox.TrailingIcon = null;
            // 
            // emailBox
            // 
            this.emailBox.AnimateReadOnly = false;
            this.emailBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailBox.Depth = 0;
            this.emailBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.emailBox.LeadingIcon = null;
            this.emailBox.Location = new System.Drawing.Point(280, 50);
            this.emailBox.MaxLength = 50;
            this.emailBox.MouseState = MaterialSkin.MouseState.OUT;
            this.emailBox.Multiline = false;
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(209, 50);
            this.emailBox.TabIndex = 10;
            this.emailBox.Text = "";
            this.emailBox.TrailingIcon = null;
            this.emailBox.TextChanged += new System.EventHandler(this.emailBox_TextChanged);
            // 
            // credentialPage
            // 
            this.credentialPage.BackColor = System.Drawing.SystemColors.Control;
            this.credentialPage.Controls.Add(this.eye2Picture);
            this.credentialPage.Controls.Add(this.eyePicture);
            this.credentialPage.Controls.Add(this.materialLabel2);
            this.credentialPage.Controls.Add(this.registerBtn);
            this.credentialPage.Controls.Add(this.passwordBox2);
            this.credentialPage.Controls.Add(this.passwordBox);
            this.credentialPage.Location = new System.Drawing.Point(4, 22);
            this.credentialPage.Name = "credentialPage";
            this.credentialPage.Padding = new System.Windows.Forms.Padding(3);
            this.credentialPage.Size = new System.Drawing.Size(514, 314);
            this.credentialPage.TabIndex = 1;
            this.credentialPage.Text = "Credenciales";
            // 
            // eye2Picture
            // 
            this.eye2Picture.Image = global::LibraryManagementSystem.Properties.Resources.vista;
            this.eye2Picture.Location = new System.Drawing.Point(380, 182);
            this.eye2Picture.Name = "eye2Picture";
            this.eye2Picture.Size = new System.Drawing.Size(71, 40);
            this.eye2Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.eye2Picture.TabIndex = 9;
            this.eye2Picture.TabStop = false;
            this.eye2Picture.Click += new System.EventHandler(this.eye2Picture_Click);
            // 
            // eyePicture
            // 
            this.eyePicture.Image = global::LibraryManagementSystem.Properties.Resources.vista;
            this.eyePicture.Location = new System.Drawing.Point(380, 82);
            this.eyePicture.Name = "eyePicture";
            this.eyePicture.Size = new System.Drawing.Size(71, 40);
            this.eyePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.eyePicture.TabIndex = 8;
            this.eyePicture.TabStop = false;
            this.eyePicture.Click += new System.EventHandler(this.eyePicture_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(197, 13);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(113, 19);
            this.materialLabel2.TabIndex = 7;
            this.materialLabel2.Text = "CREDENCIALES";
            // 
            // registerBtn
            // 
            this.registerBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.registerBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.registerBtn.Depth = 0;
            this.registerBtn.HighEmphasis = true;
            this.registerBtn.Icon = null;
            this.registerBtn.Location = new System.Drawing.Point(200, 272);
            this.registerBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.registerBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.registerBtn.Size = new System.Drawing.Size(116, 36);
            this.registerBtn.TabIndex = 6;
            this.registerBtn.Text = "Registrarse";
            this.registerBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.registerBtn.UseAccentColor = false;
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // passwordBox2
            // 
            this.passwordBox2.AnimateReadOnly = false;
            this.passwordBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordBox2.Depth = 0;
            this.passwordBox2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.passwordBox2.LeadingIcon = null;
            this.passwordBox2.Location = new System.Drawing.Point(93, 172);
            this.passwordBox2.MaxLength = 50;
            this.passwordBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.passwordBox2.Multiline = false;
            this.passwordBox2.Name = "passwordBox2";
            this.passwordBox2.Password = true;
            this.passwordBox2.Size = new System.Drawing.Size(281, 50);
            this.passwordBox2.TabIndex = 2;
            this.passwordBox2.Text = "";
            this.passwordBox2.TrailingIcon = null;
            // 
            // passwordBox
            // 
            this.passwordBox.AnimateReadOnly = false;
            this.passwordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordBox.Depth = 0;
            this.passwordBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.passwordBox.LeadingIcon = null;
            this.passwordBox.Location = new System.Drawing.Point(93, 72);
            this.passwordBox.MaxLength = 50;
            this.passwordBox.MouseState = MaterialSkin.MouseState.OUT;
            this.passwordBox.Multiline = false;
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Password = true;
            this.passwordBox.Size = new System.Drawing.Size(281, 50);
            this.passwordBox.TabIndex = 1;
            this.passwordBox.Text = "";
            this.passwordBox.TrailingIcon = null;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 407);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialDrawer1);
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SignUp_FormClosed);
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.dataPage.ResumeLayout(false);
            this.dataPage.PerformLayout();
            this.credentialPage.ResumeLayout(false);
            this.credentialPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eye2Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialDrawer materialDrawer1;
        private MaterialSkin.Controls.MaterialTextBox idBox;
        private MaterialSkin.Controls.MaterialTextBox nameBox;
        private MaterialSkin.Controls.MaterialTextBox addressBox;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage dataPage;
        private System.Windows.Forms.TabPage credentialPage;
        private MaterialSkin.Controls.MaterialTextBox phoneBox;
        private MaterialSkin.Controls.MaterialTextBox emailBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialComboBox genreList;
        private MaterialSkin.Controls.MaterialSlider ageSlider;
        private MaterialSkin.Controls.MaterialTextBox passwordBox;
        private MaterialSkin.Controls.MaterialTextBox passwordBox2;
        private MaterialSkin.Controls.MaterialButton registerBtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.PictureBox eyePicture;
        private System.Windows.Forms.PictureBox eye2Picture;
    }
}