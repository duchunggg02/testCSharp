﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace testCSharp.Models
{
    public class UserContext
    {
        public int Id { get; set; }

        [Required]
        public string Content { get; set; }
    }
}