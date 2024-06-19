using System.ComponentModel.DataAnnotations;

namespace EmprestimoJogos.Models
{
    public class EmprestimoViewModel
    {
            public int Id { get; set; }

            [Required(ErrorMessage = "Digite o nome do cliente!")]
            public string PessoaRecebe { get; set; }
            [Required(ErrorMessage = "Digite o nome do fornecedor!")]
            public string PessoaFornece { get; set; }
            [Required(ErrorMessage = "Digite o nome do jogo!")]
            public string JogoEmprestado { get; set; }
            public DateTime EmprestimoData { get; set; } = DateTime.Now;
    }
}
