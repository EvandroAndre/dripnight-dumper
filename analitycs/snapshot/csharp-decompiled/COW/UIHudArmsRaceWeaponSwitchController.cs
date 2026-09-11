using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIHudArmsRaceWeaponSwitchController : UIHudWeaponSwitchController
{
	private int m_CurLevel;

	private bool m_IsInitedNextWeapons;

	private const int NextWeaponsCount = 2;

	private List<UIHUDArmsRaceNextWeaponsController> m_NextWeaponControllers;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override bool RecyleDontDestroy()
	{
		return false;
	}

	private void OnGameArmsListCome(object[] param)
	{
	}

	private void OnPlayerARMLevelUpdate(object[] param)
	{
	}

	private void UpdateNextWeapons()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new bool _003C_003EiFixBaseProxy_RecyleDontDestroy()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
