using MovieRank.Contracts;
using MovieRank.Libs.Methods;
using MovieRank.Libs.Models;
using MovieRank.Libs.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesDynamoMVC.Services {
    public class DynamoUserService : IDynamoUserService{
        private readonly IMovieUserRepository _userRepository;
        private readonly IMapper _map;

        public DynamoUserService(IMovieUserRepository userRepository, IMapper map) {
            _userRepository = userRepository;
            _map = map;
        }

        public async Task<IEnumerable<UserDb>> GetAllItemsFromDatabase() {
            var response = await _userRepository.GetAllItems();
            //return _map.ToMovieContract(response);
            return response;
        }

       public async Task<int> GetRowCount() {
            var response = await _userRepository.GetRowCount();
            return response;
        }

        public async Task<UserDb> GetUser(int userId, string username) {
            var response = await _userRepository.GetUser(userId, username);
            //return _map.ToMovieContract(response);
            return response;
        }

        // NEED TO FIX THIS AT SOME POINT.
        public async Task AddUser(int userId, UserDb userDb) {
            //var userDb = _map.ToUserDbModel(userId, userRequest);
            await _userRepository.AddUser(userDb);
        }
        /*
        public async Task UpdateMovie(int userId, MovieUpdateRequest request) {
            var response = await _movieRankRepository.GetMovie(userId, request.MovieName);
            var movieDb = _map.ToMovieDbModel(userId, response, request);
            await _movieRankRepository.UpdateMovie(movieDb);
        }*/

        public async Task DeleteUser(UserDb user) {
            await _userRepository.DeleteUser(user);
        }
    }
}
