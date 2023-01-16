using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace AppAhorcado.AppAhorcadoBackend.Data
{
    class HelperDB
    {
        private static HelperDB instancia;
        private SqlConnection cnn;

        private HelperDB()
        {
            cnn = new SqlConnection("Data Source=DESKTOP-FU6B6SN;Initial Catalog=HANGMAN;Integrated Security=True");
        }

        public static HelperDB ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new HelperDB();
            return instancia;
        }
        public DataTable ConsultaTabla(string spNombre, List<Parámetro> listaParámetros)
        {
            DataTable dt = new DataTable();
            cnn.Open();
            SqlCommand cmd = new SqlCommand(spNombre, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            if (listaParámetros != null)
            {
                foreach (Parámetro oParametro in listaParámetros)
                {
                    cmd.Parameters.AddWithValue(oParametro.Nombre, oParametro.Valor);
                }
            }
            dt.Load(cmd.ExecuteReader());
            cnn.Close();
            return dt;
        }
        public int ConsultaEscalarConParametros(string spNombre, string pOutNombre, List<Parámetro> listaParámetros)
        {
            if (cnn != null && cnn.State == ConnectionState.Open)
                cnn.Close();
            cnn.Open();
            SqlCommand cmd = new SqlCommand(spNombre, cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            if (listaParámetros != null)
            {
                foreach (Parámetro oParametro in listaParámetros)
                {
                    cmd.Parameters.AddWithValue(oParametro.Nombre, oParametro.Valor);
                }
            }

            SqlParameter pOut = new SqlParameter();
            pOut.ParameterName = pOutNombre;
            pOut.DbType = DbType.Int32;
            pOut.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(pOut);
            cmd.ExecuteNonQuery();
            cnn.Close();
            return (int)pOut.Value;
        }
        public int EjecutarSp(string spNombre, List<Parámetro> listaParámetros)
        {
            int filasAfectadas = 0;
            SqlTransaction t = null;

            if (cnn != null && cnn.State == ConnectionState.Open)
                cnn.Close();

            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();
                SqlCommand cmd = new SqlCommand(spNombre, cnn, t);
                cmd.CommandType = CommandType.StoredProcedure;

                if (listaParámetros != null)
                {
                    foreach (Parámetro oParametro in listaParámetros)
                    {
                        cmd.Parameters.AddWithValue(oParametro.Nombre, oParametro.Valor);
                    }
                }
                filasAfectadas = cmd.ExecuteNonQuery();
                t.Commit();
            }
            catch (SqlException)
            {
                if (t != null)
                { t.Rollback(); }
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();

            }
            return filasAfectadas;
        }

        public SqlConnection ObtenerConexion()
        {
            return this.cnn;
        }
    }
}
