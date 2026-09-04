using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.AccessControl;

namespace DbApi.Models
{
    //[Table("clienteabd)]
    public class Cliente
    {
        [Key]
        [Column("codigoCli")]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        [Required] //esta se referindo a nome
        [Column("nomeCli", TypeName ="varchar(150)")]
        [MaxLength(150)]
        public string Nome { get; set; }
        [Column("telefoneCli", TypeName ="varchar(11)")]
        public string Telefone { get; set; }
        [Required] //esta se referindo a email
        public string Email { get; set; }

        public string Endereco { get; set; }

        public DateTime Datanascimento { get; set; }
        
    }
}