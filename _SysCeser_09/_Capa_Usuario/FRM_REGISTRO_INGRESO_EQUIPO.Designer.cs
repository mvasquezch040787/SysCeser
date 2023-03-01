namespace _PROYECTO_FINAL_LPV
{
    partial class FRM_REGISTRO_INGRESO_EQUIPO
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_id_orden = new MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM();
            this.mV_LABEL1 = new MVASQUEZ__CONTROLES.MV_LABEL();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_buscar = new MVASQUEZ__CONTROLES.MV_BOTON();
            this.mV_LABEL5 = new MVASQUEZ__CONTROLES.MV_LABEL();
            this.mV_LABEL4 = new MVASQUEZ__CONTROLES.MV_LABEL();
            this.mV_LABEL3 = new MVASQUEZ__CONTROLES.MV_LABEL();
            this.txt_ruc = new MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM();
            this.txt_dni = new MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM();
            this.txt_direccion = new MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM();
            this.txt_cliente = new MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM();
            this.mV_LABEL2 = new MVASQUEZ__CONTROLES.MV_LABEL();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_falla_reportada = new MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM();
            this.mV_LABEL6 = new MVASQUEZ__CONTROLES.MV_LABEL();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_agregar_marca = new MVASQUEZ__CONTROLES.MV_BOTON();
            this.btn_agregar_tipo_qeuipo = new MVASQUEZ__CONTROLES.MV_BOTON();
            this.mV_LABEL14 = new MVASQUEZ__CONTROLES.MV_LABEL();
            this.mV_LABEL13 = new MVASQUEZ__CONTROLES.MV_LABEL();
            this.txt_serie = new MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM();
            this.txt_modelo = new MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM();
            this.txt_equipo = new MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM();
            this.mV_LABEL12 = new MVASQUEZ__CONTROLES.MV_LABEL();
            this.CBO_MARCA = new MVASQUEZ__CONTROLES.MV_COMBOBOX();
            this.mV_LABEL10 = new MVASQUEZ__CONTROLES.MV_LABEL();
            this.mV_LABEL9 = new MVASQUEZ__CONTROLES.MV_LABEL();
            this.CBO_TIPO_EQUIPO = new MVASQUEZ__CONTROLES.MV_COMBOBOX();
            this.mV_LABEL8 = new MVASQUEZ__CONTROLES.MV_LABEL();
            this.DTP_FECHA_NACIMIENTO = new System.Windows.Forms.DateTimePicker();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.mV_LABEL11 = new MVASQUEZ__CONTROLES.MV_LABEL();
            this.CBO_TIPO_GARANTIA = new MVASQUEZ__CONTROLES.MV_COMBOBOX();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txt_accesorios = new MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txt_observaciones = new MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM();
            this.txt_costo_reaparcion = new MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM();
            this.BTN_IMPRIMIR = new MVASQUEZ__CONTROLES.MV_BOTON();
            this.BTN_NUEVO = new MVASQUEZ__CONTROLES.MV_BOTON();
            this.BTN_CANCELAR = new MVASQUEZ__CONTROLES.MV_BOTON();
            this.BTN_GUARDAR = new MVASQUEZ__CONTROLES.MV_BOTON();
            this.BTN_SALIR = new MVASQUEZ__CONTROLES.MV_BOTON();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.txtadelanto = new MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.txt_id_orden);
            this.groupBox1.Controls.Add(this.mV_LABEL1);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 68);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Orden";
            // 
            // txt_id_orden
            // 
            this.txt_id_orden.BackColor = System.Drawing.Color.White;
            this.txt_id_orden.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_id_orden.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_orden.Location = new System.Drawing.Point(85, 20);
            this.txt_id_orden.Name = "txt_id_orden";
            this.txt_id_orden.ReadOnly = true;
            this.txt_id_orden.Size = new System.Drawing.Size(255, 40);
            this.txt_id_orden.TabIndex = 1;
            this.txt_id_orden.TIPO_TEXTBOX = MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM.E_TIPO_TEXBOX.ES_ID;
            // 
            // mV_LABEL1
            // 
            this.mV_LABEL1.AutoSize = true;
            this.mV_LABEL1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mV_LABEL1.Location = new System.Drawing.Point(28, 24);
            this.mV_LABEL1.Name = "mV_LABEL1";
            this.mV_LABEL1.Size = new System.Drawing.Size(58, 33);
            this.mV_LABEL1.TabIndex = 0;
            this.mV_LABEL1.Text = "N° ";
            this.mV_LABEL1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.btn_buscar);
            this.groupBox2.Controls.Add(this.mV_LABEL5);
            this.groupBox2.Controls.Add(this.mV_LABEL4);
            this.groupBox2.Controls.Add(this.mV_LABEL3);
            this.groupBox2.Controls.Add(this.txt_ruc);
            this.groupBox2.Controls.Add(this.txt_dni);
            this.groupBox2.Controls.Add(this.txt_direccion);
            this.groupBox2.Controls.Add(this.txt_cliente);
            this.groupBox2.Controls.Add(this.mV_LABEL2);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(12, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(507, 115);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del cliente";
            // 
            // btn_buscar
            // 
            this.btn_buscar.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_buscar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Info;
            this.btn_buscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.Image = global::_PROYECTO_FINAL_LPV.Properties.Resources.buscar_16x16;
            this.btn_buscar.Location = new System.Drawing.Point(461, 26);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(34, 23);
            this.btn_buscar.TabIndex = 8;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // mV_LABEL5
            // 
            this.mV_LABEL5.AutoSize = true;
            this.mV_LABEL5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mV_LABEL5.Location = new System.Drawing.Point(263, 86);
            this.mV_LABEL5.Name = "mV_LABEL5";
            this.mV_LABEL5.Size = new System.Drawing.Size(32, 13);
            this.mV_LABEL5.TabIndex = 7;
            this.mV_LABEL5.Text = "Ruc :";
            this.mV_LABEL5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mV_LABEL4
            // 
            this.mV_LABEL4.AutoSize = true;
            this.mV_LABEL4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mV_LABEL4.Location = new System.Drawing.Point(49, 86);
            this.mV_LABEL4.Name = "mV_LABEL4";
            this.mV_LABEL4.Size = new System.Drawing.Size(29, 13);
            this.mV_LABEL4.TabIndex = 6;
            this.mV_LABEL4.Text = "Dni :";
            this.mV_LABEL4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mV_LABEL3
            // 
            this.mV_LABEL3.AutoSize = true;
            this.mV_LABEL3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mV_LABEL3.Location = new System.Drawing.Point(21, 56);
            this.mV_LABEL3.Name = "mV_LABEL3";
            this.mV_LABEL3.Size = new System.Drawing.Size(57, 13);
            this.mV_LABEL3.TabIndex = 5;
            this.mV_LABEL3.Text = "Direccion :";
            this.mV_LABEL3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_ruc
            // 
            this.txt_ruc.BackColor = System.Drawing.Color.White;
            this.txt_ruc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_ruc.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txt_ruc.Location = new System.Drawing.Point(301, 83);
            this.txt_ruc.Name = "txt_ruc";
            this.txt_ruc.ReadOnly = true;
            this.txt_ruc.Size = new System.Drawing.Size(154, 21);
            this.txt_ruc.TabIndex = 4;
            this.txt_ruc.TIPO_TEXTBOX = MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM.E_TIPO_TEXBOX.NUMEROS;
            // 
            // txt_dni
            // 
            this.txt_dni.BackColor = System.Drawing.Color.White;
            this.txt_dni.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_dni.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txt_dni.Location = new System.Drawing.Point(85, 84);
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.ReadOnly = true;
            this.txt_dni.Size = new System.Drawing.Size(135, 21);
            this.txt_dni.TabIndex = 3;
            this.txt_dni.Tag = "Dni";
            this.txt_dni.TIPO_TEXTBOX = MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM.E_TIPO_TEXBOX.NUMEROS;
            // 
            // txt_direccion
            // 
            this.txt_direccion.BackColor = System.Drawing.Color.White;
            this.txt_direccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_direccion.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txt_direccion.Location = new System.Drawing.Point(85, 56);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.ReadOnly = true;
            this.txt_direccion.Size = new System.Drawing.Size(370, 21);
            this.txt_direccion.TabIndex = 2;
            this.txt_direccion.Tag = "Dirección";
            this.txt_direccion.TIPO_TEXTBOX = MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM.E_TIPO_TEXBOX.NUMEROS;
            // 
            // txt_cliente
            // 
            this.txt_cliente.BackColor = System.Drawing.Color.White;
            this.txt_cliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_cliente.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txt_cliente.Location = new System.Drawing.Point(85, 28);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.ReadOnly = true;
            this.txt_cliente.Size = new System.Drawing.Size(370, 21);
            this.txt_cliente.TabIndex = 1;
            this.txt_cliente.Tag = "Cliente";
            this.txt_cliente.TIPO_TEXTBOX = MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM.E_TIPO_TEXBOX.NUMEROS;
            // 
            // mV_LABEL2
            // 
            this.mV_LABEL2.AutoSize = true;
            this.mV_LABEL2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mV_LABEL2.Location = new System.Drawing.Point(31, 31);
            this.mV_LABEL2.Name = "mV_LABEL2";
            this.mV_LABEL2.Size = new System.Drawing.Size(47, 13);
            this.mV_LABEL2.TabIndex = 0;
            this.mV_LABEL2.Text = "Cliente :";
            this.mV_LABEL2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.Controls.Add(this.txt_falla_reportada);
            this.groupBox3.Controls.Add(this.mV_LABEL6);
            this.groupBox3.Location = new System.Drawing.Point(12, 223);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(507, 71);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Falla reportada por el cliente ";
            // 
            // txt_falla_reportada
            // 
            this.txt_falla_reportada.BackColor = System.Drawing.Color.White;
            this.txt_falla_reportada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_falla_reportada.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txt_falla_reportada.Location = new System.Drawing.Point(24, 19);
            this.txt_falla_reportada.Multiline = true;
            this.txt_falla_reportada.Name = "txt_falla_reportada";
            this.txt_falla_reportada.Size = new System.Drawing.Size(471, 36);
            this.txt_falla_reportada.TabIndex = 7;
            this.txt_falla_reportada.TIPO_TEXTBOX = MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM.E_TIPO_TEXBOX.GENERAL;
            // 
            // mV_LABEL6
            // 
            this.mV_LABEL6.AutoSize = true;
            this.mV_LABEL6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mV_LABEL6.Location = new System.Drawing.Point(82, 16);
            this.mV_LABEL6.Name = "mV_LABEL6";
            this.mV_LABEL6.Size = new System.Drawing.Size(0, 13);
            this.mV_LABEL6.TabIndex = 6;
            this.mV_LABEL6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox4.Controls.Add(this.btn_agregar_marca);
            this.groupBox4.Controls.Add(this.btn_agregar_tipo_qeuipo);
            this.groupBox4.Controls.Add(this.mV_LABEL14);
            this.groupBox4.Controls.Add(this.mV_LABEL13);
            this.groupBox4.Controls.Add(this.txt_serie);
            this.groupBox4.Controls.Add(this.txt_modelo);
            this.groupBox4.Controls.Add(this.txt_equipo);
            this.groupBox4.Controls.Add(this.mV_LABEL12);
            this.groupBox4.Controls.Add(this.CBO_MARCA);
            this.groupBox4.Controls.Add(this.mV_LABEL10);
            this.groupBox4.Controls.Add(this.mV_LABEL9);
            this.groupBox4.Controls.Add(this.CBO_TIPO_EQUIPO);
            this.groupBox4.Location = new System.Drawing.Point(535, 102);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(492, 192);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datos del equipo";
            // 
            // btn_agregar_marca
            // 
            this.btn_agregar_marca.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_agregar_marca.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Info;
            this.btn_agregar_marca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.btn_agregar_marca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar_marca.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar_marca.Image = global::_PROYECTO_FINAL_LPV.Properties.Resources.agregar_grupo_16x16;
            this.btn_agregar_marca.Location = new System.Drawing.Point(439, 83);
            this.btn_agregar_marca.Name = "btn_agregar_marca";
            this.btn_agregar_marca.Size = new System.Drawing.Size(34, 23);
            this.btn_agregar_marca.TabIndex = 10;
            this.btn_agregar_marca.UseVisualStyleBackColor = true;
            this.btn_agregar_marca.Click += new System.EventHandler(this.btn_agregar_marca_Click);
            // 
            // btn_agregar_tipo_qeuipo
            // 
            this.btn_agregar_tipo_qeuipo.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_agregar_tipo_qeuipo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Info;
            this.btn_agregar_tipo_qeuipo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.btn_agregar_tipo_qeuipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar_tipo_qeuipo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar_tipo_qeuipo.Image = global::_PROYECTO_FINAL_LPV.Properties.Resources.agregar_grupo_16x16;
            this.btn_agregar_tipo_qeuipo.Location = new System.Drawing.Point(439, 54);
            this.btn_agregar_tipo_qeuipo.Name = "btn_agregar_tipo_qeuipo";
            this.btn_agregar_tipo_qeuipo.Size = new System.Drawing.Size(34, 23);
            this.btn_agregar_tipo_qeuipo.TabIndex = 9;
            this.btn_agregar_tipo_qeuipo.UseVisualStyleBackColor = true;
            this.btn_agregar_tipo_qeuipo.Click += new System.EventHandler(this.btn_agregar_tipo_qeuipo_Click);
            // 
            // mV_LABEL14
            // 
            this.mV_LABEL14.AutoSize = true;
            this.mV_LABEL14.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mV_LABEL14.Location = new System.Drawing.Point(53, 146);
            this.mV_LABEL14.Name = "mV_LABEL14";
            this.mV_LABEL14.Size = new System.Drawing.Size(38, 13);
            this.mV_LABEL14.TabIndex = 9;
            this.mV_LABEL14.Text = "Serie :";
            this.mV_LABEL14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mV_LABEL13
            // 
            this.mV_LABEL13.AutoSize = true;
            this.mV_LABEL13.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mV_LABEL13.Location = new System.Drawing.Point(43, 117);
            this.mV_LABEL13.Name = "mV_LABEL13";
            this.mV_LABEL13.Size = new System.Drawing.Size(48, 13);
            this.mV_LABEL13.TabIndex = 8;
            this.mV_LABEL13.Text = "Modelo :";
            this.mV_LABEL13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_serie
            // 
            this.txt_serie.BackColor = System.Drawing.Color.White;
            this.txt_serie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_serie.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txt_serie.Location = new System.Drawing.Point(106, 143);
            this.txt_serie.Name = "txt_serie";
            this.txt_serie.Size = new System.Drawing.Size(318, 21);
            this.txt_serie.TabIndex = 7;
            this.txt_serie.Tag = "Serie";
            this.txt_serie.TIPO_TEXTBOX = MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM.E_TIPO_TEXBOX.GENERAL;
            // 
            // txt_modelo
            // 
            this.txt_modelo.BackColor = System.Drawing.Color.White;
            this.txt_modelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_modelo.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txt_modelo.Location = new System.Drawing.Point(106, 117);
            this.txt_modelo.Name = "txt_modelo";
            this.txt_modelo.Size = new System.Drawing.Size(318, 21);
            this.txt_modelo.TabIndex = 6;
            this.txt_modelo.Tag = "Modelo";
            this.txt_modelo.TIPO_TEXTBOX = MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM.E_TIPO_TEXBOX.GENERAL;
            // 
            // txt_equipo
            // 
            this.txt_equipo.BackColor = System.Drawing.Color.White;
            this.txt_equipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_equipo.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txt_equipo.Location = new System.Drawing.Point(106, 27);
            this.txt_equipo.Name = "txt_equipo";
            this.txt_equipo.Size = new System.Drawing.Size(318, 21);
            this.txt_equipo.TabIndex = 5;
            this.txt_equipo.Tag = "Equipo";
            this.txt_equipo.TIPO_TEXTBOX = MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM.E_TIPO_TEXBOX.GENERAL;
            // 
            // mV_LABEL12
            // 
            this.mV_LABEL12.AutoSize = true;
            this.mV_LABEL12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mV_LABEL12.Location = new System.Drawing.Point(45, 31);
            this.mV_LABEL12.Name = "mV_LABEL12";
            this.mV_LABEL12.Size = new System.Drawing.Size(46, 13);
            this.mV_LABEL12.TabIndex = 4;
            this.mV_LABEL12.Text = "Equipo :";
            this.mV_LABEL12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CBO_MARCA
            // 
            this.CBO_MARCA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBO_MARCA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBO_MARCA.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBO_MARCA.FormattingEnabled = true;
            this.CBO_MARCA.Location = new System.Drawing.Point(106, 89);
            this.CBO_MARCA.Name = "CBO_MARCA";
            this.CBO_MARCA.Size = new System.Drawing.Size(318, 21);
            this.CBO_MARCA.TabIndex = 3;
            // 
            // mV_LABEL10
            // 
            this.mV_LABEL10.AutoSize = true;
            this.mV_LABEL10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mV_LABEL10.Location = new System.Drawing.Point(13, 92);
            this.mV_LABEL10.Name = "mV_LABEL10";
            this.mV_LABEL10.Size = new System.Drawing.Size(78, 13);
            this.mV_LABEL10.TabIndex = 2;
            this.mV_LABEL10.Text = "Marca equipo :";
            this.mV_LABEL10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mV_LABEL9
            // 
            this.mV_LABEL9.AutoSize = true;
            this.mV_LABEL9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mV_LABEL9.Location = new System.Drawing.Point(22, 64);
            this.mV_LABEL9.Name = "mV_LABEL9";
            this.mV_LABEL9.Size = new System.Drawing.Size(69, 13);
            this.mV_LABEL9.TabIndex = 1;
            this.mV_LABEL9.Text = "Tipo equipo :";
            this.mV_LABEL9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CBO_TIPO_EQUIPO
            // 
            this.CBO_TIPO_EQUIPO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBO_TIPO_EQUIPO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBO_TIPO_EQUIPO.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBO_TIPO_EQUIPO.FormattingEnabled = true;
            this.CBO_TIPO_EQUIPO.Location = new System.Drawing.Point(106, 56);
            this.CBO_TIPO_EQUIPO.Name = "CBO_TIPO_EQUIPO";
            this.CBO_TIPO_EQUIPO.Size = new System.Drawing.Size(318, 21);
            this.CBO_TIPO_EQUIPO.TabIndex = 0;
            this.CBO_TIPO_EQUIPO.SelectedIndexChanged += new System.EventHandler(this.CBO_TIPO_EQUIPO_SelectedIndexChanged);
            // 
            // mV_LABEL8
            // 
            this.mV_LABEL8.AutoSize = true;
            this.mV_LABEL8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mV_LABEL8.Location = new System.Drawing.Point(269, 14);
            this.mV_LABEL8.Name = "mV_LABEL8";
            this.mV_LABEL8.Size = new System.Drawing.Size(84, 13);
            this.mV_LABEL8.TabIndex = 5;
            this.mV_LABEL8.Text = "Fecha  ingreso :";
            this.mV_LABEL8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DTP_FECHA_NACIMIENTO
            // 
            this.DTP_FECHA_NACIMIENTO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_FECHA_NACIMIENTO.Location = new System.Drawing.Point(260, 33);
            this.DTP_FECHA_NACIMIENTO.Name = "DTP_FECHA_NACIMIENTO";
            this.DTP_FECHA_NACIMIENTO.Size = new System.Drawing.Size(164, 20);
            this.DTP_FECHA_NACIMIENTO.TabIndex = 17;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox5.Controls.Add(this.mV_LABEL11);
            this.groupBox5.Controls.Add(this.CBO_TIPO_GARANTIA);
            this.groupBox5.Controls.Add(this.mV_LABEL8);
            this.groupBox5.Controls.Add(this.DTP_FECHA_NACIMIENTO);
            this.groupBox5.Location = new System.Drawing.Point(535, 29);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(492, 64);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            // 
            // mV_LABEL11
            // 
            this.mV_LABEL11.AutoSize = true;
            this.mV_LABEL11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mV_LABEL11.Location = new System.Drawing.Point(22, 14);
            this.mV_LABEL11.Name = "mV_LABEL11";
            this.mV_LABEL11.Size = new System.Drawing.Size(77, 13);
            this.mV_LABEL11.TabIndex = 19;
            this.mV_LABEL11.Text = "Tipo garantia :";
            this.mV_LABEL11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CBO_TIPO_GARANTIA
            // 
            this.CBO_TIPO_GARANTIA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBO_TIPO_GARANTIA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBO_TIPO_GARANTIA.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBO_TIPO_GARANTIA.FormattingEnabled = true;
            this.CBO_TIPO_GARANTIA.Location = new System.Drawing.Point(25, 32);
            this.CBO_TIPO_GARANTIA.Name = "CBO_TIPO_GARANTIA";
            this.CBO_TIPO_GARANTIA.Size = new System.Drawing.Size(216, 21);
            this.CBO_TIPO_GARANTIA.TabIndex = 18;
            this.CBO_TIPO_GARANTIA.SelectionChangeCommitted += new System.EventHandler(this.CBO_TIPO_GARANTIA_SelectionChangeCommitted);
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox6.Controls.Add(this.txt_accesorios);
            this.groupBox6.Location = new System.Drawing.Point(13, 300);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(506, 77);
            this.groupBox6.TabIndex = 19;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Accesorios ";
            // 
            // txt_accesorios
            // 
            this.txt_accesorios.BackColor = System.Drawing.Color.White;
            this.txt_accesorios.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_accesorios.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txt_accesorios.Location = new System.Drawing.Point(23, 19);
            this.txt_accesorios.Multiline = true;
            this.txt_accesorios.Name = "txt_accesorios";
            this.txt_accesorios.Size = new System.Drawing.Size(471, 40);
            this.txt_accesorios.TabIndex = 0;
            this.txt_accesorios.TIPO_TEXTBOX = MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM.E_TIPO_TEXBOX.GENERAL;
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox7.Controls.Add(this.txt_observaciones);
            this.groupBox7.Location = new System.Drawing.Point(535, 300);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(492, 77);
            this.groupBox7.TabIndex = 20;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Observaciones recepción";
            // 
            // txt_observaciones
            // 
            this.txt_observaciones.BackColor = System.Drawing.Color.White;
            this.txt_observaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_observaciones.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txt_observaciones.Location = new System.Drawing.Point(25, 20);
            this.txt_observaciones.Multiline = true;
            this.txt_observaciones.Name = "txt_observaciones";
            this.txt_observaciones.Size = new System.Drawing.Size(448, 39);
            this.txt_observaciones.TabIndex = 0;
            this.txt_observaciones.TIPO_TEXTBOX = MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM.E_TIPO_TEXBOX.GENERAL;
            // 
            // txt_costo_reaparcion
            // 
            this.txt_costo_reaparcion.BackColor = System.Drawing.Color.White;
            this.txt_costo_reaparcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_costo_reaparcion.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_costo_reaparcion.Location = new System.Drawing.Point(12, 19);
            this.txt_costo_reaparcion.MaxLength = 4;
            this.txt_costo_reaparcion.Name = "txt_costo_reaparcion";
            this.txt_costo_reaparcion.Size = new System.Drawing.Size(132, 30);
            this.txt_costo_reaparcion.TabIndex = 37;
            this.txt_costo_reaparcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_costo_reaparcion.TIPO_TEXTBOX = MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM.E_TIPO_TEXBOX.NUMEROS;
            // 
            // BTN_IMPRIMIR
            // 
            this.BTN_IMPRIMIR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BTN_IMPRIMIR.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.BTN_IMPRIMIR.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Info;
            this.BTN_IMPRIMIR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.BTN_IMPRIMIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_IMPRIMIR.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_IMPRIMIR.Image = global::_PROYECTO_FINAL_LPV.Properties.Resources.reporte_16x16;
            this.BTN_IMPRIMIR.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_IMPRIMIR.Location = new System.Drawing.Point(12, 110);
            this.BTN_IMPRIMIR.Name = "BTN_IMPRIMIR";
            this.BTN_IMPRIMIR.Size = new System.Drawing.Size(132, 23);
            this.BTN_IMPRIMIR.TabIndex = 35;
            this.BTN_IMPRIMIR.Text = "Imprimir formato";
            this.BTN_IMPRIMIR.UseVisualStyleBackColor = true;
            this.BTN_IMPRIMIR.Click += new System.EventHandler(this.BTN_IMPRIMIR_Click);
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
            this.BTN_NUEVO.Location = new System.Drawing.Point(12, 52);
            this.BTN_NUEVO.Name = "BTN_NUEVO";
            this.BTN_NUEVO.Size = new System.Drawing.Size(132, 23);
            this.BTN_NUEVO.TabIndex = 34;
            this.BTN_NUEVO.Text = "Nuevo";
            this.BTN_NUEVO.UseVisualStyleBackColor = true;
            this.BTN_NUEVO.Click += new System.EventHandler(this.BTN_NUEVO_Click_1);
            // 
            // BTN_CANCELAR
            // 
            this.BTN_CANCELAR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BTN_CANCELAR.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.BTN_CANCELAR.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Info;
            this.BTN_CANCELAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.BTN_CANCELAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CANCELAR.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CANCELAR.Image = global::_PROYECTO_FINAL_LPV.Properties.Resources.cancelar_16x16;
            this.BTN_CANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_CANCELAR.Location = new System.Drawing.Point(12, 81);
            this.BTN_CANCELAR.Name = "BTN_CANCELAR";
            this.BTN_CANCELAR.Size = new System.Drawing.Size(132, 23);
            this.BTN_CANCELAR.TabIndex = 32;
            this.BTN_CANCELAR.Text = "Cancelar";
            this.BTN_CANCELAR.UseVisualStyleBackColor = true;
            // 
            // BTN_GUARDAR
            // 
            this.BTN_GUARDAR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BTN_GUARDAR.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.BTN_GUARDAR.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Info;
            this.BTN_GUARDAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.BTN_GUARDAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_GUARDAR.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_GUARDAR.Image = global::_PROYECTO_FINAL_LPV.Properties.Resources.guardar_16x16;
            this.BTN_GUARDAR.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_GUARDAR.Location = new System.Drawing.Point(12, 19);
            this.BTN_GUARDAR.Name = "BTN_GUARDAR";
            this.BTN_GUARDAR.Size = new System.Drawing.Size(132, 23);
            this.BTN_GUARDAR.TabIndex = 31;
            this.BTN_GUARDAR.Text = "Guardar";
            this.BTN_GUARDAR.UseVisualStyleBackColor = true;
            this.BTN_GUARDAR.Click += new System.EventHandler(this.BTN_GUARDAR_Click);
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
            this.BTN_SALIR.Location = new System.Drawing.Point(12, 161);
            this.BTN_SALIR.Name = "BTN_SALIR";
            this.BTN_SALIR.Size = new System.Drawing.Size(132, 23);
            this.BTN_SALIR.TabIndex = 33;
            this.BTN_SALIR.Text = "Salir";
            this.BTN_SALIR.UseVisualStyleBackColor = true;
            this.BTN_SALIR.Click += new System.EventHandler(this.BTN_SALIR_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox8.Controls.Add(this.BTN_GUARDAR);
            this.groupBox8.Controls.Add(this.BTN_NUEVO);
            this.groupBox8.Controls.Add(this.BTN_SALIR);
            this.groupBox8.Controls.Add(this.BTN_IMPRIMIR);
            this.groupBox8.Controls.Add(this.BTN_CANCELAR);
            this.groupBox8.Location = new System.Drawing.Point(1040, 174);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(160, 203);
            this.groupBox8.TabIndex = 38;
            this.groupBox8.TabStop = false;
            // 
            // groupBox9
            // 
            this.groupBox9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox9.Controls.Add(this.txt_costo_reaparcion);
            this.groupBox9.Location = new System.Drawing.Point(1040, 30);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(160, 66);
            this.groupBox9.TabIndex = 39;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Costo referencial reparación";
            // 
            // groupBox10
            // 
            this.groupBox10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox10.Controls.Add(this.txtadelanto);
            this.groupBox10.Location = new System.Drawing.Point(1040, 102);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(160, 66);
            this.groupBox10.TabIndex = 40;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "A cuenta";
            // 
            // txtadelanto
            // 
            this.txtadelanto.BackColor = System.Drawing.Color.White;
            this.txtadelanto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtadelanto.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadelanto.Location = new System.Drawing.Point(12, 19);
            this.txtadelanto.MaxLength = 4;
            this.txtadelanto.Name = "txtadelanto";
            this.txtadelanto.Size = new System.Drawing.Size(132, 30);
            this.txtadelanto.TabIndex = 37;
            this.txtadelanto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtadelanto.TIPO_TEXTBOX = MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM.E_TIPO_TEXBOX.NUMEROS;
            // 
            // FRM_REGISTRO_INGRESO_EQUIPO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1223, 446);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FRM_REGISTRO_INGRESO_EQUIPO";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTRO DE INGRESO DE EQUIPO";
            this.Load += new System.EventHandler(this.FRM_REGISTRO_INGRESO_EQUIPO_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM txt_id_orden;
        private MVASQUEZ__CONTROLES.MV_LABEL mV_LABEL1;
        private MVASQUEZ__CONTROLES.MV_LABEL mV_LABEL5;
        private MVASQUEZ__CONTROLES.MV_LABEL mV_LABEL4;
        private MVASQUEZ__CONTROLES.MV_LABEL mV_LABEL3;
        private MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM txt_ruc;
        private MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM txt_dni;
        private MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM txt_direccion;
        private MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM txt_cliente;
        private MVASQUEZ__CONTROLES.MV_LABEL mV_LABEL2;
        private MVASQUEZ__CONTROLES.MV_BOTON btn_buscar;
        private System.Windows.Forms.GroupBox groupBox3;
        private MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM txt_falla_reportada;
        private MVASQUEZ__CONTROLES.MV_LABEL mV_LABEL6;
        private System.Windows.Forms.GroupBox groupBox4;
        private MVASQUEZ__CONTROLES.MV_LABEL mV_LABEL8;
        private System.Windows.Forms.DateTimePicker DTP_FECHA_NACIMIENTO;
        private System.Windows.Forms.GroupBox groupBox5;
        private MVASQUEZ__CONTROLES.MV_LABEL mV_LABEL9;
        private MVASQUEZ__CONTROLES.MV_COMBOBOX CBO_TIPO_EQUIPO;
        private MVASQUEZ__CONTROLES.MV_COMBOBOX CBO_MARCA;
        private MVASQUEZ__CONTROLES.MV_LABEL mV_LABEL10;
        private MVASQUEZ__CONTROLES.MV_LABEL mV_LABEL11;
        private MVASQUEZ__CONTROLES.MV_COMBOBOX CBO_TIPO_GARANTIA;
        private MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM txt_equipo;
        private MVASQUEZ__CONTROLES.MV_LABEL mV_LABEL12;
        private MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM txt_serie;
        private MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM txt_modelo;
        private MVASQUEZ__CONTROLES.MV_LABEL mV_LABEL14;
        private MVASQUEZ__CONTROLES.MV_LABEL mV_LABEL13;
        private System.Windows.Forms.GroupBox groupBox6;
        private MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM txt_accesorios;
        private System.Windows.Forms.GroupBox groupBox7;
        private MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM txt_observaciones;
        private MVASQUEZ__CONTROLES.MV_BOTON BTN_NUEVO;
        private MVASQUEZ__CONTROLES.MV_BOTON BTN_CANCELAR;
        private MVASQUEZ__CONTROLES.MV_BOTON BTN_GUARDAR;
        private MVASQUEZ__CONTROLES.MV_BOTON BTN_SALIR;
        private MVASQUEZ__CONTROLES.MV_BOTON BTN_IMPRIMIR;
        private MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM txt_costo_reaparcion;
        private MVASQUEZ__CONTROLES.MV_BOTON btn_agregar_marca;
        private MVASQUEZ__CONTROLES.MV_BOTON btn_agregar_tipo_qeuipo;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox10;
        private MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM txtadelanto;
    }
}