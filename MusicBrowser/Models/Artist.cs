using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicBrowser.Models
{
    public class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImgSource { get; set; }
        public int Listeners { get; set; }
        public bool isFav { get; set; }



    }
}