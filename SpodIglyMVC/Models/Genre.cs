using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpodIglyMVC.Models
{
    public class Genre
    {
        public int GenreID { get; set; }
        public  string Name { get; set; }
        public string Description { get; set; }
        public string IconFilename { get; set; }

        public  virtual ICollection<Album> Albums { get; set; }
    }
}
