using MovieRank.Libs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesDynamoMVC.Services {
    public interface IUserService {
        Task<bool> ValidateCredentials(string username, string password, IDictionary<string, string> dynamoUsers, out User user);
        Task<bool> AddUser(string username, string password);
    }

    public class User {
        public User(string username) {
            Username = username;
        }

        public string Username { get; }
    }
}
