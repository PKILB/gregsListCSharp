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
        public double? Price { get; set; }
        public string ImgUrl { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
    }
}