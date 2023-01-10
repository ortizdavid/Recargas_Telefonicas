using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recargas_Telefonicas.Recargas
{
    internal class Recarga
    {
        public int NumeroSerie { get; set; }
        public int Codigo { get; set; }
        public TipoRecarga? Tipo { get; set; }
        public EstadosRecarga Estado { get; set; }

        public static string MostrarLabel()
        {
            return "Serie\tCodigo\tTipo\tEstado";
        }

        public override string ToString()
        {
            return $"{NumeroSerie}\t{Codigo}\t{Tipo.NomeTipo}\t{Estado}";
        }
    }
}
