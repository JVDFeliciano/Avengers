namespace Avengers.Domain.Shops
{
    public class InfoShop : Entity
    {
        public string FantasyName { get; set; }
        public string CorporateName { get; set; }
        public string Cnpj { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int CallNumber { get; set; }
    }
}
