using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class C_IniciarViaje
    {
        private int _Id_Viaje;
        private string _Chofer;
        private string _Autobus;
        private string _Ruta;

        public int Id_Viaje { get => _Id_Viaje; set => _Id_Viaje = value; }
        public string Chofer { get => _Chofer; set => _Chofer = value; }
        public string Autobus { get => _Autobus; set => _Autobus = value; }
        public string Ruta { get => _Ruta; set => _Ruta = value; }
    }
}
