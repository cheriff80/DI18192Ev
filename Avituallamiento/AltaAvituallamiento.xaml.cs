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
        private int errores;

        //Constructor
        public AltaAvituallamiento(LogicaNegocio logicaNegocio)
        {
            InitializeComponent();
            this.logicaNegocio = logicaNegocio;
            ComboBoxCarreras.DataContext = logicaNegocio;
            ComboBoxPersonasContacto.DataContext = logicaNegocio;
            
            
            avituallamiento = new Avituallamiento();
            TbNombreCarrera.DataContext = avituallamiento;
            TbNombreContacto.DataContext = avituallamiento;
            ListaProductosAvituallamiento.DataContext = avituallamiento;
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
            TbNombreCarrera.DataContext = avituallamiento.Carrera;
            TbNombreContacto.DataContext = avituallamiento.PersonaContacto;
            this.DataContext = avituallamiento;
            ComboBoxCarreras.DataContext = logicaNegocio;
            ComboBoxPersonasContacto.DataContext = logicaNegocio;
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
            this.posicion = posicion;
            this.modificar = true;
        }

        //constructor para consultar
        public AltaAvituallamiento(LogicaNegocio logicaNegocio, Avituallamiento avituallamiento, int posicion,int numero)
        {
            InitializeComponent();
            this.logicaNegocio = logicaNegocio;
            this.avituallamiento = avituallamiento;
            ComboBoxCarreras.DataContext = logicaNegocio;
            ComboBoxPersonasContacto.DataContext = logicaNegocio;
            TbNombreCarrera.DataContext = avituallamiento.Carrera;
            TbNombreContacto.DataContext = avituallamiento.PersonaContacto;
            this.DataContext = avituallamiento;
            this.posicion = posicion;
            this.modificar = false;
            BtnAgregarAvituallamiento.Visibility = Visibility.Hidden;
            BtnAniadirMaterial.Visibility = Visibility.Hidden;
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
                avituallamiento.Carrera = (Carrera)ComboBoxCarreras.SelectionBoxItem;
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
            avituallamiento.Carrera = (Carrera)ComboBoxCarreras.SelectedItem;
            TbNombreCarrera.Text = ComboBoxCarreras.SelectedValue.ToString();
            
        }

        private void ComboBoxPersonasContacto_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            avituallamiento.PersonaContacto = (PersonaContacto) ComboBoxPersonasContacto.SelectedItem;
            TbNombreContacto.Text = avituallamiento.PersonaContacto.NombrePersonaContacto;

        }

        private void Validation_Error(object sender, ValidationErrorEventArgs e)
        {
            if (e.Action == ValidationErrorEventAction.Added)
                errores++;
            else
                errores--;

            if (errores == 0)
                BtnAgregarAvituallamiento.IsEnabled = true;
            else
                BtnAgregarAvituallamiento.IsEnabled = false;

        }

        

       

        

        
    }
}
