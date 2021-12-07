using System;
using System.Collections.Generic;

namespace Padel
{
    public class Set
    {
        /// <summary>
        /// 6 games = 1 
        /// Read-only Auto-Property with expression bodied 
        /// </summary>
        public List<Game> _Games { get; } = new List<Game>(); 
      
        public void Point(Player player)
        {

            _Games[0].Point(player); 

        }
                
    }
}
