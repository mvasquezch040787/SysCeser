using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _Capa_data;

namespace _Capa_Negocios
{
   public  class _Detalle_Venta
    {

        private _Repuesto _repuesto;

        public _Repuesto Repuesto
        {
            get { return _repuesto; }
            set { _repuesto = value; }
        }
        private _Servicio _servicio;

        public _Servicio Servicio
        {
            get { return _servicio; }
            set { _servicio = value; }
        }
       private int _cantidad;


        
        public int Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

//       @ID_REPUESTO AS INT,
//@ID_SERVICIO AS INT,
//@CANTIDAD AS INT


       public static bool _Guardar_Detalle_Venta(_Detalle_Venta detalle_venta)
       {
           bool sw = false;
           try
           {
               _Instrucciones._Obtener_Instancia()._Oda_Consulta(System.Data.CommandType.StoredProcedure, "[SP_INSERTA_DETALLE_VENTA]");

               //PARAMETROS DE SALIDA DE PROCEDIMIENTO

               _Instrucciones._Obtener_Instancia()._Parametro("@ID_REPUESTO",detalle_venta.Repuesto.Id_repuesto,System.Data.SqlDbType.Int);
               _Instrucciones._Obtener_Instancia()._Parametro("@ID_SERVICIO", detalle_venta.Servicio.Idservicio, System.Data.SqlDbType.Int);
               _Instrucciones._Obtener_Instancia()._Parametro("@CANTIDAD", detalle_venta.Cantidad, System.Data.SqlDbType.Int);

               sw = _Instrucciones._Obtener_Instancia()._Oda_Ejecutar();

           }
           catch (Exception e)
           {
               sw = false;
               _Sistema._Obtener_Instancia()._Util._Call_mensaje(e.Message, "Error");
           }
           return sw;
       }
    }
}
