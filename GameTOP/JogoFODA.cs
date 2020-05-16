using GameTOP.Interface;

namespace GameTOP
{
    public class JogoFODA
    {
        private readonly iJogador _jogadorA;

        private readonly iJogador _jogadorB;

        public JogoFODA(iJogador jogadorA, iJogador jogadorB)
        {
            this._jogadorA = jogadorA;
            this._jogadorB = jogadorB;
        }
        public void IniciarJogo()
        {
            System.Console.Write(this._jogadorA.corre());
            System.Console.Write(this._jogadorA.chuta());
            System.Console.Write(this._jogadorA.passe());

            System.Console.Write("\n PRÓXIMO JOGADOR \n\n");

            System.Console.Write(this._jogadorB.corre());
            System.Console.Write(this._jogadorB.chuta());
            System.Console.Write(this._jogadorB.passe());
        }
    }
}