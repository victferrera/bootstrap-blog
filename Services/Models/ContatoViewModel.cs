
using System.ComponentModel.DataAnnotations;
using System;

namespace Services.Models
{
    public class ContatoViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo {0} é obrigatório!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Campo {0} é obrigatório!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public string Mensagem { get; set; }
        public DateTime DataEnvio { get; set; }
    }
}
