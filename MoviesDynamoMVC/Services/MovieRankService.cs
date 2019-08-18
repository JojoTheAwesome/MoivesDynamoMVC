using MovieRank.Contracts;
using MovieRank.Libs.Methods;
using MovieRank.Libs.Models;
using MovieRank.Libs.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesDynamoMVC.Services {
    public class MovieRankService : IMovieRankService {
        private readonly IMovieRankRepository _movieRankRepository;
        private readonly IMapper _map;

        public MovieRankService(IMovieRankRepository movieRankRepository, IMapper map) {
            _movieRankRepository = movieRankRepository;
            _map = map;
        }

        public async Task<IEnumerable<MovieDb>> GetAllItemsFromDatabase() {
            var response = await _movieRankRepository.GetAllItems();
            //return _map.ToMovieContract(response);
            return response;
        }

        public async Task<IEnumerable<MovieResponse>> GetAllItemsForUser(int uid) {
            var response = await _movieRankRepository.GetAllItemsForUser(uid);
            return _map.ToMovieContract(response);
        }

        public async Task<MovieDb> GetMovie(int userId, string movieName) {
            var response = await _movieRankRepository.GetMovie(userId, movieName);
            //return _map.ToMovieContract(response);
            return response;
        }

        public async Task AddMovie(int userId, MovieRankRequest movieRankRequest) {
            var movieDb = _map.ToMovieDbModel(userId, movieRankRequest);
            await _movieRankRepository.AddMovie(movieDb);
        }

        public async Task UpdateMovie(int userId, MovieUpdateRequest request) {
            var response = await _movieRankRepository.GetMovie(userId, request.MovieName);
            var movieDb = _map.ToMovieDbModel(userId, response, request);
            await _movieRankRepository.UpdateMovie(movieDb);
        }

        public async Task DeleteMovie(MovieDb movie) {
            await _movieRankRepository.DeleteMovie(movie);
        }
    }
}
