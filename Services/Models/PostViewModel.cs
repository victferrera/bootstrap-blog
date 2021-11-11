using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Services.Models
{
    public class PostViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public string Subtitulo { get; set; }
        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public string Conteudo { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataUltimaAlteracao { get; set; }
        public string AlteradoPor { get; set; }
        public Autor Autor { get; set; }
        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public int AutorId { get; set; }
        public IEnumerable<Autor> AutoresDisponiveis { get; set; }
    }
}
