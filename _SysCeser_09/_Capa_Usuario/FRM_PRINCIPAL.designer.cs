namespace _PROYECTO_FINAL_LPV
{
    partial class FRM_PRINCIPAL
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.areaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoEquipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscripciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarIngresoDeEquipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarIngresoEquipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matriculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarSalidaDeEquipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarReparacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iconosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NI = new System.Windows.Forms.NotifyIcon(this.components);
            this.TIMER = new System.Windows.Forms.Timer(this.components);
            this._ss = new System.Windows.Forms.StatusStrip();
            this._st_autenticacion = new System.Windows.Forms.ToolStripStatusLabel();
            this.tttt = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.registrarVentaSinIngresoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this._ss.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.mantenimientoToolStripMenuItem,
            this.procesoToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.ventanaToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.ventanaToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(835, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alumnoToolStripMenuItem,
            this.empleadoToolStripMenuItem,
            this.areaToolStripMenuItem,
            this.marcaToolStripMenuItem,
            this.cargosToolStripMenuItem,
            this.tipoEquipoToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // alumnoToolStripMenuItem
            // 
            this.alumnoToolStripMenuItem.Name = "alumnoToolStripMenuItem";
            this.alumnoToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.alumnoToolStripMenuItem.Text = "Clientes";
            this.alumnoToolStripMenuItem.Click += new System.EventHandler(this.alumnoToolStripMenuItem_Click);
            // 
            // empleadoToolStripMenuItem
            // 
            this.empleadoToolStripMenuItem.Name = "empleadoToolStripMenuItem";
            this.empleadoToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.empleadoToolStripMenuItem.Text = "Empleados";
            this.empleadoToolStripMenuItem.Click += new System.EventHandler(this.empleadoToolStripMenuItem_Click);
            // 
            // areaToolStripMenuItem
            // 
            this.areaToolStripMenuItem.Name = "areaToolStripMenuItem";
            this.areaToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.areaToolStripMenuItem.Text = "Areas";
            this.areaToolStripMenuItem.Click += new System.EventHandler(this.areaToolStripMenuItem_Click);
            // 
            // marcaToolStripMenuItem
            // 
            this.marcaToolStripMenuItem.Name = "marcaToolStripMenuItem";
            this.marcaToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.marcaToolStripMenuItem.Text = "Marcas";
            this.marcaToolStripMenuItem.Click += new System.EventHandler(this.marcaToolStripMenuItem_Click);
            // 
            // cargosToolStripMenuItem
            // 
            this.cargosToolStripMenuItem.Name = "cargosToolStripMenuItem";
            this.cargosToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.cargosToolStripMenuItem.Text = "Cargos";
            this.cargosToolStripMenuItem.Click += new System.EventHandler(this.cargosToolStripMenuItem_Click);
            // 
            // tipoEquipoToolStripMenuItem
            // 
            this.tipoEquipoToolStripMenuItem.Name = "tipoEquipoToolStripMenuItem";
            this.tipoEquipoToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.tipoEquipoToolStripMenuItem.Text = "Tipo equipo";
            this.tipoEquipoToolStripMenuItem.Click += new System.EventHandler(this.tipoEquipoToolStripMenuItem_Click);
            // 
            // procesoToolStripMenuItem
            // 
            this.procesoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inscripciónToolStripMenuItem,
            this.matriculaToolStripMenuItem});
            this.procesoToolStripMenuItem.Name = "procesoToolStripMenuItem";
            this.procesoToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.procesoToolStripMenuItem.Text = "Ordenes";
            // 
            // inscripciónToolStripMenuItem
            // 
            this.inscripciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarIngresoDeEquipoToolStripMenuItem,
            this.actualizarIngresoEquipoToolStripMenuItem});
            this.inscripciónToolStripMenuItem.Name = "inscripciónToolStripMenuItem";
            this.inscripciónToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.inscripciónToolStripMenuItem.Text = "Ingreso";
            // 
            // registrarIngresoDeEquipoToolStripMenuItem
            // 
            this.registrarIngresoDeEquipoToolStripMenuItem.Name = "registrarIngresoDeEquipoToolStripMenuItem";
            this.registrarIngresoDeEquipoToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.registrarIngresoDeEquipoToolStripMenuItem.Text = "Registrar ingreso de equipo";
            this.registrarIngresoDeEquipoToolStripMenuItem.Click += new System.EventHandler(this.registrarIngresoDeEquipoToolStripMenuItem_Click);
            // 
            // actualizarIngresoEquipoToolStripMenuItem
            // 
            this.actualizarIngresoEquipoToolStripMenuItem.Name = "actualizarIngresoEquipoToolStripMenuItem";
            this.actualizarIngresoEquipoToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.actualizarIngresoEquipoToolStripMenuItem.Text = "Actualizar ingreso equipo";
            this.actualizarIngresoEquipoToolStripMenuItem.Click += new System.EventHandler(this.actualizarIngresoEquipoToolStripMenuItem_Click);
            // 
            // matriculaToolStripMenuItem
            // 
            this.matriculaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarSalidaDeEquipoToolStripMenuItem});
            this.matriculaToolStripMenuItem.Name = "matriculaToolStripMenuItem";
            this.matriculaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.matriculaToolStripMenuItem.Text = "Salida";
            // 
            // registrarSalidaDeEquipoToolStripMenuItem
            // 
            this.registrarSalidaDeEquipoToolStripMenuItem.Name = "registrarSalidaDeEquipoToolStripMenuItem";
            this.registrarSalidaDeEquipoToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.registrarSalidaDeEquipoToolStripMenuItem.Text = "Registrar salida de equipo";
            this.registrarSalidaDeEquipoToolStripMenuItem.Click += new System.EventHandler(this.registrarSalidaDeEquipoToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarReparacionToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.consultasToolStripMenuItem.Text = "Reparaciones";
            // 
            // registrarReparacionToolStripMenuItem
            // 
            this.registrarReparacionToolStripMenuItem.Name = "registrarReparacionToolStripMenuItem";
            this.registrarReparacionToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.registrarReparacionToolStripMenuItem.Text = "Registrar reparacion equipo";
            this.registrarReparacionToolStripMenuItem.Click += new System.EventHandler(this.registrarReparacionToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarVentaToolStripMenuItem,
            this.registrarVentaSinIngresoToolStripMenuItem});
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // registrarVentaToolStripMenuItem
            // 
            this.registrarVentaToolStripMenuItem.Name = "registrarVentaToolStripMenuItem";
            this.registrarVentaToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.registrarVentaToolStripMenuItem.Text = "Registrar Venta Con Ingreso";
            this.registrarVentaToolStripMenuItem.Click += new System.EventHandler(this.registrarVentaToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.reportesToolStripMenuItem.Text = "Consultas";
            // 
            // ventanaToolStripMenuItem
            // 
            this.ventanaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadaToolStripMenuItem,
            this.horizontalToolStripMenuItem,
            this.verticalToolStripMenuItem,
            this.iconosToolStripMenuItem});
            this.ventanaToolStripMenuItem.Name = "ventanaToolStripMenuItem";
            this.ventanaToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.ventanaToolStripMenuItem.Text = "Ventana";
            // 
            // cascadaToolStripMenuItem
            // 
            this.cascadaToolStripMenuItem.Name = "cascadaToolStripMenuItem";
            this.cascadaToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.cascadaToolStripMenuItem.Text = "Cascada";
            this.cascadaToolStripMenuItem.Click += new System.EventHandler(this.cascadaToolStripMenuItem_Click);
            // 
            // horizontalToolStripMenuItem
            // 
            this.horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            this.horizontalToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.horizontalToolStripMenuItem.Text = "Horizontal";
            this.horizontalToolStripMenuItem.Click += new System.EventHandler(this.horizontalToolStripMenuItem_Click);
            // 
            // verticalToolStripMenuItem
            // 
            this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            this.verticalToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.verticalToolStripMenuItem.Text = "Vertical";
            this.verticalToolStripMenuItem.Click += new System.EventHandler(this.verticalToolStripMenuItem_Click);
            // 
            // iconosToolStripMenuItem
            // 
            this.iconosToolStripMenuItem.Name = "iconosToolStripMenuItem";
            this.iconosToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.iconosToolStripMenuItem.Text = "Iconos";
            this.iconosToolStripMenuItem.Click += new System.EventHandler(this.iconosToolStripMenuItem_Click);
            // 
            // NI
            // 
            this.NI.Text = "notifyIcon1";
            this.NI.Visible = true;
            this.NI.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NI_MouseDoubleClick);
            // 
            // TIMER
            // 
            this.TIMER.Interval = 1000;
            // 
            // _ss
            // 
            this._ss.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this._ss.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._st_autenticacion,
            this.tttt,
            this.toolStripStatusLabel1});
            this._ss.Location = new System.Drawing.Point(0, 430);
            this._ss.Name = "_ss";
            this._ss.Size = new System.Drawing.Size(835, 22);
            this._ss.TabIndex = 12;
            this._ss.Text = "statusStrip1ghfg";
            // 
            // _st_autenticacion
            // 
            this._st_autenticacion.Name = "_st_autenticacion";
            this._st_autenticacion.Size = new System.Drawing.Size(0, 17);
            // 
            // tttt
            // 
            this.tttt.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tttt.Name = "tttt";
            this.tttt.Size = new System.Drawing.Size(13, 17);
            this.tttt.Text = "-";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(835, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // registrarVentaSinIngresoToolStripMenuItem
            // 
            this.registrarVentaSinIngresoToolStripMenuItem.Name = "registrarVentaSinIngresoToolStripMenuItem";
            this.registrarVentaSinIngresoToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.registrarVentaSinIngresoToolStripMenuItem.Text = "Registrar Venta Sin Ingreso";
            // 
            // FRM_PRINCIPAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(835, 452);
            this.Controls.Add(this._ss);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FRM_PRINCIPAL";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRM_PRINCIPAL_FormClosed);
            this.Load += new System.EventHandler(this.FRM_PRINCIPAL_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this._ss.ResumeLayout(false);
            this._ss.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscripciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matriculaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.NotifyIcon NI;
        public System.Windows.Forms.Timer TIMER;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iconosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem areaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargosToolStripMenuItem;
        private System.Windows.Forms.StatusStrip _ss;
        private System.Windows.Forms.ToolStripStatusLabel _st_autenticacion;
        private System.Windows.Forms.ToolStripMenuItem registrarIngresoDeEquipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarSalidaDeEquipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel tttt;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem tipoEquipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarReparacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarIngresoEquipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarVentaSinIngresoToolStripMenuItem;
    }
}