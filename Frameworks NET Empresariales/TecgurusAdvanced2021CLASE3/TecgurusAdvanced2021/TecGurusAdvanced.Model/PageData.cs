using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecGurusAdvanced.Model
{
    //cuando me heredan, recibo una clase, cual sea
    public class PageData <T> where T : class
    {
        public IEnumerable<T> Data { get; set; }
        public int CurrentPage { get; set; }
        public int NumbreOfPage { get; set; }
        public int TotalData{ get; set; }
    }
}
