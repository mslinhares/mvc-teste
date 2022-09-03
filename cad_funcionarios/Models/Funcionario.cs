using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cad_funcionarios.Models
{
    public class Funcionario
    {
        [Column("CodFuncionario")]
        [DisplayName("Codigo do funcionário")]
        public int Id { get; set; }
        [Required(ErrorMessage = "O nome é de preenchimento obrigatório.")]
        public string? Nome { get; set; }
        [DisplayName("Data de nascimento")]
        [Required(ErrorMessage = "A data de nascimento é de preenchimento obrigatório.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DataNascimento { get; set; }
        [DisplayName("Salário")]
        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "O salário é de preenchimento obrigatório.")]
        public decimal Salario { get; set; }
        [Required(ErrorMessage = "As atividades são de preenchimento obrigatório.")]
        public string? Atividades { get; set; }
    }
}
