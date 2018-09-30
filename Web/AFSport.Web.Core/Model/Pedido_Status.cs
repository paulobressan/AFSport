namespace AFSport.Web.Core.Model
{
    public class Pedido_Status
    {
        public int IdStatus { get; set; }
        public string Status { get; set; }

        public override string ToString()
        {
            return Status.ToUpper();
        }
    }
}
