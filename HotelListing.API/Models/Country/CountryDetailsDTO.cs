using HotelListing.API.Models.Hotel;

namespace HotelListing.API.Models.Country
{
    public class CountryDetailsDTO : BaseCountryDTO
    {
        public int Id { get; set; }
        public List<HotelDTO> Hotels { get; set; }
    }
}
