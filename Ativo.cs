using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetroAtivos324133695.Models
{
    public class Ativo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public string localizacao { get; set; }
        public double CapacidadeProducao { get; set; }
        public DateTime DataUltimaInspecao { get; set; }
        public bool StatusOperacional { get; set; }
    }
}
