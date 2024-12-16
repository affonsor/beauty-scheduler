namespace BeautyScheduler.Domain.DTO.Cliente
{
    public class ClienteCreateModel
    {
        public ClienteCreateModel(string nome, string cpf, string telefone, string email)
        {
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
        }

        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
    }
}
