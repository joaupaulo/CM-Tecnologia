using System.Collections.Generic;

namespace CM_Tecnologia.Dominios
{
    public class Shooping
    {
        public int Id { get; set; }
        public string Endereco { get; set; }

        public ICollection<Lojas> Lojas { get; set; }
    }
}