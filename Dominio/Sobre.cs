using System;

namespace Dominio
{
    public class Sobre
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Conteudo { get; set; }
        public char StatusAtivo { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataUltimaAlteracao { get; set; }
    }
}
