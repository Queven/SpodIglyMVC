using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpodIglyMVC.Models
{
   public class Album
    {
        public int AlbumID { get; set; }
        public int GenreID { get; set; }
        public string AlbumTitle { get; set; }
        public string ArtistName { get; set; }
        public DateTime DateAdded { get; set; }
        public string CoverFileName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsBestseller { get; set; }
        public bool IsHidden { get; set; }

        public virtual Genre Genre { get; set; }
    }
}
