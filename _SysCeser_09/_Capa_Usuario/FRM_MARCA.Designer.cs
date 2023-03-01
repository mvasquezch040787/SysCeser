namespace _PROYECTO_FINAL_LPV
{
    partial class FRM_MARCA
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
            this._txt_id_marca = new MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM();
            this._txt_marca = new MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mV_LABEL2 = new MVASQUEZ__CONTROLES.MV_LABEL();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mV_LABEL1 = new MVASQUEZ__CONTROLES.MV_LABEL();
            this.BTN_GUARDAR = new MVASQUEZ__CONTROLES.MV_BOTON();
            this.BTN_CANCELAR = new MVASQUEZ__CONTROLES.MV_BOTON();
            this.BTN_NUEVO = new MVASQUEZ__CONTROLES.MV_BOTON();
            this.BTN_SALIR = new MVASQUEZ__CONTROLES.MV_BOTON();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _txt_id_marca
            // 
            this._txt_id_marca.BackColor = System.Drawing.Color.White;
            this._txt_id_marca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this._txt_id_marca.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this._txt_id_marca.Location = new System.Drawing.Point(100, 14);
            this._txt_id_marca.Name = "_txt_id_marca";
            this._txt_id_marca.ReadOnly = true;
            this._txt_id_marca.Size = new System.Drawing.Size(111, 21);
            this._txt_id_marca.TabIndex = 1;
            this._txt_id_marca.TIPO_TEXTBOX = MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM.E_TIPO_TEXBOX.ES_ID;
            // 
            // _txt_marca
            // 
            this._txt_marca.BackColor = System.Drawing.Color.White;
            this._txt_marca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this._txt_marca.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this._txt_marca.Location = new System.Drawing.Point(99, 20);
            this._txt_marca.MaxLength = 40;
            this._txt_marca.Name = "_txt_marca";
            this._txt_marca.Size = new System.Drawing.Size(309, 21);
            this._txt_marca.TabIndex = 2;
            this._txt_marca.Tag = "Area";
            this._txt_marca.TIPO_TEXTBOX = MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM.E_TIPO_TEXBOX.LETRAS;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._txt_marca);
            this.groupBox2.Controls.Add(this.mV_LABEL2);
            this.groupBox2.Location = new System.Drawing.Point(13, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(448, 53);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            // 
            // mV_LABEL2
            // 
            this.mV_LABEL2.AutoSize = true;
            this.mV_LABEL2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mV_LABEL2.Location = new System.Drawing.Point(54, 23);
            this.mV_LABEL2.Name = "mV_LABEL2";
            this.mV_LABEL2.Size = new System.Drawing.Size(43, 13);
            this.mV_LABEL2.TabIndex = 0;
            this.mV_LABEL2.Text = "Marca :";
            this.mV_LABEL2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mV_LABEL1);
            this.groupBox1.Controls.Add(this._txt_id_marca);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 44);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            // 
            // mV_LABEL1
            // 
            this.mV_LABEL1.AutoSize = true;
            this.mV_LABEL1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mV_LABEL1.Location = new System.Drawing.Point(43, 17);
            this.mV_LABEL1.Name = "mV_LABEL1";
            this.mV_LABEL1.Size = new System.Drawing.Size(56, 13);
            this.mV_LABEL1.TabIndex = 0;
            this.mV_LABEL1.Text = "Id marca :";
            this.mV_LABEL1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BTN_GUARDAR
            // 
            this.BTN_GUARDAR.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.BTN_GUARDAR.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Info;
            this.BTN_GUARDAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.BTN_GUARDAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_GUARDAR.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_GUARDAR.Image = global::_PROYECTO_FINAL_LPV.Properties.Resources.guardar_16x16;
            this.BTN_GUARDAR.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_GUARDAR.Location = new System.Drawing.Point(10, 131);
            this.BTN_GUARDAR.Name = "BTN_GUARDAR";
            this.BTN_GUARDAR.Size = new System.Drawing.Size(93, 23);
            this.BTN_GUARDAR.TabIndex = 45;
            this.BTN_GUARDAR.Text = "Guardar";
            this.BTN_GUARDAR.UseVisualStyleBackColor = true;
            this.BTN_GUARDAR.Click += new System.EventHandler(this.BTN_GUARDAR_Click);
            // 
            // BTN_CANCELAR
            // 
            this.BTN_CANCELAR.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.BTN_CANCELAR.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Info;
            this.BTN_CANCELAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.BTN_CANCELAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CANCELAR.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CANCELAR.Image = global::_PROYECTO_FINAL_LPV.Properties.Resources.cancelar_16x161;
            this.BTN_CANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_CANCELAR.Location = new System.Drawing.Point(252, 131);
            this.BTN_CANCELAR.Name = "BTN_CANCELAR";
            this.BTN_CANCELAR.Size = new System.Drawing.Size(92, 23);
            this.BTN_CANCELAR.TabIndex = 46;
            this.BTN_CANCELAR.Text = "Cancelar";
            this.BTN_CANCELAR.UseVisualStyleBackColor = true;
            this.BTN_CANCELAR.Click += new System.EventHandler(this.BTN_CANCELAR_Click);
            // 
            // BTN_NUEVO
            // 
            this.BTN_NUEVO.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.BTN_NUEVO.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Info;
            this.BTN_NUEVO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.BTN_NUEVO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_NUEVO.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_NUEVO.Image = global::_PROYECTO_FINAL_LPV.Properties.Resources.agregar_grupo_16x16;
            this.BTN_NUEVO.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_NUEVO.Location = new System.Drawing.Point(121, 131);
            this.BTN_NUEVO.Name = "BTN_NUEVO";
            this.BTN_NUEVO.Size = new System.Drawing.Size(101, 23);
            this.BTN_NUEVO.TabIndex = 48;
            this.BTN_NUEVO.Text = "Nuevo";
            this.BTN_NUEVO.UseVisualStyleBackColor = true;
            this.BTN_NUEVO.Click += new System.EventHandler(this.BTN_NUEVO_Click);
            // 
            // BTN_SALIR
            // 
            this.BTN_SALIR.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.BTN_SALIR.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Info;
            this.BTN_SALIR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.BTN_SALIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_SALIR.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_SALIR.Image = global::_PROYECTO_FINAL_LPV.Properties.Resources.cerrar_azul_16x16;
            this.BTN_SALIR.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_SALIR.Location = new System.Drawing.Point(370, 131);
            this.BTN_SALIR.Name = "BTN_SALIR";
            this.BTN_SALIR.Size = new System.Drawing.Size(90, 23);
            this.BTN_SALIR.TabIndex = 47;
            this.BTN_SALIR.Text = "Salir";
            this.BTN_SALIR.UseVisualStyleBackColor = true;
            this.BTN_SALIR.Click += new System.EventHandler(this.BTN_SALIR_Click);
            // 
            // FRM_MARCA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(495, 179);
            this.Controls.Add(this.BTN_GUARDAR);
            this.Controls.Add(this.BTN_CANCELAR);
            this.Controls.Add(this.BTN_NUEVO);
            this.Controls.Add(this.BTN_SALIR);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FRM_MARCA";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MARCA";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MVASQUEZ__CONTROLES.MV_BOTON BTN_GUARDAR;
        private MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM _txt_id_marca;
        private MVASQUEZ__CONTROLES.MV_BOTON BTN_CANCELAR;
        private MVASQUEZ__CONTROLES.MV_BOTON BTN_NUEVO;
        private MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM _txt_marca;
        private MVASQUEZ__CONTROLES.MV_BOTON BTN_SALIR;
        private System.Windows.Forms.GroupBox groupBox2;
        private MVASQUEZ__CONTROLES.MV_LABEL mV_LABEL2;
        private System.Windows.Forms.GroupBox groupBox1;
        private MVASQUEZ__CONTROLES.MV_LABEL mV_LABEL1;
    }
}