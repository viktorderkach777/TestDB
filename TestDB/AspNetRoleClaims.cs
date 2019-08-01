﻿using System;
using System.Collections.Generic;

namespace TestDB
{
    public partial class AspNetRoleClaims
    {
        public string Id { get; set; }
        public string RoleId { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }

        public virtual AspNetRoles Role { get; set; }
    }
}
