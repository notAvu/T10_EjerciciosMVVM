using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T10_EjerciciosMVVM.Models
{
    public class clsPersona
    {
        #region propiedades privadas
        private string nombre;
        private string apellido;
        #endregion
        #region constructores
        public clsPersona() 
        {
            nombre = "";
            apellido = "";
        }
        #endregion
        #region propiedades publicas
        public string Apellido
        { 
            get { return apellido; } 
            set { apellido = value;} 
        }
        public string Nombre 
        { 
            get{ return nombre; } 
            set{ nombre = value; } 
        }
        #endregion
        #region metodos

        #endregion
    }
}
