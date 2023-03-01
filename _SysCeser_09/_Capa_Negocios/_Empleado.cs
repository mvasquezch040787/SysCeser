using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _Capa_data;

namespace _Capa_Negocios
{
   public  class _Empleado:_Persona 
    {
       private string  _id_empleado;
       private string _nick;
       private string _password;
       private _Cargo _cargo;
       private _Area _area;

       public string  Id_empleado { set { this._id_empleado = value; } get { return this._id_empleado; } }
       public string Nick { set { this._nick = value; } get { return this._nick; } }
       public string Password { set { this._password = value; } get { return this._password; } }
       public _Cargo Cargo{get { return _cargo; }set { _cargo = value; }}
       public _Area Area{get { return _area; }set { _area = value; }}


        public string _Guardar_empleado()
        {
            try
            {
                _Instrucciones._Obtener_Instancia()._Oda_Consulta(System.Data.CommandType.StoredProcedure, "SP_INSERTA_EMPLEADO");

                //PARAMETROS DE SALIDA DE PROCEDIMIENTO

                _Instrucciones._Obtener_Instancia()._Parametro("@ID_EMPLEADO", System.Data.SqlDbType.Char, 10);
                _Instrucciones._Obtener_Instancia()._Parametro("@S", System.Data.SqlDbType.Char, 2);

                _Instrucciones._Obtener_Instancia()._Parametro("@APE_PATERNO", this.Ape_paterno.Trim (), System.Data.SqlDbType.VarChar, 50);
                _Instrucciones._Obtener_Instancia()._Parametro("@APE_MATERNO", this.Ape_materno.Trim (), System.Data.SqlDbType.VarChar, 50);
                _Instrucciones._Obtener_Instancia()._Parametro("@NOMBRES", this.Nombres.Trim (), System.Data.SqlDbType.VarChar, 50);
                _Instrucciones._Obtener_Instancia()._Parametro("@DIRECCION", this.Direccion.Trim (), System.Data.SqlDbType.VarChar, 70);
                _Instrucciones._Obtener_Instancia()._Parametro("@DNI", this.Dni.Trim (), System.Data.SqlDbType.Char, 8);
                _Instrucciones._Obtener_Instancia()._Parametro("@E_MAIL", this.E_mail.Trim (), System.Data.SqlDbType.VarChar, 50);
                _Instrucciones._Obtener_Instancia()._Parametro("@FECHA_NACIMIENTO", this.Fecha_nacimiento, System.Data.SqlDbType.DateTime );
                _Instrucciones._Obtener_Instancia()._Parametro("@SEXO", this.Sexo , System.Data.SqlDbType.Int );
                _Instrucciones._Obtener_Instancia()._Parametro("@NICK", this.Nick .Trim () , System.Data.SqlDbType.VarChar ,50);
                _Instrucciones._Obtener_Instancia()._Parametro("@PASSWORD", _Instrucciones ._Obtener_Instancia ()._Encripta ( this.Password.Trim ()) , System.Data.SqlDbType.VarChar, 50);
                _Instrucciones._Obtener_Instancia()._Parametro("@ID_CARGO",this.Cargo .Id_cargo .Trim () , System.Data.SqlDbType.Char, 5);
                _Instrucciones._Obtener_Instancia()._Parametro("@ID_AREA",this.Area .Id_area  .Trim () , System.Data.SqlDbType.VarChar, 5);

                _Instrucciones._Obtener_Instancia()._Oda_Ejecutar();

                this.Id_empleado  = Convert.ToString(_Instrucciones._Obtener_Instancia()._Parametro("@ID_EMPLEADO"));
              
                return Convert.ToString(_Instrucciones._Obtener_Instancia()._Parametro("@S"));

            }
            catch (Exception ex)
            {
                _Sistema._Obtener_Instancia()._Util._Call_mensaje(ex.Message,"Error");
                return null;
            }
        }
        

        public System.Data.DataTable _Filtrar(string texto)
        {
            try
            {
                _Instrucciones._Obtener_Instancia()._Oda_Consulta(System.Data.CommandType.StoredProcedure ,"SP_FILTRA_EMPLEADO");
                _Instrucciones._Obtener_Instancia()._Parametro("@APE_PATERNO", texto.Trim(), System.Data.SqlDbType.VarChar, 50);
                return _Instrucciones._Obtener_Instancia()._Oda_Ejecutar_Retorna_Tabla();
            }
            catch (Exception ex)
            {
                _Sistema._Obtener_Instancia()._Util._Call_mensaje(ex.Message , "Error");
                return null;
            }
        }
    

       public System.Data.DataTable _Obtener_empleados_acceso()
       {
           try
           {
               _Instrucciones._Obtener_Instancia()._Oda_Consulta(System.Data.CommandType.Text, "SELECT [ID_EMPLEADO],[NICK] FROM EMPLEADO");
               return _Instrucciones._Obtener_Instancia()._Oda_Ejecutar_Retorna_Tabla();
           }
           catch (Exception ex)
           {
               _Sistema._Obtener_Instancia()._Util._Call_mensaje(ex.Message, "Error");
               return null;   
           }
       }

