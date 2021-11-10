using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Services.Models
{
    public class PostViewModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Subtitulo { get; set; }
        public string Conteudo { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataUltimaAlteracao { get; set; }
        public string AlteradoPor { get; set; }
        public Autor Autor { get; set; }
        public IEnumerable<Autor> AutoresDisponiveis { get; set; }
    }
}
