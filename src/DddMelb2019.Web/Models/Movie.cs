using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DddMelb2019.Web.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }
        public string Title { get; set; }
        public DateTime DateOfRelease { get; set; }
        public string ImageUrl { get; set; }
        public string ImdbUrl { get; set; }
    }
}