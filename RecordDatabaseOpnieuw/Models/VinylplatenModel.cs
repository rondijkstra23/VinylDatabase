using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecordDatabaseOpnieuw.Models
{
    public class VinylplatenModel
    {
        public int Vinyl_ID { get; set; }
        [DisplayName("Artist")]
        public string Artiest { get; set; }
        [DisplayName("Album")]
        public string Album { get; set; }
        [DisplayName("Release Date")]

        [DataType(DataType.Date)]
        public DateTime Releasedatum { get; set; }
        [DisplayName("Genre")]
        public string Genre { get; set; }
        [DisplayName("In Possesion?")]
        public bool? InBezit { get; set; }

        public string Afbeelding { get; set; }
    }
}

