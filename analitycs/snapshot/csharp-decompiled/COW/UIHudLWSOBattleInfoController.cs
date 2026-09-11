using System.Collections.Generic;
using GCommon;
using message;

namespace COW;

public class UIHudLWSOBattleInfoController : UIBaseController
{
	private UIHudLWSOBattleInfoView m_View;

	private UIModelMatch m_ModelMatch;

	private bool m_IsOpen;

	private List<UIHudLWSOBattleInfoItemController> m_ItemCtrlList;

	private Dictionary<int, List<MFNHNEDOGKH>> m_VSTeamInfoDict;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void RefreshInfo()
	{
	}

	public void ArrowOpenOnClick()
	{
	}

	public void ArrowCloseOnClick()
	{
	}

	private void OnNewItemOnHand(object[] param)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
