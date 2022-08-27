namespace CM_Tecnologia.Dominios
{
    public class ShoopingLojas
    {
        public int ShoopingId { get; set; }
        public virtual Shooping Shooping { get; set; }
        public int LojasId { get; set; }
        public Lojas Lojas { get; set; }
    }
}