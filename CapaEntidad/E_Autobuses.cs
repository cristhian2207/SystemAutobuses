using System;

namespace CapaEntidad
{
    public class E_Autobuses
    {

        //Propoiedades Chofer
        private int _id_Chofer;
        private String _Nombre;
        private String _Apellido;
        private DateTime _Fecha_De_Nacimiento;
        private string _Cedula;
        private String _Disp_Chofer;

        //Propoiedades Autobus
        private int _id_Autobus;
        private String _Marca;
        private String _Modelo;
        private String _Placa;
        private String _Color;
        private int _Año;

        //Propoiedades Ruta
        private int _id_Rutas;
        private String _Nombre_Ruta;

        //Chofer
        public int Id_Chofer { get => _id_Chofer; set => _id_Chofer = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public DateTime Fecha_De_Nacimiento { get => _Fecha_De_Nacimiento; set => _Fecha_De_Nacimiento = value; }
        public string Cedula { get => _Cedula; set => _Cedula = value; }
        public string Disp_Chofer { get => _Disp_Chofer; set => _Disp_Chofer = value; }

        //Autobus
        public int Id_Autobus { get => _id_Autobus; set => _id_Autobus = value; }
        public string Marca { get => _Marca; set => _Marca = value; }
        public string Modelo { get => _Modelo; set => _Modelo = value; }
        public string Placa { get => _Placa; set => _Placa = value; }
        public string Color { get => _Color; set => _Color = value; }
        public int Año { get => _Año; set => _Año = value; }

        //Ruta
        public int Id_Rutas { get => _id_Rutas; set => _id_Rutas = value; }
        public string Nombre_Ruta { get => _Nombre_Ruta; set => _Nombre_Ruta = value; }

    }
}