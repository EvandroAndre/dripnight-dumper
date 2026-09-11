using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIModelPVE : UIBaseModel
{
	private sealed class _003C_003Ec__DisplayClass11_0
	{
		public UIModelMapOpeningInfo modelMapOpenInfo;

		internal bool _003CAllOpeningPVEMap_003Eb__0(MapOpeningInfo e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public UIModelPVE _003C_003E4__this;

		public bool showTips;

		public uint weapon;

		internal void _003CChoosePVEPrimaryWeapon_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private uint m_PVEPrimaryWeaponSkin;

	private uint m_SyncExpiredWeapon;

	public const uint PropID_PrimaryWeapon_Updated = 2u;

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Login(object[] data)
	{
	}

	public override void Logout(object[] data)
	{
	}

	public uint PrimaryWeapon()
	{
		return 0u;
	}

	public uint AvatarDefaultWeapon(uint avatarId)
	{
		return 0u;
	}

	public void ChoosePVEPrimaryWeapon(uint weapon, ulong groupid = 0uL, bool showTips = true, uint httpOption = 0u)
	{
	}

	public uint[] AllPVEWeapons()
	{
		return null;
	}

	public void UpdateWeapon(uint weaponID)
	{
	}

	public List<MapOpeningInfo> AllOpeningPVEMap()
	{
		return null;
	}

	public static bool IsPVEMode(uint gameMode)
	{
		return false;
	}

	private void _003CUpdateWeapon_003Eb__10_0()
	{
	}

	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
