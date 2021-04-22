using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador : IJogador
    {
        public readonly string Nome;

        public Jogador(string nome = "Ronaldo")
        {
            Nome = nome;
        }

        public string Chutar()
        {
            return $"{Nome} está Chutando\n";
        }
        public string Correr()
        {
            return $"{Nome} está Correndo\n";
        }
        public string Passar()
        {
            return $"{Nome} está Passando\n";
        }
    }
}