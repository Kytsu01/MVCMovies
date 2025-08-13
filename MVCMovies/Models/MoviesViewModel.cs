using Microsoft.AspNetCore.Mvc.Rendering;

namespace MVCMovies.Models
{
    public class MoviesViewModel
    {

        public List<Movies> ? Movies;
        public SelectList? Genders;

        public string? Gender;
        public string? Text;
    }
}
