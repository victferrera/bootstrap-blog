﻿using System;

namespace Dominio
{
    public class Contato
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Mensagem { get; set; }
        public DateTime DataEnvio { get; set; }
    }
}
