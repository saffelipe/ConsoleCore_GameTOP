using GameTOP.Interface;

namespace GameTOP
{
    public class JogoFODA
    {
        private readonly IJogador _jogador;
        private readonly IJogador _jogador1;

        public JogoFODA(IJogador jogador, IJogador jogador1)
        {
            _jogador = jogador;
            _jogador1 = jogador1;
        }

        public void IniciarJogo()
        {
            System.Console.Write(_jogador.Chutar());
            System.Console.Write(_jogador.Correr());
            System.Console.Write(_jogador.Passar());

            System.Console.Write("\nPróximo Jogador \n\n");

            System.Console.Write(_jogador1.Chutar());
            System.Console.Write(_jogador1.Correr());
            System.Console.Write(_jogador1.Passar());
        }
    }
}