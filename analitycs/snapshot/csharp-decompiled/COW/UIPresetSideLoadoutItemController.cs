using System;
using GCommon;

namespace COW;

internal class UIPresetSideLoadoutItemController : UIBaseLoadoutItemController
{
	public Action LoadoutItemBtnAction;

	private UILoadoutV2GuideController m_GuideController;

	private UIPresetSideLoadoutItemView m_View;

	private const string LOADOUT_SIDE_GUIDE = "LOADOUT_SIDE_GUIDE";

	private UILockController m_LockCtrl;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void InitView()
	{
	}

	private void ShowLoadoutV2Guide()
	{
	}

	private void OnLoadOutClick()
	{
	}

	public override void SetData(uint id, bool isV2Open = false, uint loadoutV2Id = 0u)
	{
	}

	private void OnClickMask()
	{
	}

	public void SetLoadoutBannedStatus(bool isShow)
	{
	}

	public UIButton GetGuideButton()
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_InitView()
	{
	}

	public void _003C_003EiFixBaseProxy_SetData(uint P0, bool P1, uint P2)
	{
	}
}
