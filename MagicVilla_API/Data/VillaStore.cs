using MagicVilla_API.Models.DTO;

namespace MagicVilla_API.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO>
        {
            new VillaDTO{Id=1, Name="Dream Villa", sqrt=5, Occupancy=9},
            new VillaDTO{Id=2, Name="Beach Villa", sqrt=10, Occupancy=18}
        };
    }
}
