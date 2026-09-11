using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIHudWereWolvesHistroyItemController : UIEasyListItemController
{
	private UIHudWereWolvesHistroyItemView m_View;

	private List<UIHudWereWolvesVoteIndexController> m_IdxChildList;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
