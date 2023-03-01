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
    public partial class FRM_BUSQUEDA_CLIENTE : Form
    {
        public FRM_BUSQUEDA_CLIENTE()
        {
            InitializeComponent();
        }

        private void BTN_SALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TXT_ALUMNO_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.TXT_CLIENTE.Text.Trim().Length > 0)
                {
                   System .Data .DataTable _Tabla=_Sistema._Obtener_Instancia()._Cliente._Filtrar(this.TXT_CLIENTE.Text.Trim());
                   this.GRID_CLIENTES.DataSource = _Tabla;
                   // this.GRID_CLIENTES.Columns[0].Visible = false;
                }
                else
                {
                    this.GRID_CLIENTES.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                _Sistema._Obtener_Instancia()._Util._Call_mensaje(ex.Message, "Error");
            }
        }

        private void GRID_ALUMNOS_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _Sistema._Obtener_Instancia()._Cliente.Id_cliente =Convert.ToString(this.GRID_CLIENTES.CurrentRow.Cells [0].Value);

            FMR_ACTUALIZA_CLIENTE A_Cliente=new  FMR_ACTUALIZA_CLIENTE();
            A_Cliente.Show();
        }

        private void BTN_NUEVO_Click(object sender, EventArgs e)
        {
            FRM_CLIENTE _Alumno = new FRM_CLIENTE();
            _Alumno.Show();
        }

        private void BTN_ACTUALIZAR_Click(object sender, EventArgs e)
        {
            if (this.GRID_CLIENTES .Rows .Count >0)
            {
                _Sistema._Obtener_Instancia()._Cliente.Id_cliente  = Convert.ToString(this.GRID_CLIENTES.CurrentRow.Cells[0].Value);
                 FMR_ACTUALIZA_CLIENTE A_Cliente = new FMR_ACTUALIZA_CLIENTE();
                 A_Cliente.Show();
            }
            
        }

        private void FRM_BUSQUEDA_ALUMNO_Load(object sender, EventArgs e)
        {

        }

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            if (this.GRID_CLIENTES .Rows .Count >0)
	        {
                _Sistema._Obtener_Instancia()._Cliente.Id_cliente = Convert.ToString(this.GRID_CLIENTES.CurrentRow.Cells[0].Value );
                this.Close();
	        }
           
        }
    }
}
