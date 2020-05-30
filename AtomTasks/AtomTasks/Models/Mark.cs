﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace AtomTasks.Models
{
    public class Mark
    {
        public int MarkId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}