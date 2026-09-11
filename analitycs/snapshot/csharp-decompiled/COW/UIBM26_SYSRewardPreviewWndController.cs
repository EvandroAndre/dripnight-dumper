using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIBM26_SYSRewardPreviewWndController : UIPopupWindowController
{
	private UIBM26SysRewardPreviewWndView m_View;

	private List<UIStandardItemMiniController> m_ItemCtrls;

	private string m_DescTips;

	private bool m_Claimed;

	private List<BaseItemInfo> m_Rewards;

	private bool m_DelaySetting;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void SetRewardInfo(List<BaseItemInfo> rewards, bool claimed = false, string desc = "")
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
