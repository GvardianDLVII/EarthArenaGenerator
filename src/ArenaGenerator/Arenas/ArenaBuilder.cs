using ArenaGenerator.GameParams;
using Ieo.EarthFileApi.Files;
using System;

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
            //hack: make player starts on oposite sides of the map to prevent IEO gamemode auto-ally
            misFile.Data.Players[party.Player].StartPositionX = (byte)(0x12 + party.Player + (party.Player % 2 == 0 ? 200 : 0));
            misFile.Data.Players[party.Player].StartPositionY = (byte)(0x12 + party.Player + (party.Player % 2 == 0 ? 200 : 0));
            misFile.Data.Players[party.Player].UnknownField = 0x5;
            //hack: spawn builder and a building underground to prevent becoming a sepctator in IEO gamemode
            misFile.Data.Objects.Add($"{0x20 + party.Player}, {0x20}, 1, 0, {party.Player}, 100, 0, 0, -1 {ChassisConsts.UCS.Mammoth}");
            misFile.Data.Objects.Add($"{0x20 + party.Player}, {0x21}, 1, 0, {party.Player}, 100, 0, 0, -1 UCSBET");
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
         ApplyPattern(misFile);
      }

      private void ApplyPattern(EarthFile<EarthMisData> misFile)
      {
         var midH = _arena.Width / 2;
         var midV = _arena.Height / 2;
         var arenaMidH = _arenaStartX + midH - 1;
         var arenaMidV = _arenaStartY + midV - 1;
         switch (_arena.Type)
         {
            case ArenaType.Open: return;
            case ArenaType.Closed:
               switch(_arena.Orientation)
               {
                  case ArenaOrientation.N_S:
                  case ArenaOrientation.S_N:
                     for (int i = _arenaStartX; i<= _arenaEndX; i++)
                     {
                        if (i >= arenaMidH - 1 && i <= arenaMidH + 1)
                           continue;
                        misFile.Data.Objects.Add($"{i}, {arenaMidV}, 0, 0, 0, 100, 0, 0, -1 NEBWALL0");
                        misFile.Data.Objects.Add($"{i}, {arenaMidV + 1}, 0, 0, 0, 100, 0, 0, -1 NEBWALL0");
                     }
                     return;
                  case ArenaOrientation.W_E:
                  case ArenaOrientation.E_W:
                     for (int j = _arenaStartY; j <= _arenaEndY; j++)
                     {
                        if (j >= arenaMidV - 1 && j <= arenaMidV + 2)
                           continue;
                        misFile.Data.Objects.Add($"{arenaMidH}, {j}, 0, 0, 0, 100, 0, 0, -1 NEBWALL0");
                        misFile.Data.Objects.Add($"{arenaMidH + 1}, {j}, 0, 0, 0, 100, 0, 0, -1 NEBWALL0");
                     }
                     return;
                  default: throw new NotImplementedException();
               }
            case ArenaType.SemiOpen:
               switch (_arena.Orientation)
               {
                  case ArenaOrientation.N_S:
                  case ArenaOrientation.S_N:
                     for (int i = _arenaStartX; i <= _arenaEndX; i++)
                     {
                        if (i >= arenaMidH - 3 && i <= arenaMidH + 4)
                           continue;
                        misFile.Data.Objects.Add($"{i}, {arenaMidV}, 0, 0, 0, 100, 0, 0, -1 NEBWALL0");
                        misFile.Data.Objects.Add($"{i}, {arenaMidV + 1}, 0, 0, 0, 100, 0, 0, -1 NEBWALL0");
                     }
                     return;
                  case ArenaOrientation.W_E:
                  case ArenaOrientation.E_W:
                     for (int j = _arenaStartY; j <= _arenaEndY; j++)
                     {
                        if (j >= arenaMidV - 3 && j <= arenaMidV + 4)
                           continue;
                        misFile.Data.Objects.Add($"{arenaMidH}, {j}, 0, 0, 0, 100, 0, 0, -1 NEBWALL0");
                        misFile.Data.Objects.Add($"{arenaMidH + 1}, {j}, 0, 0, 0, 100, 0, 0, -1 NEBWALL0");
                     }
                     return;
                  default: throw new NotImplementedException();
               }
            case ArenaType.Dotted:
               switch (_arena.Orientation)
               {
                  case ArenaOrientation.N_S:
                  case ArenaOrientation.S_N:
                     for (int i = _arenaStartX; i <= _arenaEndX; i++)
                     {
                        if(i % 2 == 0)
                           misFile.Data.Objects.Add($"{i}, {arenaMidV - 1}, 0, 0, 0, 100, 0, 0, -1 NEBWALL0");
                        else
                           misFile.Data.Objects.Add($"{i}, {arenaMidV + 2}, 0, 0, 0, 100, 0, 0, -1 NEBWALL0");
                     }
                     return;
                  case ArenaOrientation.W_E:
                  case ArenaOrientation.E_W:
                     for (int j = _arenaStartY; j <= _arenaEndY; j++)
                     {
                        if (j % 2 == 0)
                           misFile.Data.Objects.Add($"{arenaMidH - 1}, {j}, 0, 0, 0, 100, 0, 0, -1 NEBWALL0");
                        else
                           misFile.Data.Objects.Add($"{arenaMidH + 2}, {j}, 0, 0, 0, 100, 0, 0, -1 NEBWALL0");
                     }
                     return;
                  default: throw new NotImplementedException();
               }
            case ArenaType.Passages:
               switch (_arena.Orientation)
               {
                  case ArenaOrientation.N_S:
                  case ArenaOrientation.S_N:
                     for (int i = _arenaStartX; i <= _arenaEndX; i++)
                     {
                        if (i % 2 == 0)
                        {
                           misFile.Data.Objects.Add($"{i}, {arenaMidV}, 0, 0, 0, 100, 0, 0, -1 NEBWALL0");
                           misFile.Data.Objects.Add($"{i}, {arenaMidV + 1}, 0, 0, 0, 100, 0, 0, -1 NEBWALL0");
                        }
                     }
                     return;
                  case ArenaOrientation.W_E:
                  case ArenaOrientation.E_W:
                     for (int j = _arenaStartY; j <= _arenaEndY; j++)
                     {
                        if (j % 2 == 0)
                        {
                           misFile.Data.Objects.Add($"{arenaMidH}, {j}, 0, 0, 0, 100, 0, 0, -1 NEBWALL0");
                           misFile.Data.Objects.Add($"{arenaMidH + 1}, {j}, 0, 0, 0, 100, 0, 0, -1 NEBWALL0");
                        }
                     }
                     return;
                  default: throw new NotImplementedException();
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
