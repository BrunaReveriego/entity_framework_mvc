﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication3.Models
{
    public class contexto: DbContext
    {
        public DbSet<Pessoa> Pessoa { get; set; }

    }
}