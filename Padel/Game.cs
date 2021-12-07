using System;

namespace Padel
{

    public class Game
    {
        public Player _player1 { get; } // Changed to public so it can be accessed from outside the class. 
        public Player _player2 { get; } 


        public Game(Player player1, Player player2)
        {
            _player1 = player1;
            _player2 = player2;// Changed from _player1 to _player2 so we won't get null reference when we call _player2
        }

        /// <summary>
        /// _player1.Point() increases only player1's point so we changed it to Player.Point() to assign a point to the correct player 
        /// </summary>
        /// <param name="player"></param>

        public void Point(Player player)
        {
           // _player1.Point(); //it only increase player1's point by one everytime Point is invoked,
           player.Point();  
            

        }
        /// <summary>
        ///  Changed from _player1.Score to Player.Score to get the score of the correct player 
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>

        public Score Score(Player player)   
        {
            //return _player1.Score;
           return player.Score;
          
        }

        /// <summary>
        /// Added another conditon that returns "The game is not over yet", when players score are less than 4 or same score. 
        /// </summary>
        /// <returns></returns>

        public string ScoreString()
        {
           if (_player1.Score._Score > 6 || _player2.Score._Score > 6)
            {
                throw new ArgumentOutOfRangeException();
            }
            else if(_player1.Score._Score >= 4 && _player1.Score._Score > _player2.Score._Score)                     
            {
                return "Player 1 wins";
            }
            else if (_player2.Score._Score >= 4 && _player2.Score._Score > _player1.Score._Score)
            {
                return "Player 2 wins";
            }
            else
                return "The game is not over yet";


        }
    }
}
