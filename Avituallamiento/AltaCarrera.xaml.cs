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
    /// Lógica de interacción para AltaCarrera.xaml
    /// </summary>
    public partial class AltaCarrera : Window
    {
        private LogicaNegocio logicaNegocio;
        private Carrera carrera;
        private Boolean modificar;
        private int posicion;
        private int errores;

        public AltaCarrera(LogicaNegocio logicaNegocio)
        {
            InitializeComponent();
            this.logicaNegocio = logicaNegocio;
            carrera = new Carrera();
            this.DataContext = carrera;
            modificar = false;
        }

        public AltaCarrera(LogicaNegocio logicaNegocio, Carrera carrera, int posicion)
        {
            InitializeComponent();
            this.logicaNegocio = logicaNegocio;
            this.carrera = carrera;
            this.DataContext = carrera;
            this.posicion = posicion;
            modificar = true;
        }

        //constructor para modificar
        public AltaCarrera(LogicaNegocio logicaNegocio, Carrera carrera, int posicion,int consultar)
        {
            InitializeComponent();
            this.logicaNegocio = logicaNegocio;
            this.carrera = carrera;
            this.DataContext = carrera;
            this.posicion = posicion;
            this.modificar = false;
            BtnAgregarCarrera.Visibility = Visibility.Hidden;

        }
        private void BtnAgregarCarrera_Click(object sender, RoutedEventArgs e)
        {
            if (modificar)
                logicaNegocio.modificarCarrera(carrera, posicion);
            else
            logicaNegocio.aniadirCarrera(carrera);
            this.Close();

        }
       
    }
}
