﻿using System.Collections.Generic;

namespace pk3DS.Core.Structures.AXExports
{
    // Pkm
    public class ExportPokemonSite
    {
        public int SpeciesIdx { get; set; }
        public string Type1 { get; set; }
        public string Type2 { get; set; }
        public string Ability1 { get; set; }
        public string Ability2 { get; set; }
        public string AbilityH { get; set; }
        public Dictionary<string, int> BaseStats { get; set; }
        public int CatchRate { get; set; }
        public int BaseXP { get; set; }
        public string GrowthRate { get; set; }
        public List<ExportPokemonTM> TMs { get; set; } = new();

        public ExportPokemonSite() { }
    }

    public class ExportPokemonTM
    {
        public string Label { get; set; }
        public string Move { get; set; }

        public ExportPokemonTM() { }
    }

    // Trainers
    public class ExportTrPkmSite
    {
        public string Name { get; set; }
        public string Form { get; set; }
        public string Gender { get; set; } = "";
        public int Level { get; set; }
        public string Ability { get; set; }
        public string HeldItem { get; set; }
        public string Nature { get; set; }
        public int IVs { get; set; }
        public string[] Moves { get; set; } = new string[4] { "", "", "", "" };

        public ExportTrPkmSite() { }
    }

    public class ExportTrSite
    {
        public List<ExportTrPkmSite> Pokemon { get; set; } = new();

        public int TrainerID { get; set; }
        public string TrainerClass { get; set; }
        public string BattleType { get; set; }

        public ExportTrSite() { }
    }

    // Level Up Moves
    public class ExportLevelUpMoveSite
    {
        public int Level { get; set; }
        public string Move { get; set; }

        public ExportLevelUpMoveSite() { }
    }

    // Evos
    public class ExportEvoSite
    {
        public string EvolvesFrom { get; set; }
        public string FromMethod { get; set; }

        public Dictionary<string, string> EvolvesInto { get; set; } = new();

        public ExportEvoSite() { }
    }

    public class ExportMoveDataSite
    {
        public string Type { get; set; }
        public string Category { get; set; }
        public int Power { get; set; }
        public int Acc { get; set; }
        public int PP { get; set; }
        public string Description { get; set; }

        public ExportMoveDataSite() { }
    }
}
