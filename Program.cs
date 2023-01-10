using Recargas_Telefonicas.Clientes;
using Recargas_Telefonicas.Recargas;
using static System.Console;
internal class Program
{

    static string FormatarPreco(double preco)
    {
        return String.Format("{0:C}", preco);
    }

    private static void Main(string[] args)
    {
        int opcao;
        int numTelefone;
        var manipulador = new ManipuladorRecarga();

        WriteLine("Carregamento Electrónico");
        foreach (TipoRecarga tipo in manipulador.listaDeTiposRecargas)
        {
            WriteLine($"{tipo.CodigoTipo}. {tipo.NomeTipo} - {FormatarPreco(tipo.Preco)}");
        }

        do
        {
            Write("Escolha: ");
            opcao = int.Parse(ReadLine());
            Write("Telefone: ");
            numTelefone = int.Parse(ReadLine());

            Cliente cliente = new Cliente { NumeroTelefone = numTelefone };
            Recarga recarga = manipulador.ObterRecarga(codigo: opcao);

            Carregamento carregamento = new Carregamento { Cliente = cliente, Recarga = recarga };

            manipulador.EfectuarCarregamento(recarga, cliente);
            manipulador.MostrarTodosCarregamentos();

        } while (true);
       
        ReadLine();
    }
}