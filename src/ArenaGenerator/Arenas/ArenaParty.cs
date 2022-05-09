using System.Collections.Generic;

namespace ArenaGenerator.Arenas
{
   public class ArenaParty
   {
      public IList<Unit> Units { get; set; }
      public int Player { get; set; }
   }
}
