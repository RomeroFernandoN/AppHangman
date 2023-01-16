using AppAhorcado.AppAhorcadoBackend.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using AppAhorcado.AppAhorcadoBackend.Data;

namespace AppAhorcado.AppAhorcadoBackend.Implementation
{
    class AppAhorcadoDao : IAppAhorcadoDao 
    {
        public void ChangeImage(int attempt, PictureBox picBox)
        {
            switch (attempt)
            {
                case 6:
                    picBox.BackgroundImage = Properties.Resources._6Points;
                    picBox.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case 5:
                    picBox.BackgroundImage = Properties.Resources._5Points;
                    picBox.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case 4:
                    picBox.BackgroundImage = Properties.Resources._4Points;
                    picBox.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case 3:
                    picBox.BackgroundImage = Properties.Resources._3Points;
                    picBox.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case 2:
                    picBox.BackgroundImage = Properties.Resources._2Points;
                    picBox.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case 1:
                    picBox.BackgroundImage = Properties.Resources._1Points;
                    picBox.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case 0:
                    picBox.BackgroundImage = Properties.Resources._0Points;
                    picBox.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
            }
        }
        public string AvailableWords()
        {
            string[] array = new string[] { "hola", "chau", "comida", "auto", "casa" };

            Random rnd = new Random();
            int val = rnd.Next(0, 4);
            string cadena = array[val];

            return cadena;
        }
        public int AccountantLetters(int amount, string letter, List<char> list)
        {
            int counter = 0;
            for (int i = 0; i < amount; i++)
            {
                if (list[i].ToString() == letter)
                {
                    counter = counter + 1;
                }
            }
            return counter;
        }
        public List<(int, List<string>, bool)> Repeated(string letter, List<string> lettersRepeated)
        {
            bool repeated = false;
            int counter = 1;

            if (lettersRepeated.Count == 0)
            {
                lettersRepeated.Add(letter);
                counter = counter - 1;
            }

            if (lettersRepeated.Count >= 1)
            {

                for (int i = 0; i < lettersRepeated.Count; i++)
                {
                    if (lettersRepeated[i].ToString() == letter)
                    {
                        counter = counter + 1;
                    }
                    else
                    {
                        lettersRepeated.Add(letter);
                        counter = counter - 1;
                    }
                }
            }

            if (counter > 1)
            {
                repeated = true;
            }

            var list = new List<(int count, List<string> letters, bool repeat)>();
            list.Add((count : counter, letters : lettersRepeated, repeat : repeated));

            return list;
        }

        public bool CountLetters(List<string> combinedList)
        {
            bool count = true;
            foreach (string item in combinedList)
            {
                if (item.Equals("_"))
                {
                    count = false;
                    break;
                }
            }
            return count;
        }

        public bool UploadScore(int attemp, string email)
        {
             int points = 0;
             switch (attemp)
             {
                 case 5:
                     points = 500;
                     break;
                 case 4:
                     points = 400;
                     break;
                 case 3:
                     points = 300;
                     break;
                 case 2:
                     points = 200;
                     break;
                 case 1:
                     points = 100;
                     break;
            }

            bool aux = true;
            SqlConnection cnn = HelperDB.ObtenerInstancia().ObtenerConexion();
            SqlTransaction t = null;

            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();

                SqlCommand cmdUploadScore = new SqlCommand("SP_PUNCTUATION", cnn, t);
                cmdUploadScore.CommandType = CommandType.StoredProcedure;
                cmdUploadScore.Parameters.AddWithValue("@EMAIL", email);
                cmdUploadScore.Parameters.AddWithValue("@PUNCTUATION", points);
                cmdUploadScore.ExecuteNonQuery();

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

        public DataTable BestScores()
        {
            DataTable dt = HelperDB.ObtenerInstancia().ConsultaTabla("SP_BEST_SCORES",null);
            return dt;
        }
    }
}
