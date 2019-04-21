
namespace tabuleiro {
    abstract class Peca {

        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }  //acessada por ela mesmo e pela sub classes dela
        public int qteMovimento { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor) {
            this.posicao = null;
            this.cor = cor;
            this.tab = tab;
            this.qteMovimento = 0;
        }

        public void incrementarQteMovimentos() {
            qteMovimento++;
        }

        public void decrementarQteMovimentos() {
            qteMovimento--;
        }

        public bool existeMovimentosPossiveis() {
            bool[,] mat = movimentosPossiveis();
            for (int i=0; i<tab.linhas; i++) {
                for (int j=0; j<tab.colunas; j++) {
                    if (mat[i, j]) {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool movimentoPossivel(Posicao pos) {
            return movimentosPossiveis()[pos.linha, pos.coluna];
        }

        public abstract bool[,] movimentosPossiveis();

            
        
    }
}
