using System.Collections.Generic;

namespace CM_Tecnologia.Dominios
{
    public class Lojas
    {
        public int Id { get; set; }
        public string NomeLoja { get; set; }

        public ICollection<Shooping> Shoopingss { get; set; }
    }
}