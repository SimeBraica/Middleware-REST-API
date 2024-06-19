﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO {
    public class UserDTO {
        public string Username { get; set; } = null;
        public string Password { get; set; } = null;
        public int expiresInMins { get; set; } = 30;
    }
}
