using System;
using System.Collections.Generic;

namespace Spotify2.Models
{
    public partial class List
    {
        public int Id { get; set; }
        public string? ArtistName { get; set; }
        public string? TrackId { get; set; }
        public string? TrackName { get; set; }
        public decimal? Acousticness { get; set; }
        public decimal? Danceability { get; set; }
        public string? DurationMs { get; set; }
        public decimal? Energy { get; set; }
        public decimal? Instrumentalness { get; set; }
        public string? Keyy { get; set; }
        public decimal? Liveness { get; set; }
        public decimal? Loudness { get; set; }
        public decimal? Mode { get; set; }
        public decimal? Speechiness { get; set; }
        public decimal? Tempo { get; set; }
        public string? TimeSignature { get; set; }
        public string? Valence { get; set; }
        public string? Popularity { get; set; }
    }
}
