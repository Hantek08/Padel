using System;

namespace Padel
{
    public class Player
    {
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; } // Changed from set and get to get and set 
        public Score Score { get; set; } = new Score(); //Added new Score so we won't get null reference when we call Score. 


        public Player(string name )
        {
            if(string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Empty name");
            }
            Name = name;
        }


        public void Point()
        {
            Score.Increase();
        }

      
    }
}
