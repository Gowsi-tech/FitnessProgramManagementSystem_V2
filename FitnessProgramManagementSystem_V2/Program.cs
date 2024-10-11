using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProgramManagementSystem_V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string masterDbConnectionString = "server=(localdb)\\MSSQLLocalDB; Database=master; Trusted_connection= True; TrustServerCertificate=True";
            string fitnessDbConnectionString = "server=(localdb)\\MSSQLLocalDB; Database=FitnessProgramManagement; Trusted_connection= True; TrustServerCertificate=True";

            string databaseQuery = @"
                            IF NOT EXISTS(SELECT * FROM master
                            CREATE DATABASE FitnessProgramManagement)";

            string tableQuery = @"
                        IF NOT EXISTS(SELECT * FORM MASTRE
                            CREATE TABLE FitnessPrograms 
                            	FitnessProgramId INT IDENTITY (1,1) PRIMARY KEY
                                Title nvarchar(50) NOT NULL
                                 Duration nvarchar(50) NOT NULL
                                 Price DECIMAL(10,2) )";

            string insertQuery = @"
                SELECT * FROM FitnessPrograms(FitnessProgramId,Title,Duration,Price) VALUES (' weight Training' , '6 months',  10 ) ";
        }
    }
}
