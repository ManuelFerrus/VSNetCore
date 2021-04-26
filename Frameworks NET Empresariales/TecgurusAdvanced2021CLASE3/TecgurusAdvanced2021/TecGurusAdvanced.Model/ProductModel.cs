using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecGurusAdvanced.Localization;

namespace TecGurusAdvanced.Model
{
    public class ProductModel
    {
        public int ProductID { get; set; }

        [Required]
        [StringLength(40)]
        public string ProductName { get; set; }

        public int? SupplierID { get; set; }

        public int? CategoryID { get; set; }

        [StringLength(20)]
        public string QuantityPerUnit { get; set; }

        public decimal? UnitPrice { get; set; }

        public short? UnitsInStock { get; set; }

        public short? UnitsOnOrder { get; set; }

        public short? ReorderLevel { get; set; }

        public bool Discontinued { get; set; }

        public string CategoryName { get; set; }

    }

    public class ProductViewModel : PageData<ProductModel>
    {
        //DataAnnotacion
        [Display(Name ="ProductName", ResourceType =typeof(Constants))]
        public string ProductNameSearch { get; set; }

        //public List<ProductModel> Data { get; set; }
    }
}
