using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tecgurus.ThreeLayers.Ent
{
    /// <summary>
    /// CLASE DE ENTIDAD
    /// SOLAMENTE SE USA PARA DESCRIBIR LAS PROPIEDADES
    /// DE UN OBJETO DE ALMACENAMIENTO
    /// EJEMPLO: UNA TABLA DE BASE DE DATOS
    /// </summary>
    public class BookEnt
    {
        public int IdBook { get; set; }
        public string NameBook { get; set; }
        public DateTime DatePublishBook { get; set; }
        public short NumberPages { get; set; }
        public double SalePrice { get; set; }
        public decimal PurchasePrice { get; set; }
        public bool IsAvaible { get; set; }
    }
}
