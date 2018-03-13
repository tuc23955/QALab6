using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToe;

namespace Testerino
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ActiveFieldTest()
        {

            Game g = new Game();
            Assert.AreEqual(9, g.board.Length) ;

        }



        [TestMethod]
        public void CurrentPlayerX()
        {
            Game g = new Game();
            Assert.AreEqual('X', g.CurrentPlayer());
        }

        [TestMethod]
        public void CurrentPlayerO()
        {
            Game g = new Game();
            g.ChangePlayer();
            Assert.AreEqual('O', g.CurrentPlayer());
        }

        [TestMethod]
        public void XMadeMove()
        {
            Game g = new Game();
            g.MakeMove(0);  //denotes that pplayer X selected square at index 0
            Assert.AreEqual(g.board[0], 1); //1 in the field denotes that player X marked that square
        }

        [TestMethod]
        public void OMadeMove()
        {
            Game g = new Game();
            g.ChangePlayer();
            g.MakeMove(0);  //denotes that pplayer X selected square at index 0
            Assert.AreEqual(g.board[0], 0); //0 in the field denotes that player O marked that square
        }


        [TestMethod]
        public void UnoccupiedSquare()
        {
            Game g = new Game();
            
            Assert.AreEqual(g.board[0], -1); //-1 in the field denotes that player x marked that square
        }


    }
}
