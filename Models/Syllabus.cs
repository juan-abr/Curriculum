using System;
using System.ComponentModel.DataAnnotations;

namespace Curriculum.Models
{
    public class Syllabus
    {
        public int Id { get; set; }
        public string Rank { get; set; }

        public string Media { get; set; }
        public string Thumbnail { get; set; }
    }
}