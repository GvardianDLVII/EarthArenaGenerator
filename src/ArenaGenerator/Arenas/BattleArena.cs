namespace ArenaGenerator.Arenas
{
   public class BattleArena
   {
      public int Width { get; init; }
      public int Height { get; init; }
      public readonly ArenaParty[] Parties = new ArenaParty[2];
      public ArenaType Type { get; init; }
      public ArenaOrientation Orientation { get; set; } = ArenaOrientation.N_S;

      protected BattleArena() { }

      public static BattleArena CreateStandard()
      {
         return new BattleArena
         {
            Width = 20,
            Height = 20,
            Type = ArenaType.StandardSquare
         };
      }
   }
}
