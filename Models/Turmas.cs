namespace WebApplicationeExemplo1.Models
{
    public class Turmas
    {
    public int Id { get; set; } 
    public string Name { get; set; }    
    public DateTime DataAbertura { get; set; }
    public DateTime DataFechamento { get; set; }
    public string turno { get; set; }
    public ICollection<Alunos>? Alunos { get; set; }
    
    
    }
}
