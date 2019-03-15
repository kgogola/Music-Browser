using MusicBrowser.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace MusicBrowser.DAL
{
    public class ArtistsInitializer : DropCreateDatabaseIfModelChanges<ArtistsContext>
    {

        protected override void Seed(ArtistsContext context)
        {
            SeedArtistsData(context);
            base.Seed(context);
        }

        public static void SeedArtistsData(ArtistsContext context)
        {
            var artists = new List<Artist>
            {
                new Artist() {Id = 1, Name = "Michael Jackson", ImgSource="Default",Listeners=10000 },
                new Artist() { Id = 1, Name = "Drake", ImgSource = "Default", Listeners = 100000 },
                new Artist() {Id = 1, Name = "Michael ", ImgSource="Default",Listeners=10000 },
                new Artist() {Id = 1, Name = "Michael ", ImgSource="Default",Listeners=9000 },
                new Artist() {Id = 1, Name = "Michael ", ImgSource="Default",Listeners=100 },
                new Artist() {Id = 1, Name = "Micha", ImgSource="Default",Listeners=100090 }
            };

            artists.ForEach(k => context.Artists.AddOrUpdate(k));
            context.SaveChanges();
        }



    }
}