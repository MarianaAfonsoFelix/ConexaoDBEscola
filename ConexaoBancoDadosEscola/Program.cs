using (var context = new ConexaoBD())
{
    // Consultando alunbos
    var alunos = context.Aluno.ToList();
    foreach (var aluno in alunos)
    {
        Console.WriteLine($"Aluno: {aluno.Nome}, Turma: {aluno.Turma}");
    }
}