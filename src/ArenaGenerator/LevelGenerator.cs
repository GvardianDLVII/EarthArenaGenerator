using ArenaGenerator.Arenas;
using Ieo.EarthFileApi.Files;
using System;
using System.IO;
using System.Linq;

namespace ArenaGenerator
{
   public class LevelGenerator
   {
      private const int MapMaxSize = 256;
      private const int MapMargin = 17;
      internal const int ArenaPadding = 17;

      private const int MapStartX = MapMargin;
      private const int MapStartY = MapMargin;
      private const int MapEndX = MapMaxSize - MapMargin;
      private const int MapEndY = MapMaxSize - MapMargin;

      private int CurrentX = MapStartX;
      private int CurrentY = MapStartY;
      private int CurrentRowHeight = 0;

      public void GenerateLevel(params BattleArena[] arenas)
      {
         var lndFile = CreateEmptyLndTemplate("GenArena2");
         var misFile = CreateEmptyMisTemplate(lndFile);

         foreach(var arena in arenas)
         {
            if(CurrentX + arena.Width > MapEndX)
            {
               CurrentY += CurrentRowHeight;
               CurrentX = MapStartX;
               CurrentRowHeight = 0;
            }

            if (CurrentY + arena.Height > MapEndY)
            {
               continue; //TODO: maybe start placing arenas in the tunnels?
            }

            var builder = new ArenaBuilder(arena, CurrentX, CurrentY);
            builder.ApplyTo(misFile);

            CurrentX += arena.Width + ArenaPadding;
            CurrentRowHeight = Math.Max(arena.Height + ArenaPadding, CurrentRowHeight);
         }

         File.WriteAllBytes($@"D:\SteamLibrary\steamapps\common\Earth 2150 The Moon Project\Levels\{lndFile.Header.FileName}.lnd", EarthFileWriter.WriteFile(lndFile));
         File.WriteAllBytes($@"D:\SteamLibrary\steamapps\common\Earth 2150 The Moon Project\Levels\{misFile.Header.FileName}.mis", EarthFileWriter.WriteFile(misFile));
      }


      private EarthFile<EarthLndData> CreateEmptyLndTemplate(string fileName = "GeneratedBattleArena", string levelName = null) => new EarthFile<EarthLndData>
      {
         Type = FileType.Lnd,
         Header = new EarthHeader
         {
            FileId = Guid.NewGuid(),
            Header = 0x39d0a1ff,
            UnknownOptionalField = 0x0400444c,
            FileName = fileName
         },
         Data = new EarthLndData
         {
            LevelName = levelName ?? fileName,
            LevelWaterHeight = 0x800,
            MapHeight = MapMaxSize,
            MapWidth = MapMaxSize,
            Resources = new byte[MapMaxSize * MapMaxSize],
            TerrainHeight = Enumerable.Range(0, MapMaxSize * MapMaxSize).Select(_ => (short)0x800).ToArray(),
            TerrainTextures = Enumerable.Range(0, MapMaxSize * MapMaxSize).Select(_ => (byte)0x03).ToArray(),
            TerrainType = TerrainType.Summer,
            Tunnels = Enumerable.Range(0, MapMaxSize * MapMaxSize).Select(_ => (byte)0x40).ToArray(),
            UnknownField = 0x10,
            WaterHeight = Enumerable.Range(0, MapMaxSize * MapMaxSize).Select(_ => (short)0).ToArray()
         }
      };

      private EarthFile<EarthMisData> CreateEmptyMisTemplate(EarthFile<EarthLndData> lndFile) => new EarthFile<EarthMisData>
      {
         Type = FileType.Mis,
         Header = new EarthHeader
         {
            FileId = Guid.NewGuid(),
            Header = 0x39d0a1ff,
            UnknownOptionalField = 0x0700444d,
            FileName = lndFile.Header.FileName
         },
         Data = new EarthMisData
         {
            LevelHeight = (short)lndFile.Data.MapHeight,
            LevelWidth = (short)lndFile.Data.MapWidth,
            LndFileId = lndFile.Header.FileId,
            ShipsEnabled = true,
            TotalResources = 0,
            UnknownField = 1,
            UnknownField2 = 0,
            UnknownOptionalString = string.Empty,
            WaterType = WaterType.Water
         }
      };
   }
}
