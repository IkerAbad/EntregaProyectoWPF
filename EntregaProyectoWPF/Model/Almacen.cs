using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaProyectoWPF.Model
{
    public class Almacen
    {
        private int idArticulo;
        private string autor;
        private string titulo;
        private int stock;
        private int iva;
        private double pvp;

        public int IdArticulo
        {
            get => idArticulo;
            set
            {
                idArticulo = value;
                OnPropertyChanged("IdArticulo");
            }
        }

        public string Autor
        {
            get => autor;
            set
            {
                autor = value;
                OnPropertyChanged("Autor");
            }
        }

        public string Titulo
        {
            get => titulo;
            set
            {
                titulo = value;
                OnPropertyChanged("Titulo");
            }

        }

        public int Stock
        {
            get => stock;
            set
            {
                stock = value;
                OnPropertyChanged("Stock");
            }
        }

        public int IVA
        {
            get => iva;
            set
            {
                iva = value;
                OnPropertyChanged("IVA");
            }
        }

        public double Pvp
        {
            get => pvp;
            set
            {
                pvp = value;
                OnPropertyChanged("Pvp");
            }
        }

        #region INotifyPropertyChanged Members  

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
