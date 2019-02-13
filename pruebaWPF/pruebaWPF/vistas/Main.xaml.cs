﻿using pruebaWPF.logica;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace pruebaWPF
{
    
    /// <summary>
    /// Lógica de interacción para Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        public GestionCarreras Gestion { get; set; }
        public Main()
        {
            

            InitializeComponent();
            Gestion = new GestionCarreras();
           // this.Gestion.aniadirCarreras();
            
            
        }

        private void botonAniadir_Click(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow(Gestion);
            m.ShowDialog();
        }
    }
}
