﻿#pragma checksum "..\..\VentanaAlmacen.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F03C434150D60ACEE7A024853775FB94DAAB1E68"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

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
    /// VentanaAlmacen
    /// </summary>
    public partial class VentanaAlmacen : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\VentanaAlmacen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabelAlmacen;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\VentanaAlmacen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnCerrar;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\VentanaAlmacen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnBorrarProducto;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\VentanaAlmacen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnEditarProducto;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\VentanaAlmacen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGridAlmacen;
        
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
            System.Uri resourceLocater = new System.Uri("/Avituallamiento;component/ventanaalmacen.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\VentanaAlmacen.xaml"
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
            this.LabelAlmacen = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.BtnCerrar = ((System.Windows.Controls.Button)(target));
            
            #line 8 "..\..\VentanaAlmacen.xaml"
            this.BtnCerrar.Click += new System.Windows.RoutedEventHandler(this.BtnCerrar_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnBorrarProducto = ((System.Windows.Controls.Button)(target));
            
            #line 9 "..\..\VentanaAlmacen.xaml"
            this.BtnBorrarProducto.Click += new System.Windows.RoutedEventHandler(this.BtnBorrarProducto_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BtnEditarProducto = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\VentanaAlmacen.xaml"
            this.BtnEditarProducto.Click += new System.Windows.RoutedEventHandler(this.BtnEditarProducto_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.DataGridAlmacen = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

