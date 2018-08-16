using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Repository.Models
{
    public class Usuario
    {
        public string nome { get; set; }

        public string sobrenome { get; set; }

        public DateTime dataNascimento { get; set; }
    }
}