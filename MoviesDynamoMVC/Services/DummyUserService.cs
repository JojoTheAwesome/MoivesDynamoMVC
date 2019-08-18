using MovieRank.Libs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesDynamoMVC.Services {
    public class DummyUserService : IUserService{
        private IDictionary<string, (string PasswordHash, User User)> _users = new Dictionary<string, (string PasswordHash, User User)>();
        public DummyUserService(IDictionary<string, string> users) {
            foreach(var user in users) {
                _users.Add(user.Key.ToLower(), (BCrypt.Net.BCrypt.HashPassword(user.Value), new User(user.Key)));
            }
        }
        //username in all lower case (bcrypt hashed password, new User(username))
        public Task<bool> ValidateCredentials(string username, string password, IDictionary<string, string> _dynamoUsers, out User user) {
            user = null;
            IDictionary<string, (string PasswordHash, User User)> dynamoUsers = new Dictionary<string, (string PasswordHash, User User)>();
            foreach(var duser in _dynamoUsers) {
                dynamoUsers.Add(duser.Key.ToLower(), (BCrypt.Net.BCrypt.HashPassword(duser.Value), new User(duser.Key)));
            }
            var key = username.ToLower();
            
            if (dynamoUsers.ContainsKey(key)) {
                var hash = dynamoUsers[key].PasswordHash;
                if(BCrypt.Net.BCrypt.Verify(password, hash)) {
                    user = dynamoUsers[key].User;
                    return Task.FromResult(true);
                }
            }
            return Task.FromResult(false);
        }

        public Task<bool> AddUser(string username, string password) {
            if (_users.ContainsKey(username.ToLower())){
                return Task.FromResult(false);
            }
            _users.Add(username.ToLower(), (BCrypt.Net.BCrypt.HashPassword(password), new User(username)));
            return Task.FromResult(true);
        }
    }
}
