using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador3 : iJogador
    {
        public string chuta()
        {
            return "teste chuta. \n";
        }

        public string corre()
        {
            return "teste corre. \n";
        }

        public string passe()
        {
            return "teste passe. \n";
        }
    }
}