using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _Capa_data;

namespace _Capa_Negocios
{
    public  class _Cliente :_Persona , _Interfaces_polimorfismo._Obtener_persona,_Interfaces_polimorfismo ._Filtrar_general ,_Interfaces_polimorfismo ._Obtener_objeto_clase
    {
        private string  _id_cliente;
        private string _telefono;
        private string _celular;
        private string _ruc;

        public string Id_cliente { set { this._id_cliente = value; } get { return this._id_cliente; } }
        public string Telefono{get { return _telefono; }set { _telefono = value; }}
        public string Celular{get { return _celular; }set { _celular = value; }}
        public string Ruc{get { return _ruc; }set { _ruc = value; }}

        public string _Guardar_cliente()
        {
            try
            {
                _Instrucciones._Obtener_Instancia()._Oda_Consulta(System.Data.CommandType.StoredProcedure, "SP_INSERTA_CLIENTE");

                //PARAMETROS DE SALIDA DE PROCEDIMIENTO

                _Instrucciones._Obtener_Instancia()._Parametro("@ID_CLIENTE", System.Data.SqlDbType.Char, 10);
                _Instrucciones._Obtener_Instancia()._Parametro("@S", System.Data.SqlDbType.Char, 2);

                _Instrucciones._Obtener_Instancia()._Parametro("@APE_PATERNO", this.Ape_paterno.Trim (), System.Data.SqlDbType.VarChar, 50);
                _Instrucciones._Obtener_Instancia()._Parametro("@APE_MATERNO", this.Ape_materno.Trim (), System.Data.SqlDbType.VarChar, 50);
                _Instrucciones._Obtener_Instancia()._Parametro("@NOMBRES", this.Nombres.Trim (), System.Data.SqlDbType.VarChar, 50);
                _Instrucciones._Obtener_Instancia()._Parametro("@DIRECCION", this.Direccion.Trim (), System.Data.SqlDbType.VarChar, 70);
                _Instrucciones._Obtener_Instancia()._Parametro("@DNI", this.Dni.Trim (), System.Data.SqlDbType.Char, 8);
                _Instrucciones._Obtener_Instancia()._Parametro("@E_MAIL", this.E_mail.Trim (), System.Data.SqlDbType.VarChar, 50);
                _Instrucciones._Obtener_Instancia()._Parametro("@FECHA_NACIMIENTO", this.Fecha_nacimiento, System.Data.SqlDbType.DateTime );
                _Instrucciones._Obtener_Instancia()._Parametro("@SEXO", this.Sexo , System.Data.SqlDbType.Int );
                _Instrucciones._Obtener_Instancia()._Parametro("@TELEFONO", this.Telefono.Trim () , System.Data.SqlDbType.VarChar ,12);
                _Instrucciones._Obtener_Instancia()._Parametro("@CELULAR", this.Celular.Trim () , System.Data.SqlDbType.VarChar, 12);
                _Instrucciones._Obtener_Instancia()._Parametro("@RUC", this.Ruc.Trim () , System.Data.SqlDbType.VarChar, 11);
                

                _Instrucciones._Obtener_Instancia()._Oda_Ejecutar();

                this.Id_cliente = Convert.ToString(_Instrucciones._Obtener_Instancia()._Parametro("@ID_CLIENTE"));
              
                return Convert.ToString(_Instrucciones._Obtener_Instancia()._Parametro("@S"));

            }
            catch (Exception ex)
            {
                _Sistema._Obtener_Instancia()._Util._Call_mensaje(ex.Message,"Error");
                return null;
            }
        }
        public string _Actualiza_cliente(string  id_cliente)
        {
            try
            {
                _Instrucciones._Obtener_Instancia()._Oda_Consulta(System.Data.CommandType.StoredProcedure, "SP_ACTUALIZA_CLIENTE");
               
                //PARAMETRO SALIDA PROCEDIMIENTO
                _Instrucciones._Obtener_Instancia()._Parametro("@S", System.Data.SqlDbType.Char, 2);

                _Instrucciones._Obtener_Instancia()._Parametro("@ID_CLIENTE", id_cliente , System.Data.SqlDbType.Char, 10);
                _Instrucciones._Obtener_Instancia()._Parametro("@APE_PATERNO", this.Ape_paterno, System.Data.SqlDbType.VarChar, 50);
                _Instrucciones._Obtener_Instancia()._Parametro("@APE_MATERNO", this.Ape_materno, System.Data.SqlDbType.VarChar, 50);
                _Instrucciones._Obtener_Instancia()._Parametro("@NOMBRES", this.Nombres, System.Data.SqlDbType.VarChar, 50);
                _Instrucciones._Obtener_Instancia()._Parametro("@DIRECCION", this.Direccion, System.Data.SqlDbType.VarChar, 70);
                _Instrucciones._Obtener_Instancia()._Parametro("@DNI", this.Dni, System.Data.SqlDbType.Char, 8);
                _Instrucciones._Obtener_Instancia()._Parametro("@E_MAIL", this.E_mail, System.Data.SqlDbType.VarChar, 50);
                _Instrucciones._Obtener_Instancia()._Parametro("@FECHA_NACIMIENTO", this.Fecha_nacimiento, System.Data.SqlDbType.DateTime);
                _Instrucciones._Obtener_Instancia()._Parametro("@SEXO", this.Sexo, System.Data.SqlDbType.Int);
                _Instrucciones._Obtener_Instancia()._Parametro("@ESTADO", this.Estado , System.Data.SqlDbType.Int);
                _Instrucciones._Obtener_Instancia()._Parametro("@TELEFONO", this.Telefono, System.Data.SqlDbType.VarChar, 12);
                _Instrucciones._Obtener_Instancia()._Parametro("@CELULAR", this.Celular, System.Data.SqlDbType.VarChar, 12);
                _Instrucciones._Obtener_Instancia()._Parametro("@RUC", this.Ruc, System.Data.SqlDbType.VarChar, 11);
                

                _Instrucciones._Obtener_Instancia()._Oda_Ejecutar();

                return Convert.ToString(_Instrucciones._Obtener_Instancia()._Parametro("@S"));
            }
            catch (Exception)
            {
                return null;
            }
        }
               
