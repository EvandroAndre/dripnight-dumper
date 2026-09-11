using GCommon;

namespace COW;

public class ProfileCustomWeaponProficiencyData
{
	private sealed class _003C_003Ec__DisplayClass6_0
	{
		public UIModelRandomCollection modelRandomCollection;

		public UIModelInventory modelInventory;

		internal bool _003C_002Ector_003Eb__0(WeaponSkinBaseInfo info)
		{
			return false;
		}
	}

	public uint WeaponID;

	public uint WeaponSkinID;

	public uint Level;

	public ResourceID LevelIcon;

	public bool IsV2;

	public ProfileCustomWeaponProficiencyData()
	{
	}

	public ProfileCustomWeaponProficiencyData(uint weaponID)
	{
	}
}
