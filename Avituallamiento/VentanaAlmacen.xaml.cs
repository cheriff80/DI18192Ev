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
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class VentanaAlmacen : Window
    {
        private LogicaNegocio logicaNegocio;
        
        public VentanaAlmacen(LogicaNegocio logicaNegocio)
        {
            InitializeComponent();
            this.logicaNegocio = logicaNegocio;
            DataGridAlmacen.DataContext = logicaNegocio;
           
        }

        private void BtnCerrar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnBorrarProducto_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridAlmacen.SelectedIndex != -1)
            {
                Producto producto = (Producto)DataGridAlmacen.SelectedItem;
                logicaNegocio.borrarProducto(producto);
            }
        }

        private void BtnEditarProducto_Click(object sender, RoutedEventArgs e)
        {
            if(DataGridAlmacen.SelectedIndex != -1)
            {
                Producto producto = (Producto) DataGridAlmacen.SelectedItem;
                AltaProducto ap = new AltaProducto(logicaNegocio,(Producto)producto.Clone(),DataGridAlmacen.SelectedIndex);
                ap.Show();
            }
            
        }

      

       
    }
}
