using EpiServerProject.Models;

namespace EpiServerProject.Business.Services;

public interface IMovieService
{
    Task<List<MovieDetails>> GetMovieWithDetailsAsync(string query);
}
