using System;
using CsvHelper.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonPicker
{
    public class PokemonMap : ClassMap<Pokemon>
    {
        public PokemonMap()
        {
            Map(x => x.Number).Name("#");
            Map(x => x.Name).Name("Name");
            Map(x => x.Type1).Name("Type 1");
            Map(x => x.Type2).Name("Type 2");
            Map(x => x.Total).Name("Total");
            Map(x => x.HP).Name("HP");
            Map(x => x.Attack).Name("Attack");
            Map(x => x.Defense).Name("Defense");
            Map(x => x.SpcAtck).Name("Sp. Atk");
            Map(x => x.SpcDef).Name("Sp. Def");
            Map(x => x.Speed).Name("Speed");
            Map(x => x.Generation).Name("Generation");
            Map(x => x.Legendary).Name("Legendary");
        }
    }
}
