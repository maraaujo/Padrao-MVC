using MySql.Data.MySqlClient;
using ProvaA1.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaA1.DAL
{
    public class BicicletaDAL
    {
        private string connectionString = "Host=localhost;Database=provaA1;Username=root;Password=irmaos03;Convert Zero Datetime=True";

        public void Create(Bicicleta bicicleta)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Bicicleta (bicNome, bicTipo) VALUES (@Nome, @Tipo)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nome", bicicleta.BicNome);
                cmd.Parameters.AddWithValue("@Tipo", bicicleta.BicTipo);
                cmd.ExecuteNonQuery();
            }
        }
        public List<Bicicleta> Get()
        {
            List<Bicicleta> bicicletas = new List<Bicicleta>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Bicicleta";
                MySqlCommand cmd = new MySqlCommand(query, conn); //criar a querry na connectionString
                using (MySqlDataReader ler = cmd.ExecuteReader())
                {
                    while (ler.Read())
                    {
                        Bicicleta bicicleta = new Bicicleta
                        {
                            BicID = ler.GetInt32(0),
                            BicNome = ler.GetString("bicNome"),
                            BicTipo = ler.GetString("bicTipo")
                        };
                        bicicletas.Add(bicicleta);
                    }
                }
                return bicicletas;
            }

        }

        public void Update(Bicicleta bicicleta)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Bicicleta SET bicNome = @Nome, bicTipo = @Tipo WHERE bicId= @ID ";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", bicicleta.BicID);
                cmd.Parameters.AddWithValue("@Nome", bicicleta.BicNome);
                cmd.Parameters.AddWithValue("@Tipo", bicicleta.BicTipo);
                cmd.ExecuteNonQuery();
            }
        }
        public void Delete(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Bicicleta WHERE bicID = @ID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
