using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kviz
{
    internal class PristupPodacima
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["DB_Kviz"].ConnectionString;
        public static List<Model> getDataFromDB()
        {
             

        List<Model> QAndA = new List<Model>();

            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "select * from `KVIZ`";
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    QAndA.Add(new Model()
                    {
                        RedniBroj = reader.GetInt32(0),
                        Pitanje = reader.GetString(1),
                        Odgovor1 = reader.GetString(2),
                        Odgovor2 = reader.GetString(3),
                        Odgovor3 = reader.GetString(4),
                        Odgovor4 = reader.GetString(5),
                        TacanOdgovor = reader.GetString(6)

                    });
                }
                conn.Close();
                reader.Close();

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { conn.Close(); }

            return QAndA;
        }

        public static String getCorrectAnswer(int redniBroj)
        {
            String correctAnswer = "";

            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "select * from `KVIZ` where RedniBrojPitanja=@redniBroj";
                cmd.Parameters.AddWithValue("@redniBroj", redniBroj);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    correctAnswer = reader.GetString(6);
                }
                conn.Close();
                reader.Close();

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { conn.Close(); }

            return correctAnswer;
        }

        public static String getQuestion(int redniBroj)
        {
            String question = "";

            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "select * from `KVIZ` where RedniBrojPitanja=@redniBroj";
                cmd.Parameters.AddWithValue("@redniBroj", redniBroj);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    question = reader.GetString(1);
                }
                conn.Close();
                reader.Close();

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { conn.Close(); }

            return question;
        }


    }
}
