﻿#pragma checksum "..\..\AltaAvituallamiento.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "AED3C8E92E3EFD0C0890884C0B36C513CCCA5809"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using AplicacionAvituallamiento.dto;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace AplicacionAvituallamiento {
    
    
    /// <summary>
    /// AltaAvituallamiento
    /// </summary>
    public partial class AltaAvituallamiento : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 7 "..\..\AltaAvituallamiento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabelCarrera;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\AltaAvituallamiento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBoxCarreras;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\AltaAvituallamiento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabelKilometro;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\AltaAvituallamiento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox BoxPuntoKilometrico;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\AltaAvituallamiento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBoxPersonasContacto;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\AltaAvituallamiento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAniadirMaterial;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\AltaAvituallamiento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ListaProductosAvituallamiento;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\AltaAvituallamiento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAgregarAvituallamiento;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\AltaAvituallamiento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbNombreContacto;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\AltaAvituallamiento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbNombreCarrera;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Avituallamiento;component/altaavituallamiento.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AltaAvituallamiento.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.LabelCarrera = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.ComboBoxCarreras = ((System.Windows.Controls.ComboBox)(target));
            
            #line 8 "..\..\AltaAvituallamiento.xaml"
            this.ComboBoxCarreras.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBoxCarreras_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.LabelKilometro = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.BoxPuntoKilometrico = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.ComboBoxPersonasContacto = ((System.Windows.Controls.ComboBox)(target));
            
            #line 12 "..\..\AltaAvituallamiento.xaml"
            this.ComboBoxPersonasContacto.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBoxPersonasContacto_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BtnAniadirMaterial = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\AltaAvituallamiento.xaml"
            this.BtnAniadirMaterial.Click += new System.Windows.RoutedEventHandler(this.BtnAniadirMaterial_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ListaProductosAvituallamiento = ((System.Windows.Controls.ListBox)(target));
            return;
            case 8:
            this.BtnAgregarAvituallamiento = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\AltaAvituallamiento.xaml"
            this.BtnAgregarAvituallamiento.Click += new System.Windows.RoutedEventHandler(this.BtnAgregarAvituallamiento_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.TbNombreContacto = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.TbNombreCarrera = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

