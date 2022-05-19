using ArenaGenerator.Arenas;

namespace ArenaGenerator.GameParams
{
   public static class UnitTemplates
   {
      public static Unit Siberia_L() => Create(ChassisConsts.ED.Siberia102, PowerShieldType.Big, Weapons.ED.LaserUpg2);
      public static Unit Kauki_hL() => Create(ChassisConsts.ED.Kauki600, PowerShieldType.Big, Weapons.ED.HeavyLaserUpg2);
      public static Unit Ural_hL() => Create(ChassisConsts.ED.Ural900, PowerShieldType.Big, Weapons.ED.HeavyLaserUpg2, Weapons.ED.HeavyLaserUpg2);

      public static Unit Tiger3_P() => Create(ChassisConsts.UCS.Tiger3, PowerShieldType.None, Weapons.UCS.TigerPlasmaUpg1);
      public static Unit Spider3_P() => Create(ChassisConsts.UCS.Spider3, PowerShieldType.Big, Weapons.UCS.SpiderJaguarPlasmaUpg1);
      public static Unit Panther3_hP() => Create(ChassisConsts.UCS.Panther3, PowerShieldType.Big, Weapons.UCS.PantherJaguarHeavyPlasmaUpg2);
      public static Unit Jaguar2_hP() => Create(ChassisConsts.UCS.Jaguar2, PowerShieldType.Big, Weapons.UCS.PantherJaguarHeavyPlasmaUpg2, Weapons.UCS.SpiderJaguarPlasmaUpg1);
      public static Unit Jaguar2_hP_P() => Create(ChassisConsts.UCS.Jaguar2, PowerShieldType.Big, Weapons.UCS.PantherJaguarHeavyPlasmaUpg2, Weapons.UCS.SpiderJaguarPlasmaUpg1, subweapon1: Weapons.UCS.SpiderJaguarPlasmaUpg1);
      public static Unit Grizzly3_hP() => Create(ChassisConsts.UCS.Grizzly3, PowerShieldType.Big, Weapons.UCS.GrizzlyHydraHeavyPlasmaUpg1, Weapons.UCS.SpiderJaguarPlasmaUpg1);

      public static Unit MoonM3_E() => Create(ChassisConsts.LC.MoonM3, PowerShieldType.Big, Weapons.LC.ElectroCannonUpg1);
      public static Unit MoonM3_S() => Create(ChassisConsts.LC.MoonM3, PowerShieldType.Big, Weapons.LC.SonicCannonUpg1);
      public static Unit MoonM3_P() => Create(ChassisConsts.LC.MoonM3, PowerShieldType.Big, Weapons.LC.PlasmaProjector);
      public static Unit CraterM3_hE() => Create(ChassisConsts.LC.CraterM3, PowerShieldType.Big, Weapons.LC.HeavyElectroCannonUpg1);
      public static Unit CraterM3_hS() => Create(ChassisConsts.LC.CraterM3, PowerShieldType.Big, Weapons.LC.HeavySonicCannonUpg1);
      public static Unit CraterM3_hE_P() => Create(ChassisConsts.LC.CraterM3, PowerShieldType.Big, Weapons.LC.HeavyElectroCannonUpg1, subweapon1: Weapons.LC.PlasmaProjector);

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
