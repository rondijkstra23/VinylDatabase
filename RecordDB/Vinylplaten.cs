using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RecordDB
{
    public partial class Vinylplaten
    {
        public int VinylId { get; set; }
        public string Artiest { get; set; }
        public string Album { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDatum { get; set; }
        public string Genre { get; set; }
        public bool? InBezit { get; set; }
        public string Afbeelding { get; set; }
    }
}