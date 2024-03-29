﻿using PokeCards.Pokeapi.Adapter.Models.Common;
using System.Collections.Generic;

namespace PokeCards.Pokeapi.Adapter.Models.Berries
{
    public class BerryFirmness
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<NamedApiResource> Berries { get; set; }
        public IList<Name> Names { get; set; }
    }
}
