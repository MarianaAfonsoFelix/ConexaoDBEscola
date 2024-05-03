using Microsoft.Data.Sqlite;

var connectionString = "Data Source=sqlite.db";
var conexao = new SqliteConnection(connectionString);
var repositoryAluno = new AlunoRepository(conexao);


repositoryAluno.InserirAluno(new Aluno { Nome = "Jessica", Turma = "2B", DataNascimento= "02/05/1995", Matricula="5550" });


var alunos = repositoryAluno.ObterTodasAlunos();
foreach (var aluno in alunos)
{
    Console.WriteLine($"Matricula: {aluno.Matricula}, Nome: {aluno.Nome}, Turma: {aluno.Turma}, Data de Nascimento: {aluno.DataNascimento}");
}