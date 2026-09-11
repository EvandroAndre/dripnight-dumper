using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudCSShopTeammateWeaponInfoItemV2Controller : UIBaseController
{
	private sealed class _003C_003Ec__DisplayClass19_0
	{
		public UISprite sprite;

		public Vector3 weaponSpriteScale;

		internal void _003CRealSetWeaponIcon_003Eb__0()
		{
		}
	}

	private UIHudCSShopTeammateWeaponInfoItemV2View m_View;

	private Player m_OwnerPlayer;

	private uint m_PrimaryWeapon1AsyncLoadUIAtlasTicket;

	private uint m_PrimaryWeapon2AsyncLoadUIAtlasTicket;

	private FDAEPHMIEPC m_Weapon1;

	private FDAEPHMIEPC m_Weapon2;

	public static bool KillCamDontDestroy()
	{
		return false;
	}

	public override bool KillCamRecyleDontDestroy()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	public override void OnUIReInit()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIDestory()
	{
	}

	private void OnTeammateCoinChange(object[] data)
	{
	}

	private void OnReinforceRefresh(uint uniqueID)
	{
	}

	protected virtual void OnInventoryEquipmentStateChanged(uint param0, uint playerID)
	{
	}

	public void SetData(BHGGAEEHJCO playerID)
	{
	}

	private void RefreshCoin()
	{
	}

	private void RefreshEquipment()
	{
	}

	private void SetWeaponIcon(FDAEPHMIEPC weapon, bool isFirstWeapon, bool usePrimarayIcon)
	{
	}

	private void RealSetWeaponIcon(FDAEPHMIEPC weapon, UISprite sprite)
	{
	}

	private void SetWeaponLevel(FDAEPHMIEPC weapon, GameObject QualityMark1, GameObject QualityMark2, GameObject QualityMark3, GameObject GoGradeLv1, GameObject GoGradeLv2, GameObject GoGradeLv3, UISprite AwakenIcon)
	{
	}

	private void SetLevelEffect(FDAEPHMIEPC weapon, UISprite GoldEffectBG)
	{
	}

	private void SetWeaponReinforce(FDAEPHMIEPC weapon, GameObject reinforceSprite)
	{
	}

	public bool _003C_003EiFixBaseProxy_KillCamRecyleDontDestroy()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
