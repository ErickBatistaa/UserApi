namespace UsersApi.DTOs
{
    public class UserDTO
    {
        public int UserId { get; private set; }

        public string Nome { get; private set; }

        public string Sobrenome { get; private set; }

        public string Email { get; private set; }

        public DateTime DataNascimento { get; private set; }

        public int Escolaridade { get; private set; }
    }
}