       public bool _Comprobar_clave(string cod_empleado, string clave)
       {
           _Instrucciones._Obtener_Instancia()._Oda_Consulta(System.Data.CommandType.Text, "SELECT [PASSWORD]FROM EMPLEADO WHERE [ID_EMPLEADO]=@ID_EMPLEADO");
           _Instrucciones._Obtener_Instancia()._Parametro("@ID_EMPLEADO", cod_empleado .Trim(), System.Data.SqlDbType.VarChar ,50);

           System.Data.DataRow _Fila = _Instrucciones._Obtener_Instancia()._Oda_Ejecutar_Retorna_Fila();

           if (_Instrucciones._Obtener_Instancia()._Desencripta(Convert.ToString(_Fila[0]).Trim() )== clave.Trim())
           {
               return true;
           }
           else
           {
               return false;
           }

       }
       public string _Actualiza_empleado(string id_empleado)
       {
           try
           {
               _Instrucciones._Obtener_Instancia()._Oda_Consulta(System.Data.CommandType.StoredProcedure, "SP_ACTUALIZA_EMPLEADO");

               //PARAMETRO SALIDA PROCEDIMIENTO
               _Instrucciones._Obtener_Instancia()._Parametro("@S", System.Data.SqlDbType.Char, 2);

               _Instrucciones._Obtener_Instancia()._Parametro("@ID_EMPLEADO", id_empleado, System.Data.SqlDbType.Char, 10);
               _Instrucciones._Obtener_Instancia()._Parametro("@APE_PATERNO", this.Ape_paterno, System.Data.SqlDbType.VarChar, 50);
               _Instrucciones._Obtener_Instancia()._Parametro("@APE_MATERNO", this.Ape_materno, System.Data.SqlDbType.VarChar, 50);
               _Instrucciones._Obtener_Instancia()._Parametro("@NOMBRES", this.Nombres, System.Data.SqlDbType.VarChar, 50);
               _Instrucciones._Obtener_Instancia()._Parametro("@DIRECCION", this.Direccion, System.Data.SqlDbType.VarChar, 70);
               _Instrucciones._Obtener_Instancia()._Parametro("@DNI", this.Dni, System.Data.SqlDbType.Char, 8);
               _Instrucciones._Obtener_Instancia()._Parametro("@E_MAIL", this.E_mail, System.Data.SqlDbType.VarChar, 50);
               _Instrucciones._Obtener_Instancia()._Parametro("@FECHA_NACIMIENTO", this.Fecha_nacimiento, System.Data.SqlDbType.DateTime);
               _Instrucciones._Obtener_Instancia()._Parametro("@SEXO", this.Sexo, System.Data.SqlDbType.Int);
               _Instrucciones._Obtener_Instancia()._Parametro("@ESTADO", this.Estado, System.Data.SqlDbType.Int);
               _Instrucciones._Obtener_Instancia()._Parametro("@NICK", this.Nick.Trim(), System.Data.SqlDbType.VarChar, 50);
               _Instrucciones._Obtener_Instancia()._Parametro("@PASSWORD",_Sistema._Obtener_Instancia()._Util ._Encripta ( this.Password.Trim()), System.Data.SqlDbType.VarChar, 50);
               _Instrucciones._Obtener_Instancia()._Parametro("@ID_CARGO", this.Cargo.Id_cargo.Trim(), System.Data.SqlDbType.Char, 5);
               _Instrucciones._Obtener_Instancia()._Parametro("@ID_AREA", this.Area.Id_area.Trim(), System.Data.SqlDbType.Char, 5);

               _Instrucciones._Obtener_Instancia()._Oda_Ejecutar();

               return Convert.ToString(_Instrucciones._Obtener_Instancia()._Parametro("@S"));
           }
           catch (Exception ex)
           {
               _Sistema._Obtener_Instancia()._Util._Call_mensaje(ex.Message, "Error");
               return null;
           }
       }
              
        public System.Data.DataRow _Obtener(String id)
        {
            try
            {
                _Instrucciones._Obtener_Instancia()._Oda_Consulta(System.Data.CommandType.StoredProcedure, "SP_OBTENER_EMPLEADO");
                _Instrucciones._Obtener_Instancia()._Parametro("@ID_EMPLEADO", id, System.Data.SqlDbType.Char ,10);
                return  _Instrucciones._Obtener_Instancia()._Oda_Ejecutar_Retorna_Fila();
            }
            catch (Exception ex)
            {
                _Sistema._Obtener_Instancia()._Util._Call_mensaje(ex.Message, "Error");
                return null;
            }
        }
        public object _Obtener_objeto()
        {
            try
            {
                _Empleado _e = new _Empleado();

                _e.Id_empleado = this.Id_empleado;

                return _e;
            }
            catch (Exception ex)
            {
                _Sistema._Obtener_Instancia()._Util._Call_mensaje(ex.Message, "Error");
                return null;
            }
        }



        public System.Data.DataTable _Listar_empleados_tecnicos()
        {
            try
            {
                _Instrucciones._Obtener_Instancia()._Oda_Consulta(System.Data.CommandType.StoredProcedure, "SP_LISTAR_EMPLEADOS_TECNICOS");
                return _Instrucciones._Obtener_Instancia()._Oda_Ejecutar_Retorna_Tabla();
            }
            catch (Exception ex)
            {
                 _Sistema._Obtener_Instancia()._Util._Call_mensaje(ex.Message, "Error");
                 return null;
            }
        }
    }
       
    
}
