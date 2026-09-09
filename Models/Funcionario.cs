using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace DbApi.Models
{
    [Table("tb_funcionarios")]
    public class Funcionario
    {
        [Key]
        [Column ("IdFuncionario", TypeName = "varchar(50)")]
        public string Id { get; set;} = Guid.NewGuid().ToString();

        [Required]
        [MaxLength(150)]
        [Column("NomeFuncionario", TypeName = "(varchar150")]
        public string Nome { get; set; }

        [Required]
        [MaxLength(300)]
        [Column("EnderecoFuncionario", TypeName = "(varchar300))")]
        public string Endereco { get; set; }

        


    public void Update (Funcionario funcionarioAtualizado)
        {
            Nome = funcionarioAtualizado.Nome;
            Endereco = funcionarioAtualizado.Endereco;
        }
    }
}    