using ArenaGenerator.Arenas;

namespace ArenaGenerator.GameParams
{
   public static class UnitTemplates
   {
      public static Unit CraterM3(PowerShieldType shield, string weapon, string subweapon = null)
      {
         var unit = new Unit
         {
            Chassis = ChassisConsts.LC.CraterM3,
            Shield = shield
         };

         unit.Weapons[0] = weapon;
         unit.Subweapons[0] = subweapon;

         return unit;
      }
   }
}
