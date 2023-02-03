using System;
using System.Collections.Generic;

namespace WAEncuesta.Models
{
    public partial class TbCuestionario
    {
        
        public int Id { get; set; }
        public string Preguntauno { get; set; } = null!;
        public string Preguntados { get; set; } = null!;
        public string Preguntatres { get; set; } = null!;
        public string Preguntacuatro { get; set; } = null!;
        public string Preguntacinco { get; set; } = null!;
        public string Preguntaseis { get; set; } = null!;
        public string Preguntasiete { get; set; } = null!;
        public string Preguntaocho { get; set; } = null!;
        public string Preguntanueve { get; set; } = null!;
        public string Preguntadiez { get; set; } = null!;
    }
}
