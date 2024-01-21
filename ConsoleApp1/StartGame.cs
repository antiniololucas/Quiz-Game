using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    static class StartGame
    {
        public static async Task Start()
        {
            Connection con = new Connection();
            await con.Conectar();

            Game game = new Game();
            Console.WriteLine("Welcome to the game");
            game.ReadQuestions(con.ObjApi);
        }
    }
}
