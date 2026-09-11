using System.Collections.Generic;
using GCommon;

namespace COW;

public class UILadderMatchResetMatchRewardItemController : UIBaseController
{
	private UILadderMatchResetMatchRewardItemView m_View;

	private List<UIStandardItemMiniController> m_MiniItemCtrlList;

	private const int m_AddHeight = 105;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(List<BaseItemInfo> data, string rankName)
	{
	}

	private void InitView()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
