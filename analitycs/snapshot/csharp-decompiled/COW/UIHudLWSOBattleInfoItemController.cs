using System.Collections.Generic;
using GCommon;
using message;

namespace COW;

internal class UIHudLWSOBattleInfoItemController : UIBaseController
{
	private UIHudLWSOBattleInfoItemView m_View;

	private UIModelMatch m_ModelMatch;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetItemInfo(List<MFNHNEDOGKH> list)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
