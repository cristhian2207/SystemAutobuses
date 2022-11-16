using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using CapaEntidad;
using System.Data;

namespace CapaDatos
{
    public class D_Autobuses
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);
        
        //Codigo de chofer
        #region
        
        public List<E_Autobuses> ListarChofer(string buscar)
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_BUSCAR_CHOFER", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@CEDULA", buscar);
            LeerFilas = cmd.ExecuteReader();

            List<E_Autobuses> Listar = new List<E_Autobuses>();
            while (LeerFilas.Read())
            {
                Listar.Add(new E_Autobuses
                {
                    Id_Chofer = LeerFilas.GetInt32(0),
                    Cedula = LeerFilas.GetString(1),
                    Nombre = LeerFilas.GetString(2),
                    Apellido = LeerFilas.GetString(3),
                    Fecha_De_Nacimiento = LeerFilas.GetDateTime(4),
                    
                });
            }
            conexion.Close();
            LeerFilas.Close();
            return Listar;
        }

        public void InsertarChofer(E_Autobuses Chofer)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTAR_CHOFER", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@CEDULA", Chofer.Cedula);
            cmd.Parameters.AddWithValue("@NOMBRE", Chofer.Nombre);
            cmd.Parameters.AddWithValue("@APELLIDO", Chofer.Apellido);
            cmd.Parameters.AddWithValue("@FECHA_DE_NACIMIENTO", Chofer.Fecha_De_Nacimiento);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EditarChofer(E_Autobuses Chofer)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITAR_CHOFER", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@ID_CHOFER", Chofer.Id_Chofer);
            cmd.Parameters.AddWithValue("@CEDULA", Chofer.Cedula);
            cmd.Parameters.AddWithValue("@NOMBRE", Chofer.Nombre);
            cmd.Parameters.AddWithValue("@APELLIDO", Chofer.Apellido);
            cmd.Parameters.AddWithValue("@FECHA_DE_NACIMIENTO", Chofer.Fecha_De_Nacimiento);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EliminarChofer(E_Autobuses Chofer)
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINAR_CHOFER", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@ID_CHOFER", Chofer.Id_Chofer);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        #endregion

        //Codigo de autobus
        #region

        public List<E_Autobuses> ListarAutobus(string buscar)
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_BUSCAR_AUTOBUS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@NOMBRE", buscar);
            LeerFilas = cmd.ExecuteReader();

            List<E_Autobuses> Listar = new List<E_Autobuses>();
            while (LeerFilas.Read())
            {
                Listar.Add(new E_Autobuses
                {
                    Id_Autobus = LeerFilas.GetInt32(0),
                    Placa = LeerFilas.GetString(1),
                    Marca = LeerFilas.GetString(2),
                    Modelo = LeerFilas.GetString(3),
                    Color = LeerFilas.GetString(4),
                    Año = LeerFilas.GetInt32(5)

                });
            }
            conexion.Close();
            LeerFilas.Close();
            return Listar;
        }

        public void InsertarAutobus(E_Autobuses Chofer)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTAR_AUTOBUS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@PLACA", Chofer.Placa);
            cmd.Parameters.AddWithValue("@MARCA", Chofer.Marca);
            cmd.Parameters.AddWithValue("@MODELO", Chofer.Modelo);
            cmd.Parameters.AddWithValue("@COLOR", Chofer.Color);
            cmd.Parameters.AddWithValue("@AÑO", Chofer.Año);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EditarAutobus(E_Autobuses Chofer)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITAR_AUTOBUS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@ID_AUTOBUS", Chofer.Id_Autobus);
            cmd.Parameters.AddWithValue("@PLACA", Chofer.Placa);
            cmd.Parameters.AddWithValue("@MARCA", Chofer.Marca);
            cmd.Parameters.AddWithValue("@MODELO", Chofer.Modelo);
            cmd.Parameters.AddWithValue("@COLOR", Chofer.Color);
            cmd.Parameters.AddWithValue("@AÑO", Chofer.Año);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EliminarAutobus(E_Autobuses Chofer)
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINAR_AUTOBUS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@ID_AUTOBUS", Chofer.Id_Autobus);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        #endregion

        //Codigo de rutas
        #region

        public List<E_Autobuses> ListarRuta(string buscar)
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_BUSCAR_RUTA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@RUTA", buscar);
            LeerFilas = cmd.ExecuteReader();

            List<E_Autobuses> Listar = new List<E_Autobuses>();
            while (LeerFilas.Read())
            {
                Listar.Add(new E_Autobuses
                {
                    Id_Rutas = LeerFilas.GetInt32(0),
                    Nombre_Ruta = LeerFilas.GetString(1)
                });
            }
            conexion.Close();
            LeerFilas.Close();
            return Listar;
        }

        public void InsertarRuta(E_Autobuses Chofer)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTAR_RUTA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@NOMBRE", Chofer.Nombre_Ruta);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EditarRuta(E_Autobuses Chofer)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITAR_RUTA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@ID_RUTA", Chofer.Id_Rutas);
            cmd.Parameters.AddWithValue("@RUTA", Chofer.Nombre_Ruta);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EliminarRuta(E_Autobuses Chofer)
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINAR_RUTA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@ID_RUTA", Chofer.Id_Rutas);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        #endregion

        //Codigo de Iniciar y Finalizar viaje
        #region
        public List<C_IniciarViaje> ListarViaje(string buscar)
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_BUSCAR_VIAJE", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@BUSCAR", buscar);
            LeerFilas = cmd.ExecuteReader();

            List<C_IniciarViaje> Listar = new List<C_IniciarViaje>();
            while (LeerFilas.Read())
            {
                Listar.Add(new C_IniciarViaje
                {
                    Id_Viaje = LeerFilas.GetInt32(0),
                    Chofer = LeerFilas.GetString(1),
                    Autobus = LeerFilas.GetString(2),
                    Ruta = LeerFilas.GetString(3)
                });
            }
            conexion.Close();
            LeerFilas.Close();
            return Listar;
        }
        public void InsertarViaje(C_IniciarViaje Chofer)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTAR_VIAJE", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@CHOFER", Chofer.Chofer);
            cmd.Parameters.AddWithValue("@AUTOBUS", Chofer.Autobus);
            cmd.Parameters.AddWithValue("@RUTA", Chofer.Ruta);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public DataTable ComboBoxChofer()
        {
            SqlDataAdapter cmd = new SqlDataAdapter("SP_CARGAR_CHOFER", conexion);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            return dt;
        }

        public DataTable ComboBoxAutobus()
        {
            SqlDataAdapter cmd = new SqlDataAdapter("SP_CARGAR_AUTOBUS", conexion);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            return dt;
        }

        public DataTable ComboBoxRuta()
        {
            SqlDataAdapter cmd = new SqlDataAdapter("SP_CARGAR_RUTA", conexion);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            return dt;
        }

        public void DispoChofer(C_IniciarViaje Chofer)
        {
            SqlCommand cmd = new SqlCommand("SP_DISPO_CHOFER", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@NOMBRE", Chofer.Chofer);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void DispoAutobus(C_IniciarViaje Chofer)
        {
            SqlCommand cmd = new SqlCommand("SP_DISPO_AUTOBUS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@PLACA", Chofer.Autobus);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void DispoRuta(C_IniciarViaje Chofer)
        {
            SqlCommand cmd = new SqlCommand("SP_DISPO_RUTAS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@RUTA", Chofer.Ruta);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EliminarViaje(C_IniciarViaje Chofer)
        {
            SqlCommand cmd = new SqlCommand("SP_FINALIZAR_VIAJE", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@ID_VIAJE", Chofer.Id_Viaje);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void DispoChoferV(C_IniciarViaje Chofer)
        {
            SqlCommand cmd = new SqlCommand("SP_DISPO_CHOFERV", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@NOMBRE", Chofer.Chofer);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public void DispoAutobusV(C_IniciarViaje Chofer)
        {
            SqlCommand cmd = new SqlCommand("SP_DISPO_AUTOBUS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@PLACA", Chofer.Autobus);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public void DispoRutaV(C_IniciarViaje Chofer)
        {
            SqlCommand cmd = new SqlCommand("SP_DISPO_RUTAS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@RUTA", Chofer.Ruta);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        #endregion
    }
}
    
