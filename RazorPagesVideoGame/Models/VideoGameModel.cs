using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesVideoGame.Models
{
    public class VideoGameModel
    {
        public int Id { get; set; }
        [Display(Name = "Game Title")]
        public string GameTitle { get; set; }
        [Display(Name = "Release Year")]
        public string ReleaseYear { get; set; }
        public string Platform { get; set; }
        public string Publisher { get; set; }
        [Display(Name = "Complete Copy")]
        public string CompleteCopy { get; set; }
        [Display(Name = "Physical Copy")]
        public string PhysicalCopy { get; set; }
    }
}
