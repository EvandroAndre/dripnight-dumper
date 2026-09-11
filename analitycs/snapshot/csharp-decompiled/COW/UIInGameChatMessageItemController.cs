using GCommon;
using UnityEngine;

namespace COW;

public class UIInGameChatMessageItemController : UIBaseController, UITable2.IUITable2Item
{
	public UIInGameChatMessageTable2ItemView m_View;

	private ClientInGameChatMessage m_InGameChatMessageInfo;

	private UIChatMessageItemTipsController m_ChatMessageItemTipsController;

	public const int POPMENU_POS_X = 800;

	public const int POPMENU_POS_Y = 190;

	public Bounds bounds => default(Bounds);

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetUIData(ClientInGameChatMessage info)
	{
	}

	private void AdjustChatTable2Layout(GameObject view, bool isSelf)
	{
	}

	private void InitView()
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
}
