﻿namespace RezLiveApis.Models
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
        public Rooms[] Rooms { get; set; }
    }

    public class Rooms
    {
       public Room Room { get; set; }
    }

    public class Room
    {
        public string Type { get; set; } = "Room- 1";
        public int NoOfAdults { get; set; } = 2;
        public int NoOfChilds { get; set; }
    }

    public class HotelRatings
    {
        public HotelRating[] HotelRating { get; set; }
    }

    public class HotelRating
    {
        public HotelRating HotelRate { get; set; }
    }

    //public class HotelRating
    //{
    //    public int HotelRate { get; set; }
    //}

    public class Authentication
    {
        public string AgentCode { get; set; } = "CD32428";
        public string UserName { get; set; } = "YOKOSO1111";
        public string Password { get; set; } = "Hi98765#";
    }
}
