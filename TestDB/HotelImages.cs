using System;
using System.Collections.Generic;

namespace TestDB
{
    public partial class HotelImages
    {
        public string Id { get; set; }
        public string HotelId { get; set; }
        public string HotelImageUrl { get; set; }

        public virtual Hotels Hotel { get; set; }
    }
}
