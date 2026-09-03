using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;

namespace DbApi.Models
{
    public class Cliente
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        [Required] //esta se referindo a nome
        public string Nome { get; set; }

        public string Telefone { get; set; }
        [Required] //esta se referindo a email
        public string Email { get; set; }

        public string Endereco { get; set; }
    }
}