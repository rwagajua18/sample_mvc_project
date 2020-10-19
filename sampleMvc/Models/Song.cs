using System.ComponentModel.DataAnnotations;
using System;

namespace sampleMvc.Models
{
    public class Song
    {
        public int Id { get; set; }

        public string Title { get; set; }

        //[Display(Name =  "Release Date")]
        public double Duration { get; set; }

        public string Genre { get; set; }

        public string  ArtistName { get; set; }

        public string Album { get; set; }
    }
}