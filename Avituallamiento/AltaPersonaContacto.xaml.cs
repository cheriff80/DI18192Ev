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
using AplicacionAvituallamiento.Logica;
using AplicacionAvituallamiento.dto;

namespace AplicacionAvituallamiento
{
    /// <summary>
    /// Lógica de interacción para AltaPersonaContacto.xaml
    /// </summary>
    public partial class AltaPersonaContacto : Window
    {

        private LogicaNegocio logicaNegocio;
        private PersonaContacto personaContacto;
        private Boolean modificar;
        private int posicion;
        private int errores;
        

        public AltaPersonaContacto(LogicaNegocio logicaNegocio)
        {
            InitializeComponent();
            this.logicaNegocio = logicaNegocio;
            personaContacto = new PersonaContacto();
            this.DataContext = personaContacto;

        }

        public AltaPersonaContacto(LogicaNegocio logicaNegocio, PersonaContacto personaContacto, int posicion)
        {
            InitializeComponent();
            this.logicaNegocio = logicaNegocio;
            this.personaContacto = personaContacto;
            this.DataContext = personaContacto;
            this.posicion = posicion;
            modificar = true;
        }

        //constructor consultar
        public AltaPersonaContacto(LogicaNegocio logicaNegocio, PersonaContacto personaContacto, int posicion, int consultar)
        {
            InitializeComponent();
            this.logicaNegocio = logicaNegocio;
            this.personaContacto = personaContacto;
            this.DataContext = personaContacto;
            this.posicion = posicion;
            this.modificar = true;
            BtnAgregarContacto.Visibility = Visibility.Hidden;
        }

        private void BtnAgregarContacto_Click(object sender, RoutedEventArgs e)
        {
            if (modificar)
                logicaNegocio.modificarPersonaContacto(personaContacto, posicion);
            else
            logicaNegocio.aniadirPersonaContacto(personaContacto);
            this.Close();

        }
        private void Validation_Error(object sender, ValidationErrorEventArgs e)
        {
            if (e.Action == ValidationErrorEventAction.Added)
                errores++;
            else
                errores--;

            if (errores == 0)
                BtnAgregarContacto.IsEnabled = true;
            else
                BtnAgregarContacto.IsEnabled = false;

        }

       

       
    }
}
