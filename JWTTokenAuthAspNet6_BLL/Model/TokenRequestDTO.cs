﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWTTokenAuthAspNet6_BLL.Model
{
    public class TokenRequestDTO
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
