using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaProyectoWPF.Model
{
    public class Ventas
    {
        private int idVenta;
        private DateTime fecha;
        private int importe;
        private string formaPago;
        private string trabajadorNSS;

        public int IdVenta
        {
            get => idVenta;
            set
            {
                idVenta = value;
                OnPropertyChanged("IdVenta");
            }
        }

        public DateTime Fecha
        {
            get => fecha;
            set
            {
                fecha = value;
                OnPropertyChanged("Fecha");
            }
        }

        public int Importe
        {
            get => importe;
            set
            {
                importe = value;
                OnPropertyChanged("Importe");
            }
        }

        public string FormaPago
        {
            get => formaPago;
            set
            {
                formaPago = value;
                OnPropertyChanged("FormaPago");
            }
        }

        public string TrabajadorNSS
        {
            get => trabajadorNSS;
            set
            {
                trabajadorNSS = value;
                OnPropertyChanged("TrabajadorNSS");
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

