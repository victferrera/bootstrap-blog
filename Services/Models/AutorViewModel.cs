using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Dominio;

namespace Services.Models
{
    public class AutorViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(60)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Biografia { get; set; }

        public string Youtube { get; set; }
        public string Github { get; set; }
        public string Linkedin { get; set; }
        public string Twitter { get; set; }
        public DateTime DataCriacao { get; set; }
        public IEnumerable<Post> Posts { get; set; }
    }
}
