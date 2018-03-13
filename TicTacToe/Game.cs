using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Game
    {
        public int[] board = new int[9]; //-1 used to denote open space, 0 is squared marked O, 1 is square marked X
       public int turncount = 1;


        public Game()
        {
            CreateBoard();
        }

        public void CreateBoard()
        {
            for (int i = 0; i < board.Length; i++)
            {
                board[i] = -1;
            }
        }

        public void ChangePlayer()
        {
            turncount++;
        }


        public char CurrentPlayer()
        {
            

            if(turncount % 2 == 1)
            {
                return 'X';
            }

            else
            {
                return 'O';
            }

        }

        public void MakeMove(int x)
        {
            board[x] = turncount % 2;
            ChangePlayer();

        }

        public bool SpaceInUse(int x)
        {
            return x != -1; //since zero denotes an unused space, this works.
        }


    }
}
