namespace _PROYECTO_FINAL_LPV
{
    partial class BUSQUEDA_REPUESTO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BUSQUEDA_REPUESTO));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.mV_LABEL3 = new MVASQUEZ__CONTROLES.MV_LABEL();
            this.txt_desc = new MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM();
            this.GRID_REPUESTOS = new MVASQUEZ__CONTROLES.MV_GRIDVIEW();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mV_BOTON2 = new MVASQUEZ__CONTROLES.MV_BOTON();
            this.cbo_tipo_repuesto = new MVASQUEZ__CONTROLES.MV_COMBOBOX();
            this.mV_LABEL2 = new MVASQUEZ__CONTROLES.MV_LABEL();
            this.cbo_marca = new MVASQUEZ__CONTROLES.MV_COMBOBOX();
            this.mV_BOTON1 = new MVASQUEZ__CONTROLES.MV_BOTON();
            this.mV_LABEL1 = new MVASQUEZ__CONTROLES.MV_LABEL();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_seleccionar = new MVASQUEZ__CONTROLES.MV_BOTON();
            this.BTN_SALIR = new MVASQUEZ__CONTROLES.MV_BOTON();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pb_repuesto = new System.Windows.Forms.PictureBox();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRID_REPUESTOS)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_repuesto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.GRID_REPUESTOS);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Location = new System.Drawing.Point(12, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(935, 446);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.mV_LABEL3);
            this.groupBox5.Controls.Add(this.txt_desc);
            this.groupBox5.Location = new System.Drawing.Point(6, 380);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(571, 56);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Busquedad por Descripcion";
            // 
            // mV_LABEL3
            // 
            this.mV_LABEL3.AutoSize = true;
            this.mV_LABEL3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mV_LABEL3.Location = new System.Drawing.Point(28, 24);
            this.mV_LABEL3.Name = "mV_LABEL3";
            this.mV_LABEL3.Size = new System.Drawing.Size(132, 13);
            this.mV_LABEL3.TabIndex = 39;
            this.mV_LABEL3.Text = "Descripción de Repuesto :";
            this.mV_LABEL3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_desc
            // 
            this.txt_desc.BackColor = System.Drawing.Color.White;
            this.txt_desc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_desc.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txt_desc.Location = new System.Drawing.Point(171, 19);
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(378, 21);
            this.txt_desc.TabIndex = 3;
            this.txt_desc.Tag = "Dirección";
            this.txt_desc.TIPO_TEXTBOX = MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM.E_TIPO_TEXBOX.GENERAL;
            this.txt_desc.TextChanged += new System.EventHandler(this.txt_desc_TextChanged);
            // 
            // GRID_REPUESTOS
            // 
            this.GRID_REPUESTOS.AllowUserToAddRows = false;
            this.GRID_REPUESTOS.AllowUserToDeleteRows = false;
            this.GRID_REPUESTOS.AllowUserToResizeColumns = false;
            this.GRID_REPUESTOS.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.GRID_REPUESTOS.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GRID_REPUESTOS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GRID_REPUESTOS.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GRID_REPUESTOS.BackgroundColor = System.Drawing.Color.White;
            this.GRID_REPUESTOS.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GRID_REPUESTOS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GRID_REPUESTOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GRID_REPUESTOS.DefaultCellStyle = dataGridViewCellStyle3;
            this.GRID_REPUESTOS.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.GRID_REPUESTOS.EnableHeadersVisualStyles = false;
            this.GRID_REPUESTOS.Location = new System.Drawing.Point(6, 74);
            this.GRID_REPUESTOS.MultiSelect = false;
            this.GRID_REPUESTOS.Name = "GRID_REPUESTOS";
            this.GRID_REPUESTOS.ReadOnly = true;
            this.GRID_REPUESTOS.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GRID_REPUESTOS.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GRID_REPUESTOS.RowHeadersVisible = false;
            this.GRID_REPUESTOS.RowHeadersWidth = 200;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Blue;
            this.GRID_REPUESTOS.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.GRID_REPUESTOS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GRID_REPUESTOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GRID_REPUESTOS.Size = new System.Drawing.Size(923, 300);
            this.GRID_REPUESTOS.TabIndex = 1;
            this.GRID_REPUESTOS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GRID_REPUESTOS_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mV_BOTON2);
            this.groupBox1.Controls.Add(this.cbo_tipo_repuesto);
            this.groupBox1.Controls.Add(this.mV_LABEL2);
            this.groupBox1.Controls.Add(this.cbo_marca);
            this.groupBox1.Controls.Add(this.mV_BOTON1);
            this.groupBox1.Controls.Add(this.mV_LABEL1);
            this.groupBox1.Location = new System.Drawing.Point(6, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(923, 57);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccionar Items de Busqueda";
            // 
            // mV_BOTON2
            // 
            this.mV_BOTON2.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.mV_BOTON2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Info;
            this.mV_BOTON2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.mV_BOTON2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mV_BOTON2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mV_BOTON2.Image = ((System.Drawing.Image)(resources.GetObject("mV_BOTON2.Image")));
            this.mV_BOTON2.Location = new System.Drawing.Point(741, 19);
            this.mV_BOTON2.Name = "mV_BOTON2";
            this.mV_BOTON2.Size = new System.Drawing.Size(44, 27);
            this.mV_BOTON2.TabIndex = 6;
            this.mV_BOTON2.UseVisualStyleBackColor = true;
            this.mV_BOTON2.Click += new System.EventHandler(this.mV_BOTON2_Click);
            // 
            // cbo_tipo_repuesto
            // 
            this.cbo_tipo_repuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_tipo_repuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_tipo_repuesto.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_tipo_repuesto.FormattingEnabled = true;
            this.cbo_tipo_repuesto.Location = new System.Drawing.Point(446, 25);
            this.cbo_tipo_repuesto.Name = "cbo_tipo_repuesto";
            this.cbo_tipo_repuesto.Size = new System.Drawing.Size(229, 21);
            this.cbo_tipo_repuesto.TabIndex = 38;
            this.cbo_tipo_repuesto.SelectedIndexChanged += new System.EventHandler(this.cbo_tipo_repuesto_SelectedIndexChanged);
            // 
            // mV_LABEL2
            // 
            this.mV_LABEL2.AutoSize = true;
            this.mV_LABEL2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mV_LABEL2.Location = new System.Drawing.Point(357, 28);
            this.mV_LABEL2.Name = "mV_LABEL2";
            this.mV_LABEL2.Size = new System.Drawing.Size(83, 13);
            this.mV_LABEL2.TabIndex = 37;
            this.mV_LABEL2.Text = "Tipo Repuesto :";
            this.mV_LABEL2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mV_LABEL2.Click += new System.EventHandler(this.mV_LABEL2_Click);
            // 
            // cbo_marca
            // 
            this.cbo_marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_marca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_marca.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_marca.FormattingEnabled = true;
            this.cbo_marca.Location = new System.Drawing.Point(77, 25);
            this.cbo_marca.Name = "cbo_marca";
            this.cbo_marca.Size = new System.Drawing.Size(229, 21);
            this.cbo_marca.TabIndex = 36;
            // 
            // mV_BOTON1
            // 
            this.mV_BOTON1.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.mV_BOTON1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Info;
            this.mV_BOTON1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.mV_BOTON1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mV_BOTON1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mV_BOTON1.Image = global::_PROYECTO_FINAL_LPV.Properties.Resources.buscar_16x16;
            this.mV_BOTON1.Location = new System.Drawing.Point(691, 19);
            this.mV_BOTON1.Name = "mV_BOTON1";
            this.mV_BOTON1.Size = new System.Drawing.Size(44, 27);
            this.mV_BOTON1.TabIndex = 9;
            this.mV_BOTON1.UseVisualStyleBackColor = true;
            this.mV_BOTON1.Click += new System.EventHandler(this.mV_BOTON1_Click);
            // 
            // mV_LABEL1
            // 
            this.mV_LABEL1.AutoSize = true;
            this.mV_LABEL1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mV_LABEL1.Location = new System.Drawing.Point(28, 25);
            this.mV_LABEL1.Name = "mV_LABEL1";
            this.mV_LABEL1.Size = new System.Drawing.Size(43, 13);
            this.mV_LABEL1.TabIndex = 1;
            this.mV_LABEL1.Text = "Marca :";
            this.mV_LABEL1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_seleccionar);
            this.groupBox2.Controls.Add(this.BTN_SALIR);
            this.groupBox2.Location = new System.Drawing.Point(614, 380);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 56);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
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
            this.btn_seleccionar.Location = new System.Drawing.Point(13, 19);
            this.btn_seleccionar.Name = "btn_seleccionar";
            this.btn_seleccionar.Size = new System.Drawing.Size(133, 23);
            this.btn_seleccionar.TabIndex = 5;
            this.btn_seleccionar.Text = "Selecionar repuesto";
            this.btn_seleccionar.UseVisualStyleBackColor = true;
            this.btn_seleccionar.Click += new System.EventHandler(this.btn_seleccionar_Click);
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
            this.BTN_SALIR.Location = new System.Drawing.Point(152, 19);
            this.BTN_SALIR.Name = "BTN_SALIR";
            this.BTN_SALIR.Size = new System.Drawing.Size(113, 23);
            this.BTN_SALIR.TabIndex = 4;
            this.BTN_SALIR.Text = "Salir";
            this.BTN_SALIR.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pb_repuesto);
            this.groupBox4.Location = new System.Drawing.Point(953, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(386, 445);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Imagen de Repuesto Seleccionado";
            // 
            // pb_repuesto
            // 
            this.pb_repuesto.Location = new System.Drawing.Point(15, 19);
            this.pb_repuesto.Name = "pb_repuesto";
            this.pb_repuesto.Size = new System.Drawing.Size(365, 365);
            this.pb_repuesto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_repuesto.TabIndex = 0;
            this.pb_repuesto.TabStop = false;
            // 
            // BUSQUEDA_REPUESTO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1354, 491);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BUSQUEDA_REPUESTO";
            this.Text = "BUSQUEDA_REPUESTO";
            this.Load += new System.EventHandler(this.BUSQUEDA_REPUESTO_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRID_REPUESTOS)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_repuesto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private MVASQUEZ__CONTROLES.MV_GRIDVIEW GRID_REPUESTOS;
        private System.Windows.Forms.GroupBox groupBox1;
        private MVASQUEZ__CONTROLES.MV_LABEL mV_LABEL1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MVASQUEZ__CONTROLES.MV_BOTON btn_seleccionar;
        private MVASQUEZ__CONTROLES.MV_BOTON BTN_SALIR;
        private MVASQUEZ__CONTROLES.MV_BOTON mV_BOTON1;
        private MVASQUEZ__CONTROLES.MV_COMBOBOX cbo_marca;
        private MVASQUEZ__CONTROLES.MV_COMBOBOX cbo_tipo_repuesto;
        private MVASQUEZ__CONTROLES.MV_LABEL mV_LABEL2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pb_repuesto;
        private MVASQUEZ__CONTROLES.MV_BOTON mV_BOTON2;
        private System.Windows.Forms.GroupBox groupBox5;
        private MVASQUEZ__CONTROLES.MV_LABEL mV_LABEL3;
        private MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM txt_desc;
    }
}