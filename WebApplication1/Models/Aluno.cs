using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlunosApi.Models

    //Classe-Entidade com atributos e DataAnnotations para facilitar as migrations.
{
    [Table("Alunos")]
    public class Aluno
    {
        [Key]
        public int AlunoId { get; set; }
        [Required]
        [StringLength(80,ErrorMessage ="O tamanho ultrapassou 80 caracteres")]
        public string Nome { get; set; }
        [Required]
        [StringLength(80, ErrorMessage = "O tamanho ultrapassou 80 caracteres")]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public int Idade { get; set; }
    }
}
