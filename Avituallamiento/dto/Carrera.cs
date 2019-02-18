using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionAvituallamiento.dto
{
    public class Carrera : INotifyPropertyChanged, ICloneable, IDataErrorInfo
    {
        //Propiedad nombre de la carrera
        private string nombreCarrera;
        public string NombreCarrera 
        {
            get
            {
                return nombreCarrera;
            }
            set
            {
                this.nombreCarrera = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("NombreCarrera"));
            }
        }
        //Cada carrera tendrá una lista de avituallamientos propia
        private ObservableCollection<Avituallamiento> listaAvituallamientos;
        public ObservableCollection<Avituallamiento> ListaAvituallamientos
         {
            get
            {
                return listaAvituallamientos;
            }
            set
            {
                this.listaAvituallamientos = value;
            }
        }

        //Constructor de mi carrera
        public Carrera()
        {
            listaAvituallamientos = new ObservableCollection<Avituallamiento>();
        }

        //toString
        public override string ToString()
        {
            return NombreCarrera;
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
                if (columnName == "NombreCarrera")
                {
                    if (string.IsNullOrEmpty(nombreCarrera))
                        result = "Debe introducir el nombre";
                }
                 return result;
            }
        }
        

        public object Clone()
        {
            return this.MemberwiseClone();

        }
    }
}
