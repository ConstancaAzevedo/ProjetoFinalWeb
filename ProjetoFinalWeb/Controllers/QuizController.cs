using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoFinalWeb.Data;
using ProjetoFinalWeb.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoFinalWeb.Controllers
{
    public class QuizController : Controller
    {
        private readonly ApplicationDbContext _context;

        public QuizController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Categorias para criação de quiz (mantendo sua funcionalidade original)
        public IActionResult CreateCategory()
        {
            var categories = new List<string> 
            {
                "Grupos",
                "Solistas",
                "MVs", 
                "Álbuns",
                "Curiosidades",
                "História do K-Pop"
            };
            return View(categories);
        }

        public IActionResult Create(string category)
        {
            ViewBag.Category = category;
            return View();
        }

        // Nova funcionalidade: Artistas K-Pop
        public IActionResult Artists(string type)
        {
            IQueryable<Artist> query = _context.Artists.Include(a => a.Members);

            if (!string.IsNullOrEmpty(type))
            {
                if (type.ToLower() == "group")
                {
                    query = query.Where(a => a.Type == ArtistType.Group);
                }
                else if (type.ToLower() == "soloist")
                {
                    query = query.Where(a => a.Type == ArtistType.Soloist);
                }
            }

            var artists = query.OrderBy(a => a.Name).ToList();
            return View(artists);
        }

        // Detalhes do artista
        public IActionResult ArtistDetails(int id)
        {
            var artist = _context.Artists
                .Include(a => a.Members)  
                .FirstOrDefault(a => a.Id == id);

            if (artist == null)
            {
                return NotFound();
            }

            return View(artist);
        }

        // Explorar quizzes (mantendo sua funcionalidade existente)
        public IActionResult Explore()
        {
            return View();
        }
    }
}