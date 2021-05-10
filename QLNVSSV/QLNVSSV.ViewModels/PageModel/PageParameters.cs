using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLNVSSV.Client.Model
{
    public class PageParameters
    {
        const int maxPageSize = 50;
        public int PageNumber { get; set; } = 1;
        public int pageSize { get; set; }

        public string Search { get; set; }
    }
}
