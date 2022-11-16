using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class N_Autobuses
    {
        D_Autobuses objDato = new D_Autobuses();
        //CHOFER
        public List<E_Autobuses> ListandoChoferes(string buscar)
        {
            return objDato.ListarChofer(buscar);
        }
        public void InsertandoChoferes(E_Autobuses Chofer)
        {
            objDato.InsertarChofer(Chofer);
        }
        public void EditandoChoferes(E_Autobuses Chofer)
        {
            objDato.EditarChofer(Chofer);
        }
        public void EliminandoChoferes(E_Autobuses Chofer)
        {
            objDato.EliminarChofer(Chofer);
        }

        //AUTOBUS
        public List<E_Autobuses> ListandoAutobuses(string buscar)
        {
            return objDato.ListarAutobus(buscar);
        }
        public void InsertandoAutobuses(E_Autobuses Autobus)
        {
            objDato.InsertarAutobus(Autobus);
        }
        public void EditandoAutobuses(E_Autobuses Autobus)
        {
            objDato.EditarAutobus(Autobus);
        }
        public void EliminandoAutobuses(E_Autobuses Autobus)
        {
            objDato.EliminarAutobus(Autobus);
        }

        //RUTAS
        public List<E_Autobuses> ListandoRutas(string buscar)
        {
            return objDato.ListarRuta(buscar);
        }
        public void InsertandoRutas(E_Autobuses Ruta)
        {
            objDato.InsertarRuta(Ruta);
        }
        public void EditandoRutas(E_Autobuses Ruta)
        {
            objDato.EditarRuta(Ruta);
        }
        public void EliminandoRutas(E_Autobuses Ruta)
        {
            objDato.EliminarRuta(Ruta);
        }

        public List<C_IniciarViaje> ListandoViajes(string buscar)
        {
            return objDato.ListarViaje(buscar);
        }

        public void InsertandoViajes(C_IniciarViaje buscar)
        {
            objDato.InsertarViaje(buscar);
        }

        public DataTable ComboBox_Chofer()
        {
            return objDato.ComboBoxChofer();
        }
        public DataTable ComboBox_Autobus()
        {
            return objDato.ComboBoxAutobus();
        }
        public DataTable ComboBox_Ruta()
        {
            return objDato.ComboBoxRuta();
        }
        public void DisponibleChofer(C_IniciarViaje buscar)
        {
            objDato.DispoChofer(buscar);
        }
        public void DisponibleAutobus(C_IniciarViaje buscar)
        {
            objDato.DispoAutobus(buscar);
        }
        public void DisponibleRuta(C_IniciarViaje buscar)
        {
            objDato.DispoRuta(buscar);
        }
        public void FinalizandoViaje(C_IniciarViaje buscar)
        {
            objDato.EliminarViaje(buscar);
        }

        public void DisponibleChoferV(C_IniciarViaje buscar)
        {
            objDato.DispoChoferV(buscar);
        }
        public void DisponibleAutobusV(C_IniciarViaje buscar)
        {
            objDato.DispoAutobusV(buscar);
        }
        public void DisponibleRutaV(C_IniciarViaje buscar)
        {
            objDato.DispoRutaV(buscar);
        }
    }
}
