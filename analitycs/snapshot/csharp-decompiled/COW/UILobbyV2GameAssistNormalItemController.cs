using GCommon;
using UnityEngine;

namespace COW;

public class UILobbyV2GameAssistNormalItemController : UIBaseController, UITable2.IUITable2Item
{
	protected UITable2 m_Table2;

	protected UILobbyV2GameAssistWndController m_GameAssistWndCtrl;

	protected int m_Index;

	protected UITable2.Item m_Item;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected virtual void SetViewData(object data, int index)
	{
	}

	private void Update()
	{
	}

	protected virtual void SetRead()
	{
	}

	public object SetTable2ItemData(int index, object data, object viewState)
	{
		return null;
	}

	public void SetPosition(Vector2 position)
	{
	}

	public virtual void SetTable2Visible(bool visible)
	{
	}
}
