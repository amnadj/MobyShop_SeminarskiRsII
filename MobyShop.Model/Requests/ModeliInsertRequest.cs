﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MobyShop.Model.Requests
{
    public class ModeliInsertRequest
    {
        [Required]
        public string Naziv { get; set; }
    }
}
