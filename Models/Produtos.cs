namespace WebApplicationeExemplo1.Models
{
    public class Produtos
    {
     public int Id { get; set; }
     public string nome { get; set;}
     public string descricao { get; set;}
     public string estoque { get; set;}
     public string preco_unitario { get; set; }
     public int unidade_medida { get; set; }
     public Turmas turmas { get; set; }
    }
}
