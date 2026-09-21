using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Eco_Community
{
    public class MultimediaEntidad // bien
    {
       public  long id_Multimedia { get; set; }
       public string nombre_ArchivoMultimedia {  get; set; }
       public string tipo_ArchivoMultimedia { get; set; }
       public string tamaño_ArchivoMultimedia { get; set; }
       public string ruta_ArchivoMultimedia { get; set; }
       public DateOnly fecha_Adjuncion { get; set; }
       public long id_Solicitud { get; set; }
       public int id_Extension { get; set; }

    }
}
