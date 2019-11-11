using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RecordDatabaseOpnieuw.Models;
using RecordDB;

namespace RecordDatabaseOpnieuw.Repositories
{
    public class VinylplatenRepository : IVinylplatenRepository
    {
        private readonly VinylplatendbContext context;

        public VinylplatenRepository(VinylplatendbContext context)
        {
            this.context = context;
        }

        public List<Models.VinylplatenModel> GetAllVinylPlaten()
        {
            var allleVinylPlaten = new List<VinylplatenModel>();

            foreach (var vinylplaat in context.Vinylplatens)

                allleVinylPlaten.Add(new VinylplatenModel
                {
                    Vinyl_ID = vinylplaat.VinylId,
                    Artiest = vinylplaat.Artiest,
                    Album = vinylplaat.Album,
                    Releasedatum = vinylplaat.ReleaseDatum,
                    Genre = vinylplaat.Genre,
                    InBezit = vinylplaat.InBezit,
                    Afbeelding = vinylplaat.Afbeelding


                });
            return allleVinylPlaten;
        }

        public VinylplatenModel CreateNewVinyl(VinylplatenModel vinylplaat)
        {
            var nieuweVinylPlaat = new Vinylplaten
            {
                VinylId = vinylplaat.Vinyl_ID,
                Artiest = vinylplaat.Artiest,
                Album = vinylplaat.Album,
                ReleaseDatum = vinylplaat.Releasedatum,
                Genre = vinylplaat.Genre,
                InBezit = vinylplaat.InBezit


            };

            context.Vinylplatens.Add(nieuweVinylPlaat);
            context.SaveChanges();

            return vinylplaat;
        }

        public VinylplatenModel GetOneVinyplaat(int vinylID)
        {
            var getOnePlaat = context.Vinylplatens.Single(v => v.VinylId == vinylID);
            return new VinylplatenModel
            {
                Vinyl_ID = getOnePlaat.VinylId,
                Artiest = getOnePlaat.Artiest,
                Album = getOnePlaat.Album,
                Releasedatum = getOnePlaat.ReleaseDatum,
                Genre = getOnePlaat.Genre,
                InBezit = getOnePlaat.InBezit
            };
        }

        public void EditVinylPlaat(VinylplatenModel editVinylPlaat)
        {
            var plaat = context.Vinylplatens.Single(v => v.VinylId == editVinylPlaat.Vinyl_ID);

            plaat.Artiest = editVinylPlaat.Artiest;
            plaat.Album = editVinylPlaat.Album;
            plaat.ReleaseDatum = editVinylPlaat.Releasedatum;
            plaat.Genre = editVinylPlaat.Genre;
            plaat.InBezit = editVinylPlaat.InBezit;

            context.SaveChanges();

        }

        public void DeleteVinyl(VinylplatenModel deleteVinylPlaat)
        {
            var plaat = context.Vinylplatens.Single(v => v.VinylId == deleteVinylPlaat.Vinyl_ID);

            plaat.Artiest = deleteVinylPlaat.Artiest;
            plaat.Album = deleteVinylPlaat.Album;
            plaat.ReleaseDatum = deleteVinylPlaat.Releasedatum;
            plaat.Genre = deleteVinylPlaat.Genre;
            plaat.InBezit = deleteVinylPlaat.InBezit;

            context.Vinylplatens.Remove(plaat);
            context.SaveChanges();
        }

        public void DeleteVinyl(int vinylID)
        {
            throw new NotImplementedException();
        }
    }
}

