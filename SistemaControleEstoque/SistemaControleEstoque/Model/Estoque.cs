﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControleEstoque.Model
{
    public class Estoque
    {
        [Key]
        public int Id { get; set; }
        public string Produto { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }    
        public bool Ativo { get; set; }
        public int UsuarioCriacao { get; set; }
        public int UsuarioAlteracao { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAlteracao { get; set; }

    }
}
