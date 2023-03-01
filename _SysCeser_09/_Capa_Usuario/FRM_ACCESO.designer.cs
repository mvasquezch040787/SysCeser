namespace _PROYECTO_FINAL_LPV
{
    partial class FRM_ACCESO
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TXT_PASSWORD = new System.Windows.Forms.TextBox();
            this.CBO_NICKS = new MVASQUEZ__CONTROLES.MV_COMBOBOX();
            this.mV_LABEL2 = new MVASQUEZ__CONTROLES.MV_LABEL();
            this.mV_LABEL1 = new MVASQUEZ__CONTROLES.MV_LABEL();
            this._picture_01 = new System.Windows.Forms.PictureBox();
            this.BTN_CANCELAR = new MVASQUEZ__CONTROLES.MV_BOTON();
            this.BNT_ACEPTAR = new MVASQUEZ__CONTROLES.MV_BOTON();
            this._tsp_barra_progreso = new System.Windows.Forms.ProgressBar();
            this._st_autenticacion = new System.Windows.Forms.Label();
            this._tm_barra = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._picture_01)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TXT_PASSWORD);
            this.groupBox1.Controls.Add(this.CBO_NICKS);
            this.groupBox1.Controls.Add(this.mV_LABEL2);
            this.groupBox1.Controls.Add(this.mV_LABEL1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // TXT_PASSWORD
            // 
            this.TXT_PASSWORD.Location = new System.Drawing.Point(105, 50);
            this.TXT_PASSWORD.Name = "TXT_PASSWORD";
            this.TXT_PASSWORD.PasswordChar = '*';
            this.TXT_PASSWORD.Size = new System.Drawing.Size(188, 20);
            this.TXT_PASSWORD.TabIndex = 3;
            // 
            // CBO_NICKS
            // 
            this.CBO_NICKS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBO_NICKS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBO_NICKS.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBO_NICKS.FormattingEnabled = true;
            this.CBO_NICKS.Location = new System.Drawing.Point(105, 19);
            this.CBO_NICKS.Name = "CBO_NICKS";
            this.CBO_NICKS.Size = new System.Drawing.Size(188, 21);
            this.CBO_NICKS.TabIndex = 2;
            // 
            // mV_LABEL2
            // 
            this.mV_LABEL2.AutoSize = true;
            this.mV_LABEL2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mV_LABEL2.Location = new System.Drawing.Point(23, 50);
            this.mV_LABEL2.Name = "mV_LABEL2";
            this.mV_LABEL2.Size = new System.Drawing.Size(60, 13);
            this.mV_LABEL2.TabIndex = 1;
            this.mV_LABEL2.Text = "Password :";
            this.mV_LABEL2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mV_LABEL1
            // 
            this.mV_LABEL1.AutoSize = true;
            this.mV_LABEL1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mV_LABEL1.Location = new System.Drawing.Point(50, 19);
            this.mV_LABEL1.Name = "mV_LABEL1";
            this.mV_LABEL1.Size = new System.Drawing.Size(33, 13);
            this.mV_LABEL1.TabIndex = 0;
            this.mV_LABEL1.Text = "Nick :";
            this.mV_LABEL1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _picture_01
            // 
            this._picture_01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._picture_01.Image = global::_PROYECTO_FINAL_LPV.Properties.Resources.Cliente_128x128;
            this._picture_01.Location = new System.Drawing.Point(344, 12);
            this._picture_01.Name = "_picture_01";
            this._picture_01.Size = new System.Drawing.Size(112, 111);
            this._picture_01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._picture_01.TabIndex = 3;
            this._picture_01.TabStop = false;
            // 
            // BTN_CANCELAR
            // 
            this.BTN_CANCELAR.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.BTN_CANCELAR.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Info;
            this.BTN_CANCELAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.BTN_CANCELAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CANCELAR.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CANCELAR.Image = global::_PROYECTO_FINAL_LPV.Properties.Resources.cancelar_16x16;
            this.BTN_CANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_CANCELAR.Location = new System.Drawing.Point(198, 100);
            this.BTN_CANCELAR.Name = "BTN_CANCELAR";
            this.BTN_CANCELAR.Size = new System.Drawing.Size(107, 23);
            this.BTN_CANCELAR.TabIndex = 2;
            this.BTN_CANCELAR.Text = "Cancelar";
            this.BTN_CANCELAR.UseVisualStyleBackColor = true;
            this.BTN_CANCELAR.Click += new System.EventHandler(this.BTN_CANCELAR_Click);
            // 
            // BNT_ACEPTAR
            // 
            this.BNT_ACEPTAR.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.BNT_ACEPTAR.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Info;
            this.BNT_ACEPTAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.BNT_ACEPTAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BNT_ACEPTAR.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BNT_ACEPTAR.Image = global::_PROYECTO_FINAL_LPV.Properties.Resources.seleccionar_16x16;
            this.BNT_ACEPTAR.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BNT_ACEPTAR.Location = new System.Drawing.Point(65, 100);
            this.BNT_ACEPTAR.Name = "BNT_ACEPTAR";
            this.BNT_ACEPTAR.Size = new System.Drawing.Size(107, 23);
            this.BNT_ACEPTAR.TabIndex = 1;
            this.BNT_ACEPTAR.Text = "Aceptar";
            this.BNT_ACEPTAR.UseVisualStyleBackColor = true;
            this.BNT_ACEPTAR.Click += new System.EventHandler(this.BNT_ACEPTAR_Click);
            // 
            // _tsp_barra_progreso
            // 
            this._tsp_barra_progreso.Location = new System.Drawing.Point(65, 139);
            this._tsp_barra_progreso.Name = "_tsp_barra_progreso";
            this._tsp_barra_progreso.Size = new System.Drawing.Size(200, 15);
            this._tsp_barra_progreso.TabIndex = 4;
            // 
            // _st_autenticacion
            // 
            this._st_autenticacion.AutoSize = true;
            this._st_autenticacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._st_autenticacion.Location = new System.Drawing.Point(275, 139);
            this._st_autenticacion.Name = "_st_autenticacion";
            this._st_autenticacion.Size = new System.Drawing.Size(0, 13);
            this._st_autenticacion.TabIndex = 5;
            // 
            // _tm_barra
            // 
            this._tm_barra.Tick += new System.EventHandler(this._tm_barra_Tick);
            // 
            // FRM_ACCESO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(469, 170);
            this.Controls.Add(this._st_autenticacion);
            this.Controls.Add(this._tsp_barra_progreso);
            this.Controls.Add(this._picture_01);
            this.Controls.Add(this.BTN_CANCELAR);
            this.Controls.Add(this.BNT_ACEPTAR);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_ACCESO";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ACCESO";
            this.Load += new System.EventHandler(this.FRM_ACCESO_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._picture_01)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MVASQUEZ__CONTROLES.MV_COMBOBOX CBO_NICKS;
        private MVASQUEZ__CONTROLES.MV_LABEL mV_LABEL2;
        private MVASQUEZ__CONTROLES.MV_LABEL mV_LABEL1;
        private MVASQUEZ__CONTROLES.MV_BOTON BNT_ACEPTAR;
        private MVASQUEZ__CONTROLES.MV_BOTON BTN_CANCELAR;
        private System.Windows.Forms.TextBox TXT_PASSWORD;
        private System.Windows.Forms.PictureBox _picture_01;
        private System.Windows.Forms.ProgressBar _tsp_barra_progreso;
        private System.Windows.Forms.Label _st_autenticacion;
        private System.Windows.Forms.Timer _tm_barra;
    }
}