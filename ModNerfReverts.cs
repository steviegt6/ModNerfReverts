using On.FargowiltasSouls;
using System;
using Terraria.ModLoader;

namespace ModNerfReverts
{
	public class ModNerfReverts : Mod
	{
		private Mod FargowiltasSouls => ModLoader.GetMod("FargowilasSouls");
		public override void Load()
		{
			if (FargowiltasSouls != null)
			{
				On.FargowiltasSouls.FargoPlayer.ModifyWeaponDamage += RevertNerfsFargowiltasSoulsWeaponDamage;
			}
		}

		private void RevertNerfsFargowiltasSoulsWeaponDamage(On.FargowiltasSouls.FargoPlayer.orig_ModifyWeaponDamage orig, FargowiltasSouls.FargoPlayer self, object item, ref float add, ref float mult, ref float flat)
		{
			throw new NotImplementedException();
		}
	}
}