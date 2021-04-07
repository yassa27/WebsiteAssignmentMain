using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebsiteAssignmentMain.Models
{
    public class Movie
    {
        [Key]
        public int Movie_Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Movie_Name { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Movie_Genre { get; set; }

        public int Movie_Year { get; set; }

        public int Movie_Time { get; set; }

        [Column(TypeName = "decimal(18, 1)")]
        public decimal Movie_Imdb { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Movie_MetaScore { get; set; }

        public int Movie_Votes { get; set; }

        [Column(TypeName = "decimal(25, 20)")]
        public decimal Movie_Gross { get; set; } 

        /*
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        */


    }
}
