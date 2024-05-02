using Microsoft.Data.Sqlite;
public class ConexaoBD
{
    private SqliteConnection _connectionString;

    public ConexaoBD(string connectionString)
    {
        _connectionString = new SqliteConnection(connectionString);
    }

    public void AbrirConexao()
    {
        _connectionString.Open();
    }

    public void FecharConexao()
    {
        _connectionString.Close();
    }

    public SqliteCommand ExecucaoComandos()
    {
        return _connectionString.CreateCommand();
    }
}