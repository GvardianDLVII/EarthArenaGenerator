using ArenaGenerator.Arenas;
using ArenaGenerator.GameParams;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ArenaGenerator
{
   class Program
   {
      static void Main(string[] args)
      {
         new LevelGenerator().GenerateLevel(
            ArenaFactory.Create(new ArmyInput(UnitTemplates.CraterM3_hE, 100), new ArmyInput(UnitTemplates.CraterM3_hE, 100), ArenaType.Open),
            ArenaFactory.Create(new ArmyInput(UnitTemplates.CraterM3_hE, 100), new ArmyInput(UnitTemplates.CraterM3_hE, 100), ArenaType.Closed),
            ArenaFactory.Create(new ArmyInput(UnitTemplates.CraterM3_hE, 100), new ArmyInput(UnitTemplates.CraterM3_hE, 100), ArenaType.SemiOpen),
            ArenaFactory.Create(new ArmyInput(UnitTemplates.CraterM3_hE, 100), new ArmyInput(UnitTemplates.CraterM3_hE, 100), ArenaType.Dotted),
            ArenaFactory.Create(new ArmyInput(UnitTemplates.CraterM3_hE, 100), new ArmyInput(UnitTemplates.CraterM3_hE, 100), ArenaType.Passages),
            ArenaFactory.Create(new ArmyInput(UnitTemplates.CraterM3_hE_P, 100), new ArmyInput(UnitTemplates.CraterM3_hE_P, 100), ArenaType.Open),
            ArenaFactory.Create(new ArmyInput(UnitTemplates.CraterM3_hE_P, 100), new ArmyInput(UnitTemplates.CraterM3_hE_P, 100), ArenaType.Closed),
            ArenaFactory.Create(new ArmyInput(UnitTemplates.CraterM3_hE_P, 100), new ArmyInput(UnitTemplates.CraterM3_hE_P, 100), ArenaType.SemiOpen),
            ArenaFactory.Create(new ArmyInput(UnitTemplates.CraterM3_hE_P, 100), new ArmyInput(UnitTemplates.CraterM3_hE_P, 100), ArenaType.Dotted),
            ArenaFactory.Create(new ArmyInput(UnitTemplates.CraterM3_hE_P, 100), new ArmyInput(UnitTemplates.CraterM3_hE_P, 100), ArenaType.Passages),
            ArenaFactory.Create(new ArmyInput(UnitTemplates.Panther3_hP, 100), new ArmyInput(UnitTemplates.Panther3_hP, 100), ArenaType.Open),
            ArenaFactory.Create(new ArmyInput(UnitTemplates.Panther3_hP, 100), new ArmyInput(UnitTemplates.Panther3_hP, 100), ArenaType.Closed),
            ArenaFactory.Create(new ArmyInput(UnitTemplates.Panther3_hP, 100), new ArmyInput(UnitTemplates.Panther3_hP, 100), ArenaType.SemiOpen),
            ArenaFactory.Create(new ArmyInput(UnitTemplates.Panther3_hP, 100), new ArmyInput(UnitTemplates.Panther3_hP, 100), ArenaType.Dotted),
            ArenaFactory.Create(new ArmyInput(UnitTemplates.Panther3_hP, 100), new ArmyInput(UnitTemplates.Panther3_hP, 100), ArenaType.Passages),
            ArenaFactory.Create(new ArmyInput(UnitTemplates.Kauki_hL, 100), new ArmyInput(UnitTemplates.Kauki_hL, 100), ArenaType.Open),
            ArenaFactory.Create(new ArmyInput(UnitTemplates.Kauki_hL, 100), new ArmyInput(UnitTemplates.Kauki_hL, 100), ArenaType.Closed),
            ArenaFactory.Create(new ArmyInput(UnitTemplates.Kauki_hL, 100), new ArmyInput(UnitTemplates.Kauki_hL, 100), ArenaType.SemiOpen),
            ArenaFactory.Create(new ArmyInput(UnitTemplates.Kauki_hL, 100), new ArmyInput(UnitTemplates.Kauki_hL, 100), ArenaType.Dotted),
            ArenaFactory.Create(new ArmyInput(UnitTemplates.Kauki_hL, 100), new ArmyInput(UnitTemplates.Kauki_hL, 100), ArenaType.Passages),
            ArenaFactory.Create(new ArmyInput(UnitTemplates.Jaguar2_hP_P, 30, UnitTemplates.Spider3_P, 70), new ArmyInput(UnitTemplates.Jaguar2_hP_P, 30, UnitTemplates.Spider3_P, 70), ArenaType.Open),
            ArenaFactory.Create(new ArmyInput(UnitTemplates.Jaguar2_hP_P, 30, UnitTemplates.Spider3_P, 70), new ArmyInput(UnitTemplates.Jaguar2_hP_P, 30, UnitTemplates.Spider3_P, 70), ArenaType.Closed),
            ArenaFactory.Create(new ArmyInput(UnitTemplates.Jaguar2_hP_P, 30, UnitTemplates.Spider3_P, 70), new ArmyInput(UnitTemplates.Jaguar2_hP_P, 30, UnitTemplates.Spider3_P, 70), ArenaType.SemiOpen),
            ArenaFactory.Create(new ArmyInput(UnitTemplates.Jaguar2_hP_P, 30, UnitTemplates.Spider3_P, 70), new ArmyInput(UnitTemplates.Jaguar2_hP_P, 30, UnitTemplates.Spider3_P, 70), ArenaType.Dotted),
            ArenaFactory.Create(new ArmyInput(UnitTemplates.Jaguar2_hP_P, 30, UnitTemplates.Spider3_P, 70), new ArmyInput(UnitTemplates.Jaguar2_hP_P, 30, UnitTemplates.Spider3_P, 70), ArenaType.Passages),
            ArenaFactory.Create(new ArmyInput(UnitTemplates.CraterM3_hS, 100), new ArmyInput(UnitTemplates.CraterM3_hS, 100), ArenaType.Open),
            ArenaFactory.Create(new ArmyInput(UnitTemplates.CraterM3_hS, 100), new ArmyInput(UnitTemplates.CraterM3_hS, 100), ArenaType.Closed),
            ArenaFactory.Create(new ArmyInput(UnitTemplates.CraterM3_hS, 100), new ArmyInput(UnitTemplates.CraterM3_hS, 100), ArenaType.SemiOpen),
            ArenaFactory.Create(new ArmyInput(UnitTemplates.CraterM3_hS, 100), new ArmyInput(UnitTemplates.CraterM3_hS, 100), ArenaType.Dotted),
            ArenaFactory.Create(new ArmyInput(UnitTemplates.CraterM3_hS, 100), new ArmyInput(UnitTemplates.CraterM3_hS, 100), ArenaType.Passages)


            /*ArenaFactory.Create(new ArmyInput(UnitTemplates.CraterM3_hS, 100), new ArmyInput(UnitTemplates.CraterM3_hS, 100), ArenaType.Open),
            ArenaFactory.Create(new ArmyInput(UnitTemplates.MoonM3_E, 100), new ArmyInput(UnitTemplates.MoonM3_E, 100), ArenaOrientation.N_S),
            ArenaFactory.Create(new ArmyInput(UnitTemplates.MoonM3_S, 100), new ArmyInput(UnitTemplates.MoonM3_S, 100), ArenaOrientation.N_S),
            ArenaFactory.Create(new ArmyInput(UnitTemplates.MoonM3_P, 100), new ArmyInput(UnitTemplates.MoonM3_P, 100), ArenaOrientation.N_S),
            ArenaFactory.Create(new ArmyInput(UnitTemplates.CraterM3_hE, 30, UnitTemplates.MoonM3_E, 70), new ArmyInput(UnitTemplates.CraterM3_hE, 30, UnitTemplates.MoonM3_E, 70), ArenaOrientation.N_S),
            ArenaFactory.Create(new ArmyInput(UnitTemplates.CraterM3_hE, 100), new ArmyInput(UnitTemplates.CraterM3_hE, 100), ArenaOrientation.S_N),
            ArenaFactory.Create(new ArmyInput(UnitTemplates.CraterM3_hS, 100), new ArmyInput(UnitTemplates.CraterM3_hS, 100), ArenaOrientation.S_N),
            ArenaFactory.Create(new ArmyInput(UnitTemplates.MoonM3_E, 100), new ArmyInput(UnitTemplates.MoonM3_E, 100), ArenaOrientation.S_N),
            ArenaFactory.Create(new ArmyInput(UnitTemplates.MoonM3_S, 100), new ArmyInput(UnitTemplates.MoonM3_S, 100), ArenaOrientation.S_N),
            ArenaFactory.Create(new ArmyInput(UnitTemplates.MoonM3_P, 100), new ArmyInput(UnitTemplates.MoonM3_P, 100), ArenaOrientation.S_N),
            ArenaFactory.Create(new ArmyInput(UnitTemplates.CraterM3_hE, 30, UnitTemplates.MoonM3_E, 70), new ArmyInput(UnitTemplates.CraterM3_hE, 30, UnitTemplates.MoonM3_E, 70), ArenaOrientation.S_N),
            ArenaFactory.Create(new ArmyInput(UnitTemplates.Tiger3_P, 100), new ArmyInput(UnitTemplates.Tiger3_P, 100), ArenaOrientation.N_S),
            ArenaFactory.Create(new ArmyInput(UnitTemplates.Spider3_P, 100), new ArmyInput(UnitTemplates.Spider3_P, 100), ArenaOrientation.N_S),
            ArenaFactory.Create(new ArmyInput(UnitTemplates.Panther3_hP, 100), new ArmyInput(UnitTemplates.Panther3_hP, 100), ArenaOrientation.N_S),
            ArenaFactory.Create(new ArmyInput(UnitTemplates.Jaguar2_hP, 100), new ArmyInput(UnitTemplates.Jaguar2_hP, 100), ArenaOrientation.N_S),
            ArenaFactory.Create(new ArmyInput(UnitTemplates.Grizzly3_hP, 100), new ArmyInput(UnitTemplates.Grizzly3_hP, 100), ArenaOrientation.N_S),
            ArenaFactory.Create(new ArmyInput(UnitTemplates.Panther3_hP, 30, UnitTemplates.Spider3_P, 70), new ArmyInput(UnitTemplates.Panther3_hP, 30, UnitTemplates.Spider3_P, 70), ArenaOrientation.N_S),
            ArenaFactory.Create(new ArmyInput(UnitTemplates.Tiger3_P, 100), new ArmyInput(UnitTemplates.Tiger3_P, 100), ArenaOrientation.S_N),
            ArenaFactory.Create(new ArmyInput(UnitTemplates.Spider3_P, 100), new ArmyInput(UnitTemplates.Spider3_P, 100), ArenaOrientation.S_N),
            ArenaFactory.Create(new ArmyInput(UnitTemplates.Panther3_hP, 100), new ArmyInput(UnitTemplates.Panther3_hP, 100), ArenaOrientation.S_N),
            ArenaFactory.Create(new ArmyInput(UnitTemplates.Jaguar2_hP, 100), new ArmyInput(UnitTemplates.Jaguar2_hP, 100), ArenaOrientation.S_N),
            ArenaFactory.Create(new ArmyInput(UnitTemplates.Grizzly3_hP, 100), new ArmyInput(UnitTemplates.Grizzly3_hP, 100), ArenaOrientation.S_N),
            ArenaFactory.Create(new ArmyInput(UnitTemplates.Panther3_hP, 30, UnitTemplates.Spider3_P, 70), new ArmyInput(UnitTemplates.Panther3_hP, 30, UnitTemplates.Spider3_P, 70), ArenaOrientation.S_N),
            ArenaFactory.Create(new ArmyInput(UnitTemplates.Siberia_L, 150), new ArmyInput(UnitTemplates.Siberia_L, 150), ArenaOrientation.N_S),
            ArenaFactory.Create(new ArmyInput(UnitTemplates.Kauki_hL, 100), new ArmyInput(UnitTemplates.Kauki_hL, 100), ArenaOrientation.N_S),
            ArenaFactory.Create(new ArmyInput(UnitTemplates.Ural_hL, 100), new ArmyInput(UnitTemplates.Ural_hL, 100), ArenaOrientation.N_S),
            ArenaFactory.Create(new ArmyInput(UnitTemplates.Kauki_hL, 30, UnitTemplates.Siberia_L, 70), new ArmyInput(UnitTemplates.Kauki_hL, 30, UnitTemplates.Siberia_L, 70), ArenaOrientation.N_S),
            ArenaFactory.Create(new ArmyInput(UnitTemplates.Siberia_L, 150), new ArmyInput(UnitTemplates.Siberia_L, 150), ArenaOrientation.S_N),
            ArenaFactory.Create(new ArmyInput(UnitTemplates.Kauki_hL, 100), new ArmyInput(UnitTemplates.Kauki_hL, 100), ArenaOrientation.S_N),
            ArenaFactory.Create(new ArmyInput(UnitTemplates.Ural_hL, 100), new ArmyInput(UnitTemplates.Ural_hL, 100), ArenaOrientation.S_N),
            ArenaFactory.Create(new ArmyInput(UnitTemplates.Kauki_hL, 30, UnitTemplates.Siberia_L, 70), new ArmyInput(UnitTemplates.Kauki_hL, 30, UnitTemplates.Siberia_L, 70), ArenaOrientation.S_N)*/
            );
      }
   }

   public static class ArenaFactory
   {
      public static BattleArena Create(ArmyInput army1, ArmyInput army2, ArenaType type = ArenaType.Open, ArenaOrientation orientation = ArenaOrientation.N_S)
      {
         var arena = new BattleArena(type: type, orientation: orientation);
         arena.Parties[0] = new ArenaParty
         {
            Player = 0,
            Units = CreateUnits(army1)
         };

         arena.Parties[1] = new ArenaParty
         {
            Player = 1,
            Units = CreateUnits(army2)
         };

         return arena;
      }

      private static IList<Unit> CreateUnits(ArmyInput input)
      {
         var random = new Random();
         return input.Groups.SelectMany(g => Enumerable.Range(0, g.Count).Select(_ => g.Unit())).OrderBy(_ => random.Next()).ToList();
      }
   }

   public class ArmyInput
   {
      public IList<ArmyGroupInfo> Groups { get; init; }
      public ArmyInput(Func<Unit> unit, int count)
      {
         Groups = new List<ArmyGroupInfo>
         {
            new ArmyGroupInfo
            {
               Unit = unit,
               Count = count
            }
         };
      }
      public ArmyInput(Func<Unit> unit, int count, Func<Unit> unit2, int count2)
      {
         Groups = new List<ArmyGroupInfo>
         {
            new ArmyGroupInfo
            {
               Unit = unit,
               Count = count
            },
            new ArmyGroupInfo
            {
               Unit = unit2,
               Count = count2
            }
         };
      }
   }

   public class ArmyGroupInfo
   {
      public Func<Unit> Unit { get; set; }
      public int Count { get; set; }
   }
}
