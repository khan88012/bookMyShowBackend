﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMovie2.Data
{
    public class AuthenticatedResponse
    {
        public string? Token { get; set; }

        public string? Message { get; set; }

        public string? Username { get; set; }
    }
}
