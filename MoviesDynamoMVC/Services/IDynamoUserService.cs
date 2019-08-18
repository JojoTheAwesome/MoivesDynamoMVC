using MovieRank.Libs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesDynamoMVC.Services {
    public interface IDynamoUserService {
        Task<IEnumerable<UserDb>> GetAllItemsFromDatabase();
        Task<UserDb> GetUser(int userId, string username);
        Task DeleteUser(UserDb user);
        Task AddUser(int userId, UserDb userDb);
        Task<int> GetRowCount();
    }
}
