namespace BeautyScheduler.Domain.DTO.Cliente
{
    public record ClienteUpdateModel
    {
        public ClienteUpdateModel(string nome, string cpf, string telefone, string email)
        {
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
        }

        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public string Telefone { get; private set; }
        public string Email { get; private set; }
    }
}