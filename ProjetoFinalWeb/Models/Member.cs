// Models/Member.cs
namespace ProjetoFinalWeb.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string ImageUrl { get; set; }
        public int ArtistId { get; set; }
        public Artist Artist { get; set; }
    }
}