namespace ArenaGenerator.Arenas
{
   public class BattleArena
   {
      public int Width { get; init; }
      public int Height { get; init; }
      public readonly ArenaParty[] Parties = new ArenaParty[2];
      public ArenaType Type { get; init; }
      public ArenaOrientation Orientation { get; init; }


      public BattleArena(int width = 20, int height = 20, ArenaType type = ArenaType.Open, ArenaOrientation orientation = ArenaOrientation.N_S)
      {
         Width = width;
         Height = height;
         Type = type;
         Orientation = orientation;
      }
   }
}
