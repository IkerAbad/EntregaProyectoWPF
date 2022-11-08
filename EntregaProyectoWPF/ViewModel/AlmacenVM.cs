using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.ComponentModel;
using System.Windows;
using EntregaProyectoWPF.Model;

namespace EntregaProyectoWPF.ViewModel
{
    class AlmacenVM
    {
        public IList<Almacen> _ListaAlmacen;

        public AlmacenVM()
        {
            _ListaAlmacen = new List<Almacen>
            {
                new Almacen{IdArticulo = 0001, Autor="Miguel de Cervantes", Titulo = "Don Quijote", Stock = 11, IVA = 10, Pvp = 22 },
                new Almacen{IdArticulo = 0002, Autor="Charles Dickens", Titulo = "Historia de dos ciudades", Stock = 6, IVA = 21, Pvp = 16},
                new Almacen{IdArticulo = 0003, Autor="J.R.R. Tolkien", Titulo = "El señor de los anillos", Stock = 7, IVA = 10, Pvp = 13},
                new Almacen{IdArticulo = 0004, Autor="Antoine de Saint-Exupéry", Titulo = "El Principito", Stock = 8, IVA = 4, Pvp = 17},
                new Almacen{IdArticulo = 0005, Autor="J.K. Rowling", Titulo = "Harry Potter y la piedra filosofal", Stock = 11, IVA = 10, Pvp = 26},
                new Almacen{IdArticulo = 0006, Autor="J. R. R. Tolkien", Titulo = "El Hobbit", Stock = 3, IVA = 21, Pvp = 31},
                new Almacen{IdArticulo = 0007, Autor="Agatha Christie", Titulo = "Diez negritos", Stock = 1, IVA = 4, Pvp = 9},
                new Almacen{IdArticulo = 0008, Autor="Cao Xueqin", Titulo = "Sueño en el pabellón rojo", Stock = 0, IVA = 10, Pvp = 21}
            };
        }

        public IList<Almacen> Almacen
        {
            get { return _ListaAlmacen; }
            set { _ListaAlmacen = value; }
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
            set
            {
                mUpdater = value;
            }
        }

        private class Updater : ICommand
        {
            #region ICommand Members  

            public bool CanExecute(object parameter)
            {
                return true;
            }

            public event EventHandler CanExecuteChanged;

            public void Execute(object parameter)
            {

            }

            #endregion
        }*/
    }
}
