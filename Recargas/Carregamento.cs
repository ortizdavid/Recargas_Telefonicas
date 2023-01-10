using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Recargas_Telefonicas.Clientes;

namespace Recargas_Telefonicas.Recargas
{
    internal class Carregamento
    {
        public Cliente? Cliente { get; set; }
        public Recarga? Recarga { get; set; }
        public EstadosCarregamento Estado { get; set; }
        public DateTime DataCarregamento { get; set; }

        public static string MostrarLabel()
        {
            return "Telefone\tCodigo\tTipo\tData\tEstado";
        }

        public override String ToString()
        {
            return String.Format("{0}\t{1}\t{2}\t{3}\t{4:dd/mm/yyyy}",
                   Cliente?.NumeroTelefone, Recarga?.Codigo, Recarga?.Tipo.NomeTipo, Recarga?.Estado, DataCarregamento);
        }
    }
}
