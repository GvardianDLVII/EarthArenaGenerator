using Ieo.EarthFileApi.Files;

namespace ArenaGenerator.Arenas
{
   public class ArenaBuilder
   {
      private readonly int _arenaStartX;
      private readonly int _arenaStartY;
      private readonly int _arenaEndX;
      private readonly int _arenaEndY;
      private readonly BattleArena _arena;

      public ArenaBuilder(BattleArena arena, int startX, int startY)
      {
         _arena = arena;
         _arenaStartX = startX;
         _arenaStartY = startY;
         _arenaEndX = _arenaStartX + _arena.Width - 1;
         _arenaEndY = _arenaStartY + _arena.Height - 1;
      }

      public void ApplyTo(EarthFile<EarthMisData> misFile)
      {
         ApplyPlayers(misFile);
         BuildArena(misFile);
         ApplyArmies(misFile);
      }
      private void ApplyPlayers(EarthFile<EarthMisData> misFile)
      {
         foreach (var party in _arena.Parties)
         {
            misFile.Data.Players[party.Player].StartPositionX = (byte)(0x20 + party.Player);
            misFile.Data.Players[party.Player].StartPositionY = (byte)(0x20 + party.Player);
            misFile.Data.Players[party.Player].UnknownField = 0x5;
         }
      }

      private void BuildArena(EarthFile<EarthMisData> misFile)
      {
         for (int i = _arenaStartX - 5; i <= _arenaEndX + 5; i++)
         {
            for (int j = _arenaStartY - 5; j <= _arenaEndY + 5; j++)
            {
               if (i < _arenaStartX || i > _arenaEndX || j < _arenaStartY || j > _arenaEndY)
               {
                  misFile.Data.Objects.Add($"{i}, {j}, 0, 0, 0, 100, 0, 0, -1 NEBWALL0");
               }
            }
         }
      }

      private void ApplyArmies(EarthFile<EarthMisData> misFile)
      {
         foreach (var unit in ArenaPopulator.Populate(_arena, _arenaStartX, _arenaStartY, _arenaEndX, _arenaEndY))
         {
            misFile.Data.Objects.Add(unit);
         }
      }
   }
}
