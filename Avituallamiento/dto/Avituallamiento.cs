using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionAvituallamiento.dto
{
    public class Avituallamiento : INotifyPropertyChanged, ICloneable, IDataErrorInfo
    {
        //CARRERA A LA QUE PERTENECE
        private Carrera carrera;
        public Carrera Carrera
        {
            get
            {
                return carrera;
            }
            set
            {
                this.carrera = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Carrera"));
            }
        }

        //PUNTO KILOMÉTRICO
        private string puntoKilometrico;
        public string PuntoKilometrico
        {
            get
            {
                return puntoKilometrico;
            }
            set
            {
                this.puntoKilometrico = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("PuntoKilometrico"));
            }
        }

        //PERSONA CONTACTO
        private PersonaContacto personaContacto;
        public PersonaContacto PersonaContacto
        {
            get
            {
                return personaContacto;
            }
            set
            {
                this.personaContacto = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("PersonaContacto"));
            }
        }

        //LISTA MATERIALES
        private ObservableCollection<Producto> listaMateriales;
        public ObservableCollection<Producto> ListaMateriales
        {
            get
            {
                return listaMateriales;
            }
            set
            {
                this.listaMateriales = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("ListaMateriales"));
            }
        }

        //Constructor
        public Avituallamiento()
        {
            listaMateriales = new ObservableCollection<Producto>();
        }

        //toString
        public override string ToString()
        {
            return carrera.NombreCarrera + " , "+ puntoKilometrico;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public string Error
        {
            get { return ""; }
        }

        public string this[string columnName]
        {
            get { string result = "";
            if (columnName == "Carrera")
            {
                
                if (Carrera ==  null)
                    result = "Debe introducir la carrera";
            }
            if (columnName == "PuntoKilometrico")
            {
                if (string.IsNullOrEmpty(puntoKilometrico))
                    result = "Debe introducir el punto Kilométrico";
            }
            if (columnName == "PersonaContacto")
            {
                if (PersonaContacto == null)
                    result = "Debe introducir persona de contacto";
            }
            if (columnName == "ListaMateriales")
            {
                if (listaMateriales.Count == 0)
                    result = "Debe introducir algún material";
            }
            return result;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
