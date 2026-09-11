using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudCSShopTeammateWeaponInfoItemController : UIBaseController
{
	private UIHudCSShopTeammateWeaponInfoItemView m_View;

	private Player m_OwnerPlayer;

	private Dictionary<UISprite, uint> m_AsyncLoadUIAtlasTickets;

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

	protected virtual void OnInventoryEquipmentStateChanged(uint param0, uint playerID)
	{
	}

	public void SetData(BHGGAEEHJCO playerID)
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

	private void SetWeaponLevel(FDAEPHMIEPC weapon, GameObject QualityMark1, GameObject QualityMark2, GameObject QualityMark3, GameObject GoGradeLv1, GameObject GoGradeLv2, GameObject GoGradeLv3)
	{
	}

	private void SetLevelEffect(FDAEPHMIEPC weapon, UISprite GoldEffectBG)
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
