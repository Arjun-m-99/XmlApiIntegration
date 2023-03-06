namespace RezLiveApis.Models
{
    public class HotelFindRequest
    {
        public Authentication Authentication { get; set; }
        public Booking Booking { get; set; }
    }

    public class Booking
    {
        public string ArrivalDate { get; set; }
        public string DepartureDate { get; set; }
        public string CountryCode { get; set; }
        public int City { get; set; }
        public string GuestNationality { get; set; }
        public HotelRatings HotelRatings { get; set; }
        public Rooms Rooms { get; set; }
    }

    public class Rooms
    {
       public Room[] Room { get; set; }
    }

    public class Room
    {
        public string Type { get; set; }
        public int NoOfAdults { get; set; }
        public int NoOfChilds { get; set; }
    }

    public class HotelRatings
    {
        public int[] HotelRating { get; set; }
    }

    //public class HotelRating
    //{
    //    public int HotelRate { get; set; }
    //}

    public class Authentication
    {
        public string AgentCode { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
