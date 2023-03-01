namespace _Capa_Negocios
{
    partial class _Configuracion
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
            this.TXT_PASSWORD = new System.Windows.Forms.TextBox();
            this.TXT_USUARIO = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.TXT_BASE = new System.Windows.Forms.TextBox();
            this.TXT_SERVIDOR = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.LBL_SEERVIDOR = new System.Windows.Forms.Label();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.CBO_AUTENTICACION = new System.Windows.Forms.ComboBox();
            this.BTN_CANCELAR = new MVASQUEZ__CONTROLES.MV_BOTON();
            this.BTN_ACEPTAR = new System.Windows.Forms.Button();
            this.GroupBox1.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TXT_PASSWORD
            // 
            this.TXT_PASSWORD.Location = new System.Drawing.Point(99, 36);
            this.TXT_PASSWORD.MaxLength = 50;
            this.TXT_PASSWORD.Name = "TXT_PASSWORD";
            this.TXT_PASSWORD.Size = new System.Drawing.Size(220, 20);
            this.TXT_PASSWORD.TabIndex = 17;
            // 
            // TXT_USUARIO
            // 
            this.TXT_USUARIO.Location = new System.Drawing.Point(99, 14);
            this.TXT_USUARIO.MaxLength = 50;
            this.TXT_USUARIO.Name = "TXT_USUARIO";
            this.TXT_USUARIO.Size = new System.Drawing.Size(220, 20);
            this.TXT_USUARIO.TabIndex = 16;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(19, 89);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(79, 13);
            this.Label2.TabIndex = 25;
            this.Label2.Text = "Autenticacion :";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(40, 17);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(50, 13);
            this.Label4.TabIndex = 15;
            this.Label4.Text = "Usuario :";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(29, 39);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(60, 13);
            this.Label5.TabIndex = 15;
            this.Label5.Text = "Password :";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.TXT_BASE);
            this.GroupBox1.Controls.Add(this.TXT_SERVIDOR);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.LBL_SEERVIDOR);
            this.GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(331, 63);
            this.GroupBox1.TabIndex = 26;
            this.GroupBox1.TabStop = false;
            // 
            // TXT_BASE
            // 
            this.TXT_BASE.Location = new System.Drawing.Point(97, 38);
            this.TXT_BASE.MaxLength = 50;
            this.TXT_BASE.Name = "TXT_BASE";
            this.TXT_BASE.Size = new System.Drawing.Size(221, 20);
            this.TXT_BASE.TabIndex = 17;
            // 
            // TXT_SERVIDOR
            // 
            this.TXT_SERVIDOR.Location = new System.Drawing.Point(98, 14);
            this.TXT_SERVIDOR.MaxLength = 50;
            this.TXT_SERVIDOR.Name = "TXT_SERVIDOR";
            this.TXT_SERVIDOR.Size = new System.Drawing.Size(220, 20);
            this.TXT_SERVIDOR.TabIndex = 16;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(56, 40);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(37, 13);
            this.Label3.TabIndex = 15;
            this.Label3.Text = "Base :";
            // 
            // LBL_SEERVIDOR
            // 
            this.LBL_SEERVIDOR.AutoSize = true;
            this.LBL_SEERVIDOR.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_SEERVIDOR.ForeColor = System.Drawing.Color.Black;
            this.LBL_SEERVIDOR.Location = new System.Drawing.Point(37, 18);
            this.LBL_SEERVIDOR.Name = "LBL_SEERVIDOR";
            this.LBL_SEERVIDOR.Size = new System.Drawing.Size(54, 13);
            this.LBL_SEERVIDOR.TabIndex = 13;
            this.LBL_SEERVIDOR.Text = "Servidor :";
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.TXT_PASSWORD);
            this.GroupBox3.Controls.Add(this.TXT_USUARIO);
            this.GroupBox3.Controls.Add(this.Label4);
            this.GroupBox3.Controls.Add(this.Label5);
            this.GroupBox3.Location = new System.Drawing.Point(11, 112);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(332, 62);
            this.GroupBox3.TabIndex = 27;
            this.GroupBox3.TabStop = false;
            // 
            // CBO_AUTENTICACION
            // 
            this.CBO_AUTENTICACION.FormattingEnabled = true;
            this.CBO_AUTENTICACION.Items.AddRange(new object[] {
            "Autenticaión de Windows",
            "Autenticación de SQLServer"});
            this.CBO_AUTENTICACION.Location = new System.Drawing.Point(110, 83);
            this.CBO_AUTENTICACION.Name = "CBO_AUTENTICACION";
            this.CBO_AUTENTICACION.Size = new System.Drawing.Size(220, 21);
            this.CBO_AUTENTICACION.TabIndex = 29;
            this.CBO_AUTENTICACION.SelectedIndexChanged += new System.EventHandler(this.CBO_AUTENTICACION_SelectedIndexChanged);
            // 
            // BTN_CANCELAR
            // 
            this.BTN_CANCELAR.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.BTN_CANCELAR.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Info;
            this.BTN_CANCELAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.BTN_CANCELAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CANCELAR.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CANCELAR.Image = global::_Capa_Negocios.Properties.Resources.cancelar_16x16;
            this.BTN_CANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_CANCELAR.Location = new System.Drawing.Point(182, 195);
            this.BTN_CANCELAR.Name = "BTN_CANCELAR";
            this.BTN_CANCELAR.Size = new System.Drawing.Size(93, 23);
            this.BTN_CANCELAR.TabIndex = 30;
            this.BTN_CANCELAR.Text = "Cancelar";
            this.BTN_CANCELAR.UseVisualStyleBackColor = true;
            this.BTN_CANCELAR.Click += new System.EventHandler(this.BTN_CANCELAR_Click);
            // 
            // BTN_ACEPTAR
            // 
            this.BTN_ACEPTAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_ACEPTAR.Image = global::_Capa_Negocios.Properties.Resources.seleccionar_16x16;
            this.BTN_ACEPTAR.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_ACEPTAR.Location = new System.Drawing.Point(52, 195);
            this.BTN_ACEPTAR.Name = "BTN_ACEPTAR";
            this.BTN_ACEPTAR.Size = new System.Drawing.Size(104, 23);
            this.BTN_ACEPTAR.TabIndex = 28;
            this.BTN_ACEPTAR.Text = "Aceptar";
            this.BTN_ACEPTAR.UseVisualStyleBackColor = true;
            this.BTN_ACEPTAR.Click += new System.EventHandler(this.BTN_ACEPTAR_Click);
            // 
            // _Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(366, 230);
            this.Controls.Add(this.BTN_CANCELAR);
            this.Controls.Add(this.CBO_AUTENTICACION);
            this.Controls.Add(this.BTN_ACEPTAR);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.GroupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "_Configuracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONFIGURACION";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this._Configuracion_FormClosed);
            this.Load += new System.EventHandler(this._Configuracion_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox TXT_PASSWORD;
        internal System.Windows.Forms.TextBox TXT_USUARIO;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox TXT_BASE;
        internal System.Windows.Forms.TextBox TXT_SERVIDOR;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label LBL_SEERVIDOR;
        internal System.Windows.Forms.GroupBox GroupBox3;
        private System.Windows.Forms.Button BTN_ACEPTAR;
        private System.Windows.Forms.ComboBox CBO_AUTENTICACION;
        private MVASQUEZ__CONTROLES.MV_BOTON BTN_CANCELAR;
    }
}