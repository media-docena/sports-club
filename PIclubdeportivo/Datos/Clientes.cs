using MySql.Data.MySqlClient;
using PIclubdeportivo.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIclubdeportivo.Datos
{
    internal class Clientes
    {
        public string Nuevo_Cliente(E_Cliente cliente)
        {
            string? salida;

            MySqlConnection sqlCon = new MySqlConnection();
            try {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("NuevoCliente", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("Nom", MySqlDbType.VarChar).Value = cliente.NombreC;
                comando.Parameters.Add("Ape", MySqlDbType.VarChar).Value = cliente.ApellidoC;
                comando.Parameters.Add("DNI", MySqlDbType.VarChar).Value = cliente.DniC;
                comando.Parameters.Add("Tel", MySqlDbType.VarChar).Value = cliente.TelC;
                comando.Parameters.Add("Correo", MySqlDbType.VarChar).Value = cliente.CorreoC;
                comando.Parameters.Add("Tipo", MySqlDbType.VarChar).Value = cliente.TipoC;

                MySqlParameter parCodigo = new MySqlParameter();
                parCodigo.ParameterName = "rta";
                parCodigo.MySqlDbType = MySqlDbType.Int32;
                parCodigo.Direction = ParameterDirection.Output;
                comando.Parameters.Add(parCodigo);
                sqlCon.Open();
                comando.ExecuteNonQuery();
                salida = Convert.ToString(parCodigo.Value);
            }
            catch (Exception ex) {
                salida = ex.Message;
            }
            // como proceso final
            finally 
            {
                if (sqlCon.State == ConnectionState.Open) 
                { 
                    sqlCon.Close(); 
                }
            }
            return salida;
        }
    }
}
