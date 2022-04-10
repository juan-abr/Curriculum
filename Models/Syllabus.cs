using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Curriculum.Models
{
    public class Syllabus
    {
        public int Id { get; set; }
        public string Rank { get; set; }

        public string Media { get; set; }
        public string Thumbnail { get; set; }
        
        [Display(Name = "Date Created")]
        [DataType(DataType.Date)]
        public DateTime DateCreated { get; set; }

        public bool IsCurrent { get; set; }
    }
}