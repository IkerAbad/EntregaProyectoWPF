using EntregaProyectoWPF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EntregaProyectoWPF.ViewModel
{
    class TrabajadorVM
    { 
    private IList<Trabajador> _ListTrabajadores;

    public TrabajadorVM()
    {
        _ListTrabajadores = new List<Trabajador>
            {
                new Trabajador{NSS = "11321252Z", Nombre = "Alberto", Apellido = "Fernández", Comision = 1, NVentas= 50, SalarioBase = 1050},
                new Trabajador{NSS = "11312412A", Nombre = "Juan", Apellido = "Chaves", Comision = 2, NVentas= 70, SalarioBase = 1100},
                new Trabajador{NSS = "12312314F", Nombre = "María", Apellido = "Alves", Comision = 1, NVentas= 35, SalarioBase = 1230},
                new Trabajador{NSS = "41312156G", Nombre = "Rodrigo", Apellido = "Sánchez", Comision = 3, NVentas= 60, SalarioBase = 1120},
                new Trabajador{NSS = "31231654F", Nombre = "Antonio", Apellido = "López", Comision = 2, NVentas= 40, SalarioBase = 1060}
            };

        }

        public IList<Trabajador> Trabajador
    {
        get => _ListTrabajadores;
        set => _ListTrabajadores = value;
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
        */
}
}

