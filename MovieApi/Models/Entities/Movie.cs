﻿namespace MovieApi.Models.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public int Year { get; set; }
        public string Genre { get; set; } = null!;
        public int Duration { get; set; } // Duration in minutes
        public MovieDetails MovieDetails { get; set; } = null!;
        public ICollection<Review> Reviews { get; set; } = [];
        public ICollection<Actor> Actors { get; set; } = [];
    }
}
