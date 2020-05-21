using System.Linq;
using System.Net.Sockets;

namespace DataLayer {
    public partial class Remedio {
        public override string ToString() {
            return $"{Nome}";
        }

        public string NomeApresentacao => $"{Nome} ({Apresentacao})";

        public string QtdUnidade => $"{Quantidade} {Unidade}";

        public string CategoriasCSV => Categorias.Any() ?
            Categorias.Select(c=>c.Nome).OrderBy(c=>c)
            .Aggregate((accumulator, piece) => accumulator + ", " + piece) :
            string.Empty;

        public string IndicacoesCSV => Indicacoes.Any() ?
            Indicacoes.Select(c => c.Nome).OrderBy(c => c)
            .Aggregate((accumulator, piece) => accumulator + ", " + piece) :
            string.Empty;

        public string PrincipiosCSV => Principios.Any() ?
            Principios.Select(c => c.Nome).OrderBy(c => c)
            .Aggregate((accumulator, piece) => accumulator + ", " + piece) :
            string.Empty;
    }

    public partial class Principio {
        public override string ToString() {
            return $"{Nome}, remédio {Remedio.Nome}";
        }
    }
}
