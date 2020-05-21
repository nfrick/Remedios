using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace DataLayer {
    public partial class AnvisaRemedio {
        public string ProdutoNome => Produto.Nome;

        public string LaboratorioNome => Laboratorio.Nome;

        public string ClasseTerapeuticaNome => ClasseTerapeutica.Nome;

        public string TipoDeProdutoNome => TiposDeProduto.Nome;

        public Color TarjaColor => TarjaID == 1 ? Color.Black : (TarjaID == 2 ? Color.Red : Color.Green);
        public string TarjaNome => Tarja.Nome;

        public string PrincipioAtivo => string.Join(", ", PrincipiosAtivos
            .Select(p => p.Nome).OrderBy(p => p).ToArray());

        public int Matches { get; private set; }

        public void SetMatches(IEnumerable<PrincipioAtivo> principios) {
            Matches = PrincipiosAtivos.Intersect(principios).Count();
        }
    }
}
