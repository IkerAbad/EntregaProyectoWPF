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

namespace EntregaProyectoWPF.View
{
    /// <summary>
    /// Lógica de interacción para Inicio.xaml
    /// </summary>
    public partial class Inicio : Page
    {
        public Inicio()
        {
            InitializeComponent();
        }
        private void Trabajador(object sender, RoutedEventArgs e)
        {
            Trabajador trabajador = new Trabajador();
            this.NavigationService.Navigate(trabajador);

        }
        
        private void Almacen(object sender, RoutedEventArgs e)
        {
            Almacen almacen = new Almacen();
            this.NavigationService.Navigate(almacen);
        }

        private void Ventas(object sender, RoutedEventArgs e)
        {
            Ventas ventas = new Ventas();
            this.NavigationService.Navigate(ventas);
        }


        private void Home(object sender, RoutedEventArgs e)
        {
            Inicio inicio = new Inicio();
            this.NavigationService.Navigate(inicio);
        }
    }
}
