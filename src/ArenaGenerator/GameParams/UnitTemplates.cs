using ArenaGenerator.Arenas;

namespace ArenaGenerator.GameParams
{
   public static class UnitTemplates
   {
      public static Unit MoonM3_E => Create(ChassisConsts.LC.MoonM3, PowerShieldType.Big, Weapons.LC.ElectroCannonUpg1);
      public static Unit MoonM3_S => Create(ChassisConsts.LC.MoonM3, PowerShieldType.Big, Weapons.LC.SonicCannonUpg1);
      public static Unit MoonM3_P => Create(ChassisConsts.LC.MoonM3, PowerShieldType.Big, Weapons.LC.PlasmaProjector);
      public static Unit CraterM3_hE => Create(ChassisConsts.LC.CraterM3, PowerShieldType.Big, Weapons.LC.HeavyElectroCannonUpg1);
      public static Unit CraterM3_hS => Create(ChassisConsts.LC.CraterM3, PowerShieldType.Big, Weapons.LC.HeavySonicCannonUpg1);

      public static Unit Create(string chassis, PowerShieldType shield, string weapon1 = null, string weapon2 = null, string weapon3 = null, string weapon4 = null, string subweapon1 = null, string subweapon2 = null, string subweapon3 = null, string subweapon4 = null)
      {
         var unit = new Unit
         {
            Chassis = chassis,
            Shield = shield
         };

         unit.Weapons[0] = weapon1;
         unit.Subweapons[0] = subweapon1;
         unit.Weapons[1] = weapon2;
         unit.Subweapons[1] = subweapon2;
         unit.Weapons[2] = weapon3;
         unit.Subweapons[2] = subweapon3;
         unit.Weapons[3] = weapon4;
         unit.Subweapons[3] = subweapon4;

         return unit;
      }
   }
}
