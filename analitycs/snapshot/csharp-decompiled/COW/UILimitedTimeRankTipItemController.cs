using GCommon;
using UnityEngine;

namespace COW;

public class UILimitedTimeRankTipItemController : UIBaseController
{
	private UILimitedTimeRankTipItemView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void SetViewData(string rankName, uint rankPoint, Color? valueSpecialColor = null, Color? titleSpecialColor = null)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
