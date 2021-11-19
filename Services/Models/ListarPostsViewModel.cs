using Dominio;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Services.Models
{
    public class ListarPostsViewModel
    {
        public IEnumerable<Post> Posts { get; set; }
        public string Message { get; set; } = null;
    }
}
