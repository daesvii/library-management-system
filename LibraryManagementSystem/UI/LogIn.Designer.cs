namespace LibraryManagementSystem
{
    partial class LogIn
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.idBox = new MaterialSkin.Controls.MaterialTextBox();
            this.passwordLogInBox = new MaterialSkin.Controls.MaterialTextBox();
            this.logInBtn = new MaterialSkin.Controls.MaterialButton();
            this.signUpBtn = new MaterialSkin.Controls.MaterialButton();
            this.eye2Picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.eye2Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // idBox
            // 
            this.idBox.AnimateReadOnly = false;
            this.idBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idBox.Depth = 0;
            this.idBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.idBox.LeadingIcon = null;
            this.idBox.Location = new System.Drawing.Point(117, 123);
            this.idBox.MaxLength = 50;
            this.idBox.MouseState = MaterialSkin.MouseState.OUT;
            this.idBox.Multiline = false;
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(281, 50);
            this.idBox.TabIndex = 2;
            this.idBox.Text = "";
            this.idBox.TrailingIcon = null;
            // 
            // passwordLogInBox
            // 
            this.passwordLogInBox.AnimateReadOnly = false;
            this.passwordLogInBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordLogInBox.Depth = 0;
            this.passwordLogInBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.passwordLogInBox.LeadingIcon = null;
            this.passwordLogInBox.Location = new System.Drawing.Point(117, 218);
            this.passwordLogInBox.MaxLength = 50;
            this.passwordLogInBox.MouseState = MaterialSkin.MouseState.OUT;
            this.passwordLogInBox.Multiline = false;
            this.passwordLogInBox.Name = "passwordLogInBox";
            this.passwordLogInBox.Password = true;
            this.passwordLogInBox.Size = new System.Drawing.Size(281, 50);
            this.passwordLogInBox.TabIndex = 3;
            this.passwordLogInBox.Text = "";
            this.passwordLogInBox.TrailingIcon = null;
            // 
            // logInBtn
            // 
            this.logInBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.logInBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.logInBtn.Depth = 0;
            this.logInBtn.HighEmphasis = true;
            this.logInBtn.Icon = null;
            this.logInBtn.Location = new System.Drawing.Point(117, 310);
            this.logInBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.logInBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.logInBtn.Name = "logInBtn";
            this.logInBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.logInBtn.Size = new System.Drawing.Size(128, 36);
            this.logInBtn.TabIndex = 4;
            this.logInBtn.Text = "Iniciar sesión";
            this.logInBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.logInBtn.UseAccentColor = false;
            this.logInBtn.UseVisualStyleBackColor = true;
            this.logInBtn.Click += new System.EventHandler(this.logInBtn_Click);
            // 
            // signUpBtn
            // 
            this.signUpBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.signUpBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.signUpBtn.Depth = 0;
            this.signUpBtn.HighEmphasis = true;
            this.signUpBtn.Icon = null;
            this.signUpBtn.Location = new System.Drawing.Point(282, 310);
            this.signUpBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.signUpBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.signUpBtn.Size = new System.Drawing.Size(116, 36);
            this.signUpBtn.TabIndex = 5;
            this.signUpBtn.Text = "Registrarse";
            this.signUpBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.signUpBtn.UseAccentColor = false;
            this.signUpBtn.UseVisualStyleBackColor = true;
            this.signUpBtn.Click += new System.EventHandler(this.signUpBtn_Click);
            // 
            // eye2Picture
            // 
            this.eye2Picture.Image = global::LibraryManagementSystem.Properties.Resources.vista;
            this.eye2Picture.Location = new System.Drawing.Point(404, 228);
            this.eye2Picture.Name = "eye2Picture";
            this.eye2Picture.Size = new System.Drawing.Size(71, 40);
            this.eye2Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.eye2Picture.TabIndex = 10;
            this.eye2Picture.TabStop = false;
            this.eye2Picture.Click += new System.EventHandler(this.eye2Picture_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 407);
            this.Controls.Add(this.eye2Picture);
            this.Controls.Add(this.signUpBtn);
            this.Controls.Add(this.logInBtn);
            this.Controls.Add(this.passwordLogInBox);
            this.Controls.Add(this.idBox);
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar sesión";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eye2Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox idBox;
        private MaterialSkin.Controls.MaterialTextBox passwordLogInBox;
        private MaterialSkin.Controls.MaterialButton logInBtn;
        private MaterialSkin.Controls.MaterialButton signUpBtn;
        private System.Windows.Forms.PictureBox eye2Picture;
    }
}

