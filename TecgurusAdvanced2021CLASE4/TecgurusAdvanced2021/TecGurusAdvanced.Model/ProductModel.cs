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

        //se agrega esto para que en la vista, aparesca la alerta
        [Required(ErrorMessageResourceName = "Required", ErrorMessageResourceType = typeof(Common))]
        [MaxLength(40, ErrorMessageResourceName = "MaxLenght", ErrorMessageResourceType = typeof(Common))]
        [Display(Name = "ProductName", ResourceType = typeof(Constants))]
        public string ProductName { get; set; }

        [Display(Name = "Supplier", ResourceType = typeof(Constants))]
        public int? SupplierID { get; set; }

        [Required(ErrorMessageResourceName = "Required", ErrorMessageResourceType = typeof(Common))]
        [Display(Name = "Category", ResourceType = typeof(Constants))]
        public int? CategoryID { get; set; }

        [MaxLength(20, ErrorMessageResourceName = "MaxLenght", ErrorMessageResourceType = typeof(Common))]
        [Display(Name = "QuantityPerUnit", ResourceType = typeof(Constants))]
        public string QuantityPerUnit { get; set; }

        [Required(ErrorMessageResourceName = "Required", ErrorMessageResourceType = typeof(Common))]
        [Display(Name = "UnitPrice", ResourceType = typeof(Constants))]
        [RegularExpression(@"^\d*(\.|,|(\.\d{1,2})|(,\d{1,2}))?$", ErrorMessageResourceName = "MaximumDecimal", ErrorMessageResourceType = typeof(Common))]
        public decimal? UnitPrice { get; set; }

        [Display(Name = "UnitsInStock", ResourceType = typeof(Constants))]
        public short? UnitsInStock { get; set; }


        [Display(Name = "UnitsOnOrder", ResourceType = typeof(Constants))]
        public short? UnitsOnOrder { get; set; }


        [Display(Name = "ReorderLevel", ResourceType = typeof(Constants))]
        public short? ReorderLevel { get; set; }


        [Display(Name = "Discontinued", ResourceType = typeof(Constants))]
        public bool Discontinued { get; set; }


        [Display(Name = "Category", ResourceType = typeof(Constants))]
        public string CategoryName { get; set; }

    }

    public class ProductViewModel : PagedData<ProductModel>
    {
        [Display(Name = "ProductName", ResourceType = typeof(Constants))]
        public string ProductNameSearch { get; set; }
    }
}
