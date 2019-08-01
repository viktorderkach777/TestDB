﻿using System;
using System.Collections.Generic;

namespace TestDB
{
    public partial class AspNetUserClaims
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }

        public virtual AspNetUsers User { get; set; }
    }
}
