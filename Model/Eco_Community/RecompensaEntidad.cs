using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Eco_Community
{
    public class RecompensaEntidad // bien
    {
      public  int id_Recompensa { get; set; }
       public string descripcionRecompensa { get; set; }
       public int id_Mision { get; set; }
       public int id_TipoRecompensa { get; set; }

    }
}
