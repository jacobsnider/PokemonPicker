using System;
using CsvHelper.Configuration.Attributes;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonPicker
{
    public class Pokemon
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public string Type1 { get; set; }
        public string Type2 { get; set; }
        public int Total { get; set; }
        public int HP { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int SpcAtck { get; set; }
        public int SpcDef { get; set; }
        public int Speed { get; set; }
        public int Generation { get; set; }
        public string Legendary { get; set; }

        /// <summary>
        /// Print each property name with it's value on a new line
        /// </summary>
        /// <returns>A string.... duh</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("\nNumber: ").Append(Number)
                .Append("Name: ").Append(Name)
                .Append("Type1: ").Append(Type1)
                .Append("Type2: ").Append(Type2)
                .Append("\nTotal: ").Append(Total)
                .Append("\nHP: ").Append(HP)
                .Append("\nAttack: ").Append(Attack)
                .Append("\nDefense: ").Append(Defense)
                .Append("\nSpcAtck: ").Append(SpcAtck)
                .Append("\nSpcDef: ").Append(SpcDef)
                .Append("\nSpeed: ").Append(Speed)
                .Append("\nGeneration: ").Append(Generation)
                .Append("Legendary: ").Append(Legendary);

            return sb.ToString();
        }
    }
}