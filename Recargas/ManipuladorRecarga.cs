using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using Recargas_Telefonicas.Clientes;

namespace Recargas_Telefonicas.Recargas
{
    internal class ManipuladorRecarga
    {
        public List<Carregamento> listaDeCarregamentos = new();   
        public List<Recarga> listaDeRecargas = new();
        public List<Recarga> listaDeRecargasEfectuadas = new();
        public List<TipoRecarga> listaDeTiposRecargas = new();

        public ManipuladorRecarga()
        {
            InicializarTiposRecargas();
            InicializarRecargas();
        }

        public void InicializarRecargas()
        {
            listaDeRecargas = new List<Recarga>
            {
                new Recarga { Codigo = 1001, NumeroSerie = 111, Tipo = listaDeTiposRecargas[0] },
                new Recarga { Codigo = 1002, NumeroSerie = 111, Tipo = listaDeTiposRecargas[1] },
                new Recarga { Codigo = 1003, NumeroSerie = 222, Tipo = listaDeTiposRecargas[2] },
                new Recarga { Codigo = 1004, NumeroSerie = 222, Tipo = listaDeTiposRecargas[3] },
                new Recarga { Codigo = 1005, NumeroSerie = 222, Tipo = listaDeTiposRecargas[2] },
                new Recarga { Codigo = 1006, NumeroSerie = 222, Tipo = listaDeTiposRecargas[2] },
                new Recarga { Codigo = 1007, NumeroSerie = 333, Tipo = listaDeTiposRecargas[3] },
                new Recarga { Codigo = 1008, NumeroSerie = 333, Tipo = listaDeTiposRecargas[2] },
                new Recarga { Codigo = 1009, NumeroSerie = 333, Tipo = listaDeTiposRecargas[5] },
                new Recarga { Codigo = 1010, NumeroSerie = 111, Tipo = listaDeTiposRecargas[0] },
                new Recarga { Codigo = 1011, NumeroSerie = 111, Tipo = listaDeTiposRecargas[1] },
                new Recarga { Codigo = 1012, NumeroSerie = 222, Tipo = listaDeTiposRecargas[2] },
                new Recarga { Codigo = 1013, NumeroSerie = 222, Tipo = listaDeTiposRecargas[3] },
                new Recarga { Codigo = 1014, NumeroSerie = 222, Tipo = listaDeTiposRecargas[2] },
                new Recarga { Codigo = 1015, NumeroSerie = 222, Tipo = listaDeTiposRecargas[0] },
                new Recarga { Codigo = 1016, NumeroSerie = 333, Tipo = listaDeTiposRecargas[0] },
                new Recarga { Codigo = 1017, NumeroSerie = 333, Tipo = listaDeTiposRecargas[2] },
                new Recarga { Codigo = 1018, NumeroSerie = 333, Tipo = listaDeTiposRecargas[5] },
            };
        }

        public void InicializarTiposRecargas()
        {
            this.listaDeTiposRecargas = new List<TipoRecarga>
            {
                new TipoRecarga { CodigoTipo = 1, NomeTipo = "Saldo 100", Preco  = 100 },
                new TipoRecarga { CodigoTipo = 2, NomeTipo = "Saldo 200", Preco  = 200 },
                new TipoRecarga { CodigoTipo = 3, NomeTipo = "Saldo 500", Preco  = 500 },
                new TipoRecarga { CodigoTipo = 4, NomeTipo = "Saldo 1000", Preco  = 1000 },
                new TipoRecarga { CodigoTipo = 5, NomeTipo = "Saldo 1500", Preco  = 1500 },
                new TipoRecarga { CodigoTipo = 6, NomeTipo = "Saldo 2000", Preco  = 2000 },
                new TipoRecarga { CodigoTipo = 7, NomeTipo = "Saldo 5000", Preco  = 5000 },
                new TipoRecarga { CodigoTipo = 8, NomeTipo = "Saldo 10000", Preco  = 10000 },
            };
        }
        
        public List<TipoRecarga> ObterTiposRecarga()
        {
            return listaDeTiposRecargas;
        }
        public void AdicionarCarregamento(Carregamento carregamento)
        {
            listaDeCarregamentos.Add(carregamento);   
        }

        public List<Recarga> ObterRecargasUtilizadas()
        {
            List<Recarga> utilizadas = new();
            foreach (Recarga recarga in listaDeRecargas)
            {
                if (recarga.Estado == EstadosRecarga.Utilizada)
                {
                    utilizadas.Add(recarga);
                }
            }
            return utilizadas;
        }

        public List<Recarga> ObterRecargasInUtilizadas()
        {
            List<Recarga> inUtilizadas = new();
            foreach (Recarga recarga in listaDeRecargas)
            {
                if (recarga.Estado == EstadosRecarga.Inutilizada)
                {
                    inUtilizadas.Add(recarga);
                }
            }
            return inUtilizadas;
        }

        public List<Carregamento> ObterCarregamentosSucedidos()
        {
            List<Carregamento> bemSucedidos = new();
            foreach (Carregamento carregamento in listaDeCarregamentos)
            {
                if (carregamento.Estado == EstadosCarregamento.BemSucedido)
                {
                    bemSucedidos.Add(carregamento);
                }
            }
            return bemSucedidos;
        }

        public List<Carregamento> ObterCarregamentosFalhados()
        {
            List<Carregamento> malSucedidos = new();
            foreach (Carregamento carregamento in listaDeCarregamentos)
            {
                if (carregamento.Estado == EstadosCarregamento.MalSucedido)
                {
                    malSucedidos.Add(carregamento);
                }
            }
            return malSucedidos;
        }


        public Recarga ObterRecarga(int codigo)
        {
            Recarga result = new();
            foreach (Recarga recarga in listaDeRecargas)
            {
                if (recarga?.Tipo?.CodigoTipo == codigo)
                {
                    result = recarga;
                    break;
                }
            }
            return result;
        }

        public void MostrarTodasRecargas()
        {
            Recarga.MostrarLabel();
            foreach (Recarga recarga in listaDeRecargas)
            {
                WriteLine(recarga);
            }
        }

        public void MostrarTodosCarregamentos()
        {
            Recarga.MostrarLabel();
            foreach (Carregamento carregamento in listaDeCarregamentos)
            {
                WriteLine(carregamento);
            }
        }

        public void EfectuarCarregamento(Recarga recarga, Cliente cliente)
        {
            Carregamento carregamento = new Carregamento
            {
                Cliente = cliente,
                Recarga = recarga,
                DataCarregamento = DateTime.Now
            };
            foreach (Recarga recargaExistente in listaDeRecargas)
            {
               
                if (recargaExistente.Codigo == recarga.Codigo)
                {
                    recarga.Estado = EstadosRecarga.Utilizada;
                    carregamento.Estado = EstadosCarregamento.BemSucedido;
                    WriteLine(Mensagem.CarregamentoEfectuado);
                    break;
                }
                else
                {
                    recarga.Estado = EstadosRecarga.Inutilizada;
                    carregamento.Estado = EstadosCarregamento.MalSucedido;
                    WriteLine(Mensagem.ErroCarregamento);
                    break;
                }
            }
            listaDeRecargasEfectuadas.Add(recarga);
            listaDeCarregamentos.Add(carregamento);
        }

    }
}
