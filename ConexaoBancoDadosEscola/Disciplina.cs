using System.ComponentModel.DataAnnotations;

public class Disciplina
{
    [Key]
    public int IdDisciplina { get; set; }
    public string Nome { get; set; }

    // Esta é a chave estrangeira para a relação de um para muitos
    public int ProfessorId { get; set; }

    // Esta é a propriedade de navegação para a relação de um para muitos
    public Professor Professor { get; set; }
}