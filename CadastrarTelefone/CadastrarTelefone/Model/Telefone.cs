﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastrarTelefone.Model
{
    public class Telefone
    {
        [Key]
        public int Id { get; set; }
        public int Numero { get; set; }
        public string Nome { get; set; }
    }
}
