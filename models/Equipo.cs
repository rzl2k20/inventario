using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ices.client.models
{
    public class Equipo
    {
        public int Id { get; set; }
        [Required]
        public required string clv_depto { get; set; }
        [Required]
        public required string ns { get; set; }
        [Required]
        public required string modelo { get; set; }
        [Required]
        public required string marca { get; set; }
        [Required]
        public required string caracteristicas { get; set; }
        [Required]
        public required string status { get; set; }
        [Required]
        public required string tipo_equipo { get; set; }

    }
}