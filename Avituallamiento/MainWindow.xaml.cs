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
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace AplicacionAvituallamiento
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private LogicaNegocio logicaNegocio;
        private Boolean consulta;

        public MainWindow()
        {
            InitializeComponent();
            logicaNegocio = new LogicaNegocio();
            ComboBoxContactos.DataContext = logicaNegocio;
            ComboBoxCarreras.DataContext = logicaNegocio;
            ComboBoxAvituallamientos.DataContext = logicaNegocio;
            this.consulta = false;
        }

        //al pulsar nuevo producto genero la página de Alta producto
        private void MenuItem_Click_2 (object sender, RoutedEventArgs e)
        {
            AltaProducto vap = new AltaProducto(logicaNegocio);
            vap.Show();
        }

        //al pulsar consultar almacén abro la ventana del almacén
        private void MenuItem_Click_3 (object sender, RoutedEventArgs e)
        {
            VentanaAlmacen va = new VentanaAlmacen(logicaNegocio);
            va.Show();
        }

        private void MenuItem_Click_NuevoContacto (object sender, RoutedEventArgs e)
        {
            AltaPersonaContacto apc = new AltaPersonaContacto (logicaNegocio);
            apc.Show();
        }

        private void MenuItem_Click_NuevoAvituallamiento(object sender, RoutedEventArgs e)
        {
            AltaAvituallamiento apc = new AltaAvituallamiento(logicaNegocio);
            apc.Show();
        }

        private void MenuItem_Click_NuevaCarrera(object sender, RoutedEventArgs e)
        {
            AltaCarrera ac = new AltaCarrera(logicaNegocio);
            ac.Show();
        }

        private void BtnBorrar_Click(object sender, RoutedEventArgs e)
        {
            if (ComboBoxCarreras.SelectedIndex != -1) 
            {
                Carrera carrera = (Carrera)ComboBoxCarreras.SelectedItem;
                logicaNegocio.borrarCarrera(carrera);
            }
            if(ComboBoxContactos.SelectedIndex != -1)
            {
                PersonaContacto pc = (PersonaContacto)ComboBoxContactos.SelectedItem;
                logicaNegocio.borrarPersonaContacto(pc);
            }
            if (ComboBoxAvituallamientos.SelectedIndex != -1)
            {
                Avituallamiento av = (Avituallamiento)ComboBoxAvituallamientos.SelectedItem;
                logicaNegocio.borrarAvituallamiento(av);
            }
           
        }

        private void BtnModificar_Click(object sender, RoutedEventArgs e)
        {
            if (ComboBoxCarreras.SelectedIndex != -1)
            {
                Carrera carrera = (Carrera)ComboBoxCarreras.SelectedItem;
                AltaCarrera ac = new AltaCarrera(logicaNegocio, (Carrera)carrera.Clone(), ComboBoxCarreras.SelectedIndex);
                ac.Show();
            }
            if (ComboBoxContactos.SelectedIndex != -1)
            {
                PersonaContacto pc = (PersonaContacto)ComboBoxContactos.SelectedItem;
                AltaPersonaContacto apc = new AltaPersonaContacto(logicaNegocio, (PersonaContacto)pc.Clone(), ComboBoxContactos.SelectedIndex);
                apc.Show();
            }
            if (ComboBoxAvituallamientos.SelectedIndex != -1)
            {
                Avituallamiento av = (Avituallamiento)ComboBoxAvituallamientos.SelectedItem;
                AltaAvituallamiento aav = new AltaAvituallamiento(logicaNegocio, (Avituallamiento)av.Clone(), ComboBoxAvituallamientos.SelectedIndex);
                aav.Show();
            }
        }

        private void BtnConsultar_Click(object sender, RoutedEventArgs e)
        {
            if (ComboBoxCarreras.SelectedIndex != -1)
            {
                Carrera carrera = (Carrera)ComboBoxCarreras.SelectedItem;
                AltaCarrera ac = new AltaCarrera(logicaNegocio, (Carrera)carrera.Clone(), ComboBoxCarreras.SelectedIndex,1);
                ac.Show();
            }
            if (ComboBoxContactos.SelectedIndex != -1)
            {
                PersonaContacto pc = (PersonaContacto)ComboBoxContactos.SelectedItem;
                AltaPersonaContacto apc = new AltaPersonaContacto(logicaNegocio, (PersonaContacto)pc.Clone(), ComboBoxContactos.SelectedIndex);
                apc.Show();
            }
            if (ComboBoxAvituallamientos.SelectedIndex != -1)
            {
                Avituallamiento av = (Avituallamiento)ComboBoxAvituallamientos.SelectedItem;
                AltaAvituallamiento aav = new AltaAvituallamiento(logicaNegocio, (Avituallamiento)av.Clone(), ComboBoxAvituallamientos.SelectedIndex,1);
                aav.Show();
            }

        }
    }
}
