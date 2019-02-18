using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionAvituallamiento.dto
{
    public class Tipo
    {
        public string TipoMaterial { get; set; }

        public Tipo(string tipo)
        {
            this.TipoMaterial = tipo;
        }

        public override string ToString()
        {
            return TipoMaterial;
        }
    }
}
