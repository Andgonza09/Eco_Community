using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Eco_Community
{
    public class DetalleClasificacionSitioEntidad
    {
       public long id_DetalleClasificacionSitio { get; set; }
       public long id_InformacionSitio { get; set; }
       public int id_CatalogoResiduos { get; set; }
    }
}
