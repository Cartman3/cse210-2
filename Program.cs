using unit02_hilo;

namespace unit02_hilo
{
    class Program{
        ///Begins game
        static int Main(string[] args){
            PlayGame playGame = new PlayGame();
            playGame.StartGame();
            return 0;
        }
    }
}