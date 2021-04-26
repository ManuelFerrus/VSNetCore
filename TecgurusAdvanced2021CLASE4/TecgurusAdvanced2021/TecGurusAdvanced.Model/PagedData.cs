using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecGurusAdvanced.Model
{
    public class PagedData<T> where T : class
    {
        public IEnumerable<T> Data { get; set; }
        public int CurrentPage { get; set; }
        public int NumberOfPage { get; set; }
        public int TotalData { get; set; }
    }
}
