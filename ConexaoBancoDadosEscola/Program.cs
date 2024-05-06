using Microsoft.Data.Sqlite;

var connectionString = "Data Source=C:\\EstudoCSharp\\ConexaoDBEscola\\BD\\EscolaBancoDados.sdb";
var conexao = new ConexaoBD(connectionString);
var repositoryAluno = new AlunoRepository(conexao);


repositoryAluno.InserirAluno(new Aluno { Nome = "Edson", Turma = "3B", DataNascimento= "14/01/2000", Matricula="15084874" });


var alunos = repositoryAluno.ObterTodosAlunos();
foreach (var aluno in alunos)
{
    Console.WriteLine($"Matricula: {aluno.Matricula}, Nome: {aluno.Nome}, Turma: {aluno.Turma}, Data de Nascimento: {aluno.DataNascimento}");
}