        public System.Data.DataRow _Obtener(String id)
        {
            try
            {
                _Instrucciones._Obtener_Instancia()._Oda_Consulta(System.Data.CommandType.StoredProcedure, "SP_OBTENER_CLIENTE");
                _Instrucciones._Obtener_Instancia()._Parametro("@ID_CLIENTE", id, System.Data.SqlDbType.Char ,10);
                return  _Instrucciones._Obtener_Instancia()._Oda_Ejecutar_Retorna_Fila();
            }
            catch (Exception ex)
            {
                _Sistema._Obtener_Instancia()._Util._Call_mensaje(ex.Message, "Error");
                return null;
            }
        }

        public System.Data.DataTable _Filtrar(string texto)
        {
            try
            {
                _Instrucciones._Obtener_Instancia()._Oda_Consulta(System.Data.CommandType.Text,
                    "SELECT  dbo.CLIENTE.ID_CLIENTE, dbo.PERSONA.APELLIDO_PATERNO, dbo.PERSONA.APELLIDO_MATERNO, dbo.PERSONA.NOMBRES, dbo.PERSONA.DIRECCION,"+
                     "dbo.PERSONA.DNI FROM  dbo.CLIENTE INNER JOIN dbo.PERSONA ON dbo.CLIENTE.ID_PERSONA = dbo.PERSONA.ID_PERSONA AND dbo.PERSONA.APELLIDO_PATERNO LIKE '%'+@TEXTO+'%'");
                _Instrucciones._Obtener_Instancia()._Parametro("@TEXTO", texto.Trim(), System.Data.SqlDbType.VarChar, 50);
                return _Instrucciones._Obtener_Instancia()._Oda_Ejecutar_Retorna_Tabla();
            }
            catch (Exception ex)
            {
                _Sistema._Obtener_Instancia()._Util._Call_mensaje(ex.Message , "Error");
                return null;
            }
        }

        public object _Obtener_objeto()
        {
            try
            {
            _Cliente _cli = new _Cliente();
            _cli.Id_cliente = this.Id_cliente;

            return _cli;
            }
            catch (Exception ex)
            {
                _Sistema._Obtener_Instancia()._Util._Call_mensaje(ex.Message, "Error");
                return null;
            }
           ;
        }
    }
}
