using Dominio;
using System.Collections.Generic;

namespace Services.Models
{
    public class ListarAutoresViewModel
    {
        public IEnumerable<Autor> Autores { get; set; }
        public string Mensagem { get; set; }
    }
}
