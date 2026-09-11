using GCommon;
using UnityEngine;

namespace COW;

public class UINinthSYSPrizePoolSeparatorController : UIBaseController, UITable2.IUITable2Item
{
	private UINinthSYSPrizePoolSeparatorView m_View;

	private UIModelNinthSYS.SeparatorAwardDesc m_SeparatorAwardDesc;

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

	public object SetTable2ItemData(int index, object data, object viewState)
	{
		return null;
	}

	public void SetPosition(Vector2 position)
	{
	}

	public void SetTable2Visible(bool visible)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
