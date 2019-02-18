using AplicacionAvituallamiento.dto;
using AplicacionAvituallamiento.Logica;
using System;
using System.Collections.Generic;
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
    /// Lógica de interacción para VentanaRetirarAlmacen.xaml
    /// </summary>
    public partial class VentanaRetirarAlmacen : Window
    {
        private LogicaNegocio logicaNegocio;
        private Avituallamiento avituallamiento;
        
        //private Producto producto;

        public VentanaRetirarAlmacen(LogicaNegocio logicaNegocio, Avituallamiento avituallamiento)
        {
            InitializeComponent();
            DataGridAlmacen.DataContext = logicaNegocio;
            this.logicaNegocio = logicaNegocio;
            this.avituallamiento = avituallamiento;
            
            //this.DataContext = producto;


        }

        private void BtnRetirar_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridAlmacen.SelectedIndex != -1)
            {
                Producto producto = (Producto)DataGridAlmacen.SelectedItem;
                //obtengo el número del textBox
                
                String loquecontiene = BoxCantidadRetirar.Text;
                int numero = Convert.ToInt32(loquecontiene);

                //creo un nuevo producto
                Producto productoRetirar = new Producto(producto.NombreProducto,
                    producto.TipoProducto, producto.Precio, numero);
                
                logicaNegocio.retirarProducto(productoRetirar,avituallamiento);
                
                //inicio la ventana entrando por el constructor de modificar
                
                AltaAvituallamiento av = new AltaAvituallamiento(logicaNegocio,avituallamiento);
                this.Close();
                av.Show();
                
            }
        }

        private void DataGridAlmacen_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DataGridAlmacen.SelectedIndex != -1) 
            {
                Producto producto = (Producto)DataGridAlmacen.SelectedItem;
                LabelProducto.Content = producto.NombreProducto;
            }
            
        }

       
    }
}
