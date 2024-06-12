using System.ComponentModel.DataAnnotations;

public class Aluno
{
    [Key]
    public string Matricula { get; set; }
    public string Nome { get; set; }
    public string DataNascimento { get; set; }
    public string Turma { get; set; }
}