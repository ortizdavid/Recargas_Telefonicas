using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recargas_Telefonicas.Recargas
{
    internal class TipoRecarga
    {
        public int CodigoTipo { get; set; }
        public string? NomeTipo { get; set; }
        public double Preco { get; set; }
        public override string ToString()
        {
            return String.Format("{0}\t{1:C}", NomeTipo, Preco);
        }
    }
}
