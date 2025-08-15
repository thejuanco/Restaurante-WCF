using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PruebaServiceCore.EntidadesClassLibrary.Dominio.E00.Platillos
{
    [Serializable]
    public class PlatilloEntityClass
    {
        [DataMember]
        public string platillo_Id { get; set; }

        [DataMember]
        public string platillo_Nombre { get; set; }
        [DataMember]
        public string platillo_Desc { get; set; }
        [DataMember]
        public decimal platillo_Precio { get; set; }
    }
}
