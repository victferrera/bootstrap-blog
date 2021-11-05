using System;


namespace Dominio
{
    public class Post
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Subtitulo { get; set; }
        public string Conteudo { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataUltimaAlteracao { get; set; }
        public string AlteradoPor { get; set; }
        public Autor Autor { get; set; }
    }
}
