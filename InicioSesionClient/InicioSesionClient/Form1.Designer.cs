namespace InicioSesionClient
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
            this.textEditInicioSesionUsuario = new DevExpress.XtraEditors.TextEdit();
            this.textEditInicioSesionPassword = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.textEditInicioSesionUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditInicioSesionPassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // textEditInicioSesionUsuario
            // 
            this.textEditInicioSesionUsuario.EditValue = "";
            this.textEditInicioSesionUsuario.Location = new System.Drawing.Point(269, 196);
            this.textEditInicioSesionUsuario.Name = "textEditInicioSesionUsuario";
            this.textEditInicioSesionUsuario.Size = new System.Drawing.Size(287, 20);
            this.textEditInicioSesionUsuario.TabIndex = 0;
            // 
            // textEditInicioSesionPassword
            // 
            this.textEditInicioSesionPassword.EditValue = "";
            this.textEditInicioSesionPassword.Location = new System.Drawing.Point(269, 247);
            this.textEditInicioSesionPassword.Name = "textEditInicioSesionPassword";
            this.textEditInicioSesionPassword.Properties.PasswordChar = '*';
            this.textEditInicioSesionPassword.Properties.UseSystemPasswordChar = true;
            this.textEditInicioSesionPassword.Size = new System.Drawing.Size(287, 20);
            this.textEditInicioSesionPassword.TabIndex = 1;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(269, 303);
            this.simpleButton1.LookAndFeel.SkinName = "Visual Studio 2013 Blue";
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(287, 23);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "Iniciar sesión";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(324, 120);
            this.labelControl3.LookAndFeel.SkinName = "Office 2013";
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(183, 33);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Inicio de sesión";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(269, 176);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Usuario";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(269, 227);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(56, 13);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Contraseña";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 474);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.textEditInicioSesionPassword);
            this.Controls.Add(this.textEditInicioSesionUsuario);
            this.LookAndFeel.SkinName = "Visual Studio 2013 Blue";
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.textEditInicioSesionUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditInicioSesionPassword.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textEditInicioSesionUsuario;
        private DevExpress.XtraEditors.TextEdit textEditInicioSesionPassword;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}

