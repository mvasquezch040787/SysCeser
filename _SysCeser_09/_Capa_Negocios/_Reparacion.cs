using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _Capa_data;

namespace _Capa_Negocios
{
   public  class _Reparacion 
    {
        private string _id_reparacion;
        private _Orden _orden;
        private _Empleado _empleado;
        private DateTime _fecha_reparacion;
        private string _falla_reportada_tecnico;
        private string _solucion_reportada;
        private string _observaciones_reparacion;
        private int _estado;
        private _Estado_equipo _estado_equipo;

        public string Id_reparacion { get { return _id_reparacion; } set { _id_reparacion = value; } }
        public _Orden Orden { get { return _orden; } set { _orden = value; } }
        public _Empleado Empleado { get { return _empleado; } set { _empleado = value; } }
        public DateTime Fecha_reparacion { get { return _fecha_reparacion; } set { _fecha_reparacion = value; } }
        public string Falla_reportada_tecnico { get { return _falla_reportada_tecnico; } set { _falla_reportada_tecnico = value; } }
        public string Solucion_reportada{get { return _solucion_reportada; }set { _solucion_reportada = value; }}
        public string Observaciones_reparacion { get { return _observaciones_reparacion; } set { _observaciones_reparacion = value; } }
        public int Estado { get { return _estado; } set { _estado = value; } }
        public _Estado_equipo Estado_equipo { get { return _estado_equipo; } set { _estado_equipo = value; } }

        public string _Guardar_reparacion()
        {
            try
            {
                _Instrucciones._Obtener_Instancia()._Oda_Consulta(System.Data.CommandType.StoredProcedure, "SP_INSERTA_REPARACION");

                _Instrucciones._Obtener_Instancia()._Parametro("@S", System.Data.SqlDbType.Char, 2);

                _Instrucciones._Obtener_Instancia()._Parametro("@ID_ORDEN", this.Orden.Id_orden.Trim(), System.Data.SqlDbType.Char, 10);
                _Instrucciones._Obtener_Instancia()._Parametro("@ID_EMPLEADO", this.Empleado.Id_empleado, System.Data.SqlDbType.Char, 10);
                _Instrucciones._Obtener_Instancia()._Parametro("@FALLA_REPORTADA_TECNICO", this.Falla_reportada_tecnico.Trim(), System.Data.SqlDbType.VarChar, 300);
                _Instrucciones._Obtener_Instancia()._Parametro("@SOLUCION_REPORTADA_TECNICO", this.Solucion_reportada.Trim(), System.Data.SqlDbType.VarChar, 500);
                _Instrucciones._Obtener_Instancia()._Parametro("@OBSERVACIONES_REPARACION", this.Observaciones_reparacion.Trim(), System.Data.SqlDbType.VarChar, 500);
                _Instrucciones._Obtener_Instancia()._Parametro("@ID_ESTADO_EQUIPO", this.Estado_equipo.Id_estado_equipo.Trim(), System.Data.SqlDbType.Char, 10);

                _Instrucciones._Obtener_Instancia()._Oda_Ejecutar();

                return Convert.ToString(_Instrucciones._Obtener_Instancia()._Parametro("@S"));
            }
            catch (Exception ex)
            {
                _Sistema._Obtener_Instancia()._Util._Call_mensaje(ex.Message, "Error");
                return null;
            }

        }
        public System.Data.DataTable _Imprimir_informe_reparacion(string id_orden)
        {
            try
            {
                _Instrucciones._Obtener_Instancia()._Oda_Consulta(System.Data.CommandType.StoredProcedure, "SP_FORMATO_SALIDA_EQUIPO");
                _Instrucciones._Obtener_Instancia()._Parametro("@ID_ORDEN", id_orden.Trim(), System.Data.SqlDbType.Char, 10);
                return _Instrucciones._Obtener_Instancia()._Oda_Ejecutar_Retorna_Tabla();
            }
            catch (Exception ex)
            {
              _Sistema._Obtener_Instancia()._Util._Call_mensaje(ex.Message, "Error");
                 return null;
            }
        }

        public System.Data.DataRow _Obtener_reparacion(string id_orden)
        {
            try
            {
                _Instrucciones._Obtener_Instancia()._Oda_Consulta(System.Data.CommandType.StoredProcedure, "SP_OBTENER_REPARACION");
                _Instrucciones._Obtener_Instancia()._Parametro("@ID_ORDEN", id_orden.Trim(), System.Data.SqlDbType.VarChar, 10);
                return _Instrucciones._Obtener_Instancia()._Oda_Ejecutar_Retorna_Fila();
            }
            catch (Exception ex)
            {
                 _Sistema._Obtener_Instancia()._Util._Call_mensaje(ex.Message, "Error");
                 return null;
            }
        }
    }
}
