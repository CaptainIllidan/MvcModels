﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcModels.Models
{
    [Bind(nameof(City))]
    public class AddressSummary
    {
        public string City { get; set; }
        public string Country { get; set; }
    }
}
