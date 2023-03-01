using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using _Capa_Negocios;

namespace _PROYECTO_FINAL_LPV
{
    public partial class FRM_PRINCIPAL : Form
    {
        public FRM_PRINCIPAL()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_Capa_Negocios._Sistema._Obtener_Instancia()._Util._Call_mensaje_box(" ¿Desea salir del sistema?", "Mensaje"))
            {
               
                this.Dispose();
                this.Close();
                Application.Exit();
            }
        }

        private void FRM_PRINCIPAL_Load(object sender, EventArgs e)
        {
            FRM_ACCESO _Acceso = new FRM_ACCESO();
            _Acceso.ShowDialog(this);
            this.TIMER.Enabled = true;
            this.NI.ShowBalloonTip(20, "Modulo Ceser", "Bienvenido.....", ToolTipIcon.None);

            try
            {

                System.Data.DataRow _Fila = _Sistema._Obtener_Instancia()._Empleado._Obtener(_Sistema._Obtener_Instancia()._Empleado.Id_empleado.Trim());

                this.tttt.Text = "         USUARIO : " + _Fila[1] + " " + _Fila[2] + " " + _Fila[3];
            }
            catch (Exception)
            {
                
            }
          
            
        }

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_BUSQUEDA_CLIENTE _B_cliente = new FRM_BUSQUEDA_CLIENTE();
            // NewMDIChild.MdiParent = Me
            _B_cliente.MdiParent = this;
            _B_cliente.Show();
            
        }

        private void FRM_PRINCIPAL_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            this.Dispose();
            this.Close();
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_BUSQUEDA_EMPLEADO _B_empleado = new FRM_BUSQUEDA_EMPLEADO();
            _B_empleado.MdiParent = this;
            _B_empleado .Show();
        }

        private void NI_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if( Convert .ToBoolean ( this.WindowState=System.Windows.Forms.FormWindowState.Maximized))
                {
                    this.WindowState = FormWindowState.Minimized;
                    NI.Visible = true;
                }
            else
                {
                    this.WindowState = FormWindowState.Maximized;
                    NI.Visible = true;
                }
            }
        catch (Exception ex)
            {
                _Sistema._Obtener_Instancia()._Util._Call_mensaje(ex.Message, "");
            }
        }

        private void apoderadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }


        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal );
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical );
        }

        private void iconosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void _tm_barra_Tick(object sender, EventArgs e)
        {
        }

        private void areaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_BUSCAR_AREA _B_Area = new FRM_BUSCAR_AREA();
            _B_Area.MdiParent=this;
            _B_Area.Show();

        }

        private void cargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_BUSCA_CARGO _B_cargo = new FRM_BUSCA_CARGO();
            _B_cargo.MdiParent = this;
            _B_cargo.Show();
        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_BUSCA_MARCA _B_marca = new FRM_BUSCA_MARCA();
            _B_marca.MdiParent = this;
            _B_marca.Show();
        }

        private void registrarIngresoDeEquipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_REGISTRO_INGRESO_EQUIPO r_e = new FRM_REGISTRO_INGRESO_EQUIPO();
            r_e.MdiParent = this;
            r_e.Show();
        }
       

        private void tipoEquipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_TIPO_EQUIPO _Te = new FRM_TIPO_EQUIPO();
            _Te.MdiParent = this;
            _Te.Show();
        }

        private void registrarSalidaDeEquipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_REGISTRO_SALIDA_EQUIPO _Rs = new FRM_REGISTRO_SALIDA_EQUIPO();
            _Rs.MdiParent = this;
            _Rs.Show();
        }

        private void registrarReparacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_REGISTRO_REPARACIONES _Rr = new FRM_REGISTRO_REPARACIONES();
            _Rr.MdiParent = this;
            _Rr.Show();
        }

        private void actualizarIngresoEquipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ACTUALIZA_INGRESO_EQUIPO _Aie = new FRM_ACTUALIZA_INGRESO_EQUIPO();
            _Aie.MdiParent = this;
            _Aie.Show();
        }

        private void registrarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_REGISTRAR_VENTA _Rr = new FRM_REGISTRAR_VENTA();
            _Rr.MdiParent = this;
            _Rr.Show();
        }
    }
}
