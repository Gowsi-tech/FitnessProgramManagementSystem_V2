using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProgramManagementSystem_V2
{
    internal class FitnessProgramRepository
    {
        string ConnectionString = "server=(localdb)\\MSSQLLocalDB; Database=FitnessProgramManagement; Trusted_connection= True; TrustServerCertificate=True";

        public void createprogram(int FitnessProgramId, string Title, string Duration, decimal Price)
        {
            string insertQuery = @"
                        INSERT INTO FitnessPrograms(FitnessProgramId, Title, Duration, Price) VALUES (@FitnessProgramId,@Title,@Duration, @Price)";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.ExecuteNonQuery();
                }

            }
        }

    }
}
