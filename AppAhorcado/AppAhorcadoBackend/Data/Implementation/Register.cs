using AppAhorcado.AppAhorcadoBackend.Data.Interface;
using AppAhorcado.AppAhorcadoBackend.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace AppAhorcado.AppAhorcadoBackend.Data.Implementation
{
    class Register : IRegister
    {
        public bool InsertUser(User oUser)
        {
            bool aux = true;
            SqlConnection cnn = HelperDB.ObtenerInstancia().ObtenerConexion();
            SqlTransaction t = null;

            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();

                SqlCommand cmdUser = new SqlCommand("SP_INSERT_USER", cnn, t);
                cmdUser.CommandType = CommandType.StoredProcedure;
                cmdUser.Parameters.AddWithValue("@NAME",oUser.Name);
                cmdUser.Parameters.AddWithValue("@SURNAME",oUser.Surname);
                cmdUser.Parameters.AddWithValue("@EMAIL",oUser.Email);
                cmdUser.Parameters.AddWithValue("@BIRTHDATE",oUser.Birthdate);
                cmdUser.Parameters.AddWithValue("@PUNCTUATION",oUser.Points);
                cmdUser.Parameters.AddWithValue("@COUNTRY", oUser.Country);
                cmdUser.ExecuteNonQuery();

                t.Commit();
            }
            catch (Exception)
            {
                if (t != null)
                    t.Rollback();
                aux = false;
            }

            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return aux;
        }
    }
}
