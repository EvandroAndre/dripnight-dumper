using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIHudMatchResultItemRewardController : UIPopupWindowController
{
	private UIHudMatchResultItemRewardView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	public void ShowRewards(List<CommonRewardItemInfo> debrisList, List<CommonRewardItemInfo> commonList)
	{
	}

	public override int GlassDelay()
	{
		return 0;
	}

	private void OnClickSkipMaskBtn()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public int _003C_003EiFixBaseProxy_GlassDelay()
	{
		return 0;
	}
}
