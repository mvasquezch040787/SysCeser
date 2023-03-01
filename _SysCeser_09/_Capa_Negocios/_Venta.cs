using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _Capa_data;

namespace _Capa_Negocios
{
   public class _Venta
    {
        private DateTime _fecha_venta;
        private _Cliente _cliente;

public _Cliente Cliente
{
  get { return _cliente; }
  set { _cliente = value; }
}
        private _Empleado _empleado;

public _Empleado Empleado
{
  get { return _empleado; }
  set { _empleado = value; }
}
        private int _tipo_comprobante;


       

        public DateTime Fecha_venta
        {
            get { return _fecha_venta; }
            set { _fecha_venta = value; }
        }
        


        public int Tipo_comprobante
        {
            get { return _tipo_comprobante; }
            set { _tipo_comprobante = value; }
        }
        public static bool _Guardar_Venta(_Venta venta,string id_orden)
        {
            bool sw = false;
            try
            {
                _Instrucciones._Obtener_Instancia()._Oda_Consulta(System.Data.CommandType.StoredProcedure, "[SP_INSERTA_VENTA]");

                //PARAMETROS DE SALIDA DE PROCEDIMIENTO

                _Instrucciones._Obtener_Instancia()._Parametro("@FECHA_VENTA",venta.Fecha_venta, System.Data.SqlDbType.Date);
                _Instrucciones._Obtener_Instancia()._Parametro("@ID_CLIENTE", venta.Cliente.Id_cliente.Trim(), System.Data.SqlDbType.Char, 10);
                _Instrucciones._Obtener_Instancia()._Parametro("@ID_EMPLEADO",venta.Empleado.Id_empleado.Trim(), System.Data.SqlDbType.Char, 10);
                _Instrucciones._Obtener_Instancia()._Parametro("@TIPO_COMPROBANTE", venta.Tipo_comprobante, System.Data.SqlDbType.Int);
                _Instrucciones._Obtener_Instancia()._Parametro("@ID_ORDEN", id_orden.Trim(), System.Data.SqlDbType.Char,10);
                

                sw = _Instrucciones._Obtener_Instancia()._Oda_Ejecutar();
                
            }catch(Exception e)
            {
                sw = false;
                _Sistema._Obtener_Instancia()._Util._Call_mensaje(e.Message, "Error");
            }
            return sw;
        }
    }
}
