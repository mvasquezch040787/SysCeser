using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _Capa_data;

namespace _Capa_Negocios
{
    public  class _Orden : _Interfaces_polimorfismo._Fila_general,_Interfaces_polimorfismo._Obtener_objeto_clase
    {
        private string _id_orden;
        private _Cliente _cliente;
        private DateTime _fecha_ingreso;
        private DateTime _fecha_salida;
        private string _falla_reportada_cliente;
        private string _equipo;
        private string _modelo_equpipo;
        private string _serie_equipo;
        private _Tipo_equipo _tipo_equipo;
        private _Marca _marca;
        private String _observaciones_equipo;
        private string _accesorios_adicionsles_equipo;
        private _Tipo_garantia _tipo_garantia;
        private _Estado_equipo _estado_equipo;
        private _Empleado _empelado;
        private string _falla_reportada_tecnico;
        private string _solucion_reportada_tecnico;
        private int _estado;
        private string _observaciones;
        private int _costo_reparacion;
        private double _adelanto;

      
       
       


        public string Id_orden{get { return _id_orden; }set { _id_orden = value; } }
        public _Cliente Cliente {get { return _cliente; }set { _cliente = value; }}
        public DateTime Fecha_ingreso{get { return _fecha_ingreso; }set { _fecha_ingreso = value; }}
        public DateTime Fecha_salida{get { return _fecha_salida; }set { _fecha_salida = value; }}
        public string Falla_reportada_cliente{ get { return _falla_reportada_cliente; }set { _falla_reportada_cliente = value; }}
        public string Equipo{get { return _equipo; }set { _equipo = value; }}
        public string Modelo_equpipo{ get { return _modelo_equpipo; }set { _modelo_equpipo = value; } }
        public string Serie_equipo{get { return _serie_equipo; } set { _serie_equipo = value; }}
        public _Tipo_equipo Tipo_equipo{get { return _tipo_equipo; }set { _tipo_equipo = value; }}
        public _Marca Marca{get { return _marca; }set { _marca = value; }}
        public String Observaciones_equipo{get { return _observaciones_equipo; }set { _observaciones_equipo = value; }}
        public string Accesorios_adicionsles_equipo{get { return _accesorios_adicionsles_equipo; }set { _accesorios_adicionsles_equipo = value; }}
        public _Tipo_garantia Tipo_garantia{get { return _tipo_garantia; }set { _tipo_garantia = value; }}
        public _Estado_equipo Estado_equipo{get { return _estado_equipo; }set { _estado_equipo = value; }}
        public _Empleado Empelado{get { return _empelado; }set { _empelado = value; }}
        public string Falla_reportada_tecnico{get { return _falla_reportada_tecnico; }set { _falla_reportada_tecnico = value; }}
        public string Solucion_reportada_tecnico{get { return _solucion_reportada_tecnico; } set { _solucion_reportada_tecnico = value; }}
        public int Estado{get { return _estado; }set { _estado = value; }}
        public string Observaciones{get { return _observaciones; }set { _observaciones = value; }}
        public int Costo_reparacion{get { return _costo_reparacion; }set { _costo_reparacion = value; }}
        public double Adelanto{get { return _adelanto; }set { _adelanto = value; }
        }

