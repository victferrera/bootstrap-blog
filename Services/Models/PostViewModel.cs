using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public List<Autor> AutoresDisponiveis { get; set; }
    }
}
