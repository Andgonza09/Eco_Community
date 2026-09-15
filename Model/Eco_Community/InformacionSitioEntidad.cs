using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Eco_Community
{
    public class InformacionSitioEntidad // bien
    {
      public  long id_InformacionSitio { get; set; }
       public string tipoSitio {  get; set; }
       public string direccion {  get; set; }
       public int id_Barrio { get; set; }
       public decimal latitud { get; set; }
       public decimal length { get; set; }


    }
}
