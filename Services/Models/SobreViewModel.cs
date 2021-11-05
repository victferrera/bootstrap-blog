using System;

namespace Services.Models
{
    class SobreViewModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Conteudo { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataUltimaAlteracao { get; set; }
    }
}
