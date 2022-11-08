using EntregaProyectoWPF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EntregaProyectoWPF.ViewModel
{
    class VentasVM
    {
        private IList<Ventas> _ListVentas;

        public VentasVM()
        {
            _ListVentas = new List<Ventas>
            {

                new Ventas{IdVenta=0001, Fecha= new DateTime(), Importe=22, FormaPago="Contado",TrabajadorNSS="41312156G"},
                new Ventas{IdVenta=0002, Fecha= new DateTime(), Importe=16, FormaPago="Tarjeta",TrabajadorNSS="12312314F"},
                new Ventas{IdVenta=0003, Fecha= new DateTime(), Importe=13, FormaPago="Contado",TrabajadorNSS="31231654F"},
                new Ventas{IdVenta=0004, Fecha= new DateTime(), Importe=17, FormaPago="Contado",TrabajadorNSS="41312156G"},
                new Ventas{IdVenta=0005, Fecha= new DateTime(), Importe=26, FormaPago="Contado",TrabajadorNSS="31231654F"},
                new Ventas{IdVenta=0006, Fecha= new DateTime(), Importe=31, FormaPago="Tarjeta",TrabajadorNSS="11312412A"},
                new Ventas{IdVenta=0007, Fecha= new DateTime(), Importe=18, FormaPago="Contado",TrabajadorNSS="11312412A"},
                new Ventas{IdVenta=0008, Fecha= new DateTime(), Importe=21, FormaPago="Tarjeta",TrabajadorNSS="11321252Z"}

            };
        }

        public IList<Ventas> Ventas
        {
            get => _ListVentas;
            set => _ListVentas = value;
        }
        /*
        private ICommand mUpdater;
        public ICommand UpdateCommand
        {
            get
            {
                if (mUpdater == null)
                    mUpdater = new Updater();
                return mUpdater;
            }
            set => mUpdater = value;
        }

        private class Updater : ICommand
        {
            #region ICommand Members  

            public bool CanExecute(object parameter) => true;

            public event EventHandler CanExecuteChanged;

            public void Execute(object parameter)
            {

            }

            #endregion
        }*/
    }
}
