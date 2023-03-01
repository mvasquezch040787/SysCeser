using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _Capa_data;


namespace _Capa_Negocios
{
   public  class _Sistema
    {
        public static _Sistema _Obtener_Instancia()
        {
            return _Instancia_costante.instancia;
        }
        private static class _Instancia_costante
        {
            public static _Sistema instancia = new _Sistema();
        }


        public _Empleado _Empleado = new _Empleado();
        public   _toools _Util = new _toools();
        public _Cliente _Cliente = new _Cliente();
        public _Area _Area = new _Area();
        public _Marca _Marca = new _Marca();
        public _Cargo _Cargo = new _Cargo();
        public _Estado_equipo _Estado_equipo = new _Estado_equipo();
        public _Tipo_garantia _Tipo_garantia = new _Tipo_garantia();
        public _Tipo_equipo _Tipo_equipo = new _Tipo_equipo();
        public _Orden _Orden = new _Orden();
        public _Reparacion _Reparacion = new _Reparacion();
        public _Servicio _Servicio = new _Servicio();
        public _Tipo_repuesto _Tipo_repuesto = new _Tipo_repuesto();
        public _Repuesto _Repuesto = new _Repuesto();
        public _Pago_referencial _Pago_referencial = new _Pago_referencial();
        public _Igv _Igv = new _Igv();
        public _Venta _Venta = new _Venta();
        public _Detalle_Venta _Detalle_venta = new _Detalle_Venta();

        public _Sistema()
        {
            try
            {
            if ( _Instrucciones._Obtener_Instancia()._Conectar()==false )
               {
                _Configuracion _Config=new _Configuracion();
                _Config.ShowDialog();
               }
            }
        catch(Exception)
            {
                throw;
            }
       
        }
    }
}
