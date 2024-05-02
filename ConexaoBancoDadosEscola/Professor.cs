public class Professor
{
    public int IdProfessor { get; set; }
    public string Nome { get; set; }
    // Chave estrangeira para a disciplina
    public int IdDisciplina { get; set; }
    public Disciplina Disciplina { get; set; }
}