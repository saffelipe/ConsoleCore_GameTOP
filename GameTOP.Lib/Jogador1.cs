using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador1 : IJogador
    {
        public string Chutar()
        {
            return "Maradona está Chutando.\n";
        }

        public string Correr()
        {
            return "Maradona está Correndo.\n";
        }

        public string Passar()
        {
            return "Maradona está Passando.\n";
        }
    }
}