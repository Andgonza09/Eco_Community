using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Eco_Community
{
    public class DetalleConsultaArchivoEntidad // bien

    {
      public  long id_DetalleConsultaArchivo { get; set; }
      public  DateOnly fechaConsulta {  get; set; }
       public long id_Usuario { get; set; }
       public int id_ArchivoCriterio { get; set; }

    }
}
