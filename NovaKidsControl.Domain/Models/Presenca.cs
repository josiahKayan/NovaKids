﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaKidsControl.Domain.Models
{
    public class Presenca
    {
        public int Id { get; set; }
        public string Data { get; set; }
        public string HorarioKids { get; set; }
        public UserKids UserKids { get; set; }

    }
}
