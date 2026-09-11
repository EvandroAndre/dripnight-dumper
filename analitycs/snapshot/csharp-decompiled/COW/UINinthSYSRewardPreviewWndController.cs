using System.Collections.Generic;
using GCommon;

namespace COW;

public class UINinthSYSRewardPreviewWndController : UIPopupWindowController
{
	private UINinthSYSRewardPreviewWndView m_View;

	private List<UINinthSYSStandardItemMiniController> m_ItemCtrls;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	protected override void OnUIDestory()
	{
	}

	public void SetRewardInfo(List<BaseItemInfo> rewards, bool claimed = false, string desc = "")
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
