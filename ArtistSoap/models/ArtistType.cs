using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArtistSoap.models
{
    public class ArtistType
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string username { get; set; }
        public string phone_number { get; set; }
        public int studio_id { get; set; }
        public string studio_address { get; set; }
        public string city { get; set; }
        public string studio_name { get; set; }

    }
}