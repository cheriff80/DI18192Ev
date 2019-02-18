using AplicacionAvituallamiento.dto;
using AplicacionAvituallamiento.Logica;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AplicacionAvituallamiento
{
    /// <summary>
    /// Lógica de interacción para AltaProducto.xaml
    /// </summary>
    public partial  class AltaProducto : Window
    {

        private LogicaNegocio logicaNegocio;
        private Producto producto;
        public ObservableCollection<string> listaTipos { get; set; }
        private int posicion;
        private Boolean modificar;
            
        //constructor para producto nuevo
        public AltaProducto(LogicaNegocio logicaNegocio)
        {
            InitializeComponent();
            this.logicaNegocio = logicaNegocio;
            //cargo la lista de los tipos a la espera de saber cómo se hace con enum
            cargarListaTipos();

            //recorro la lista y cargo el combo
            foreach(String tipo in listaTipos)
            {
                 ComboBoxItem cbi = new ComboBoxItem();
                 cbi.Content = tipo;
                 ComboTipos.Items.Add(cbi);

            }
                
            //pongo modificar a false
            modificar = false;

            producto = new Producto();
            this.DataContext = producto;
          }

        //constructor para producto a modificar
        public AltaProducto(LogicaNegocio logicaNegocio, Producto producto, int posicion)
        {
            InitializeComponent();
            this.logicaNegocio = logicaNegocio;
            //cargo la lista de los tipos a la espera de saber cómo se hace con enum
            cargarListaTipos();

            //recorro la lista y cargo el combo
            foreach (String tipo in listaTipos)
            {
                ComboBoxItem cbi = new ComboBoxItem();
                cbi.Content = tipo;
                ComboTipos.Items.Add(cbi);

            }
            //pongo modificar a true
            modificar = true;
            this.producto = producto;
            this.posicion = posicion;
            this.DataContext = producto;
        }


        //Botón añadir
        private void BtnAniadir_Click(object sender, RoutedEventArgs e)
        {
            if (modificar)
                logicaNegocio.modificarProducto(producto,posicion);
            else
            logicaNegocio.aniadirProducto(producto);
            
            this.Close();
        }

        //método para cargar la lista de los tipos de productos
        public void cargarListaTipos()
        {
            listaTipos = new ObservableCollection<string>();
            listaTipos.Add("bebida");
            listaTipos.Add("comida");
            listaTipos.Add("materialSanitario");
        }

        

       
    }

  
}
