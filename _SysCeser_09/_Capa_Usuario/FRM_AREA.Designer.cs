namespace _PROYECTO_FINAL_LPV
{
    partial class FRM_AREA
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
            this.mV_LABEL1 = new MVASQUEZ__CONTROLES.MV_LABEL();
            this.@__txt_area = new MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_area = new MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM();
            this.mV_LABEL2 = new MVASQUEZ__CONTROLES.MV_LABEL();
            this.BTN_GUARDAR = new MVASQUEZ__CONTROLES.MV_BOTON();
            this.BTN_CANCELAR = new MVASQUEZ__CONTROLES.MV_BOTON();
            this.BTN_NUEVO = new MVASQUEZ__CONTROLES.MV_BOTON();
            this.BTN_SALIR = new MVASQUEZ__CONTROLES.MV_BOTON();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mV_LABEL1
            // 
            this.mV_LABEL1.AutoSize = true;
            this.mV_LABEL1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mV_LABEL1.Location = new System.Drawing.Point(43, 17);
            this.mV_LABEL1.Name = "mV_LABEL1";
            this.mV_LABEL1.Size = new System.Drawing.Size(49, 13);
            this.mV_LABEL1.TabIndex = 0;
            this.mV_LABEL1.Text = "Id area :";
            this.mV_LABEL1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // __txt_area
            // 
            this.@__txt_area.BackColor = System.Drawing.Color.White;
            this.@__txt_area.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.@__txt_area.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.@__txt_area.Location = new System.Drawing.Point(100, 14);
            this.@__txt_area.Name = "__txt_area";
            this.@__txt_area.ReadOnly = true;
            this.@__txt_area.Size = new System.Drawing.Size(111, 21);
            this.@__txt_area.TabIndex = 1;
            this.@__txt_area.TIPO_TEXTBOX = MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM.E_TIPO_TEXBOX.ES_ID;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mV_LABEL1);
            this.groupBox1.Controls.Add(this.@__txt_area);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 44);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_area);
            this.groupBox2.Controls.Add(this.mV_LABEL2);
            this.groupBox2.Location = new System.Drawing.Point(13, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(448, 53);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // txt_area
            // 
            this.txt_area.BackColor = System.Drawing.Color.White;
            this.txt_area.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_area.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txt_area.Location = new System.Drawing.Point(99, 20);
            this.txt_area.MaxLength = 40;
            this.txt_area.Name = "txt_area";
            this.txt_area.Size = new System.Drawing.Size(309, 21);
            this.txt_area.TabIndex = 2;
            this.txt_area.Tag = "Area";
            this.txt_area.TIPO_TEXTBOX = MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM.E_TIPO_TEXBOX.LETRAS;
            // 
            // mV_LABEL2
            // 
            this.mV_LABEL2.AutoSize = true;
            this.mV_LABEL2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mV_LABEL2.Location = new System.Drawing.Point(54, 23);
            this.mV_LABEL2.Name = "mV_LABEL2";
            this.mV_LABEL2.Size = new System.Drawing.Size(37, 13);
            this.mV_LABEL2.TabIndex = 0;
            this.mV_LABEL2.Text = "Area :";
            this.mV_LABEL2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.BTN_GUARDAR.Location = new System.Drawing.Point(10, 121);
            this.BTN_GUARDAR.Name = "BTN_GUARDAR";
            this.BTN_GUARDAR.Size = new System.Drawing.Size(93, 23);
            this.BTN_GUARDAR.TabIndex = 39;
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
            this.BTN_CANCELAR.Location = new System.Drawing.Point(252, 121);
            this.BTN_CANCELAR.Name = "BTN_CANCELAR";
            this.BTN_CANCELAR.Size = new System.Drawing.Size(92, 23);
            this.BTN_CANCELAR.TabIndex = 40;
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
            this.BTN_NUEVO.Location = new System.Drawing.Point(121, 121);
            this.BTN_NUEVO.Name = "BTN_NUEVO";
            this.BTN_NUEVO.Size = new System.Drawing.Size(101, 23);
            this.BTN_NUEVO.TabIndex = 42;
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
            this.BTN_SALIR.Location = new System.Drawing.Point(370, 121);
            this.BTN_SALIR.Name = "BTN_SALIR";
            this.BTN_SALIR.Size = new System.Drawing.Size(90, 23);
            this.BTN_SALIR.TabIndex = 41;
            this.BTN_SALIR.Text = "Salir";
            this.BTN_SALIR.UseVisualStyleBackColor = true;
            this.BTN_SALIR.Click += new System.EventHandler(this.BTN_SALIR_Click);
            // 
            // FRM_AREA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(473, 164);
            this.Controls.Add(this.BTN_GUARDAR);
            this.Controls.Add(this.BTN_CANCELAR);
            this.Controls.Add(this.BTN_NUEVO);
            this.Controls.Add(this.BTN_SALIR);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FRM_AREA";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AREA";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MVASQUEZ__CONTROLES.MV_LABEL mV_LABEL1;
        private MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM __txt_area;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM txt_area;
        private MVASQUEZ__CONTROLES.MV_LABEL mV_LABEL2;
        private MVASQUEZ__CONTROLES.MV_BOTON BTN_GUARDAR;
        private MVASQUEZ__CONTROLES.MV_BOTON BTN_CANCELAR;
        private MVASQUEZ__CONTROLES.MV_BOTON BTN_NUEVO;
        private MVASQUEZ__CONTROLES.MV_BOTON BTN_SALIR;

    }
}