using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class BonusNegocio
    {
        public List<Bonus> listar ()
        {
            List<Bonus> lista = new List<Bonus>();
            SqlConnection conexion = new SqlConnection ();
            SqlCommand comando = new SqlCommand ();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=BonusHunt_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select Id, Nombre, MaxWin, Bet, Multi, Win, Activo from ListaBonus";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Bonus aux = new Bonus ();
                    aux.Id = (int)lector["Id"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Bet = (double)lector["Bet"];
                    aux.Multi = (double)lector["Multi"];
                    aux.Win = (double)lector["Win"];
                    aux.MaxWin = (double)lector["MaxWin"];
                    aux.Activo = bool.Parse(lector["Activo"].ToString());

                    lista.Add(aux);

                }
                conexion.Close ();
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Bonus> listarActivos()
        {
            List<Bonus> lista = new List<Bonus>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand ();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=BonusHunt_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select ID, Nombre, MaxWin, Bet, Multi, Win, Activo from ListaBonus where Activo = 1";
                comando.Connection = conexion;

                conexion.Open ();
                lector = comando.ExecuteReader ();

                while (lector.Read ())
                {
                    Bonus aux = new Bonus();
                    double multiAux = 0;
                    double maxAux = 0;
                    aux.Id = (int)lector["ID"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.MaxWin = (double)lector["MaxWin"];
                    aux.Bet = (double)lector["bet"];
                    aux.Win = (double)lector["Win"];
                    aux.Activo = bool.Parse(lector["Activo"].ToString());
                    
                    if(aux.Win > 0)
                    {
                        multiAux = aux.Win / aux.Bet;
                        aux.Multi = (double)multiAux;

                    }

                    if (aux.Win > aux.MaxWin)
                    {
                        aux.MaxWin = aux.Win;
                    }

                    lista.Add(aux);
                }
                conexion.Close ();
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void Agregar(Bonus nuevo)
        {
            AccesoDatos datos = new AccesoDatos ();

            try
            {
                datos.setearConsulta("Insert into ListaBonus (Nombre) values (@Nombre)");
                datos.setearParametros("@Nombre", nuevo.Nombre);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void activarBonus(Bonus nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update ListaBonus set Activo = 1 where ID = @ID");
                datos.setearParametros("@ID", nuevo.Id);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion ();
            }
        }

        public void modificar(Bonus nuevo, double bet, double win)
        {
            AccesoDatos datos = new AccesoDatos();
            nuevo.Bet = bet;
            nuevo.Win = win;
            
            try
            {
                datos.setearConsulta("update ListaBonus set Bet = @bet, Win = @win where ID = @id");
                datos.setearParametros("@bet", nuevo.Bet);
                datos.setearParametros("@win", nuevo.Win);
                datos.setearParametros("@id", nuevo.Id);
                

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion ();
            }
        }
    }
}
