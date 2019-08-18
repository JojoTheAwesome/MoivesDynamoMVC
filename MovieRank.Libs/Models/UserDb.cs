using Amazon.DynamoDBv2.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRank.Libs.Models {
    [DynamoDBTable("MovieUsers")]
    public class UserDb {
        [DynamoDBHashKey]
        public int UserId { get; set; }
        [DynamoDBGlobalSecondaryIndexHashKey]
        public string Username { get; set; }
        public string Password { get; set; }
        public Boolean IsAdmin { get; set; }
    }
}
