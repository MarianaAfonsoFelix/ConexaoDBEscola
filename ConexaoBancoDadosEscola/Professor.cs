using System.ComponentModel.DataAnnotations;

public class Professor
{
    [Key]
    public int IdProfessor { get; set; }
    public string Nome { get; set; }
    // Chave estrangeira para a disciplina
    public ICollection<Disciplina> Disciplinas { get; set; }
}