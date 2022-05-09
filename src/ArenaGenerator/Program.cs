using ArenaGenerator.Arenas;
using ArenaGenerator.GameParams;
using System.Linq;

namespace ArenaGenerator
{
   class Program
   {
      static void Main(string[] args)
      {
         var arenas = Enumerable.Range(0, 24).Select(i =>
         {
            var arena = BattleArena.CreateStandard();
            arena.Parties[0] = new ArenaParty
            {
               Player = 0,
               Units = Enumerable.Range(0, 100).Select(_ => UnitTemplates.CraterM3_hE).ToList()
            };

            arena.Parties[1] = new ArenaParty
            {
               Player = 1,
               Units = Enumerable.Range(0, 100).Select(_ => UnitTemplates.CraterM3_hE).ToList()
            };

            arena.Orientation = i < 6 ? ArenaOrientation.N_S
               : i < 12 ? ArenaOrientation.S_N
               : i < 18 ? ArenaOrientation.W_E
               : ArenaOrientation.E_W;
            return arena;
         }).ToArray();

         new LevelGenerator().GenerateLevel(arenas);
      }
   }
}
