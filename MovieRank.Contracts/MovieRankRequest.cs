using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRank.Contracts {
    public class MovieRankRequest {
        public string MovieName { get; set; }
        public string Description { get; set; }
        public string MainActor { get; set; }
        public int Ranking { get; set; }
    }
}
