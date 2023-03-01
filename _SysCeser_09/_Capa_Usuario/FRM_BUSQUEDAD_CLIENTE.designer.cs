namespace _PROYECTO_FINAL_LPV
{
    partial class FRM_BUSQUEDA_CLIENTE
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mV_LABEL1 = new MVASQUEZ__CONTROLES.MV_LABEL();
            this.TXT_CLIENTE = new MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM();
            this.GRID_CLIENTES = new MVASQUEZ__CONTROLES.MV_GRIDVIEW();
            this.BTN_NUEVO = new MVASQUEZ__CONTROLES.MV_BOTON();
            this.BTN_ACTUALIZAR = new MVASQUEZ__CONTROLES.MV_BOTON();
            this.BTN_SALIR = new MVASQUEZ__CONTROLES.MV_BOTON();
            this.btn_seleccionar = new MVASQUEZ__CONTROLES.MV_BOTON();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRID_CLIENTES)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mV_LABEL1);
            this.groupBox1.Controls.Add(this.TXT_CLIENTE);
            this.groupBox1.Location = new System.Drawing.Point(15, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(679, 51);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // mV_LABEL1
            // 
            this.mV_LABEL1.AutoSize = true;
            this.mV_LABEL1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mV_LABEL1.Location = new System.Drawing.Point(19, 20);
            this.mV_LABEL1.Name = "mV_LABEL1";
            this.mV_LABEL1.Size = new System.Drawing.Size(109, 13);
            this.mV_LABEL1.TabIndex = 1;
            this.mV_LABEL1.Text = "Apellidos y nombres :";
            this.mV_LABEL1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TXT_CLIENTE
            // 
            this.TXT_CLIENTE.BackColor = System.Drawing.Color.White;
            this.TXT_CLIENTE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXT_CLIENTE.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.TXT_CLIENTE.Location = new System.Drawing.Point(134, 17);
            this.TXT_CLIENTE.Name = "TXT_CLIENTE";
            this.TXT_CLIENTE.Size = new System.Drawing.Size(399, 21);
            this.TXT_CLIENTE.TabIndex = 0;
            this.TXT_CLIENTE.TIPO_TEXTBOX = MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM.E_TIPO_TEXBOX.GENERAL;
            this.TXT_CLIENTE.TextChanged += new System.EventHandler(this.TXT_ALUMNO_TextChanged);
            // 
            // GRID_CLIENTES
            // 
            this.GRID_CLIENTES.AllowUserToAddRows = false;
            this.GRID_CLIENTES.AllowUserToDeleteRows = false;
            this.GRID_CLIENTES.AllowUserToResizeColumns = false;
            this.GRID_CLIENTES.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.GRID_CLIENTES.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.GRID_CLIENTES.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GRID_CLIENTES.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GRID_CLIENTES.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GRID_CLIENTES.BackgroundColor = System.Drawing.Color.White;
            this.GRID_CLIENTES.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GRID_CLIENTES.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.GRID_CLIENTES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GRID_CLIENTES.DefaultCellStyle = dataGridViewCellStyle8;
            this.GRID_CLIENTES.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.GRID_CLIENTES.EnableHeadersVisualStyles = false;
            this.GRID_CLIENTES.Location = new System.Drawing.Point(15, 74);
            this.GRID_CLIENTES.MultiSelect = false;
            this.GRID_CLIENTES.Name = "GRID_CLIENTES";
            this.GRID_CLIENTES.ReadOnly = true;
            this.GRID_CLIENTES.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GRID_CLIENTES.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.GRID_CLIENTES.RowHeadersVisible = false;
            this.GRID_CLIENTES.RowHeadersWidth = 200;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Blue;
            this.GRID_CLIENTES.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.GRID_CLIENTES.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GRID_CLIENTES.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GRID_CLIENTES.Size = new System.Drawing.Size(679, 157);
            this.GRID_CLIENTES.TabIndex = 1;
            this.GRID_CLIENTES.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GRID_ALUMNOS_CellDoubleClick);
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
            this.BTN_NUEVO.Location = new System.Drawing.Point(21, 19);
            this.BTN_NUEVO.Name = "BTN_NUEVO";
            this.BTN_NUEVO.Size = new System.Drawing.Size(123, 23);
            this.BTN_NUEVO.TabIndex = 2;
            this.BTN_NUEVO.Text = "Nuevo";
            this.BTN_NUEVO.UseVisualStyleBackColor = true;
            this.BTN_NUEVO.Click += new System.EventHandler(this.BTN_NUEVO_Click);
            // 
            // BTN_ACTUALIZAR
            // 
            this.BTN_ACTUALIZAR.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.BTN_ACTUALIZAR.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Info;
            this.BTN_ACTUALIZAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.BTN_ACTUALIZAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ACTUALIZAR.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ACTUALIZAR.Image = global::_PROYECTO_FINAL_LPV.Properties.Resources.editar_matricula_16x16;
            this.BTN_ACTUALIZAR.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_ACTUALIZAR.Location = new System.Drawing.Point(163, 19);
            this.BTN_ACTUALIZAR.Name = "BTN_ACTUALIZAR";
            this.BTN_ACTUALIZAR.Size = new System.Drawing.Size(118, 23);
            this.BTN_ACTUALIZAR.TabIndex = 3;
            this.BTN_ACTUALIZAR.Text = "Modificar";
            this.BTN_ACTUALIZAR.UseVisualStyleBackColor = true;
            this.BTN_ACTUALIZAR.Click += new System.EventHandler(this.BTN_ACTUALIZAR_Click);
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
            this.BTN_SALIR.Location = new System.Drawing.Point(550, 19);
            this.BTN_SALIR.Name = "BTN_SALIR";
            this.BTN_SALIR.Size = new System.Drawing.Size(113, 23);
            this.BTN_SALIR.TabIndex = 4;
            this.BTN_SALIR.Text = "Salir";
            this.BTN_SALIR.UseVisualStyleBackColor = true;
            this.BTN_SALIR.Click += new System.EventHandler(this.BTN_SALIR_Click);
            // 
            // btn_seleccionar
            // 
            this.btn_seleccionar.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_seleccionar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Info;
            this.btn_seleccionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.btn_seleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_seleccionar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_seleccionar.Image = global::_PROYECTO_FINAL_LPV.Properties.Resources.seleccionar_16x16;
            this.btn_seleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_seleccionar.Location = new System.Drawing.Point(300, 19);
            this.btn_seleccionar.Name = "btn_seleccionar";
            this.btn_seleccionar.Size = new System.Drawing.Size(133, 23);
            this.btn_seleccionar.TabIndex = 5;
            this.btn_seleccionar.Text = "Selecionar cliente";
            this.btn_seleccionar.UseVisualStyleBackColor = true;
            this.btn_seleccionar.Click += new System.EventHandler(this.btn_seleccionar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.btn_seleccionar);
            this.groupBox2.Controls.Add(this.BTN_NUEVO);
            this.groupBox2.Controls.Add(this.BTN_SALIR);
            this.groupBox2.Controls.Add(this.BTN_ACTUALIZAR);
            this.groupBox2.Location = new System.Drawing.Point(15, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(679, 56);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.Controls.Add(this.GRID_CLIENTES);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Location = new System.Drawing.Point(14, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(711, 313);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // FRM_BUSQUEDA_CLIENTE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(772, 340);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FRM_BUSQUEDA_CLIENTE";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BUSQUEDA CLIENTE";
            this.Load += new System.EventHandler(this.FRM_BUSQUEDA_ALUMNO_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRID_CLIENTES)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MVASQUEZ__CONTROLES.MV_LABEL mV_LABEL1;
        private MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM TXT_CLIENTE;
        private MVASQUEZ__CONTROLES.MV_GRIDVIEW GRID_CLIENTES;
        private MVASQUEZ__CONTROLES.MV_BOTON BTN_NUEVO;
        private MVASQUEZ__CONTROLES.MV_BOTON BTN_ACTUALIZAR;
        private MVASQUEZ__CONTROLES.MV_BOTON BTN_SALIR;
        private MVASQUEZ__CONTROLES.MV_BOTON btn_seleccionar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}