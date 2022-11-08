using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaProyectoWPF.Model
{
    public class Trabajador
    {
        private string nss;
        private string nombre;
        private string apellido;
        private int comision;
        private int nVentas;
        private int salarioBase;
        private int salarioTotal;

        public string NSS
        {
            get => nss;
            set
            {
                nss = value;
                OnPropertyChanged("NSS");
            }
        }

        public string Nombre
        {
            get => nombre;
            set
            {
                nombre = value;
                OnPropertyChanged("Nombre");
            }
        }

        public string Apellido
        {
            get => apellido;
            set
            {
                apellido = value;
                OnPropertyChanged("Apellido");
            }
        }

        public int Comision
        {
            get => comision;
            set
            {
                comision = value;
                OnPropertyChanged("Comision");
            }
        }

        public int NVentas
        {
            get => nVentas;
            set
            {
                nVentas = value;
                OnPropertyChanged("NVentas");
            }
        }

        public int SalarioBase
        {
            get => salarioBase;
            set
            {
                salarioBase = value;
                OnPropertyChanged("SalarioBase");
            }
        }

        public int SalarioTotal
        {
            get
            {
                int comisionTotal = (salarioBase * (comision / 100)) * nVentas;
                int total = comisionTotal + salarioBase;
                salarioTotal = total;

                return salarioTotal;
     
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

