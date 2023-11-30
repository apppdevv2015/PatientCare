using System;
using System.Collections.Generic;
using System.Text;

namespace Healthcare.Entity.Models
{
    public class PaginationFilter
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public string Filter { get; set; }

        public PaginationFilter()
        {
            PageNumber = 1;
            PageSize = 100000;

        }
        public PaginationFilter(int pageNumber, int pageSize)
        {
            PageNumber = pageNumber < 1 ? 1 : pageNumber;
            PageSize = pageSize > 100000 ? 100000 : pageSize;

        }
    }
}
