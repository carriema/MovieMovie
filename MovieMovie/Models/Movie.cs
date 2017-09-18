using System;
namespace MovieMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public String Genre { get; set; }
        public DateTime? Releasedate { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
