using GCommon;
using UnityEngine;

namespace COW;

public class UIHudMatchResultPointsItemController : UIBaseController
{
	private UIHudMatchResultPointsItemView m_View;

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

	public void SetViewData(uint matchMode, string titleStr, string valueStr, Color? valueSpecialColor = null, Color? titleSpecialColor = null, uint scoreType = 0u, int multiScoreRadio = 0)
	{
	}

	private void SetRatioLabelByScoreType(int multiScoreRadio)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
