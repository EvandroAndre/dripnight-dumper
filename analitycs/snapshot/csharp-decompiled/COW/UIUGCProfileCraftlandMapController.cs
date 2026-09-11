using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UIUGCProfileCraftlandMapController : UIBaseController
{
	private UIUGCProfileCraftlandMapView m_View;

	private UIUGCUnifiedMapSlot1Controller m_Item;

	protected SceneEditSlotInfo m_SlotInfo;

	protected List<string> m_PinModeMapShareCodeList;

	private bool m_IgnoreToggleChange;

	public Action OnToggleChangeCallback;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnToggleChange()
	{
	}

	protected override void OnUIOpen()
	{
	}

	public string GetMapShareCode()
	{
		return null;
	}

	public void RefreshToggleState(bool value)
	{
	}

	public void RefreshToggleIndex()
	{
	}

	private void SetToggleVisible(bool value, bool isToggleOn)
	{
	}

	public void SetSlotInfo(SceneEditSlotInfo slotInfo, List<string> pinModeMapShareCodeList)
	{
	}

	public void SetFromInfo(UINavigationUtil.UINavigationFrom from, string fromInfo, EUGCScene scene)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
