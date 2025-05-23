﻿// Models/Artist.cs
using System.ComponentModel.DataAnnotations;

namespace ProjetoFinalWeb.Models
{
    public class Artist
    {
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public ArtistType Type { get; set; } // Grupo ou Solista
        
        // Relação com os membros
        public ICollection<Member> Members { get; set; }
    }

    public enum ArtistType
    {
        Group,
        Soloist
    }
}