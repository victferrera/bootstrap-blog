using System;
using System.Collections.Generic;

namespace Dominio
{
    public class Autor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Biografia { get; set; }
        public string Youtube { get; set; }
        public string Github { get; set; }
        public string Linkedin { get; set; }
        public string Twitter { get; set; }
        public DateTime DataCriacao { get; set; }
        public IEnumerable<Post> Posts { get; set; }
    }
}
