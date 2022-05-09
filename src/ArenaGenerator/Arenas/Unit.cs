using ArenaGenerator.GameParams;

namespace ArenaGenerator.Arenas
{
   public class Unit
   {
      public string Chassis { get; set; }
      public readonly string[] Weapons = new string[4];
      public readonly string[] Subweapons = new string[4];
      public PowerShieldType Shield { get; set; }

      public override string ToString()
      {
         return $"{(int)Shield} {Chassis}" +
            $"{(!string.IsNullOrEmpty(Weapons[0]) ? $" # {Weapons[0]}{(!string.IsNullOrEmpty(Subweapons[0]) ? $"@{Subweapons[0]}" : "")}" : "")}" +
            $"{(!string.IsNullOrEmpty(Weapons[1]) ? $" {Weapons[1]}{(!string.IsNullOrEmpty(Subweapons[1]) ? $"@{Subweapons[1]}" : "")}" : "")}" +
           $"{(!string.IsNullOrEmpty(Weapons[2]) ? $" {Weapons[2]}{(!string.IsNullOrEmpty(Subweapons[2]) ? $"@{Subweapons[2]}" : "")}" : "")}" +
           $"{(!string.IsNullOrEmpty(Weapons[3]) ? $" {Weapons[3]}{(!string.IsNullOrEmpty(Subweapons[3]) ? $"@{Subweapons[3]}" : "")}" : "")}"; ;
      }
   }
}
