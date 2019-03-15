using MusicBrowser.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MusicBrowser.DAL 
{
    public class ArtistsContext : DbContext // DbContext is a class from Data.Entity
    {
        public ArtistsContext() : base("ArtistsContext")
        {
        }

        static ArtistsContext()
        {
            Database.SetInitializer<ArtistsContext>(new ArtistsInitializer());
        }

        public DbSet<Artist> Artists { get; set; }



    }
}