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
    /// Lógica de interacción para AltaAvituallamiento.xaml
    /// </summary>
    public partial class AltaAvituallamiento : Window
    {
        private LogicaNegocio logicaNegocio;
        private Avituallamiento avituallamiento;
        private Carrera carrera;
        private PersonaContacto personaContacto;
        private Boolean modificar = false;
        private int  posicion;
        private int indexCombo;

        //Constructor
        public AltaAvituallamiento(LogicaNegocio logicaNegocio)
        {
            InitializeComponent();
            this.logicaNegocio = logicaNegocio;
            ComboBoxCarreras.DataContext = logicaNegocio;
            ComboBoxPersonasContacto.DataContext = logicaNegocio;
            ListaProductosAvituallamiento.DataContext = avituallamiento;
            avituallamiento = new Avituallamiento();
            BoxPuntoKilometrico.DataContext = avituallamiento;
            this.DataContext = avituallamiento;
        }

        //constructor cuando vuelve de seleccionar material para el avituallamiento
        //o de modificar
        public AltaAvituallamiento(LogicaNegocio logicaNegocio, Avituallamiento avituallamiento1)
        {
            
            InitializeComponent();
            this.logicaNegocio = logicaNegocio;
            this.avituallamiento = avituallamiento1;
            //BoxPuntoKilometrico.DataContext = avituallamiento;
            TbNombreCarrera.DataContext = avituallamiento.Carrera;
            TbNombreContacto.DataContext = avituallamiento.PersonaContacto;
            //TbNombreContacto.Text = avituallamiento.PersonaContacto.ToString();
            //TbNombreCarrera.Text = avituallamiento.Carrera.ToString();
            this.DataContext = avituallamiento;
            
            ComboBoxCarreras.DataContext = logicaNegocio;
            ComboBoxPersonasContacto.DataContext = logicaNegocio;
            
            //ComboBoxCarreras.SelectedIndex = indexCombo;
           
            this.modificar = true;
            this.posicion = 0;
        }

        public AltaAvituallamiento(LogicaNegocio logicaNegocio, Avituallamiento avituallamiento,int posicion)
        {
            InitializeComponent();
            this.logicaNegocio = logicaNegocio;
            this.avituallamiento = avituallamiento;
            ComboBoxCarreras.DataContext = logicaNegocio;
            ComboBoxPersonasContacto.DataContext = logicaNegocio;
            TbNombreCarrera.DataContext = avituallamiento.Carrera;
            TbNombreContacto.DataContext = avituallamiento.PersonaContacto;
            this.DataContext = avituallamiento;
            this.modificar = true;
            this.posicion = posicion;
        }

        private void BtnAniadirMaterial_Click(object sender, RoutedEventArgs e)
        {
            if (!modificar) 
            {
                //casteo la carrera seleccionada en el ComboBox
                carrera = (Carrera)ComboBoxCarreras.SelectedItem;
                avituallamiento.Carrera = carrera;
                indexCombo = ComboBoxCarreras.SelectedIndex;

                //añado la lista material
                carrera.ListaAvituallamientos.Add(avituallamiento);

                avituallamiento.PersonaContacto = (PersonaContacto)ComboBoxPersonasContacto.SelectionBoxItem;
            }
            
            VentanaRetirarAlmacen vra = new VentanaRetirarAlmacen(logicaNegocio,avituallamiento);
            vra.Show();
            this.Close();

            
        }

        private void BtnAgregarAvituallamiento_Click(object sender, RoutedEventArgs e)
        {

            if (!modificar)
                logicaNegocio.modificarAvituallamiento(avituallamiento, posicion);
            else
            logicaNegocio.aniadirAvituallamiento(avituallamiento);
            this.Close();
        }

        private void ComboBoxCarreras_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TbNombreCarrera.Text = ComboBoxCarreras.SelectedValue.ToString();
            avituallamiento.Carrera = (Carrera) ComboBoxCarreras.SelectedItem;
        }

        private void ComboBoxPersonasContacto_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            avituallamiento.PersonaContacto = (PersonaContacto) ComboBoxPersonasContacto.SelectedItem;
            TbNombreContacto.Text = avituallamiento.PersonaContacto.NombrePersonaContacto;
        }

        

       

        

        
    }
}
