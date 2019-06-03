﻿using PokeCards.Pokeapi.Adapter.Models.Common;
using System.Collections.Generic;

namespace PokeCards.Pokeapi.Adapter.Models.Moves
{
    public class MoveBattleStyle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Name> Names { get; set; }
    }
}
