using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionAvituallamiento.dto
{

    

    public class Producto :INotifyPropertyChanged,ICloneable,IDataErrorInfo
    {
        private string nombreProducto;
        public string NombreProducto
        {
            get
            {
                return nombreProducto;
            }
            set
            {
                this.nombreProducto = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("NombreProducto"));
            }
        }
        

        private string tipoProducto;
        public string TipoProducto
        {
            get
            {
                return tipoProducto;
            }
            set
            {
                this.tipoProducto = value;
               this.PropertyChanged(this, new PropertyChangedEventArgs("TipoProducto"));
            }
        }
        private int precio;
        public int Precio
        {
            get
            {
                return precio;
            }
            set
            {
                this.precio = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Precio"));
            }
        }
         private int cantidadProducto;
        public int CantidadProducto
        {
            get
            {
                return cantidadProducto;
            }
            set
            {
                this.cantidadProducto = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("CantidadProducto"));
            }
        }

        public Producto()
        {
            cantidadProducto = 0;
        }
        //Constructor
        public Producto(string nombreProducto, string tipoProducto, int precioProducto)
        {
            this.nombreProducto = nombreProducto;
            this.tipoProducto = tipoProducto;
            this.precio = precioProducto;
            cantidadProducto = 0;
        }

        public Producto(string p1, string p2, int p3, int numero)
        {
            
            this.nombreProducto = p1;
            this.tipoProducto = p2;
            this.precio = p3;
            this.cantidadProducto = numero;
        }

        //Sobreescribimos el método string
        public override string ToString()
        {
            return NombreProducto + " / "+ TipoProducto + " / "  + CantidadProducto ;
        }


        
        public event PropertyChangedEventHandler PropertyChanged;
     

        public object Clone()
        {
            return this.MemberwiseClone();
            
        }

        public string Error
        {
            get { return " "; }
        }

        public string this[string columnName]
        {
            get 
            { string result = "";
            if (columnName == "NombreProducto")
            {
                if (string.IsNullOrEmpty(nombreProducto))
                    result = "Debe introducir el nombre";
            }
            if (columnName == "TipoProducto")
            {
                if (string.IsNullOrEmpty(tipoProducto))
                    result = "Debe introducir el tipo";
            }
            if (columnName == "CantidadProducto")
            {
                if (cantidadProducto == 0)
                    result = "Debe introducir la cantidad";
            }
            if (columnName == "Precio")
            {
                if (precio == 0)
                    result = "Debe introducir un precio";
            }
            return result;
            }
        }
    }
}
