﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ftec.ProjWeb.WatchYourself.Api.Models
{
    public class Steps
    {
        public Guid Id { get; set; }
        public int Quantity { get; set; }
        public DateTime Date { get; set; }
    }
}