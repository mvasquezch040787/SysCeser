using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _Capa_data;

namespace _Capa_Negocios
{
    public class _Tipo_equipo : _Interfaces_polimorfismo._Obtener_objeto_clase, _Interfaces_polimorfismo._Listar_general,
                                 _Interfaces_polimorfismo._Fila_general
    {

        private string _id_tipo_equipo;
        private string _tipo;
        private int _estado;

        public string Id_tipo_equipo{get { return _id_tipo_equipo; }set { _id_tipo_equipo = value; }}
        public string Tipo { get { return _tipo; } set { _tipo = value; } }
        public int Estado { get { return _estado; } set { _estado = value; } }

        public System.Data.DataTable _Listar()
        {
            try
            {
                _Instrucciones._Obtener_Instancia()._Oda_Consulta(System.Data.CommandType.Text, "SELECT * FROM [TIPO_EQUIPO] WHERE ESTADO=1 ");
                return _Instrucciones._Obtener_Instancia()._Oda_Ejecutar_Retorna_Tabla();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public System.Data.DataRow _Obtener_fila(string id)
        {
            try
            {
                _Instrucciones._Obtener_Instancia()._Oda_Consulta(System.Data.CommandType.Text, "SELECT * FROM [TIPO_EQUIPO] WHERE ID_TIPO_EQUIPO=@ID_TIPO_EQUIPO");
                _Instrucciones._Obtener_Instancia()._Parametro("@ID_TIPO_EQUIPO", id.Trim(), System.Data.SqlDbType.Char, 5);
                return _Instrucciones._Obtener_Instancia()._Oda_Ejecutar_Retorna_Fila();
            }
            catch (Exception)
            {
                return null;
            }
        }
        public string _Guarda_tipo_equipo()
        {
            try
            {
                _Instrucciones._Obtener_Instancia()._Oda_Consulta(System.Data.CommandType.StoredProcedure, "SP_INSERTA_TIPO_EQUIPO");
                _Instrucciones._Obtener_Instancia()._Parametro("@ID_TIPO_EQUIPO", System.Data.SqlDbType.Char, 5);
                _Instrucciones._Obtener_Instancia()._Parametro("@S", System.Data.SqlDbType.Char, 2);

                _Instrucciones._Obtener_Instancia()._Parametro("@TIPO_EQUIPO",this.Tipo .Trim (), System.Data.SqlDbType.VarChar, 50);
                _Instrucciones._Obtener_Instancia()._Oda_Ejecutar();

                this.Id_tipo_equipo = Convert.ToString(_Instrucciones._Obtener_Instancia()._Parametro("@ID_TIPO_EQUIPO"));
                return Convert.ToString(_Instrucciones._Obtener_Instancia()._Parametro("@S"));

            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public object _Obtener_objeto()
        {
            try
            {
                _Tipo_equipo _tipo_equipo = new _Tipo_equipo();

                _tipo_equipo.Id_tipo_equipo = this.Id_tipo_equipo;
                _tipo_equipo.Tipo = this.Tipo ;
                _tipo_equipo.Estado = this.Estado;

                return _tipo_equipo;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
