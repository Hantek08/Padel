using System;
using System.Collections.Generic;


namespace Padel
{
    public class Set 
    {
        
        public List<Game> _Games { get; } = new List<Game>();

        public void Point(Player player)
        {
            _Games[0].Point(player);

        }

    }
}