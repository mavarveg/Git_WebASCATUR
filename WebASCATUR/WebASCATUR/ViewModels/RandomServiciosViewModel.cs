﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebASCATUR.Data.Models;

namespace WebASCATUR.ViewModels
{
    public class RandomServiciosViewModel
    {
        public IEnumerable<Servicio> Servicios { get; set; }
    }
}
