using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador1 : iJogador
    {
        public readonly string _nome;

        public Jogador1(string nome = "Ronaldo")
        {
            this._nome = nome;
        }

        //Chuta
        public string chuta()
        {
            return $"{_nome} está chutando. \n";
        }

        //Corre
        public string corre()
        {
            return $"{_nome} está correndo. \n";
        }

        //Passe
        public string passe()
        {
            return $"{_nome} está passando. \n";
        }
    }
}