using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Model.Eco_Community
{
    public class SolicitudesEntidad // bien
    {
      public  long id_Solicitud { get; set; }
       public string estado_Solicitud {  get; set; }
       public DateOnly fecha_Solicitud { get; set; }
       public DateOnly fecha_Resolucion { get; set; }
       public long id_UsuarioEstandar {  get; set; }
       public long id_InformacionSitio { get; set; }


    }
}
