namespace RezLiveApis.Models
{
    //public class HotelFindRequest
    //{
    //    public Authentication Authentication { get; set; }
    //    public Booking Booking { get; set; }
    //}


    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class HotelFindRequest
    {

        private HotelFindRequestAuthentication authenticationField;

        private HotelFindRequestBooking bookingField;

        /// <remarks/>
        public HotelFindRequestAuthentication Authentication
        {
            get
            {
                return this.authenticationField;
            }
            set
            {
                this.authenticationField = value;
            }
        }

        /// <remarks/>
        public HotelFindRequestBooking Booking
        {
            get
            {
                return this.bookingField;
            }
            set
            {
                this.bookingField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class HotelFindRequestAuthentication
    {

        private string agentCodeField;

        private string userNameField;

        private string passwordField;

        /// <remarks/>
        public string AgentCode
        {
            get
            {
                return this.agentCodeField;
            }
            set
            {
                this.agentCodeField = value;
            }
        }

        /// <remarks/>
        public string UserName
        {
            get
            {
                return this.userNameField;
            }
            set
            {
                this.userNameField = value;
            }
        }

        /// <remarks/>
        public string Password
        {
            get
            {
                return this.passwordField;
            }
            set
            {
                this.passwordField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class HotelFindRequestBooking
    {

        private string arrivalDateField;

        private string departureDateField;

        private string countryCodeField;

        private ushort cityField;

        private string guestNationalityField;

        private byte[] hotelRatingsField;

        private HotelFindRequestBookingRoom[] roomsField;

        /// <remarks/>
        public string ArrivalDate
        {
            get
            {
                return this.arrivalDateField;
            }
            set
            {
                this.arrivalDateField = value;
            }
        }

        /// <remarks/>
        public string DepartureDate
        {
            get
            {
                return this.departureDateField;
            }
            set
            {
                this.departureDateField = value;
            }
        }

        /// <remarks/>
        public string CountryCode
        {
            get
            {
                return this.countryCodeField;
            }
            set
            {
                this.countryCodeField = value;
            }
        }

        /// <remarks/>
        public ushort City
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }

        /// <remarks/>
        public string GuestNationality
        {
            get
            {
                return this.guestNationalityField;
            }
            set
            {
                this.guestNationalityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("HotelRating", IsNullable = false)]
        public byte[] HotelRatings
        {
            get
            {
                return this.hotelRatingsField;
            }
            set
            {
                this.hotelRatingsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Room", IsNullable = false)]
        public HotelFindRequestBookingRoom[] Rooms
        {
            get
            {
                return this.roomsField;
            }
            set
            {
                this.roomsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class HotelFindRequestBookingRoom
    {

        private string typeField;

        private byte noOfAdultsField;

        private byte noOfChildsField;

        /// <remarks/>
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        public byte NoOfAdults
        {
            get
            {
                return this.noOfAdultsField;
            }
            set
            {
                this.noOfAdultsField = value;
            }
        }

        /// <remarks/>
        public byte NoOfChilds
        {
            get
            {
                return this.noOfChildsField;
            }
            set
            {
                this.noOfChildsField = value;
            }
        }
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
