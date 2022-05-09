using System;
using System.Collections.Generic;
using System.Linq;

namespace ArenaGenerator.Arenas
{
   public static class ArenaPopulator
   {
      public static IEnumerable<string> Populate(BattleArena arena, int arenaStartX, int arenaStartY, int arenaEndX, int arenaEndY)
      {
         switch (arena.Orientation)
         {
            case ArenaOrientation.N_S: return PopulateNorth(arena.Parties[0], arenaStartX, arenaStartY, arenaEndX).Concat(PopulateSouth(arena.Parties[1], arenaStartX, arenaEndX, arenaEndY));
            case ArenaOrientation.S_N: return PopulateSouth(arena.Parties[0], arenaStartX, arenaEndX, arenaEndY).Concat(PopulateNorth(arena.Parties[1], arenaStartX, arenaStartY, arenaEndX));
            case ArenaOrientation.W_E: return PopulateWest(arena.Parties[0], arenaStartX, arenaStartY, arenaEndY).Concat(PopulateEast(arena.Parties[1], arenaStartY, arenaEndX, arenaEndY));
            case ArenaOrientation.E_W: return PopulateEast(arena.Parties[0], arenaStartY, arenaEndX, arenaEndY).Concat(PopulateWest(arena.Parties[1], arenaStartX, arenaStartY, arenaEndY));
            default: throw new NotImplementedException();
         }
      }

      private static IEnumerable<string> PopulateNorth(ArenaParty party, int arenaStartX, int arenaStartY, int arenaEndX)
      {
         var currentX = arenaStartX;
         var currentY = arenaStartY;
         foreach (var unit in party.Units)
         {
            yield return $"{currentX}, {currentY}, 0, 128, {party.Player}, 100, 0, 0, {unit}";
            currentX++;
            if (currentX > arenaEndX)
            {
               currentX = arenaStartX;
               currentY++;
            }
         }
      }
      private static IEnumerable<string> PopulateSouth(ArenaParty party, int arenaStartX, int arenaEndX, int arenaEndY)
      {
         var currentX = arenaEndX;
         var currentY = arenaEndY;
         foreach (var unit in party.Units)
         {
            yield return $"{currentX}, {currentY}, 0, 0, {party.Player}, 100, 0, 0, {unit}";
            currentX--;
            if (currentX < arenaStartX)
            {
               currentX = arenaEndX;
               currentY--;
            }
         }
      }
      private static IEnumerable<string> PopulateWest(ArenaParty party, int arenaStartX, int arenaStartY, int arenaEndY)
      {
         var currentX = arenaStartX;
         var currentY = arenaStartY;
         foreach (var unit in party.Units)
         {
            yield return $"{currentX}, {currentY}, 0, 64, {party.Player}, 100, 0, 0, {unit}";
            currentY++;
            if (currentY > arenaEndY)
            {
               currentY = arenaStartY;
               currentX++;
            }
         }
      }
      private static IEnumerable<string> PopulateEast(ArenaParty party, int arenaStartY, int arenaEndX, int arenaEndY)
      {
         var currentX = arenaEndX;
         var currentY = arenaEndY;
         foreach (var unit in party.Units)
         {
            yield return $"{currentX}, {currentY}, 0, 192, {party.Player}, 100, 0, 0, {unit}";
            currentY--;
            if (currentY < arenaStartY)
            {
               currentY = arenaEndY;
               currentX--;
            }
         }
      }
   }
}
