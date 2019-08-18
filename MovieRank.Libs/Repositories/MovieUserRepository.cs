using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using System.Collections.Generic;
using System.Threading.Tasks;
using MovieRank.Libs.Models;
using Amazon.DynamoDBv2.DocumentModel;

namespace MovieRank.Libs.Repositories {
    public class MovieUserRepository : IMovieUserRepository {
        private readonly DynamoDBContext _context;

        // The client was set up in our startup class.
        public MovieUserRepository(IAmazonDynamoDB dynamoDbClient) {
            _context = new DynamoDBContext(dynamoDbClient);
        }

        public async Task<IEnumerable<UserDb>> GetAllItems() {
            return await _context.ScanAsync<UserDb>(new List<ScanCondition>()).GetRemainingAsync();
        }

        public async Task<int> GetRowCount() {
            List<UserDb> list =  await _context.ScanAsync<UserDb>(new List<ScanCondition>()).GetRemainingAsync();
            return list.Count;
        }

        public async Task<UserDb> GetUser(int userId, string username) {
            return await _context.LoadAsync<UserDb>(userId, username);
        }

        public async Task AddUser(UserDb userDb) {
            await _context.SaveAsync(userDb);
        }

        public async Task UpdateUser(UserDb request) {
            await _context.SaveAsync(request);
        }


        public async Task DeleteUser(UserDb request) {
            await _context.DeleteAsync(request);
        }
    }
}
