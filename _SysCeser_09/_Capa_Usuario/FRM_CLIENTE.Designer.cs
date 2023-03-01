namespace _PROYECTO_FINAL_LPV
{
    partial class FRM_CLIENTE
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
            this.TXT_E_MAIL = new System.Windows.Forms.TextBox();
            this.TXT_ID_CLIENTE = new MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM();
            this.mV_LABEL14 = new MVASQUEZ__CONTROLES.MV_LABEL();
            this.CBO_SEXO = new MVASQUEZ__CONTROLES.MV_COMBOBOX();
            this.DTP_FECHA_NACIMIENTO = new System.Windows.Forms.DateTimePicker();
            this.TXT_TELEFONO = new MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM();
            this.mV_LABEL_ESPEJO1 = new MVASQUEZ__CONTROLES.MV_LABEL_ESPEJO();
            this.TXT_DIRECCION = new MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM();
            this.mV_LABEL13 = new MVASQUEZ__CONTROLES.MV_LABEL();
            this.mV_LABEL6 = new MVASQUEZ__CONTROLES.MV_LABEL();
            this.mV_LABEL9 = new MVASQUEZ__CONTROLES.MV_LABEL();
            this.BTN_CANCELAR = new MVASQUEZ__CONTROLES.MV_BOTON();
            this.BTN_GUARDAR = new MVASQUEZ__CONTROLES.MV_BOTON();
            this.mV_LABEL8 = new MVASQUEZ__CONTROLES.MV_LABEL();
            this.BTN_SALIR = new MVASQUEZ__CONTROLES.MV_BOTON();
            this.mV_LABEL7 = new MVASQUEZ__CONTROLES.MV_LABEL();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TXT_CELULAR = new MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM();
            this.mV_LABEL10 = new MVASQUEZ__CONTROLES.MV_LABEL();
            this.TXT_RUC = new MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM();
            this.TXT_DNI = new MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM();
            this.mV_LABEL3 = new MVASQUEZ__CONTROLES.MV_LABEL();
            this.mV_LABEL4 = new MVASQUEZ__CONTROLES.MV_LABEL();
            this.mV_LABEL5 = new MVASQUEZ__CONTROLES.MV_LABEL();
            this.TXT_NOMBRES = new MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM();
            this.TXT_APE_MATERNO = new MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM();
            this.TXT_APE_PATERNO = new MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM();
            this.mV_LABEL2 = new MVASQUEZ__CONTROLES.MV_LABEL();
            this.mV_LABEL1 = new MVASQUEZ__CONTROLES.MV_LABEL();
            this.BTN_NUEVO = new MVASQUEZ__CONTROLES.MV_BOTON();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TXT_E_MAIL
            // 
            this.TXT_E_MAIL.Location = new System.Drawing.Point(113, 189);
            this.TXT_E_MAIL.MaxLength = 50;
            this.TXT_E_MAIL.Name = "TXT_E_MAIL";
            this.TXT_E_MAIL.Size = new System.Drawing.Size(404, 20);
            this.TXT_E_MAIL.TabIndex = 18;
            // 
            // TXT_ID_CLIENTE
            // 
            this.TXT_ID_CLIENTE.BackColor = System.Drawing.Color.White;
            this.TXT_ID_CLIENTE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXT_ID_CLIENTE.Enabled = false;
            this.TXT_ID_CLIENTE.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_ID_CLIENTE.Location = new System.Drawing.Point(129, 32);
            this.TXT_ID_CLIENTE.Name = "TXT_ID_CLIENTE";
            this.TXT_ID_CLIENTE.ReadOnly = true;
            this.TXT_ID_CLIENTE.Size = new System.Drawing.Size(138, 23);
            this.TXT_ID_CLIENTE.TabIndex = 21;
            this.TXT_ID_CLIENTE.TIPO_TEXTBOX = MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM.E_TIPO_TEXBOX.NUMEROS;
            // 
            // mV_LABEL14
            // 
            this.mV_LABEL14.AutoSize = true;
            this.mV_LABEL14.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mV_LABEL14.Location = new System.Drawing.Point(75, 159);
            this.mV_LABEL14.Name = "mV_LABEL14";
            this.mV_LABEL14.Size = new System.Drawing.Size(32, 13);
            this.mV_LABEL14.TabIndex = 23;
            this.mV_LABEL14.Text = "Ruc :";
            this.mV_LABEL14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CBO_SEXO
            // 
            this.CBO_SEXO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBO_SEXO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBO_SEXO.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBO_SEXO.FormattingEnabled = true;
            this.CBO_SEXO.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMENINO"});
            this.CBO_SEXO.Location = new System.Drawing.Point(366, 99);
            this.CBO_SEXO.Name = "CBO_SEXO";
            this.CBO_SEXO.Size = new System.Drawing.Size(151, 21);
            this.CBO_SEXO.TabIndex = 17;
            // 
            // DTP_FECHA_NACIMIENTO
            // 
            this.DTP_FECHA_NACIMIENTO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_FECHA_NACIMIENTO.Location = new System.Drawing.Point(366, 159);
            this.DTP_FECHA_NACIMIENTO.Name = "DTP_FECHA_NACIMIENTO";
            this.DTP_FECHA_NACIMIENTO.Size = new System.Drawing.Size(151, 20);
            this.DTP_FECHA_NACIMIENTO.TabIndex = 16;
            // 
            // TXT_TELEFONO
            // 
            this.TXT_TELEFONO.BackColor = System.Drawing.Color.White;
            this.TXT_TELEFONO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXT_TELEFONO.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.TXT_TELEFONO.Location = new System.Drawing.Point(113, 215);
            this.TXT_TELEFONO.MVASQUEZ_LABEL_ESPEJO = this.mV_LABEL_ESPEJO1;
            this.TXT_TELEFONO.Name = "TXT_TELEFONO";
            this.TXT_TELEFONO.Size = new System.Drawing.Size(138, 21);
            this.TXT_TELEFONO.TabIndex = 15;
            this.TXT_TELEFONO.TIPO_TEXTBOX = MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM.E_TIPO_TEXBOX.NUMEROS;
            // 
            // mV_LABEL_ESPEJO1
            // 
            this.mV_LABEL_ESPEJO1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mV_LABEL_ESPEJO1.Dock = System.Windows.Forms.DockStyle.Top;
            this.mV_LABEL_ESPEJO1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mV_LABEL_ESPEJO1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mV_LABEL_ESPEJO1.Location = new System.Drawing.Point(0, 0);
            this.mV_LABEL_ESPEJO1.Name = "mV_LABEL_ESPEJO1";
            this.mV_LABEL_ESPEJO1.Size = new System.Drawing.Size(584, 24);
            this.mV_LABEL_ESPEJO1.TabIndex = 20;
            this.mV_LABEL_ESPEJO1.Text = " ";
            this.mV_LABEL_ESPEJO1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mV_LABEL_ESPEJO1.Click += new System.EventHandler(this.mV_LABEL_ESPEJO1_Click);
            // 
            // TXT_DIRECCION
            // 
            this.TXT_DIRECCION.BackColor = System.Drawing.Color.White;
            this.TXT_DIRECCION.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXT_DIRECCION.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.TXT_DIRECCION.Location = new System.Drawing.Point(113, 131);
            this.TXT_DIRECCION.MVASQUEZ_LABEL_ESPEJO = this.mV_LABEL_ESPEJO1;
            this.TXT_DIRECCION.Name = "TXT_DIRECCION";
            this.TXT_DIRECCION.Size = new System.Drawing.Size(404, 21);
            this.TXT_DIRECCION.TabIndex = 14;
            this.TXT_DIRECCION.Tag = "Direccion";
            this.TXT_DIRECCION.TIPO_TEXTBOX = MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM.E_TIPO_TEXBOX.GENERAL;
            // 
            // mV_LABEL13
            // 
            this.mV_LABEL13.AutoSize = true;
            this.mV_LABEL13.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mV_LABEL13.Location = new System.Drawing.Point(70, 189);
            this.mV_LABEL13.Name = "mV_LABEL13";
            this.mV_LABEL13.Size = new System.Drawing.Size(41, 13);
            this.mV_LABEL13.TabIndex = 13;
            this.mV_LABEL13.Text = "E mail :";
            this.mV_LABEL13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mV_LABEL6
            // 
            this.mV_LABEL6.AutoSize = true;
            this.mV_LABEL6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mV_LABEL6.Location = new System.Drawing.Point(322, 102);
            this.mV_LABEL6.Name = "mV_LABEL6";
            this.mV_LABEL6.Size = new System.Drawing.Size(38, 13);
            this.mV_LABEL6.TabIndex = 7;
            this.mV_LABEL6.Text = "Sexo :";
            this.mV_LABEL6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mV_LABEL9
            // 
            this.mV_LABEL9.AutoSize = true;
            this.mV_LABEL9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mV_LABEL9.Location = new System.Drawing.Point(263, 163);
            this.mV_LABEL9.Name = "mV_LABEL9";
            this.mV_LABEL9.Size = new System.Drawing.Size(97, 13);
            this.mV_LABEL9.TabIndex = 9;
            this.mV_LABEL9.Text = "Fecha nacimiento :";
            this.mV_LABEL9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.BTN_CANCELAR.Location = new System.Drawing.Point(297, 329);
            this.BTN_CANCELAR.Name = "BTN_CANCELAR";
            this.BTN_CANCELAR.Size = new System.Drawing.Size(128, 23);
            this.BTN_CANCELAR.TabIndex = 26;
            this.BTN_CANCELAR.Text = "Cancelar";
            this.BTN_CANCELAR.UseVisualStyleBackColor = true;
            this.BTN_CANCELAR.Click += new System.EventHandler(this.BTN_CANCELAR_Click);
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
            this.BTN_GUARDAR.Location = new System.Drawing.Point(16, 329);
            this.BTN_GUARDAR.Name = "BTN_GUARDAR";
            this.BTN_GUARDAR.Size = new System.Drawing.Size(128, 23);
            this.BTN_GUARDAR.TabIndex = 25;
            this.BTN_GUARDAR.Text = "Guardar";
            this.BTN_GUARDAR.UseVisualStyleBackColor = true;
            this.BTN_GUARDAR.Click += new System.EventHandler(this.BTN_GUARDAR_Click);
            // 
            // mV_LABEL8
            // 
            this.mV_LABEL8.AutoSize = true;
            this.mV_LABEL8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mV_LABEL8.Location = new System.Drawing.Point(51, 220);
            this.mV_LABEL8.Name = "mV_LABEL8";
            this.mV_LABEL8.Size = new System.Drawing.Size(56, 13);
            this.mV_LABEL8.TabIndex = 8;
            this.mV_LABEL8.Text = "Telefono :";
            this.mV_LABEL8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.BTN_SALIR.Location = new System.Drawing.Point(458, 329);
            this.BTN_SALIR.Name = "BTN_SALIR";
            this.BTN_SALIR.Size = new System.Drawing.Size(105, 23);
            this.BTN_SALIR.TabIndex = 28;
            this.BTN_SALIR.Text = "Salir";
            this.BTN_SALIR.UseVisualStyleBackColor = true;
            this.BTN_SALIR.Click += new System.EventHandler(this.BTN_SALIR_Click);
            // 
            // mV_LABEL7
            // 
            this.mV_LABEL7.AutoSize = true;
            this.mV_LABEL7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mV_LABEL7.Location = new System.Drawing.Point(54, 134);
            this.mV_LABEL7.Name = "mV_LABEL7";
            this.mV_LABEL7.Size = new System.Drawing.Size(57, 13);
            this.mV_LABEL7.TabIndex = 7;
            this.mV_LABEL7.Text = "Direccion :";
            this.mV_LABEL7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TXT_CELULAR);
            this.groupBox1.Controls.Add(this.mV_LABEL10);
            this.groupBox1.Controls.Add(this.TXT_RUC);
            this.groupBox1.Controls.Add(this.TXT_E_MAIL);
            this.groupBox1.Controls.Add(this.mV_LABEL14);
            this.groupBox1.Controls.Add(this.CBO_SEXO);
            this.groupBox1.Controls.Add(this.DTP_FECHA_NACIMIENTO);
            this.groupBox1.Controls.Add(this.TXT_TELEFONO);
            this.groupBox1.Controls.Add(this.TXT_DIRECCION);
            this.groupBox1.Controls.Add(this.mV_LABEL13);
            this.groupBox1.Controls.Add(this.mV_LABEL6);
            this.groupBox1.Controls.Add(this.mV_LABEL9);
            this.groupBox1.Controls.Add(this.mV_LABEL8);
            this.groupBox1.Controls.Add(this.mV_LABEL7);
            this.groupBox1.Controls.Add(this.TXT_DNI);
            this.groupBox1.Controls.Add(this.mV_LABEL3);
            this.groupBox1.Controls.Add(this.mV_LABEL4);
            this.groupBox1.Controls.Add(this.mV_LABEL5);
            this.groupBox1.Controls.Add(this.TXT_NOMBRES);
            this.groupBox1.Controls.Add(this.TXT_APE_MATERNO);
            this.groupBox1.Controls.Add(this.TXT_APE_PATERNO);
            this.groupBox1.Controls.Add(this.mV_LABEL2);
            this.groupBox1.Location = new System.Drawing.Point(16, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 249);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // TXT_CELULAR
            // 
            this.TXT_CELULAR.BackColor = System.Drawing.Color.White;
            this.TXT_CELULAR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXT_CELULAR.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.TXT_CELULAR.Location = new System.Drawing.Point(366, 217);
            this.TXT_CELULAR.Name = "TXT_CELULAR";
            this.TXT_CELULAR.Size = new System.Drawing.Size(151, 21);
            this.TXT_CELULAR.TabIndex = 26;
            this.TXT_CELULAR.TIPO_TEXTBOX = MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM.E_TIPO_TEXBOX.NUMEROS;
            // 
            // mV_LABEL10
            // 
            this.mV_LABEL10.AutoSize = true;
            this.mV_LABEL10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mV_LABEL10.Location = new System.Drawing.Point(304, 222);
            this.mV_LABEL10.Name = "mV_LABEL10";
            this.mV_LABEL10.Size = new System.Drawing.Size(47, 13);
            this.mV_LABEL10.TabIndex = 25;
            this.mV_LABEL10.Text = "Celular :";
            this.mV_LABEL10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TXT_RUC
            // 
            this.TXT_RUC.BackColor = System.Drawing.Color.White;
            this.TXT_RUC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXT_RUC.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.TXT_RUC.Location = new System.Drawing.Point(113, 159);
            this.TXT_RUC.MaxLength = 11;
            this.TXT_RUC.MVASQUEZ_LABEL_ESPEJO = this.mV_LABEL_ESPEJO1;
            this.TXT_RUC.Name = "TXT_RUC";
            this.TXT_RUC.Size = new System.Drawing.Size(138, 21);
            this.TXT_RUC.TabIndex = 24;
            this.TXT_RUC.TIPO_TEXTBOX = MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM.E_TIPO_TEXBOX.NUMEROS;
            // 
            // TXT_DNI
            // 
            this.TXT_DNI.BackColor = System.Drawing.Color.White;
            this.TXT_DNI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXT_DNI.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.TXT_DNI.Location = new System.Drawing.Point(113, 102);
            this.TXT_DNI.MaxLength = 8;
            this.TXT_DNI.MVASQUEZ_LABEL_ESPEJO = this.mV_LABEL_ESPEJO1;
            this.TXT_DNI.Name = "TXT_DNI";
            this.TXT_DNI.Size = new System.Drawing.Size(138, 21);
            this.TXT_DNI.TabIndex = 4;
            this.TXT_DNI.Tag = "Dni";
            this.TXT_DNI.TIPO_TEXTBOX = MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM.E_TIPO_TEXBOX.NUMEROS;
            // 
            // mV_LABEL3
            // 
            this.mV_LABEL3.AutoSize = true;
            this.mV_LABEL3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mV_LABEL3.Location = new System.Drawing.Point(82, 109);
            this.mV_LABEL3.Name = "mV_LABEL3";
            this.mV_LABEL3.Size = new System.Drawing.Size(29, 13);
            this.mV_LABEL3.TabIndex = 4;
            this.mV_LABEL3.Text = "Dni :";
            this.mV_LABEL3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mV_LABEL4
            // 
            this.mV_LABEL4.AutoSize = true;
            this.mV_LABEL4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mV_LABEL4.Location = new System.Drawing.Point(55, 82);
            this.mV_LABEL4.Name = "mV_LABEL4";
            this.mV_LABEL4.Size = new System.Drawing.Size(56, 13);
            this.mV_LABEL4.TabIndex = 5;
            this.mV_LABEL4.Text = "Nombres :";
            this.mV_LABEL4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mV_LABEL5
            // 
            this.mV_LABEL5.AutoSize = true;
            this.mV_LABEL5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mV_LABEL5.Location = new System.Drawing.Point(17, 54);
            this.mV_LABEL5.Name = "mV_LABEL5";
            this.mV_LABEL5.Size = new System.Drawing.Size(94, 13);
            this.mV_LABEL5.TabIndex = 6;
            this.mV_LABEL5.Text = "Apellido materno :";
            this.mV_LABEL5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TXT_NOMBRES
            // 
            this.TXT_NOMBRES.BackColor = System.Drawing.Color.White;
            this.TXT_NOMBRES.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXT_NOMBRES.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.TXT_NOMBRES.Location = new System.Drawing.Point(113, 74);
            this.TXT_NOMBRES.MVASQUEZ_LABEL_ESPEJO = this.mV_LABEL_ESPEJO1;
            this.TXT_NOMBRES.Name = "TXT_NOMBRES";
            this.TXT_NOMBRES.Size = new System.Drawing.Size(247, 21);
            this.TXT_NOMBRES.TabIndex = 3;
            this.TXT_NOMBRES.Tag = "Nombres";
            this.TXT_NOMBRES.TIPO_TEXTBOX = MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM.E_TIPO_TEXBOX.LETRAS;
            // 
            // TXT_APE_MATERNO
            // 
            this.TXT_APE_MATERNO.BackColor = System.Drawing.Color.White;
            this.TXT_APE_MATERNO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXT_APE_MATERNO.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.TXT_APE_MATERNO.Location = new System.Drawing.Point(113, 46);
            this.TXT_APE_MATERNO.MVASQUEZ_LABEL_ESPEJO = this.mV_LABEL_ESPEJO1;
            this.TXT_APE_MATERNO.Name = "TXT_APE_MATERNO";
            this.TXT_APE_MATERNO.Size = new System.Drawing.Size(247, 21);
            this.TXT_APE_MATERNO.TabIndex = 2;
            this.TXT_APE_MATERNO.Tag = "Apellido materno";
            this.TXT_APE_MATERNO.TIPO_TEXTBOX = MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM.E_TIPO_TEXBOX.LETRAS;
            // 
            // TXT_APE_PATERNO
            // 
            this.TXT_APE_PATERNO.BackColor = System.Drawing.Color.White;
            this.TXT_APE_PATERNO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXT_APE_PATERNO.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.TXT_APE_PATERNO.Location = new System.Drawing.Point(113, 18);
            this.TXT_APE_PATERNO.MVASQUEZ_LABEL_ESPEJO = this.mV_LABEL_ESPEJO1;
            this.TXT_APE_PATERNO.Name = "TXT_APE_PATERNO";
            this.TXT_APE_PATERNO.Size = new System.Drawing.Size(247, 21);
            this.TXT_APE_PATERNO.TabIndex = 1;
            this.TXT_APE_PATERNO.Tag = "Apellido paterno";
            this.TXT_APE_PATERNO.TIPO_TEXTBOX = MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM.E_TIPO_TEXBOX.LETRAS;
            // 
            // mV_LABEL2
            // 
            this.mV_LABEL2.AutoSize = true;
            this.mV_LABEL2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mV_LABEL2.Location = new System.Drawing.Point(19, 20);
            this.mV_LABEL2.Name = "mV_LABEL2";
            this.mV_LABEL2.Size = new System.Drawing.Size(92, 13);
            this.mV_LABEL2.TabIndex = 0;
            this.mV_LABEL2.Text = "Apellido paterno :";
            this.mV_LABEL2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mV_LABEL1
            // 
            this.mV_LABEL1.AutoSize = true;
            this.mV_LABEL1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mV_LABEL1.Location = new System.Drawing.Point(35, 39);
            this.mV_LABEL1.Name = "mV_LABEL1";
            this.mV_LABEL1.Size = new System.Drawing.Size(58, 13);
            this.mV_LABEL1.TabIndex = 29;
            this.mV_LABEL1.Text = "Id cliente :";
            this.mV_LABEL1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.BTN_NUEVO.Location = new System.Drawing.Point(153, 329);
            this.BTN_NUEVO.Name = "BTN_NUEVO";
            this.BTN_NUEVO.Size = new System.Drawing.Size(129, 23);
            this.BTN_NUEVO.TabIndex = 30;
            this.BTN_NUEVO.Text = "Nuevo";
            this.BTN_NUEVO.UseVisualStyleBackColor = true;
            this.BTN_NUEVO.Click += new System.EventHandler(this.BTN_NUEVO_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(16, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(547, 43);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            // 
            // FRM_CLIENTE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(584, 374);
            this.Controls.Add(this.BTN_NUEVO);
            this.Controls.Add(this.mV_LABEL1);
            this.Controls.Add(this.TXT_ID_CLIENTE);
            this.Controls.Add(this.BTN_CANCELAR);
            this.Controls.Add(this.BTN_GUARDAR);
            this.Controls.Add(this.BTN_SALIR);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mV_LABEL_ESPEJO1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FRM_CLIENTE";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CLIENTE";
            this.Load += new System.EventHandler(this.FRM_ALUMNO_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXT_E_MAIL;
        private MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM TXT_ID_CLIENTE;
        private MVASQUEZ__CONTROLES.MV_LABEL mV_LABEL14;
        private MVASQUEZ__CONTROLES.MV_COMBOBOX CBO_SEXO;
        private System.Windows.Forms.DateTimePicker DTP_FECHA_NACIMIENTO;
        private MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM TXT_TELEFONO;
        private MVASQUEZ__CONTROLES.MV_LABEL_ESPEJO mV_LABEL_ESPEJO1;
        private MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM TXT_DIRECCION;
        private MVASQUEZ__CONTROLES.MV_LABEL mV_LABEL13;
        private MVASQUEZ__CONTROLES.MV_LABEL mV_LABEL6;
        private MVASQUEZ__CONTROLES.MV_LABEL mV_LABEL9;
        private MVASQUEZ__CONTROLES.MV_BOTON BTN_CANCELAR;
        private MVASQUEZ__CONTROLES.MV_BOTON BTN_GUARDAR;
        private MVASQUEZ__CONTROLES.MV_LABEL mV_LABEL8;
        private MVASQUEZ__CONTROLES.MV_BOTON BTN_SALIR;
        private MVASQUEZ__CONTROLES.MV_LABEL mV_LABEL7;
        private System.Windows.Forms.GroupBox groupBox1;
        private MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM TXT_DNI;
        private MVASQUEZ__CONTROLES.MV_LABEL mV_LABEL3;
        private MVASQUEZ__CONTROLES.MV_LABEL mV_LABEL4;
        private MVASQUEZ__CONTROLES.MV_LABEL mV_LABEL5;
        private MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM TXT_NOMBRES;
        private MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM TXT_APE_MATERNO;
        private MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM TXT_APE_PATERNO;
        private MVASQUEZ__CONTROLES.MV_LABEL mV_LABEL2;
        private MVASQUEZ__CONTROLES.MV_LABEL mV_LABEL1;
        private MVASQUEZ__CONTROLES.MV_BOTON BTN_NUEVO;
        private MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM TXT_RUC;
        private MVASQUEZ__CONTROLES.MV_TEXTBOXT_ENUM TXT_CELULAR;
        private MVASQUEZ__CONTROLES.MV_LABEL mV_LABEL10;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}