//using Microsoft.Data.Sqlite;

//public class AlunoRepository
//{
//    private ConexaoBD _connector;

//    public AlunoRepository(ConexaoBD connector)
//    {
//        _connector = connector;
//    }
// s
//    public void InserirAluno(Aluno aluno)
//    {
//        _connector.AbrirConexao();
//        var command = _connector.ExecucaoComandos();
//        command.CommandText = "INSERT INTO Aluno (Matricula, Nome, DataNascimento, Turma) VALUES (@matricula, @nome, @dataNascimento, @turma)";
//        command.Parameters.AddWithValue("@matricula", aluno.Matricula);
//        command.Parameters.AddWithValue("@nome", aluno.Nome);
//        command.Parameters.AddWithValue("@dataNascimento", aluno.DataNascimento);
//        command.Parameters.AddWithValue("@turma", aluno.Turma);
//        command.ExecuteNonQuery();
//        _connector.FecharConexao();
//    }
//    public List<Aluno> ObterTodosAlunos()
//    {
//        _connector.AbrirConexao();
//        var command = _connector.ExecucaoComandos();
//        command.CommandText = "SELECT Matricula, Nome, DataNascimento, Turma FROM Aluno";
//        var reader = command.ExecuteReader();
//        var aluno = new List<Aluno>();
//        while (reader.Read())
//        {
//            aluno.Add(new Aluno
//            {
//                Matricula = reader.GetString(0),
//                Nome = reader.GetString(1),
//                DataNascimento = reader.GetString(2),
//                Turma = reader.GetString(3),
//            });
//        }
//        _connector.FecharConexao();
//        return aluno;
//    }

//    public Aluno ObterAluno(string matricula)
//    {
//        _connector.AbrirConexao();
//        var command = _connector.ExecucaoComandos();
//        command.CommandText = "SELECT Matricula, Nome, DataNascimento, Turma FROM Aluno WHERE Matricula = @matricula";
//        command.Parameters.AddWithValue("@matricula", matricula);
//        var reader = command.ExecuteReader();
//        var aluno = new Aluno();
//        while (reader.Read())
//        {
//            aluno.Matricula = reader.GetString(0);
//            aluno.Nome = reader.GetString(1);
//            aluno.DataNascimento = reader.GetString(2);
//            aluno.Turma = reader.GetString(3);
//        }
//        _connector.FecharConexao();
//        return aluno;
//    }

//}
