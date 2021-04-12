using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebsiteAssignmentMain.Models
{
    public class MovieForm
    {
        [Key]
        public int Movie_Id { get; set; }

        [Required(ErrorMessage =" ")]
        public string Movie_Name { get; set; }

        [Required(ErrorMessage = " ")]
        public int? Movie_Year { get; set; }

        public string Movie_Genre { get; set; }

        public int Movie_Time { get; set; }

        public decimal Movie_Imdb { get; set; }

        /*public decimal Movie_MetaScore { get; set; }*/

        public int Movie_Votes { get; set; }

        public decimal Movie_Gross { get; set; }
    }
}
