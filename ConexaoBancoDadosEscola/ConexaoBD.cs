using Microsoft.EntityFrameworkCore;
public class ConexaoBD : DbContext
{
    public DbSet<Aluno> Aluno { get; set; }
    public DbSet<Professor> Professor { get; set; }
    public DbSet<Disciplina> Disciplina { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=C:\\EstudoCSharp\\ConexaoDBEscola\\BD\\EscolaBancoDados.sdb");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Aluno>().HasKey(a => a.Matricula);
        modelBuilder.Entity<Disciplina>().HasKey(d => d.IdDisciplina);
        modelBuilder.Entity<Professor>()
        .HasMany(p => p.Disciplinas)
        .WithOne(d => d.Professor)
        .HasForeignKey(d => d.ProfessorId);
    }

}