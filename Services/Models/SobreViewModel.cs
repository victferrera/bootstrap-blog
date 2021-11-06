using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Services.Models
{
    public class SobreViewModel
    {
        public SobreViewModel()
        {
            DataCriacao = DateTime.Now;
        }
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo {0} obrigatório")]
        [DisplayName("Descrição")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "Campo {0} obrigatório")]
        [DisplayName("Conteúdo")]
        public string Conteudo { get; set; }
        [DisplayName("Salvar como descrição principal")]
        public bool StatusAtivo { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataUltimaAlteracao { get; set; }
    }
}
