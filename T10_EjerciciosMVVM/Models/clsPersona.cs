using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace T10_EjerciciosMVVM.Models
{
    public class clsPersona :INotifyPropertyChanged
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
            get {
                
                return apellido; 
            } 
            set {
                if (value.Contains('n'))
                { 
                    nombre = "";
                    NotifyPropertyChanged("Nombre");
                }
                apellido = value;
            }
        }
        public string Nombre 
        { 
            get
            {
                
                return nombre; 
            }
            set
            {
                if (value.Contains('n'))
                { 
                    apellido = "";
                    NotifyPropertyChanged("Apellido");
                }
                nombre = value;

            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
        #region metodos
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