         public string _Guardar_ingreso()
        {
            try
            { 
                _Instrucciones._Obtener_Instancia()._Oda_Consulta(System.Data.CommandType.StoredProcedure, "SP_INSERTA_ORDEN");

                _Instrucciones._Obtener_Instancia()._Parametro("@ID_ORDEN", System.Data.SqlDbType.Char, 10);
                _Instrucciones._Obtener_Instancia()._Parametro("@S", System.Data.SqlDbType.Char, 2);

                _Instrucciones._Obtener_Instancia()._Parametro("@ID_CLIENTE", this.Cliente .Id_cliente .Trim(), System.Data.SqlDbType.Char, 10);
                _Instrucciones._Obtener_Instancia()._Parametro("@FECHA_INGRESO_EQUIPO", this.Fecha_ingreso, System.Data.SqlDbType.DateTime );
                _Instrucciones._Obtener_Instancia()._Parametro("@EQUIPO", this.Equipo.Trim(), System.Data.SqlDbType.VarChar, 100);
                _Instrucciones._Obtener_Instancia()._Parametro("@MODELO_EQUIPO", this.Modelo_equpipo.Trim(), System.Data.SqlDbType.VarChar, 50);
                _Instrucciones._Obtener_Instancia()._Parametro("@FALLA_REPORTADA_CLIENTE", this.Falla_reportada_cliente.Trim(), System.Data.SqlDbType.VarChar, 200);
                _Instrucciones._Obtener_Instancia()._Parametro("@SERIE_EQUIPO", this.Serie_equipo .Trim(), System.Data.SqlDbType.VarChar, 20);
                _Instrucciones._Obtener_Instancia()._Parametro("@ID_TIPO_EQUIPO", this.Tipo_equipo .Id_tipo_equipo .Trim (), System.Data.SqlDbType.Char,5);
                _Instrucciones._Obtener_Instancia()._Parametro("@ID_MARCA", this.Marca.Id_marca , System.Data.SqlDbType.Char ,5);
                _Instrucciones._Obtener_Instancia()._Parametro("@OBSERVACIONES_EQUIPO", this.Observaciones_equipo .Trim(), System.Data.SqlDbType.VarChar, 300);
                _Instrucciones._Obtener_Instancia()._Parametro("@ACCESORIOS_ADICIONALES_EQUIPO", this.Accesorios_adicionsles_equipo .Trim(), System.Data.SqlDbType.VarChar, 300);
                _Instrucciones._Obtener_Instancia()._Parametro("@ID_TIPO_GARANTIA", this.Tipo_garantia.Id_tipo_garantia  .Trim(), System.Data.SqlDbType.Char, 5);
                _Instrucciones._Obtener_Instancia()._Parametro("@ID_EMPLEADO", this.Empelado .Id_empleado .Trim(), System.Data.SqlDbType.Char, 10);
                _Instrucciones._Obtener_Instancia()._Parametro("@COSTO_REPARACION", this.Costo_reparacion , System.Data.SqlDbType.Money );
                _Instrucciones._Obtener_Instancia()._Parametro("@ADELANTO", this.Adelanto, System.Data.SqlDbType.Decimal);
                _Instrucciones._Obtener_Instancia()._Oda_Ejecutar();

                this.Id_orden = Convert.ToString(_Instrucciones._Obtener_Instancia()._Parametro("@ID_ORDEN"));

                return Convert.ToString(_Instrucciones._Obtener_Instancia()._Parametro("@S"));
            }
            catch (Exception ex)
            {
                _Sistema._Obtener_Instancia()._Util._Call_mensaje(ex.Message, "Error");
                return null;
            }
        }
         public bool _Actualizar_ingreso_equipo(string id_orden)
         {
             try
             {
                 _Instrucciones._Obtener_Instancia()._Oda_Consulta(System.Data.CommandType.Text, "UPDATE [ORDENES] SET ID_CLIENTE=@ID_CLIENTE," +
                     "FALLA_REPORTADA_CLIENTE=@FALLA_REPORTADA_CLIENTE,EQUIPO=@EQUIPO,MODELO_EQUIPO=@MODELO_EQUIPO,SERIE_EQUIPO=@SERIE_EQUIPO," +
                     "ID_TIPO_EQUIPO=@ID_TIPO_EQUIPO,ID_MARCA=@ID_MARCA,OBSERVACIONES_EQUIPO=@OBSERVACIONES_EQUIPO,ACCESORIOS_ADICIONALES_EQUIPO=@ACCESORIOS_ADICIONALES_EQUIPO," +
                     "ID_TIPO_GARANTIA=@ID_TIPO_GARANTIA,COSTO_REPARACION=@COSTO_REPARACION WHERE ID_ORDEN=@ID_ORDEN");

                 _Instrucciones._Obtener_Instancia()._Parametro("@ID_CLIENTE", _cliente.Id_cliente.Trim(), System.Data.SqlDbType.Char, 10);
                 _Instrucciones._Obtener_Instancia()._Parametro("@FALLA_REPORTADA_CLIENTE", this.Falla_reportada_cliente.Trim(), System.Data.SqlDbType.VarChar, 300);
                 _Instrucciones._Obtener_Instancia()._Parametro("@EQUIPO", this.Equipo.Trim(), System.Data.SqlDbType.VarChar, 100);
                 _Instrucciones._Obtener_Instancia()._Parametro("@MODELO_EQUIPO", this.Modelo_equpipo.Trim(), System.Data.SqlDbType.VarChar, 50);
                 _Instrucciones._Obtener_Instancia()._Parametro("@SERIE_EQUIPO", this.Serie_equipo.Trim(), System.Data.SqlDbType.VarChar, 20);
                 _Instrucciones._Obtener_Instancia()._Parametro("@ID_TIPO_EQUIPO", this.Tipo_equipo.Id_tipo_equipo.Trim(), System.Data.SqlDbType.Char, 5);
                 _Instrucciones._Obtener_Instancia()._Parametro("@ID_MARCA", this.Marca.Id_marca.Trim(), System.Data.SqlDbType.Char, 5);
                 _Instrucciones._Obtener_Instancia()._Parametro("@OBSERVACIONES_EQUIPO", this.Observaciones_equipo .Trim(), System.Data.SqlDbType.VarChar, 300);
                 _Instrucciones._Obtener_Instancia()._Parametro("@ACCESORIOS_ADICIONALES_EQUIPO", this.Accesorios_adicionsles_equipo.Trim(), System.Data.SqlDbType.VarChar, 300);
                 _Instrucciones._Obtener_Instancia()._Parametro("@ID_TIPO_GARANTIA", this.Tipo_garantia.Id_tipo_garantia.Trim(), System.Data.SqlDbType.Char, 5);
                 _Instrucciones._Obtener_Instancia()._Parametro("@COSTO_REPARACION", this.Costo_reparacion, System.Data.SqlDbType.Money);

                 _Instrucciones._Obtener_Instancia()._Parametro("@ID_ORDEN", id_orden.Trim(), System.Data.SqlDbType.Char, 10);

                 return _Instrucciones._Obtener_Instancia()._Oda_Ejecutar();
             }

             catch (Exception ex)
             {
                 _Sistema._Obtener_Instancia()._Util._Call_mensaje(ex.Message, "Error");
                return false;
             }
         }
        public bool _Guardar_salida(string id_orden)
        {
            try
            {
                _Instrucciones._Obtener_Instancia()._Oda_Consulta(System.Data.CommandType.Text,
                 "UPDATE [ORDENES] SET FECHA_SALIDA_EQUIPO=@FECHA_SALIDA_EQUIPO," +
                 "COSTO_REPARACION=@COSTO_REPARACION,ID_ESTADO_EQUIPO=@ID_ESTADO_EQUIPO,ESTADO_ORDEN=@ESTADO_ORDEN WHERE ID_ORDEN=@ID_ORDEN");

                _Instrucciones._Obtener_Instancia()._Parametro("@FECHA_SALIDA_EQUIPO", this.Fecha_salida , System.Data.SqlDbType.DateTime );
                _Instrucciones._Obtener_Instancia()._Parametro("@ID_ESTADO_EQUIPO", this.Estado_equipo .Id_estado_equipo .Trim (), System.Data.SqlDbType .Char ,5);
                _Instrucciones._Obtener_Instancia()._Parametro("@COSTO_REPARACION", this.Costo_reparacion, System.Data.SqlDbType.Money );
                _Instrucciones._Obtener_Instancia()._Parametro("@ID_ORDEN", id_orden.Trim(), System.Data.SqlDbType.Char, 10);
                _Instrucciones._Obtener_Instancia()._Parametro("@ESTADO_ORDEN", "ORDEN CERRADA".Trim(), System.Data.SqlDbType.VarChar, 50);

                return _Instrucciones._Obtener_Instancia()._Oda_Ejecutar();
            }
            catch (Exception ex)
            {
                _Sistema._Obtener_Instancia()._Util._Call_mensaje(ex.Message, "Error");
                return false;
            }
        }
        public System.Data.DataTable _imprimir_orden_ingreso(string id_orden)
        {
            try
            {
            _Instrucciones._Obtener_Instancia()._Oda_Consulta(System.Data.CommandType.StoredProcedure, "SP_FORMATO_INGRESO_EQUIPO");
            _Instrucciones._Obtener_Instancia()._Parametro("@ID_ORDEN", id_orden.Trim(), System.Data.SqlDbType.Char, 10);
            return _Instrucciones._Obtener_Instancia()._Oda_Ejecutar_Retorna_Tabla();
            }
            catch (Exception ex)
            {
                _Sistema._Obtener_Instancia()._Util._Call_mensaje(ex.Message, "Error"); 
                throw;
            }

            
        }
        public System.Data.DataTable _imprimir_orden_salida(string id_orden)
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
                throw;
            }


        }
        

        public System.Data.DataRow _Obtener_fila(string id)
        {
            try
            {
                _Instrucciones._Obtener_Instancia()._Oda_Consulta(System.Data.CommandType.StoredProcedure, "SP_OBTENER_ORDEN_INGRESO");
                _Instrucciones._Obtener_Instancia()._Parametro("@ID_ORDEN", id.Trim(), System.Data.SqlDbType.VarChar, 10);
                return _Instrucciones._Obtener_Instancia()._Oda_Ejecutar_Retorna_Fila();
            }
            catch (Exception ex)
            {
                _Sistema._Obtener_Instancia()._Util._Call_mensaje(ex.Message, "Error");  
                throw;
            }
        }
       

        public object _Obtener_objeto()
        {
            try 
	        {
                _Orden _orden = new _Orden(); 
                 _orden .Id_orden =this.Id_orden ;
                return _orden ;
	        }
	        catch (Exception ex)
	        {
                _Sistema._Obtener_Instancia()._Util._Call_mensaje(ex.Message, "Error");  
		        throw;
	        }
           
        }
    }
}
