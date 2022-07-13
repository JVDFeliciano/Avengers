namespace Avengers.Domain.Users
{
    public class InfoUser : Entity
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Cpf { get; set; }
        public string Address { get; set; }
        public string Cep { get; set; }
        public string Email { get; set; }
        public int CallNumber { get; set; }
    }
}
