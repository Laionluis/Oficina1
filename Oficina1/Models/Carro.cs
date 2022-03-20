using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Oficina1.Models
{
    public class Carro
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public Cliente Cliente { get; set; }
    }
}