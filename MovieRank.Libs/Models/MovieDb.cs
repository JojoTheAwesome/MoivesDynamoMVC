using Amazon.DynamoDBv2.DataModel;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieRank.Libs.Models {
    [DynamoDBTable("MovieRank")]
    public class MovieDb{
        [DynamoDBHashKey]
        public int UserId { get; set; }
        [DynamoDBGlobalSecondaryIndexHashKey]
        public string MovieName { get; set; }
        public string Description { get; set; }
        public string MainActor { get; set; }
        [Range(1,10)]
        public int Ranking { get; set; }
        public string RankedDateTime { get; set; }
    }
}