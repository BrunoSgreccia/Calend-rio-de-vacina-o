﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto_Calendario_de_Vacinacao.Models
{
    public class UsersInRoleViewModel
    {
        public string UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
    }
}