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
    public partial class FRM_BUSQUEDA_EMPLEADO : Form
    {
        public FRM_BUSQUEDA_EMPLEADO()
        {
            InitializeComponent();
        }

        private void TXT_ALUMNO_TextChanged(object sender, EventArgs e)
        {
            try
            {
                System.Data .DataTable _Tabla=_Sistema._Obtener_Instancia()._Empleado._Filtrar(this.TXT_EMPLEADO.Text.Trim());
                this.GRID_EMPLEADOS.DataSource = _Tabla;
            }
            catch (Exception ex)
            {
                _Sistema._Obtener_Instancia()._Util._Call_mensaje(ex.Message, "Error");
            }
        }

        private void BTN_NUEVO_Click(object sender, EventArgs e)
        {
            FRM_EMPLEADO _Empleado = new FRM_EMPLEADO();
            _Empleado.ShowDialog(this);
        }

        private void BTN_ACTUALIZAR_Click(object sender, EventArgs e)
        {
            if (this.GRID_EMPLEADOS .Rows .Count >0)
            {
                 _Sistema._Obtener_Instancia()._Empleado.Id_empleado = Convert.ToString(this.GRID_EMPLEADOS.CurrentRow.Cells[0].Value);
                FRM_ACTUALIZA_EMPLEADO _A_empleado = new FRM_ACTUALIZA_EMPLEADO();
                _A_empleado.ShowDialog(this);
            }
           
        }

        private void GRID_EMPLEADOS_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _Sistema._Obtener_Instancia()._Empleado.Id_empleado = Convert.ToString(this.GRID_EMPLEADOS.CurrentRow.Cells[0].Value);
            FRM_ACTUALIZA_EMPLEADO _A_empleado = new FRM_ACTUALIZA_EMPLEADO();
            _A_empleado.ShowDialog(this);
        }

        private void BTN_SALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GRID_EMPLEADOS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FRM_BUSQUEDA_EMPLEADO_Load(object sender, EventArgs e)
        {

        }
    }
}
