namespace WebApplicationeExemplo1.Models
{
    public class Alunos
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Turmas turmas { get; set; }
        public int numero { get; set; }
        public string email { get; set; }

    }
}
