using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionAvituallamiento.dto
{
    public class PersonaContacto : INotifyPropertyChanged, ICloneable, IDataErrorInfo
    {
        private string nombrePersonaContacto;
        public string NombrePersonaContacto
        {
            get
            {
                return nombrePersonaContacto;
            }
            set
            {
                this.nombrePersonaContacto = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("NombrePersonaContacto"));
            }
        }


        private string telefonoPersonaContacto;
        public string TelefonoPersonaContacto
        {
            get
            {
                return telefonoPersonaContacto;
            }
            set
            {
                this.telefonoPersonaContacto = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("TelefonoPersonaContacto"));
            }
        }

        //Constructor
        public PersonaContacto()
        {

        }

        public override string ToString()
        {
            return NombrePersonaContacto + " , " + TelefonoPersonaContacto;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string Error
        {
            get { return ""; }
        }

        public string this[string columnName]
        {
            get
            {
                string result = "";
                if (columnName == "NombrePersonaContacto")
                {
                    if (string.IsNullOrEmpty(nombrePersonaContacto))
                        result = "Debe introducir el nombre";
                }
                if (columnName == "TelefonoPersonaContacto")
                {
                    if (string.IsNullOrEmpty(telefonoPersonaContacto))
                        result = "Debe introducir el teléfono";
                } return result;
            }
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
