using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace _Capa_Negocios
{
   public  class _Persona
    {
       private string _ape_paterno;
       private string _ape_materno;
       private string _nombres;
       private string _direccion;
       private string _dni;
       private string _e_mail;
       private DateTime _fecha_nacimiento;
       private int _sexo;
       private int _estado;

       public string Ape_paterno { set { this._ape_paterno = value; } get { return this._ape_paterno; } }
       public string Ape_materno { set { this._ape_materno = value; } get { return this._ape_materno; } }
       public string Nombres { set { this._nombres = value; } get { return this._nombres; } }
       public string Direccion { set { this._direccion = value; } get { return this._direccion; } }
       public string Dni { set { this._dni = value; } get { return this._dni; } }
       public string E_mail { set { this._e_mail = value; } get { return this._e_mail; } }
       public DateTime Fecha_nacimiento { set { this._fecha_nacimiento = value; } get { return this._fecha_nacimiento; } }
       public int Sexo { get { return _sexo; } set { _sexo = value; } }
       public int Estado { get { return _estado; } set { _estado = value; } }
       
    }
}
