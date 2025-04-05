namespace ProjetoFinalWeb.Models;

public class Groups
{
    public int Id { get; set; }
    public string Name { get; set; }
    
    // Relação 1-para-muitos (um grupo pode ter vários membros)
    public ICollection<Member> Members { get; set; }
    
    // Outras propriedades...
}