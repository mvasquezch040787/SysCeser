using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _Capa_data;

namespace _Capa_Negocios
{
   public  class _Estado_equipo
    {
        private string _id_estado_equipo;
        private string _estado_equipo;
        private int _estado;

        public string Id_estado_equipo { get { return _id_estado_equipo; } set { _id_estado_equipo = value; } }
        public string Estado_equipo { get { return _estado_equipo; } set { _estado_equipo = value; } }
        public int Estado { get { return _estado; } set { _estado = value; } }




        public object _Obtener_objeto()
        {
            try
            {
                _Estado_equipo estado_equipo = new _Estado_equipo();

                estado_equipo.Id_estado_equipo = this.Id_estado_equipo;
                estado_equipo.Estado_equipo = this.Estado_equipo;
                return estado_equipo;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public System.Data.DataTable _Listar()
        {
            try
            {
                _Instrucciones._Obtener_Instancia()._Oda_Consulta(System.Data.CommandType.Text, "SELECT * FROM [ESTADO_EQUIPO]");
                return _Instrucciones._Obtener_Instancia()._Oda_Ejecutar_Retorna_Tabla();
            }
            catch (Exception)
            {
                return null;
            }

        }

        
    }
}
