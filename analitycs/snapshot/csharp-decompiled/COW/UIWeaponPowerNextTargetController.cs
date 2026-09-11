using GCommon;
using UnityEngine;

namespace COW;

internal class UIWeaponPowerNextTargetController : UIPopupWindowController
{
	private UIWeaponPowerNextTargetView m_View;

	private UIModelWeaponPower m_ModelWeaponPower;

	private UILeaderBoardTitleCommonController m_LeaderBoardTitleCommonCtrl;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetViewData(Vector3 position, int regionType, uint weaponID, uint nextScore, bool isBR, uint titleMaxRank)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
