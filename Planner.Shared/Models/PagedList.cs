﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Shared.Models
{
    public class PagedList<T>
    {
        public int TotalPages { get; set; }
        public int ItemsCount { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public IEnumerable<T> Records { get; set; }
    }
}
