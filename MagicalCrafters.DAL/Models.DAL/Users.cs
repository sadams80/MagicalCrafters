﻿using System;

namespace MagicalCrafters.DAL.Models.DAL
{
    public class Users : Users_Info
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public bool isBlocked { get; set; }
    }
}
