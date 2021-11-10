using Dominio;
using System.Collections.Generic;

namespace Services.Models
{
    public class ListarPostsViewModel
    {
        public IEnumerable<Post> Posts { get; set; }
    }
}
