using MovieRank.Contracts;
using MovieRank.Libs.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MoviesDynamoMVC.Services {
    public interface IMovieRankService {
        Task<IEnumerable<MovieDb>> GetAllItemsFromDatabase();
        Task<IEnumerable<MovieResponse>> GetAllItemsForUser(int uid);
        Task<MovieDb> GetMovie(int userId, string movieName);
        Task AddMovie(int userId, MovieRankRequest movieRankRequest);
        Task UpdateMovie(int userId, MovieUpdateRequest request);
        Task DeleteMovie(MovieDb movie);
    }
}
