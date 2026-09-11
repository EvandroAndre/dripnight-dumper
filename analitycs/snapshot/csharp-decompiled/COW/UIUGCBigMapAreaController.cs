using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIUGCBigMapAreaController : UIPopupWindowController
{
	private UIUGCParadiseRegionView m_View;

	private List<WorkShopEditAreaConfigData> m_AreaData;

	private List<UIUGCBigMapAreaItemController> m_ItemControllerList;

	public Action OnAreaAppyClick;

	private uint m_AreaID;

	public uint AreaID => 0u;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void GenerateRegion(uint mapId)
	{
	}

	private void OnAreaSelect(UIToggleButton button)
	{
	}

	private void PlayGlobalAni(UIToggleButton button)
	{
	}

	private void TryEnterAreaEdit()
	{
	}

	public override int MinGroupDepth()
	{
		return 0;
	}

	private void OnCloseClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public int _003C_003EiFixBaseProxy_MinGroupDepth()
	{
		return 0;
	}
}
