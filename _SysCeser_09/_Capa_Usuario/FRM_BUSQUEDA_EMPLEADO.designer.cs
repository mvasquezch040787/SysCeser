namespace _PROYECTO_FINAL_LPV
{
    partial class FRM_BUSQUEDA_EMPLEADO
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
            this.BTN_SALIR = new MVASQUEZ__CONTROLES.MV_BOTON();
            this.BTN_ACTUALIZAR = new MVASQUEZ__CONTROLES.MV_BOTON();
            this.BTN_NUEVO = new MVASQUEZ__CONTROLES.MV_BOTON();
            this.GRID_EMPLEADOS = new MVASQUEZ__CONTROLES.MV_GRIDVIEW();
            this.mV_LABEL1 = new MVASQUEZ__CONTROLES.MV_LABEL();
            this.TXT_EMPLEADO = new MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.GRID_EMPLEADOS)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_SALIR
            // 
            this.BTN_SALIR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BTN_SALIR.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.BTN_SALIR.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Info;
            this.BTN_SALIR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.BTN_SALIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_SALIR.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_SALIR.Location = new System.Drawing.Point(472, 17);
            this.BTN_SALIR.Name = "BTN_SALIR";
            this.BTN_SALIR.Size = new System.Drawing.Size(113, 23);
            this.BTN_SALIR.TabIndex = 9;
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
            this.BTN_ACTUALIZAR.Location = new System.Drawing.Point(146, 17);
            this.BTN_ACTUALIZAR.Name = "BTN_ACTUALIZAR";
            this.BTN_ACTUALIZAR.Size = new System.Drawing.Size(113, 23);
            this.BTN_ACTUALIZAR.TabIndex = 8;
            this.BTN_ACTUALIZAR.Text = "Modificar";
            this.BTN_ACTUALIZAR.UseVisualStyleBackColor = true;
            this.BTN_ACTUALIZAR.Click += new System.EventHandler(this.BTN_ACTUALIZAR_Click);
            // 
            // BTN_NUEVO
            // 
            this.BTN_NUEVO.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BTN_NUEVO.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.BTN_NUEVO.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Info;
            this.BTN_NUEVO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.BTN_NUEVO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_NUEVO.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_NUEVO.Location = new System.Drawing.Point(18, 17);
            this.BTN_NUEVO.Name = "BTN_NUEVO";
            this.BTN_NUEVO.Size = new System.Drawing.Size(113, 23);
            this.BTN_NUEVO.TabIndex = 7;
            this.BTN_NUEVO.Text = "Nuevo";
            this.BTN_NUEVO.UseVisualStyleBackColor = true;
            this.BTN_NUEVO.Click += new System.EventHandler(this.BTN_NUEVO_Click);
            // 
            // GRID_EMPLEADOS
            // 
            this.GRID_EMPLEADOS.AllowUserToAddRows = false;
            this.GRID_EMPLEADOS.AllowUserToDeleteRows = false;
            this.GRID_EMPLEADOS.AllowUserToResizeColumns = false;
            this.GRID_EMPLEADOS.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.GRID_EMPLEADOS.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GRID_EMPLEADOS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GRID_EMPLEADOS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GRID_EMPLEADOS.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GRID_EMPLEADOS.BackgroundColor = System.Drawing.Color.White;
            this.GRID_EMPLEADOS.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GRID_EMPLEADOS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GRID_EMPLEADOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GRID_EMPLEADOS.DefaultCellStyle = dataGridViewCellStyle3;
            this.GRID_EMPLEADOS.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.GRID_EMPLEADOS.EnableHeadersVisualStyles = false;
            this.GRID_EMPLEADOS.Location = new System.Drawing.Point(24, 83);
            this.GRID_EMPLEADOS.MultiSelect = false;
            this.GRID_EMPLEADOS.Name = "GRID_EMPLEADOS";
            this.GRID_EMPLEADOS.ReadOnly = true;
            this.GRID_EMPLEADOS.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GRID_EMPLEADOS.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GRID_EMPLEADOS.RowHeadersVisible = false;
            this.GRID_EMPLEADOS.RowHeadersWidth = 200;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Blue;
            this.GRID_EMPLEADOS.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.GRID_EMPLEADOS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GRID_EMPLEADOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GRID_EMPLEADOS.Size = new System.Drawing.Size(614, 143);
            this.GRID_EMPLEADOS.TabIndex = 6;
            this.GRID_EMPLEADOS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GRID_EMPLEADOS_CellContentClick);
            this.GRID_EMPLEADOS.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GRID_EMPLEADOS_CellDoubleClick);
            // 
            // mV_LABEL1
            // 
            this.mV_LABEL1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mV_LABEL1.AutoSize = true;
            this.mV_LABEL1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mV_LABEL1.Location = new System.Drawing.Point(19, 20);
            this.mV_LABEL1.Name = "mV_LABEL1";
            this.mV_LABEL1.Size = new System.Drawing.Size(109, 13);
            this.mV_LABEL1.TabIndex = 1;
            this.mV_LABEL1.Text = "Apellidos y nombres :";
            this.mV_LABEL1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TXT_EMPLEADO
            // 
            this.TXT_EMPLEADO.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TXT_EMPLEADO.BackColor = System.Drawing.Color.White;
            this.TXT_EMPLEADO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXT_EMPLEADO.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.TXT_EMPLEADO.Location = new System.Drawing.Point(134, 17);
            this.TXT_EMPLEADO.Name = "TXT_EMPLEADO";
            this.TXT_EMPLEADO.Size = new System.Drawing.Size(455, 21);
            this.TXT_EMPLEADO.TabIndex = 0;
            this.TXT_EMPLEADO.TIPO_TEXTBOX = MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM.E_TIPO_TEXBOX.GENERAL;
            this.TXT_EMPLEADO.TextChanged += new System.EventHandler(this.TXT_ALUMNO_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.mV_LABEL1);
            this.groupBox1.Controls.Add(this.TXT_EMPLEADO);
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(614, 54);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.BTN_SALIR);
            this.groupBox2.Controls.Add(this.BTN_ACTUALIZAR);
            this.groupBox2.Controls.Add(this.BTN_NUEVO);
            this.groupBox2.Location = new System.Drawing.Point(28, 228);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(609, 49);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // FRM_BUSQUEDA_EMPLEADO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(665, 299);
            this.Controls.Add(this.GRID_EMPLEADOS);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRM_BUSQUEDA_EMPLEADO";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BUSQUEDA EMPLEADO";
            this.Load += new System.EventHandler(this.FRM_BUSQUEDA_EMPLEADO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GRID_EMPLEADOS)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MVASQUEZ__CONTROLES.MV_BOTON BTN_SALIR;
        private MVASQUEZ__CONTROLES.MV_BOTON BTN_ACTUALIZAR;
        private MVASQUEZ__CONTROLES.MV_BOTON BTN_NUEVO;
        private MVASQUEZ__CONTROLES.MV_GRIDVIEW GRID_EMPLEADOS;
        private MVASQUEZ__CONTROLES.MV_LABEL mV_LABEL1;
        private MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM TXT_EMPLEADO;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}