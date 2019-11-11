using System.Collections.Generic;
using RecordDatabaseOpnieuw.Models;

namespace RecordDatabaseOpnieuw.Repositories
{
    public interface IVinylplatenRepository
    {
        VinylplatenModel CreateNewVinyl(VinylplatenModel vinylplaat);
        void DeleteVinyl(int vinylID);
        void DeleteVinyl(VinylplatenModel deleteVinylPlaat);
        void EditVinylPlaat(VinylplatenModel editVinylPlaat);
        List<VinylplatenModel> GetAllVinylPlaten();
        VinylplatenModel GetOneVinyplaat(int vinylID);
    }
}