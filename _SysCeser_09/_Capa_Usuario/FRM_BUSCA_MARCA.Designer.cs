namespace _PROYECTO_FINAL_LPV
{
    partial class FRM_BUSCA_MARCA
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TXT_MARCA = new MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM();
            this.GRID_MARCA = new MVASQUEZ__CONTROLES.MV_GRIDVIEW();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mV_LABEL1 = new MVASQUEZ__CONTROLES.MV_LABEL();
            this.BTN_NUEVO = new MVASQUEZ__CONTROLES.MV_BOTON();
            this.BTN_SALIR = new MVASQUEZ__CONTROLES.MV_BOTON();
            this.BTN_ACTUALIZAR = new MVASQUEZ__CONTROLES.MV_BOTON();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.GRID_MARCA)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TXT_MARCA
            // 
            this.TXT_MARCA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TXT_MARCA.BackColor = System.Drawing.Color.White;
            this.TXT_MARCA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXT_MARCA.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.TXT_MARCA.Location = new System.Drawing.Point(65, 17);
            this.TXT_MARCA.Name = "TXT_MARCA";
            this.TXT_MARCA.Size = new System.Drawing.Size(215, 21);
            this.TXT_MARCA.TabIndex = 0;
            this.TXT_MARCA.TIPO_TEXTBOX = MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM.E_TIPO_TEXBOX.GENERAL;
            this.TXT_MARCA.TextChanged += new System.EventHandler(this.TXT_MARCA_TextChanged);
            // 
            // GRID_MARCA
            // 
            this.GRID_MARCA.AllowUserToAddRows = false;
            this.GRID_MARCA.AllowUserToDeleteRows = false;
            this.GRID_MARCA.AllowUserToResizeColumns = false;
            this.GRID_MARCA.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.GRID_MARCA.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GRID_MARCA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GRID_MARCA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GRID_MARCA.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GRID_MARCA.BackgroundColor = System.Drawing.Color.White;
            this.GRID_MARCA.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GRID_MARCA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GRID_MARCA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GRID_MARCA.DefaultCellStyle = dataGridViewCellStyle3;
            this.GRID_MARCA.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.GRID_MARCA.EnableHeadersVisualStyles = false;
            this.GRID_MARCA.Location = new System.Drawing.Point(12, 80);
            this.GRID_MARCA.MultiSelect = false;
            this.GRID_MARCA.Name = "GRID_MARCA";
            this.GRID_MARCA.ReadOnly = true;
            this.GRID_MARCA.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GRID_MARCA.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GRID_MARCA.RowHeadersVisible = false;
            this.GRID_MARCA.RowHeadersWidth = 200;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Blue;
            this.GRID_MARCA.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.GRID_MARCA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GRID_MARCA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GRID_MARCA.Size = new System.Drawing.Size(292, 122);
            this.GRID_MARCA.TabIndex = 16;
            this.GRID_MARCA.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GRID_MARCA_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.mV_LABEL1);
            this.groupBox1.Controls.Add(this.TXT_MARCA);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 54);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // mV_LABEL1
            // 
            this.mV_LABEL1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mV_LABEL1.AutoSize = true;
            this.mV_LABEL1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mV_LABEL1.Location = new System.Drawing.Point(19, 20);
            this.mV_LABEL1.Name = "mV_LABEL1";
            this.mV_LABEL1.Size = new System.Drawing.Size(46, 13);
            this.mV_LABEL1.TabIndex = 1;
            this.mV_LABEL1.Text = "Marca  :";
            this.mV_LABEL1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BTN_NUEVO
            // 
            this.BTN_NUEVO.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BTN_NUEVO.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.BTN_NUEVO.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Info;
            this.BTN_NUEVO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.BTN_NUEVO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_NUEVO.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_NUEVO.Image = global::_PROYECTO_FINAL_LPV.Properties.Resources.agregar_grupo_16x16;
            this.BTN_NUEVO.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_NUEVO.Location = new System.Drawing.Point(6, 19);
            this.BTN_NUEVO.Name = "BTN_NUEVO";
            this.BTN_NUEVO.Size = new System.Drawing.Size(76, 23);
            this.BTN_NUEVO.TabIndex = 17;
            this.BTN_NUEVO.Text = "Nuevo";
            this.BTN_NUEVO.UseVisualStyleBackColor = true;
            this.BTN_NUEVO.Click += new System.EventHandler(this.BTN_NUEVO_Click);
            // 
            // BTN_SALIR
            // 
            this.BTN_SALIR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BTN_SALIR.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.BTN_SALIR.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Info;
            this.BTN_SALIR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.BTN_SALIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_SALIR.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_SALIR.Image = global::_PROYECTO_FINAL_LPV.Properties.Resources.cerrar_azul_16x16;
            this.BTN_SALIR.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_SALIR.Location = new System.Drawing.Point(194, 19);
            this.BTN_SALIR.Name = "BTN_SALIR";
            this.BTN_SALIR.Size = new System.Drawing.Size(103, 23);
            this.BTN_SALIR.TabIndex = 19;
            this.BTN_SALIR.Text = "Salir";
            this.BTN_SALIR.UseVisualStyleBackColor = true;
            this.BTN_SALIR.Click += new System.EventHandler(this.BTN_SALIR_Click);
            // 
            // BTN_ACTUALIZAR
            // 
            this.BTN_ACTUALIZAR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BTN_ACTUALIZAR.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.BTN_ACTUALIZAR.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Info;
            this.BTN_ACTUALIZAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.BTN_ACTUALIZAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ACTUALIZAR.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ACTUALIZAR.Image = global::_PROYECTO_FINAL_LPV.Properties.Resources.editar_matricula_16x16;
            this.BTN_ACTUALIZAR.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_ACTUALIZAR.Location = new System.Drawing.Point(97, 19);
            this.BTN_ACTUALIZAR.Name = "BTN_ACTUALIZAR";
            this.BTN_ACTUALIZAR.Size = new System.Drawing.Size(75, 23);
            this.BTN_ACTUALIZAR.TabIndex = 18;
            this.BTN_ACTUALIZAR.Text = "Modificar";
            this.BTN_ACTUALIZAR.UseVisualStyleBackColor = true;
            this.BTN_ACTUALIZAR.Click += new System.EventHandler(this.BTN_ACTUALIZAR_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.BTN_NUEVO);
            this.groupBox2.Controls.Add(this.BTN_SALIR);
            this.groupBox2.Controls.Add(this.BTN_ACTUALIZAR);
            this.groupBox2.Location = new System.Drawing.Point(9, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(303, 49);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // FRM_BUSCA_MARCA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(335, 278);
            this.Controls.Add(this.GRID_MARCA);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FRM_BUSCA_MARCA";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BUSCA MARCA";
            ((System.ComponentModel.ISupportInitialize)(this.GRID_MARCA)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM TXT_MARCA;
        private MVASQUEZ__CONTROLES.MV_BOTON BTN_NUEVO;
        private MVASQUEZ__CONTROLES.MV_GRIDVIEW GRID_MARCA;
        private MVASQUEZ__CONTROLES.MV_BOTON BTN_SALIR;
        private MVASQUEZ__CONTROLES.MV_BOTON BTN_ACTUALIZAR;
        private System.Windows.Forms.GroupBox groupBox1;
        private MVASQUEZ__CONTROLES.MV_LABEL mV_LABEL1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}