using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gregsListCSharp.Models
{
    public class House
    {
        public int Id { get; set; }
        public int Bathrooms { get; set; }
        public int Bedrooms { get; set; }
        public int Levels { get; set; }
        public int Price { get; set; }
        public int Description { get; set; }
        public int ImgUrl { get; set; }
        public int Year { get; set; }
    }
}