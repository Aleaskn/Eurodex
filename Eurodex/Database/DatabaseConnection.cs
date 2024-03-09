// File per la connessione al database con la sua logica

using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

public class DatabaseConnection
{
    private readonly IConfiguration _configuration;

    public DatabaseConnection(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public SqlConnection GetDbConnection()
    {
        string connectionString = _configuration.GetConnectionString("DefaultConnection");
        return new SqlConnection(connectionString);
    }
}