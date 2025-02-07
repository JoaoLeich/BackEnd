using System.ComponentModel.DataAnnotations;

public class Livro
{

    [Key]
    public int id { get; set; }

    public string nome { get; set; }

    public string categoria { get; set; }

    public DateTime dataPublicacao { get; set; }

}