﻿#pragma checksum "..\..\..\vistas\VistaGestionAvituallamiento.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "747BB70D80BF2A40CC5E1ED7EC190474EC7C6F3B"
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
using pruebaWPF.vistas;


namespace pruebaWPF.vistas {
    
    
    /// <summary>
    /// VistaGestionAvituallamiento
    /// </summary>
    public partial class VistaGestionAvituallamiento : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\vistas\VistaGestionAvituallamiento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid gridAvituallamientos;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\vistas\VistaGestionAvituallamiento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button botonEliminar;
        
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
            System.Uri resourceLocater = new System.Uri("/pruebaWPF;component/vistas/vistagestionavituallamiento.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\vistas\VistaGestionAvituallamiento.xaml"
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
            
            #line 12 "..\..\..\vistas\VistaGestionAvituallamiento.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.gridAvituallamientos = ((System.Windows.Controls.DataGrid)(target));
            
            #line 14 "..\..\..\vistas\VistaGestionAvituallamiento.xaml"
            this.gridAvituallamientos.GotMouseCapture += new System.Windows.Input.MouseEventHandler(this.GridAvituallamientos_GotMouseCapture);
            
            #line default
            #line hidden
            
            #line 14 "..\..\..\vistas\VistaGestionAvituallamiento.xaml"
            this.gridAvituallamientos.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.GridAvituallamientos_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.botonEliminar = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\vistas\VistaGestionAvituallamiento.xaml"
            this.botonEliminar.Click += new System.Windows.RoutedEventHandler(this.BotonEliminar_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
