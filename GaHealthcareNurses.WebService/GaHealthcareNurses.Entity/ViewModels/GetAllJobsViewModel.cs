﻿using Healthcare.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Healthcare.Entity.ViewModels
{
    public class GetAllJobsViewModel
    {
        public PaginationFilter PaginationFilter { get; set; }
        public string UserId { get; set; }
    }
}
