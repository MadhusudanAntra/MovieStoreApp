﻿namespace MovieStoreApp.WebMVC.Models
{
    public class MovieModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ReleaseDate { get; set; }
        public int Duration { get; set; }
        public string Description { get; set; }
        public string PosterUrl { get; set; }
    }
}