namespace WebApplicationeExemplo1.Models
{
    public class Unidade_Medida
    {
    
    public int id { get; set; }
    public string sigla { get; set; }
    public string nomeExtenso { get; set; }
    public ICollection<Produtos>? produtos { get; set; }
    }
}
