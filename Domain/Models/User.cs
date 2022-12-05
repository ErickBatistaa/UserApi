using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UsersApi.DTOs;

namespace UsersApi.Models
{
    public class User
    {
        public User(UserDTO @params)
        {
            UserId = @params.UserId;
            Nome = @params.Nome;
            Sobrenome = @params.Sobrenome;
            Email = @params.Email;
            DataNascimento = @params.DataNascimento;
            Escolaridade = @params.Escolaridade;
        }

        [Key]
        public int UserId { get; private set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Nome { get; private set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Sobrenome { get; private set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Email { get; private set; }

        [Column(TypeName = "nvarchar(15)")]
        public DateTime DataNascimento { get; private set; }

        [Column(TypeName = "nvarchar(1)")]
        public int Escolaridade { get; private set; }
    }
}
