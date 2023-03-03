namespace RezLiveApis.Models
{
    public class FindHotelResponse
    {
        public HotelFindResponse HotelFindResponse { get; set; }
    }

    public class HotelFindResponse
    {
        public DateTime ArrivalDate { get; set; }
        public DateTime DepartureDate { get; set; }
    }
}
