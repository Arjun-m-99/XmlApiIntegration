using System.ComponentModel;
using System.Xml.Serialization;

namespace RezLiveApis.Models
{
    public class HotelFindRequest
    {
        public Authentication Authentication { get; set; } = null!;
        public Booking Booking { get; set; } = null!;
    }

    public class Booking
    {
        public string ArrivalDate { get; set; }
        public string DepartureDate { get; set; }

        //[DefaultValue("IN")]
        public string CountryCode { get; set; }

        //[DefaultValue("8896")]
        public int City { get; set; }

        //[DefaultValue("IN")]
        public string GuestNationality { get; set; }
        public HotelRatings HotelRatings { get; set; }
        public Rooms Rooms { get; set; }
    }

    public class Rooms
    {
        [XmlElement("Room")]
        public Room[] Room { get ; set; }= new Room[] {};
    }

    public class Room
    {
        [XmlElement("Type")]
        //[DefaultValue("Room- 1")]
        public string Type { get; set; }

        [XmlElement("NoOfAdults")]
        //[DefaultValue(2)]
        public int NoOfAdults { get; set; }

        [XmlElement("NoOfChilds")]
        //[DefaultValue(0)]
        public int NoOfChilds { get; set; }
    }

    public class HotelRatings
    {
        [XmlElement("HotelRating")]
        public int[] HotelRating { get; set; }
    }

    //public class HotelRating
    //{
    //    public int HotelRate { get; set; }
    //}

    public class Authentication
    {
        [DefaultValue("CD32428")]
        public string AgentCode { get; set; }

        [DefaultValue("YOKOSO1111")]
        public string UserName { get; set; }

        [DefaultValue("Hi98765#")]
        public string Password { get; set; }
    }
}
