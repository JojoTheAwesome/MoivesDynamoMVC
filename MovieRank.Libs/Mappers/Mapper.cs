using MovieRank.Contracts;
using MovieRank.Libs.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieRank.Libs.Methods {
    public class Mapper :IMapper{
        public IEnumerable<MovieResponse> ToMovieContract(IEnumerable<MovieDb> items) {
            return items.Select(ToMovieContract);
        }

        public MovieResponse ToMovieContract(MovieDb movie) {
            return new MovieResponse {
                MovieName = movie.MovieName,
                Description = movie.Description,
                MainActor = movie.MainActor,
                Ranking = movie.Ranking,
                TimeRanked = movie.RankedDateTime
            };
        }

        public MovieDb ToMovieDbModel(int userId, MovieRankRequest movieRankRequest) {
            return new MovieDb {
                UserId = userId,
                MovieName = movieRankRequest.MovieName,
                Description = movieRankRequest.Description,
                MainActor = movieRankRequest.MainActor,
                Ranking = movieRankRequest.Ranking,
                RankedDateTime = DateTime.UtcNow.ToString()
            };
        }

        public MovieDb ToMovieDbModel(int userId, MovieDb movieDbRequest, MovieUpdateRequest movieUpdateRequest) {
            return new MovieDb {
                UserId = movieDbRequest.UserId,
                MovieName = movieDbRequest.MovieName,
                Description = movieDbRequest.Description,
                MainActor = movieDbRequest.MainActor,
                Ranking = movieUpdateRequest.Ranking,
                RankedDateTime = DateTime.UtcNow.ToString()
            };
        }
    }
}
