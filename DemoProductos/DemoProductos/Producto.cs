using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProductos
{
   [Serializable]
   public class Producto
   {
      public string SKU { get; set; }
      public string Descripcion { get; set; }
      public string Proveedor { get; set; }
      public int  Cantidad { get; set; }
      public decimal Precio { get; set; }

   }
}
