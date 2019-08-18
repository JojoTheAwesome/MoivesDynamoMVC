using MovieRank.Libs.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieRank.Libs.Repositories {
    public interface IMovieUserRepository {
        Task<IEnumerable<UserDb>> GetAllItems();
        Task<UserDb> GetUser(int userId, string username);
        Task AddUser(UserDb userDb);
        Task UpdateUser(UserDb request);
        Task DeleteUser(UserDb request);
        Task<int> GetRowCount();
    }
}
