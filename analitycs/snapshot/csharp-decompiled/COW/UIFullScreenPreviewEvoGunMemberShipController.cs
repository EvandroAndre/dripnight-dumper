using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

internal class UIFullScreenPreviewEvoGunMemberShipController : UIPreviewPopUpWindowController
{
	private UIFullScreenPreviewEvoGunMemberShipView m_View;

	private MembershipBigAwardDesc m_Data;

	private List<UIEvoGunMembershipPreviewGunItemController> m_ItemCtrlList;

	private uint m_CurrentId;

	private int m_ShowIndex;

	private const int PriviewGunItemWidth = 220;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override FrontendPreviewType GetPreviewUIType()
	{
		return FrontendPreviewType.Lobby;
	}

	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	public override void OnNavigationClosed()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	public void SetData(MembershipBigAwardDesc data, int index)
	{
	}

	public void SetPreviewInfo(uint itemID, int index)
	{
	}

	private void OnClickSwitchBtn(bool state)
	{
	}

	private void OnGotoWeaponSkinUpgraderClick()
	{
	}

	private void RefreshBG()
	{
	}

	private void RefreshGunItem()
	{
	}

	private string GetTimeString(long startTime, long endTime)
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}
}
