﻿using PokeCards.Pokeapi.Adapter.Models.Common;

namespace PokeCards.Pokeapi.Adapter.Models.Contests
{
    public class ContestName
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public NamedApiResource Language { get; set; }
    }
}
