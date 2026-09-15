using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Eco_Community
{
    public class UsuarioEntidad // bien
    { 
      public  long id_Usuario { get; set; } 
      public  string nombre_Usuario { get; set; }
       public string contraseña_Usuario { get; set; }
       public string correo_Usuario { get; set; }
       public DateOnly fecha_Registro { get; set; }
       public int id_Roles { get; set; }

    }
}
